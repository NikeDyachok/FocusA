//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFocus.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ComInitDefault
    {
        public long id { get; set; }
        public string CompName { get; set; }
        public Nullable<long> DateTimeBegin { get; set; }
        public Nullable<long> DateTimeStop { get; set; }
        public Nullable<long> DeltaTime { get; set; }
        public string DataServer { get; set; }
        public string DataBaseName { get; set; }
        public Nullable<int> MinSumm { get; set; }
        public Nullable<int> MaxSumm { get; set; }
        public Nullable<bool> TypeEvery { get; set; }
        public Nullable<int> PrintEvery { get; set; }
    }
}
