using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanPC.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("Model1")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual DbSet<NSX> NSXes { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.maKH)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.maHD)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .Property(e => e.maKH)
                .IsUnicode(false);

            modelBuilder.Entity<Invoice>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Invoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.maHD)
                .IsUnicode(false);

            modelBuilder.Entity<InvoiceDetail>()
                .Property(e => e.maSP)
                .IsUnicode(false);

            modelBuilder.Entity<NSX>()
                .Property(e => e.maNSX)
                .IsUnicode(false);

            modelBuilder.Entity<NSX>()
                .Property(e => e.tenNSX)
                .IsUnicode(false);

            modelBuilder.Entity<NSX>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.NSX)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.maSP)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.tenSP)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.maNSX)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .HasMany(e => e.InvoiceDetails)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
