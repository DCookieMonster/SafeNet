//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigiGuard
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimStatu
    {
        public DimStatu()
        {
            this.FactReports = new HashSet<FactReport>();
        }
    
        public int StatusID { get; set; }
        public string StatusName { get; set; }
    
        public virtual ICollection<FactReport> FactReports { get; set; }
    }
}
