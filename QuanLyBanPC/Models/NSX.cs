namespace QuanLyBanPC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NSX")]
    public partial class NSX
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NSX()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [StringLength(10)]
        public string maNSX { get; set; }

        [Required]
        [StringLength(50)]
        public string tenNSX { get; set; }

        [Required]
        [StringLength(40)]
        public string diachiNSX { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
