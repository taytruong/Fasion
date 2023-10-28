﻿namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("tb_News")]
    public partial class tb_News
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Bạn không để trống tiêu đề tin")]
        [StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        public string Image { get; set; }

        public int CategoryId { get; set; }

        public string SeoTitle { get; set; }

        public string SeoDescription { get; set; }

        public string SeoKeywords { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Modifiedby { get; set; }

        public string Alias { get; set; }

        public bool IsActive { get; set; }

        public virtual tb_Category tb_Category { get; set; }
    }
}
