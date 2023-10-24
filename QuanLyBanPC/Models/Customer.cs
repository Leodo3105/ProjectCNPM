namespace QuanLyBanPC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            Invoices = new HashSet<Invoice>();
        }

        [Key]
        [StringLength(10)]
        public string maKH { get; set; }

        [Required]
        [StringLength(40)]
        public string tenKH { get; set; }

        [Required]
        [StringLength(5)]
        public string gioitinh { get; set; }

        [Required]
        [StringLength(10)]
        public string sdt { get; set; }

        [Required]
        [StringLength(60)]
        public string diachiKH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
