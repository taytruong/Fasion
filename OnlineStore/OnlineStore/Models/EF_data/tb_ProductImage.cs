namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_ProductImage")]
    public partial class tb_ProductImage
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }

        public bool IsDefault { get; set; }

        public virtual tb_Product tb_Product { get; set; }
    }
}
