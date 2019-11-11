namespace OnlineMarket.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductImage")]
    public partial class ProductImage
    {
        public int ProductImageID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(300)]
        public string ImageURL { get; set; }

        public bool? Status { get; set; }

        public virtual Product Product { get; set; }
    }
}
