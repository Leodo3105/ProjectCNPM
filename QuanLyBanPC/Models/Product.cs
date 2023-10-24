namespace QuanLyBanPC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            InvoiceDetails = new HashSet<InvoiceDetail>();
        }

        [Key]
        [StringLength(50)]
        public string maSP { get; set; }

        [Required]
        [StringLength(50)]
        public string tenSP { get; set; }

        [Required]
        [StringLength(255)]
        public string mota { get; set; }

        public int baohanh { get; set; }

        [Required]
        [StringLength(10)]
        public string maNSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public virtual NSX NSX { get; set; }
    }
}
