namespace OnlineStore.Models.EF_data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    [Table("tb_Contact")]
    public partial class tb_Contact
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên không ????c ?ê? trô?ng")]
        [StringLength(150,ErrorMessage = "Không v???t qua? 150 ky? t??")]       
        public string Name { get; set; }

        [StringLength(150, ErrorMessage = "Không v???t qua? 150 ky? t??")]
        public string Email { get; set; }

        public string Website { get; set; }

        [StringLength(4000)]
        public string Message { get; set; }

        public bool IsRead { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string Modifiedby { get; set; }
    }
}
