//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_project_dotnet
{
    using System;
    using System.Collections.Generic;
    
    public partial class Items
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public string UserId { get; set; }
    
        public virtual AspNetUsers AspNetUsers { get; set; }
    }
}
