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
    
    public partial class OrderItem
    {
        public int ID { get; set; }
        public int Order_id { get; set; }
        public int MenuItem_id { get; set; }
        public Nullable<int> Count { get; set; }
    
        public virtual MenuItem MenuItem { get; set; }
        public virtual Order Order { get; set; }
    }
}