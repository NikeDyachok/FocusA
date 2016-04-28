﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncOpenStoreService
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="FPWork")]
	public partial class DataClassesFocusADataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Inserttbl_ComInit(tbl_ComInit instance);
    partial void Updatetbl_ComInit(tbl_ComInit instance);
    partial void Deletetbl_ComInit(tbl_ComInit instance);
    partial void Inserttbl_SyncDB(tbl_SyncDB instance);
    partial void Updatetbl_SyncDB(tbl_SyncDB instance);
    partial void Deletetbl_SyncDB(tbl_SyncDB instance);
    partial void Inserttbl_SyncDBStatus(tbl_SyncDBStatus instance);
    partial void Updatetbl_SyncDBStatus(tbl_SyncDBStatus instance);
    partial void Deletetbl_SyncDBStatus(tbl_SyncDBStatus instance);
    #endregion
		
		public DataClassesFocusADataContext() : 
				base(global::SyncOpenStoreService.Properties.Settings.Default.FPWorkConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFocusADataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFocusADataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFocusADataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesFocusADataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tbl_ComInit> tbl_ComInits
		{
			get
			{
				return this.GetTable<tbl_ComInit>();
			}
		}
		
		public System.Data.Linq.Table<tbl_SyncDB> tbl_SyncDBs
		{
			get
			{
				return this.GetTable<tbl_SyncDB>();
			}
		}
		
		public System.Data.Linq.Table<tbl_SyncDBStatus> tbl_SyncDBStatus
		{
			get
			{
				return this.GetTable<tbl_SyncDBStatus>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_ComInit")]
	public partial class tbl_ComInit : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _CompName;
		
		private int _Port;
		
		private bool _Init;
		
		private bool _Error;
		
		private System.Nullable<bool> _WorkOff;
		
		private System.Nullable<bool> _auto;
		
		private System.Nullable<int> _ErrorCode;
		
		private string _ErrorInfo;
		
		private System.Nullable<int> _FPNumber;
		
		private string _RealNumber;
		
		private string _SerialNumber;
		
		private string _FiscalNumber;
		
		private System.Nullable<long> _DateTimeBegin;
		
		private System.Nullable<long> _DateTimeStop;
		
		private System.Nullable<long> _DeltaTime;
		
		private string _CurrentDate;
		
		private string _CurrentTime;
		
		private System.Nullable<System.DateTime> _CurrentSystemDateTime;
		
		private string _Version;
		
		private System.Nullable<bool> _SmenaOpened;
		
		private string _PapStat;
		
		private System.Nullable<int> _ByteStatus;
		
		private string _ByteStatusInfo;
		
		private System.Nullable<int> _ByteResult;
		
		private string _ByteResultInfo;
		
		private System.Nullable<int> _ByteReserv;
		
		private string _ByteReservInfo;
		
		private string _DataServer;
		
		private string _DataBaseName;
		
		private System.Nullable<int> _MinSumm;
		
		private System.Nullable<int> _MaxSumm;
		
		private System.Nullable<bool> _TypeEvery;
		
		private System.Nullable<int> _PrintEvery;
		
		private System.Nullable<int> _KlefMem;
		
		private System.Nullable<System.DateTime> _DateTimeSyncFP;
		
		private System.Nullable<System.DateTime> _DateTimeSyncDB;
		
		private string _MoxaIP;
		
		private System.Nullable<int> _MoxaPort;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnCompNameChanging(string value);
    partial void OnCompNameChanged();
    partial void OnPortChanging(int value);
    partial void OnPortChanged();
    partial void OnInitChanging(bool value);
    partial void OnInitChanged();
    partial void OnErrorChanging(bool value);
    partial void OnErrorChanged();
    partial void OnWorkOffChanging(System.Nullable<bool> value);
    partial void OnWorkOffChanged();
    partial void OnautoChanging(System.Nullable<bool> value);
    partial void OnautoChanged();
    partial void OnErrorCodeChanging(System.Nullable<int> value);
    partial void OnErrorCodeChanged();
    partial void OnErrorInfoChanging(string value);
    partial void OnErrorInfoChanged();
    partial void OnFPNumberChanging(System.Nullable<int> value);
    partial void OnFPNumberChanged();
    partial void OnRealNumberChanging(string value);
    partial void OnRealNumberChanged();
    partial void OnSerialNumberChanging(string value);
    partial void OnSerialNumberChanged();
    partial void OnFiscalNumberChanging(string value);
    partial void OnFiscalNumberChanged();
    partial void OnDateTimeBeginChanging(System.Nullable<long> value);
    partial void OnDateTimeBeginChanged();
    partial void OnDateTimeStopChanging(System.Nullable<long> value);
    partial void OnDateTimeStopChanged();
    partial void OnDeltaTimeChanging(System.Nullable<long> value);
    partial void OnDeltaTimeChanged();
    partial void OnCurrentDateChanging(string value);
    partial void OnCurrentDateChanged();
    partial void OnCurrentTimeChanging(string value);
    partial void OnCurrentTimeChanged();
    partial void OnCurrentSystemDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnCurrentSystemDateTimeChanged();
    partial void OnVersionChanging(string value);
    partial void OnVersionChanged();
    partial void OnSmenaOpenedChanging(System.Nullable<bool> value);
    partial void OnSmenaOpenedChanged();
    partial void OnPapStatChanging(string value);
    partial void OnPapStatChanged();
    partial void OnByteStatusChanging(System.Nullable<int> value);
    partial void OnByteStatusChanged();
    partial void OnByteStatusInfoChanging(string value);
    partial void OnByteStatusInfoChanged();
    partial void OnByteResultChanging(System.Nullable<int> value);
    partial void OnByteResultChanged();
    partial void OnByteResultInfoChanging(string value);
    partial void OnByteResultInfoChanged();
    partial void OnByteReservChanging(System.Nullable<int> value);
    partial void OnByteReservChanged();
    partial void OnByteReservInfoChanging(string value);
    partial void OnByteReservInfoChanged();
    partial void OnDataServerChanging(string value);
    partial void OnDataServerChanged();
    partial void OnDataBaseNameChanging(string value);
    partial void OnDataBaseNameChanged();
    partial void OnMinSummChanging(System.Nullable<int> value);
    partial void OnMinSummChanged();
    partial void OnMaxSummChanging(System.Nullable<int> value);
    partial void OnMaxSummChanged();
    partial void OnTypeEveryChanging(System.Nullable<bool> value);
    partial void OnTypeEveryChanged();
    partial void OnPrintEveryChanging(System.Nullable<int> value);
    partial void OnPrintEveryChanged();
    partial void OnKlefMemChanging(System.Nullable<int> value);
    partial void OnKlefMemChanged();
    partial void OnDateTimeSyncFPChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeSyncFPChanged();
    partial void OnDateTimeSyncDBChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeSyncDBChanged();
    partial void OnMoxaIPChanging(string value);
    partial void OnMoxaIPChanged();
    partial void OnMoxaPortChanging(System.Nullable<int> value);
    partial void OnMoxaPortChanged();
    #endregion
		
		public tbl_ComInit()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string CompName
		{
			get
			{
				return this._CompName;
			}
			set
			{
				if ((this._CompName != value))
				{
					this.OnCompNameChanging(value);
					this.SendPropertyChanging();
					this._CompName = value;
					this.SendPropertyChanged("CompName");
					this.OnCompNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Port", DbType="Int NOT NULL")]
		public int Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				if ((this._Port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._Port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Init", DbType="Bit NOT NULL")]
		public bool Init
		{
			get
			{
				return this._Init;
			}
			set
			{
				if ((this._Init != value))
				{
					this.OnInitChanging(value);
					this.SendPropertyChanging();
					this._Init = value;
					this.SendPropertyChanged("Init");
					this.OnInitChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Error", DbType="Bit NOT NULL")]
		public bool Error
		{
			get
			{
				return this._Error;
			}
			set
			{
				if ((this._Error != value))
				{
					this.OnErrorChanging(value);
					this.SendPropertyChanging();
					this._Error = value;
					this.SendPropertyChanged("Error");
					this.OnErrorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkOff", DbType="Bit")]
		public System.Nullable<bool> WorkOff
		{
			get
			{
				return this._WorkOff;
			}
			set
			{
				if ((this._WorkOff != value))
				{
					this.OnWorkOffChanging(value);
					this.SendPropertyChanging();
					this._WorkOff = value;
					this.SendPropertyChanged("WorkOff");
					this.OnWorkOffChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_auto", DbType="Bit")]
		public System.Nullable<bool> auto
		{
			get
			{
				return this._auto;
			}
			set
			{
				if ((this._auto != value))
				{
					this.OnautoChanging(value);
					this.SendPropertyChanging();
					this._auto = value;
					this.SendPropertyChanged("auto");
					this.OnautoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorCode", DbType="Int")]
		public System.Nullable<int> ErrorCode
		{
			get
			{
				return this._ErrorCode;
			}
			set
			{
				if ((this._ErrorCode != value))
				{
					this.OnErrorCodeChanging(value);
					this.SendPropertyChanging();
					this._ErrorCode = value;
					this.SendPropertyChanged("ErrorCode");
					this.OnErrorCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ErrorInfo", DbType="NVarChar(MAX)")]
		public string ErrorInfo
		{
			get
			{
				return this._ErrorInfo;
			}
			set
			{
				if ((this._ErrorInfo != value))
				{
					this.OnErrorInfoChanging(value);
					this.SendPropertyChanging();
					this._ErrorInfo = value;
					this.SendPropertyChanged("ErrorInfo");
					this.OnErrorInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FPNumber", DbType="Int")]
		public System.Nullable<int> FPNumber
		{
			get
			{
				return this._FPNumber;
			}
			set
			{
				if ((this._FPNumber != value))
				{
					this.OnFPNumberChanging(value);
					this.SendPropertyChanging();
					this._FPNumber = value;
					this.SendPropertyChanged("FPNumber");
					this.OnFPNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RealNumber", DbType="NVarChar(20)")]
		public string RealNumber
		{
			get
			{
				return this._RealNumber;
			}
			set
			{
				if ((this._RealNumber != value))
				{
					this.OnRealNumberChanging(value);
					this.SendPropertyChanging();
					this._RealNumber = value;
					this.SendPropertyChanged("RealNumber");
					this.OnRealNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SerialNumber", DbType="NVarChar(20)")]
		public string SerialNumber
		{
			get
			{
				return this._SerialNumber;
			}
			set
			{
				if ((this._SerialNumber != value))
				{
					this.OnSerialNumberChanging(value);
					this.SendPropertyChanging();
					this._SerialNumber = value;
					this.SendPropertyChanged("SerialNumber");
					this.OnSerialNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FiscalNumber", DbType="NVarChar(20)")]
		public string FiscalNumber
		{
			get
			{
				return this._FiscalNumber;
			}
			set
			{
				if ((this._FiscalNumber != value))
				{
					this.OnFiscalNumberChanging(value);
					this.SendPropertyChanging();
					this._FiscalNumber = value;
					this.SendPropertyChanged("FiscalNumber");
					this.OnFiscalNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeBegin", DbType="BigInt")]
		public System.Nullable<long> DateTimeBegin
		{
			get
			{
				return this._DateTimeBegin;
			}
			set
			{
				if ((this._DateTimeBegin != value))
				{
					this.OnDateTimeBeginChanging(value);
					this.SendPropertyChanging();
					this._DateTimeBegin = value;
					this.SendPropertyChanged("DateTimeBegin");
					this.OnDateTimeBeginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeStop", DbType="BigInt")]
		public System.Nullable<long> DateTimeStop
		{
			get
			{
				return this._DateTimeStop;
			}
			set
			{
				if ((this._DateTimeStop != value))
				{
					this.OnDateTimeStopChanging(value);
					this.SendPropertyChanging();
					this._DateTimeStop = value;
					this.SendPropertyChanged("DateTimeStop");
					this.OnDateTimeStopChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeltaTime", DbType="BigInt")]
		public System.Nullable<long> DeltaTime
		{
			get
			{
				return this._DeltaTime;
			}
			set
			{
				if ((this._DeltaTime != value))
				{
					this.OnDeltaTimeChanging(value);
					this.SendPropertyChanging();
					this._DeltaTime = value;
					this.SendPropertyChanged("DeltaTime");
					this.OnDeltaTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentDate", DbType="NVarChar(10)")]
		public string CurrentDate
		{
			get
			{
				return this._CurrentDate;
			}
			set
			{
				if ((this._CurrentDate != value))
				{
					this.OnCurrentDateChanging(value);
					this.SendPropertyChanging();
					this._CurrentDate = value;
					this.SendPropertyChanged("CurrentDate");
					this.OnCurrentDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentTime", DbType="NVarChar(10)")]
		public string CurrentTime
		{
			get
			{
				return this._CurrentTime;
			}
			set
			{
				if ((this._CurrentTime != value))
				{
					this.OnCurrentTimeChanging(value);
					this.SendPropertyChanging();
					this._CurrentTime = value;
					this.SendPropertyChanged("CurrentTime");
					this.OnCurrentTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrentSystemDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> CurrentSystemDateTime
		{
			get
			{
				return this._CurrentSystemDateTime;
			}
			set
			{
				if ((this._CurrentSystemDateTime != value))
				{
					this.OnCurrentSystemDateTimeChanging(value);
					this.SendPropertyChanging();
					this._CurrentSystemDateTime = value;
					this.SendPropertyChanged("CurrentSystemDateTime");
					this.OnCurrentSystemDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Version", DbType="NVarChar(5)")]
		public string Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				if ((this._Version != value))
				{
					this.OnVersionChanging(value);
					this.SendPropertyChanging();
					this._Version = value;
					this.SendPropertyChanged("Version");
					this.OnVersionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SmenaOpened", DbType="Bit")]
		public System.Nullable<bool> SmenaOpened
		{
			get
			{
				return this._SmenaOpened;
			}
			set
			{
				if ((this._SmenaOpened != value))
				{
					this.OnSmenaOpenedChanging(value);
					this.SendPropertyChanging();
					this._SmenaOpened = value;
					this.SendPropertyChanged("SmenaOpened");
					this.OnSmenaOpenedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PapStat", DbType="NVarChar(MAX)")]
		public string PapStat
		{
			get
			{
				return this._PapStat;
			}
			set
			{
				if ((this._PapStat != value))
				{
					this.OnPapStatChanging(value);
					this.SendPropertyChanging();
					this._PapStat = value;
					this.SendPropertyChanged("PapStat");
					this.OnPapStatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteStatus", DbType="Int")]
		public System.Nullable<int> ByteStatus
		{
			get
			{
				return this._ByteStatus;
			}
			set
			{
				if ((this._ByteStatus != value))
				{
					this.OnByteStatusChanging(value);
					this.SendPropertyChanging();
					this._ByteStatus = value;
					this.SendPropertyChanged("ByteStatus");
					this.OnByteStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteStatusInfo", DbType="NVarChar(MAX)")]
		public string ByteStatusInfo
		{
			get
			{
				return this._ByteStatusInfo;
			}
			set
			{
				if ((this._ByteStatusInfo != value))
				{
					this.OnByteStatusInfoChanging(value);
					this.SendPropertyChanging();
					this._ByteStatusInfo = value;
					this.SendPropertyChanged("ByteStatusInfo");
					this.OnByteStatusInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteResult", DbType="Int")]
		public System.Nullable<int> ByteResult
		{
			get
			{
				return this._ByteResult;
			}
			set
			{
				if ((this._ByteResult != value))
				{
					this.OnByteResultChanging(value);
					this.SendPropertyChanging();
					this._ByteResult = value;
					this.SendPropertyChanged("ByteResult");
					this.OnByteResultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteResultInfo", DbType="NVarChar(MAX)")]
		public string ByteResultInfo
		{
			get
			{
				return this._ByteResultInfo;
			}
			set
			{
				if ((this._ByteResultInfo != value))
				{
					this.OnByteResultInfoChanging(value);
					this.SendPropertyChanging();
					this._ByteResultInfo = value;
					this.SendPropertyChanged("ByteResultInfo");
					this.OnByteResultInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteReserv", DbType="Int")]
		public System.Nullable<int> ByteReserv
		{
			get
			{
				return this._ByteReserv;
			}
			set
			{
				if ((this._ByteReserv != value))
				{
					this.OnByteReservChanging(value);
					this.SendPropertyChanging();
					this._ByteReserv = value;
					this.SendPropertyChanged("ByteReserv");
					this.OnByteReservChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ByteReservInfo", DbType="NVarChar(MAX)")]
		public string ByteReservInfo
		{
			get
			{
				return this._ByteReservInfo;
			}
			set
			{
				if ((this._ByteReservInfo != value))
				{
					this.OnByteReservInfoChanging(value);
					this.SendPropertyChanging();
					this._ByteReservInfo = value;
					this.SendPropertyChanged("ByteReservInfo");
					this.OnByteReservInfoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataServer", DbType="NVarChar(1024)")]
		public string DataServer
		{
			get
			{
				return this._DataServer;
			}
			set
			{
				if ((this._DataServer != value))
				{
					this.OnDataServerChanging(value);
					this.SendPropertyChanging();
					this._DataServer = value;
					this.SendPropertyChanged("DataServer");
					this.OnDataServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataBaseName", DbType="NVarChar(1024)")]
		public string DataBaseName
		{
			get
			{
				return this._DataBaseName;
			}
			set
			{
				if ((this._DataBaseName != value))
				{
					this.OnDataBaseNameChanging(value);
					this.SendPropertyChanging();
					this._DataBaseName = value;
					this.SendPropertyChanged("DataBaseName");
					this.OnDataBaseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MinSumm", DbType="Int")]
		public System.Nullable<int> MinSumm
		{
			get
			{
				return this._MinSumm;
			}
			set
			{
				if ((this._MinSumm != value))
				{
					this.OnMinSummChanging(value);
					this.SendPropertyChanging();
					this._MinSumm = value;
					this.SendPropertyChanged("MinSumm");
					this.OnMinSummChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaxSumm", DbType="Int")]
		public System.Nullable<int> MaxSumm
		{
			get
			{
				return this._MaxSumm;
			}
			set
			{
				if ((this._MaxSumm != value))
				{
					this.OnMaxSummChanging(value);
					this.SendPropertyChanging();
					this._MaxSumm = value;
					this.SendPropertyChanged("MaxSumm");
					this.OnMaxSummChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TypeEvery", DbType="Bit")]
		public System.Nullable<bool> TypeEvery
		{
			get
			{
				return this._TypeEvery;
			}
			set
			{
				if ((this._TypeEvery != value))
				{
					this.OnTypeEveryChanging(value);
					this.SendPropertyChanging();
					this._TypeEvery = value;
					this.SendPropertyChanged("TypeEvery");
					this.OnTypeEveryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrintEvery", DbType="Int")]
		public System.Nullable<int> PrintEvery
		{
			get
			{
				return this._PrintEvery;
			}
			set
			{
				if ((this._PrintEvery != value))
				{
					this.OnPrintEveryChanging(value);
					this.SendPropertyChanging();
					this._PrintEvery = value;
					this.SendPropertyChanged("PrintEvery");
					this.OnPrintEveryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KlefMem", DbType="Int")]
		public System.Nullable<int> KlefMem
		{
			get
			{
				return this._KlefMem;
			}
			set
			{
				if ((this._KlefMem != value))
				{
					this.OnKlefMemChanging(value);
					this.SendPropertyChanging();
					this._KlefMem = value;
					this.SendPropertyChanged("KlefMem");
					this.OnKlefMemChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeSyncFP", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTimeSyncFP
		{
			get
			{
				return this._DateTimeSyncFP;
			}
			set
			{
				if ((this._DateTimeSyncFP != value))
				{
					this.OnDateTimeSyncFPChanging(value);
					this.SendPropertyChanging();
					this._DateTimeSyncFP = value;
					this.SendPropertyChanged("DateTimeSyncFP");
					this.OnDateTimeSyncFPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeSyncDB", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTimeSyncDB
		{
			get
			{
				return this._DateTimeSyncDB;
			}
			set
			{
				if ((this._DateTimeSyncDB != value))
				{
					this.OnDateTimeSyncDBChanging(value);
					this.SendPropertyChanging();
					this._DateTimeSyncDB = value;
					this.SendPropertyChanged("DateTimeSyncDB");
					this.OnDateTimeSyncDBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoxaIP", DbType="NVarChar(1024)")]
		public string MoxaIP
		{
			get
			{
				return this._MoxaIP;
			}
			set
			{
				if ((this._MoxaIP != value))
				{
					this.OnMoxaIPChanging(value);
					this.SendPropertyChanging();
					this._MoxaIP = value;
					this.SendPropertyChanged("MoxaIP");
					this.OnMoxaIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoxaPort", DbType="Int")]
		public System.Nullable<int> MoxaPort
		{
			get
			{
				return this._MoxaPort;
			}
			set
			{
				if ((this._MoxaPort != value))
				{
					this.OnMoxaPortChanging(value);
					this.SendPropertyChanging();
					this._MoxaPort = value;
					this.SendPropertyChanged("MoxaPort");
					this.OnMoxaPortChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_SyncDB")]
	public partial class tbl_SyncDB : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _CompName;
		
		private int _FPNumber;
		
		private string _DataServer;
		
		private string _DataBaseName;
		
		private int _Port;
		
		private string _MoxaIP;
		
		private System.Nullable<int> _MoxaPort;
		
		private string _TableName;
		
		private System.DateTime _DateTimeSyncDB;
		
		private System.Nullable<System.DateTime> _DataAddDateTime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnCompNameChanging(string value);
    partial void OnCompNameChanged();
    partial void OnFPNumberChanging(int value);
    partial void OnFPNumberChanged();
    partial void OnDataServerChanging(string value);
    partial void OnDataServerChanged();
    partial void OnDataBaseNameChanging(string value);
    partial void OnDataBaseNameChanged();
    partial void OnPortChanging(int value);
    partial void OnPortChanged();
    partial void OnMoxaIPChanging(string value);
    partial void OnMoxaIPChanged();
    partial void OnMoxaPortChanging(System.Nullable<int> value);
    partial void OnMoxaPortChanged();
    partial void OnTableNameChanging(string value);
    partial void OnTableNameChanged();
    partial void OnDateTimeSyncDBChanging(System.DateTime value);
    partial void OnDateTimeSyncDBChanged();
    partial void OnDataAddDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnDataAddDateTimeChanged();
    #endregion
		
		public tbl_SyncDB()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompName", DbType="NVarChar(256) NOT NULL", CanBeNull=false)]
		public string CompName
		{
			get
			{
				return this._CompName;
			}
			set
			{
				if ((this._CompName != value))
				{
					this.OnCompNameChanging(value);
					this.SendPropertyChanging();
					this._CompName = value;
					this.SendPropertyChanged("CompName");
					this.OnCompNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FPNumber", DbType="Int NOT NULL")]
		public int FPNumber
		{
			get
			{
				return this._FPNumber;
			}
			set
			{
				if ((this._FPNumber != value))
				{
					this.OnFPNumberChanging(value);
					this.SendPropertyChanging();
					this._FPNumber = value;
					this.SendPropertyChanged("FPNumber");
					this.OnFPNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataServer", DbType="NVarChar(1024) NOT NULL", CanBeNull=false)]
		public string DataServer
		{
			get
			{
				return this._DataServer;
			}
			set
			{
				if ((this._DataServer != value))
				{
					this.OnDataServerChanging(value);
					this.SendPropertyChanging();
					this._DataServer = value;
					this.SendPropertyChanged("DataServer");
					this.OnDataServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataBaseName", DbType="NVarChar(1024) NOT NULL", CanBeNull=false)]
		public string DataBaseName
		{
			get
			{
				return this._DataBaseName;
			}
			set
			{
				if ((this._DataBaseName != value))
				{
					this.OnDataBaseNameChanging(value);
					this.SendPropertyChanging();
					this._DataBaseName = value;
					this.SendPropertyChanged("DataBaseName");
					this.OnDataBaseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Port", DbType="Int NOT NULL")]
		public int Port
		{
			get
			{
				return this._Port;
			}
			set
			{
				if ((this._Port != value))
				{
					this.OnPortChanging(value);
					this.SendPropertyChanging();
					this._Port = value;
					this.SendPropertyChanged("Port");
					this.OnPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoxaIP", DbType="NVarChar(1024)")]
		public string MoxaIP
		{
			get
			{
				return this._MoxaIP;
			}
			set
			{
				if ((this._MoxaIP != value))
				{
					this.OnMoxaIPChanging(value);
					this.SendPropertyChanging();
					this._MoxaIP = value;
					this.SendPropertyChanged("MoxaIP");
					this.OnMoxaIPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoxaPort", DbType="Int")]
		public System.Nullable<int> MoxaPort
		{
			get
			{
				return this._MoxaPort;
			}
			set
			{
				if ((this._MoxaPort != value))
				{
					this.OnMoxaPortChanging(value);
					this.SendPropertyChanging();
					this._MoxaPort = value;
					this.SendPropertyChanged("MoxaPort");
					this.OnMoxaPortChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TableName", DbType="NVarChar(1024) NOT NULL", CanBeNull=false)]
		public string TableName
		{
			get
			{
				return this._TableName;
			}
			set
			{
				if ((this._TableName != value))
				{
					this.OnTableNameChanging(value);
					this.SendPropertyChanging();
					this._TableName = value;
					this.SendPropertyChanged("TableName");
					this.OnTableNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeSyncDB", DbType="DateTime NOT NULL")]
		public System.DateTime DateTimeSyncDB
		{
			get
			{
				return this._DateTimeSyncDB;
			}
			set
			{
				if ((this._DateTimeSyncDB != value))
				{
					this.OnDateTimeSyncDBChanging(value);
					this.SendPropertyChanging();
					this._DateTimeSyncDB = value;
					this.SendPropertyChanged("DateTimeSyncDB");
					this.OnDateTimeSyncDBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataAddDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> DataAddDateTime
		{
			get
			{
				return this._DataAddDateTime;
			}
			set
			{
				if ((this._DataAddDateTime != value))
				{
					this.OnDataAddDateTimeChanging(value);
					this.SendPropertyChanging();
					this._DataAddDateTime = value;
					this.SendPropertyChanged("DataAddDateTime");
					this.OnDataAddDateTimeChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tbl_SyncDBStatus")]
	public partial class tbl_SyncDBStatus : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _CompName;
		
		private System.Nullable<int> _FPNumber;
		
		private string _DataServer;
		
		private string _DataBaseName;
		
		private string _Status;
		
		private System.Nullable<System.DateTime> _DateTimeSyncDB;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnCompNameChanging(string value);
    partial void OnCompNameChanged();
    partial void OnFPNumberChanging(System.Nullable<int> value);
    partial void OnFPNumberChanged();
    partial void OnDataServerChanging(string value);
    partial void OnDataServerChanged();
    partial void OnDataBaseNameChanging(string value);
    partial void OnDataBaseNameChanged();
    partial void OnStatusChanging(string value);
    partial void OnStatusChanged();
    partial void OnDateTimeSyncDBChanging(System.Nullable<System.DateTime> value);
    partial void OnDateTimeSyncDBChanged();
    #endregion
		
		public tbl_SyncDBStatus()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompName", DbType="NVarChar(256)")]
		public string CompName
		{
			get
			{
				return this._CompName;
			}
			set
			{
				if ((this._CompName != value))
				{
					this.OnCompNameChanging(value);
					this.SendPropertyChanging();
					this._CompName = value;
					this.SendPropertyChanged("CompName");
					this.OnCompNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FPNumber", DbType="Int")]
		public System.Nullable<int> FPNumber
		{
			get
			{
				return this._FPNumber;
			}
			set
			{
				if ((this._FPNumber != value))
				{
					this.OnFPNumberChanging(value);
					this.SendPropertyChanging();
					this._FPNumber = value;
					this.SendPropertyChanged("FPNumber");
					this.OnFPNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataServer", DbType="NVarChar(1024)")]
		public string DataServer
		{
			get
			{
				return this._DataServer;
			}
			set
			{
				if ((this._DataServer != value))
				{
					this.OnDataServerChanging(value);
					this.SendPropertyChanging();
					this._DataServer = value;
					this.SendPropertyChanged("DataServer");
					this.OnDataServerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DataBaseName", DbType="NVarChar(1024)")]
		public string DataBaseName
		{
			get
			{
				return this._DataBaseName;
			}
			set
			{
				if ((this._DataBaseName != value))
				{
					this.OnDataBaseNameChanging(value);
					this.SendPropertyChanging();
					this._DataBaseName = value;
					this.SendPropertyChanged("DataBaseName");
					this.OnDataBaseNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="NVarChar(MAX)")]
		public string Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._Status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateTimeSyncDB", DbType="DateTime")]
		public System.Nullable<System.DateTime> DateTimeSyncDB
		{
			get
			{
				return this._DateTimeSyncDB;
			}
			set
			{
				if ((this._DateTimeSyncDB != value))
				{
					this.OnDateTimeSyncDBChanging(value);
					this.SendPropertyChanging();
					this._DateTimeSyncDB = value;
					this.SendPropertyChanged("DateTimeSyncDB");
					this.OnDateTimeSyncDBChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
