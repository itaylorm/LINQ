//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Translation
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrderDetail
    {
        public System.DateTime DueDate { get; set; }
        public Nullable<decimal> LineTotal { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public short OrderQty { get; set; }
        public int PurchaseOrderDetailID { get; set; }
        public int PurchaseOrderID { get; set; }
        public Nullable<decimal> ReceivedQty { get; set; }
        public Nullable<decimal> RejectedQty { get; set; }
        public Nullable<decimal> StockedQty { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    
        public virtual Product Product { get; set; }
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
