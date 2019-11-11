namespace OnlineMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int OrderID { get; set; }

        public int? CustomerID { get; set; }

        public int? ShipingDataID { get; set; }

        public DateTime? Date { get; set; }

        public bool? State { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ShipingData ShipingData { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
