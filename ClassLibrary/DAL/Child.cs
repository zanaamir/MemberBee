//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Child
    {
        public int ChildCode { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string gender { get; set; }
        public int CustomerIdNumber { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
