namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_SystemSetting")]
    public partial class tb_SystemSetting
    {
        [Key]
        [StringLength(50)]
        public string SettingKey { get; set; }

        [StringLength(4000)]
        public string SettingValue { get; set; }

        [StringLength(4000)]
        public string SettingDescription { get; set; }
    }
}
