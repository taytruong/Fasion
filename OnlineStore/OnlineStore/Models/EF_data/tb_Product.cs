namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    [Table("tb_Product")]
    public partial class tb_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Product()
        {
            tb_OrderDetail = new HashSet<tb_OrderDetail>();
            tb_ProductImage = new HashSet<tb_ProductImage>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        public decimal Price { get; set; }

        public decimal? PriceSale { get; set; }

        public int Quantity { get; set; }

        public bool IsHome { get; set; }

        public bool IsSale { get; set; }

        public bool IsFeature { get; set; }

        public bool IsHot { get; set; }

        public int ProductCategoryId { get; set; }

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

        [StringLength(250)]
        public string Alias { get; set; }

        public bool IsActive { get; set; }

        public int ViewCount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_OrderDetail> tb_OrderDetail { get; set; }

        public virtual tb_ProductCategory tb_ProductCategory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_ProductImage> tb_ProductImage { get; set; }
    }
}
