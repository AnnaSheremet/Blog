//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Blog.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public int ID_User { get; set; }
        public string Logins { get; set; }
        public string Fist_name { get; set; }
        public string Surname { get; set; }
        public string Passwords { get; set; }
        public Nullable<System.DateTime> Date_of_birth { get; set; }
        public string roles { get; set; }
        public string Gender { get; set; }
        public System.DateTime Date_of_registration { get; set; }
    }
}