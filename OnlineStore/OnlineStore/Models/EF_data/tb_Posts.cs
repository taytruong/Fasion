namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("tb_Posts")]
    public partial class tb_Posts
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public int CategoryId { get; set; }

        [StringLength(250)]
        public string SeoTitle { get; set; }

        [StringLength(500)]
        public string SeoDescription { get; set; }

        [StringLength(250)]
        public string SeoKeywords { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Modifiedby { get; set; }

        [StringLength(150)]
        public string Alias { get; set; }

        public bool IsActive { get; set; }

        public virtual tb_Category tb_Category { get; set; }
    }
}
