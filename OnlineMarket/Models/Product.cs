namespace OnlineMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderDetail = new HashSet<OrderDetail>();
            ProductImage = new HashSet<ProductImage>();
        }

        public int ProductID { get; set; }

        public int CategoryID { get; set; }

        public int ModelID { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? Stock { get; set; }

        public bool? State { get; set; }

        public virtual Category Category { get; set; }

        public virtual Model Model { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductImage> ProductImage { get; set; }
    }
}
