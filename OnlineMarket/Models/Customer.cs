namespace OnlineMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Order = new HashSet<Order>();
        }

        public int CustomerID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(500)]
        public string Address { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        [StringLength(10)]
        public string Gender { get; set; }

        public bool? State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
