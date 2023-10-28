namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_Category")]
    public partial class tb_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Category()
        {
            tb_News = new HashSet<tb_News>();
            tb_Posts = new HashSet<tb_Posts>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage ="Tên danh mục không để trống")]
        [StringLength(150)]
        public string Title { get; set; }

        public string Description { get; set; }

        [StringLength(150)]
        public string SeoTitle { get; set; }

        [StringLength(250)]
        public string SeoDescription { get; set; }

        [StringLength(150)]
        public string SeoKeywords { get; set; }

        public int Position { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Modifiedby { get; set; }

        public string Alias { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_News> tb_News { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Posts> tb_Posts { get; set; }
    }
}
