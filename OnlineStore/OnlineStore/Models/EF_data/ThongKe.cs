namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("ThongKes")]
    public partial class ThongKe
    {
        public int Id { get; set; }

        public DateTime ThoiGian { get; set; }

        public long SoTruyCap { get; set; }
    }
}
