namespace OnlineMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShipingData")]
    public partial class ShipingData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShipingData()
        {
            Order = new HashSet<Order>();
        }

        public int ShipingDataID { get; set; }

        [StringLength(150)]
        public string City { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(6)]
        public string PostalCode { get; set; }

        public bool? State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
