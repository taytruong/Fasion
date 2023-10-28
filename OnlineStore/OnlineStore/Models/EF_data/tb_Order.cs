namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_Order")]
    public partial class tb_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Order()
        {
            tb_OrderDetail = new HashSet<tb_OrderDetail>();
        }

        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required(ErrorMessage ="Tên khách hàng không để trống")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "Số điện thoại không để trống")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không để trống")]
        public string Address { get; set; }

        public decimal TotalAmount { get; set; }

        public int Quantity { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Modifiedby { get; set; }

        public int TypePayment { get; set; }

        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_OrderDetail> tb_OrderDetail { get; set; }
    }
}
