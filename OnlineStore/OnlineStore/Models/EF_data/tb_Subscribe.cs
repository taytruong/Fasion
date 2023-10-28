namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Subscribe
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
