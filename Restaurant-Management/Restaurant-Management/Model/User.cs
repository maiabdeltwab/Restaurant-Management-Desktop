//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserPhones = new HashSet<UserPhone>();
            this.SaveLogins = new HashSet<SaveLogin>();
        }
    
        public int ID { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserType_id { get; set; }
    
        public virtual ICollection<UserPhone> UserPhones { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<SaveLogin> SaveLogins { get; set; }
    }
}
