namespace QuanLyBanPC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InvoiceDetail")]
    public partial class InvoiceDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string maSP { get; set; }

        public int soluong { get; set; }

        public int giaban { get; set; }

        public virtual Invoice Invoice { get; set; }

        public virtual Product Product { get; set; }
    }
}
