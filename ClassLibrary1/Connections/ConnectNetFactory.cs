﻿using CentralLib.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CentralLib.Connections
{
    class ConnectNetFactory : IConnectFactory, IDisposable
    {
        public byte[] bytesBegin = { (byte)WorkByte.DLE, (byte)WorkByte.STX };
        public byte[] bytesEnd = { (byte)WorkByte.DLE, (byte)WorkByte.ETX };

        private byte[] glbytesResponse;
        private int waiting; // waiting time for serial port answer

        public bool statusOperation { get; set; }
        public byte ByteStatus { get; set; } // Возврат ФР статус
        public byte ByteResult { get; set; } // Возврат ФР результат
        public byte ByteReserv { get; set; } // Возврат ФР результат
        public string errorInfo { get; set; }
        public int ConsecutiveNumber { get; set; }
        public byte[] glbytesForSend { get; set; }
        public byte[] glbytesPrepare { get; set; }
        public bool useCRC16 { get; set; }

        private string IpAdress;
        private int port;
        private ByteHelper byteHelper;
  
        public bool IsOpen
        {
            get
            {
                return true;
            }
        }

        public ConnectNetFactory(string IpAdress, int port, int waiting)
        {
            this.IpAdress = IpAdress;
            this.port = port;
            byteHelper = new ByteHelper();
            byteHelper.initialCrc16();
            this.errorInfo = "";
            this.ConsecutiveNumber = 0;
            this.waiting = waiting;
        }


        public void Open()
        {
            //нет смысла открывать, так как не ком порт
            //сохранено для поддержки
        }

        public void Close()
        {
            //нет смысла Закрывать, так как не ком порт
            //сохранено для поддержки
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputbyte"></param>
        /// <param name="useCRC16"></param>
        /// <param name="repeatError"></param>
        /// <returns></returns>
        private async Task<byte[]> ExchangeFP(byte[] inputbyte, bool useCRC16 = false, bool repeatError = false)
        {

            this.ByteStatus = 0;
            this.ByteResult = 0;
            this.ByteReserv = 0;
            this.statusOperation = false;
            this.errorInfo = "";
            if (!repeatError)
            {
                this.ConsecutiveNumber++;
            }
            this.glbytesForSend = inputbyte;

            //if (!base.IsOpen)
            //    base.Open();
            //if (!base.IsOpen)
            //{
            //    setError("Не возможно подключиться к порту:" + base.PortName.ToString());
            //    throw new ArgumentException(this.errorInfo);
            //}
            byte[] unsigned = null;
            using (TcpClient client = new TcpClient())
            {
                await client.ConnectAsync(IPAddress.Parse(IpAdress), port);

#if Debug
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("подготовка к отправке:{0}", byteHelper.PrintByteArrayX(inputbyte));
#endif
                using (var networkStream = client.GetStream())
                {
                    await networkStream.WriteAsync(inputbyte, 0, inputbyte.Length);
                    //base.Write(inputbyte, 0, inputbyte.Length);

#if Debug
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("отправлено");
#endif
                    byte[] result = new byte[] { };
                    Thread.Sleep(this.waiting);
                    
                    int twait = 0;
                    while (networkStream.DataAvailable)
                    {
                        byte[] result_fromPort = new byte[1024];
                        int bufferSize = await networkStream.ReadAsync(result_fromPort, 0, result_fromPort.Length);
                        if (bufferSize <= 0)
                            break;
                        int count_wait = 0;
                        for (int tByte = 0; tByte < bufferSize; tByte++)
                        {
                            if ((result_fromPort[tByte] == (byte)WorkByte.ACK) || (result_fromPort[tByte] == (byte)WorkByte.SYN))
                            {
                                count_wait++;
                            }
                        }
                        if (bufferSize == 1 && result_fromPort[0] == (byte)WorkByte.ACK)
                        {
                            Thread.Sleep(1000);
                        }
                        else if ((bufferSize < 10) || (bufferSize == count_wait) || ((count_wait > 0) && (bufferSize / count_wait < 2)))
                        {
                            twait++;
                            Thread.Sleep(twait * 300);
                        }
                        if (twait > 10) break;
                        result = byteHelper.Combine(result, result_fromPort.Take(bufferSize).ToArray());

                       
                    };

                    byte[] BytesBegin = new byte[4];
                    Buffer.BlockCopy(inputbyte, 0, BytesBegin, 0, 4);

                    int positionPacketBegin = byteHelper.ByteSearch(result, BytesBegin);

                    if (positionPacketBegin < 0)
                    {
                        setError("В байтах ответа не найдено \"начало\", ip:" + this.IpAdress+":"+port.ToString());
                        throw new ArgumentException(this.errorInfo);
                        // return null;
                    }
                    //}
                    int positionPacketEnd = -1;
                    int tCurrentPos = positionPacketBegin + 7;
                    int tPostEnd = -1;
                    do
                    {
                        tCurrentPos++;
                        tPostEnd = byteHelper.ByteSearch(result, bytesEnd, tCurrentPos);
                        if (tPostEnd != -1)
                        {
                            tCurrentPos = tPostEnd;

                            if (result[tPostEnd - 1] != (byte)WorkByte.DLE)
                            {
                                positionPacketEnd = tPostEnd;
                                break;
                            }
                            else if ((result[tPostEnd - 1] == (byte)WorkByte.DLE) && (result[tPostEnd - 2] == (byte)WorkByte.DLE))
                            {
                                positionPacketEnd = tPostEnd;
                                // break; 
                            }
                        }
                    } while (tCurrentPos < result.Length);
                    if (positionPacketEnd < 0)
                    {
                        setError("В байтах ответа не найдено \"конец\", ip:" + this.IpAdress + ":" + port.ToString());
                        throw new ArgumentException(this.errorInfo);
                    }
                    //e  } while (base.BytesToRead>0);


                    if (useCRC16)
                    {
                        unsigned = new byte[positionPacketEnd - positionPacketBegin + 4];
                        Buffer.BlockCopy(result, positionPacketBegin, unsigned, 0, positionPacketEnd - positionPacketBegin + 4);
                    }
                    else
                    {
                        unsigned = new byte[positionPacketEnd - positionPacketBegin + 2];
                        Buffer.BlockCopy(result, positionPacketBegin, unsigned, 0, positionPacketEnd - positionPacketBegin + 2);
                    }
                    //this.bytesOutput = unsigned;
                    //TODO: доработать проверку CRC && CRC16
                    unsigned = byteHelper.returnWithOutDublicateDLE(unsigned);
                    this.glbytesResponse = unsigned;

                    byte byteCheckSum = unsigned[unsigned.Length - 3];
                    unsigned[unsigned.Length - 3] = 0;

                    if (byteCheckSum!=byteHelper.getchecksum(unsigned))
                    {
                        //не совпала чек сумма
                        this.statusOperation = false;
                        setError("Не правильная чек сумма обмена, ip:" + this.IpAdress + ":" + port.ToString());
                        throw new ArgumentException(this.errorInfo);
                    }
                    
                    this.statusOperation = true;
                    this.ByteStatus = unsigned[4];
                    this.ByteResult = unsigned[5];
                    this.ByteReserv = unsigned[6];
                    this.errorInfo = "";
                }
            }
            //Console.WriteLine(PrintByteArray(unsigned));
            //Console.WriteLine(PrintByteArray(unsigned.Skip(8).Take(unsigned.Length - 7 - 3 - ((useCRC16) ? 2 : 0)).ToArray()));
            return unsigned;//.Skip(8).Take(unsigned.Length-7-3- ((useCRC16)?2:0) ).ToArray();
        }




        public virtual byte[] dataExchange(byte[] input, bool repeatError = false)
        {
            return this.dataExchange(input, this.useCRC16, repeatError);
        }

        public virtual byte[] dataExchange(byte[] input)
        {
            return this.dataExchange(input, this.useCRC16, false);
        }

        public virtual byte[] dataExchange(byte[] input, bool useCRC16 = false, bool repeatError = false)
        {
            Func<byte[], Task<byte[]>> function = async (byte[] inByte) =>
            {
                this.glbytesPrepare = inByte;
                return await ExchangeFP(byteHelper.prepareForSend(ConsecutiveNumber, inByte, useCRC16, repeatError), useCRC16, repeatError);
            };

            Task<byte[]> answer = function(input);
            //byte[] answer = ExchangeFP(prepareForSend(input, useCRC16));
            //return await answer;
            try
            {
                return byteHelper.returnBytesWithoutSufixAndPrefix(answer.Result);
            }
            catch (AggregateException e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Caught {0}, exception: {1}", e.InnerExceptions.Count, string.Join(", ", e.InnerExceptions.Select(x => x.Message)));

                setError(sb.ToString());
#if Debug
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Описание ошибки:{0}", this.errorInfo);
#endif
            }
            finally
            {

            }
            return null;
        }


        private void setError(string errorInfo = "Unknown error", byte ByteStatus = 255, byte ByteResult = 255, byte ByteReserv = 255)
        {
            this.ByteStatus = ByteStatus;
            this.ByteResult = ByteResult;
            this.ByteReserv = ByteReserv;
            this.statusOperation = false;
            this.errorInfo += errorInfo + "; ";
        }

        void IDisposable.Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
