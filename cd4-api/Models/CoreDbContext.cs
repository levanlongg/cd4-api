using System;
using System.Threading.Tasks;
using cd4_api.ViewModels.Client.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace cd4_api.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BillSale> BillSale { get; set; }
        public virtual DbSet<BillSaleDetail> BillSaleDetail { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CumulativePoints> CumulativePoints { get; set; }
        public virtual DbSet<Dbimage> Dbimage { get; set; }
        public virtual DbSet<Dbuser> Dbuser { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<ImportInvoice> ImportInvoice { get; set; }
        public virtual DbSet<ImportInvoiceDetail> ImportInvoiceDetail { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsType> NewsType { get; set; }
        public virtual DbSet<Price> Price { get; set; }
        public virtual DbSet<Producer> Producer { get; set; }
        public virtual DbSet<Product> Product { get; set; }

        internal object GetByNameSubstring(string namelike)
        {
            throw new NotImplementedException();
        }

        public virtual DbSet<ProductType> ProductType { get; set; }

        internal Task Search(string name)
        {
            throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LEVANLONG\\SQLEXPRESS;Database=DBGomSu;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillSale>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.PersonImportId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.BillSale)
                    .HasForeignKey<BillSale>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillSale");
            });

            modelBuilder.Entity<BillSaleDetail>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.BillSaleId).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.BillSaleDetail)
                    .HasForeignKey<BillSaleDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillSaleDetail");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.BillSaleDetail)
                    .HasForeignKey<BillSaleDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BillSaleDetail1");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.ProductypeId).IsUnicode(false);

                entity.HasOne(d => d.Productype)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.ProductypeId)
                    .HasConstraintName("FK_Category");
            });

            modelBuilder.Entity<CumulativePoints>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.PriceId).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.HasOne(d => d.Price)
                    .WithMany(p => p.CumulativePoints)
                    .HasForeignKey(d => d.PriceId)
                    .HasConstraintName("FK_CumulativePoints");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CumulativePoints)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CumulativePoints1");
            });

            modelBuilder.Entity<Dbimage>(entity =>
            {
                entity.Property(e => e.Image).IsUnicode(false);
            });

            modelBuilder.Entity<Dbuser>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.ReturnPassword).IsUnicode(false);

                entity.Property(e => e.Sale).IsUnicode(false);

                entity.Property(e => e.UserPassword).IsUnicode(false);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.PercentDiscount).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Discount)
                    .HasForeignKey<Discount>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Discount");
            });

            modelBuilder.Entity<ImportInvoice>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.PersonImportId).IsUnicode(false);

                entity.Property(e => e.ProducerId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ImportInvoice)
                    .HasForeignKey<ImportInvoice>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportInvoice1");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.ImportInvoice)
                    .HasForeignKey<ImportInvoice>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportInvoice");
            });

            modelBuilder.Entity<ImportInvoiceDetail>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.ImportInvoidId).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.ImportInvoiceDetail)
                    .HasForeignKey<ImportInvoiceDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportInvoiceDetail");

                entity.HasOne(d => d.Id1)
                    .WithOne(p => p.ImportInvoiceDetail)
                    .HasForeignKey<ImportInvoiceDetail>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImportInvoiceDetail1");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.NewtypeId).IsUnicode(false);

                entity.HasOne(d => d.Newtype)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewtypeId)
                    .HasConstraintName("FK_News");
            });

            modelBuilder.Entity<NewsType>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.ProductId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Price)
                    .HasForeignKey<Price>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Price");
            });

            modelBuilder.Entity<Producer>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Logo).IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.Demo).IsUnicode(false);

                entity.Property(e => e.ProductypeId).IsUnicode(false);

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Product)
                    .HasForeignKey<Product>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product1");
            });

            modelBuilder.Entity<ProductType>(entity =>
            {
                entity.Property(e => e.Id).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        internal Task Login(UserLoginViewModel user)
        {
            throw new NotImplementedException();
        }

        internal object GetAll()
        {
            throw new NotImplementedException();
        }

        internal object Authenticate(Dbuser model)
        {
            throw new NotImplementedException();
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
