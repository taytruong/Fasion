namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_OrderDetail")]
    public partial class tb_OrderDetail
    {
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual tb_Order tb_Order { get; set; }

        public virtual tb_Product tb_Product { get; set; }
    }
}
