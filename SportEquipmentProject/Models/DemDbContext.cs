using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SportEquipmentProject.Models;

public partial class DemDbContext : DbContext
{
    public DemDbContext()
    {
    }

    public DemDbContext(DbContextOptions<DemDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Manufacturer> Manufacturers { get; set; }

    public virtual DbSet<OrderHistory> OrderHistories { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<OrdersProduct> OrdersProducts { get; set; }

    public virtual DbSet<PointsOfDelivery> PointsOfDeliveries { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<UnitsOfMeasurement> UnitsOfMeasurements { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=dem_db;Password=1111;Username=postgres");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Manufacturer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("manufacturers_pkey");

            entity.ToTable("manufacturers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ManufacturerName).HasColumnName("manufacturer_name");
        });

        modelBuilder.Entity<OrderHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_history_pkey");

            entity.ToTable("order_history");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.DeliveryDate).HasColumnName("delivery_date");
            entity.Property(e => e.IdPointOfDelivery).HasColumnName("id_point_of_delivery");
            entity.Property(e => e.IdStatus).HasColumnName("id_status");
            entity.Property(e => e.IdUser).HasColumnName("id_user");
            entity.Property(e => e.OrderArticle).HasColumnName("order_article");
            entity.Property(e => e.OrderDate).HasColumnName("order_date");

            entity.HasOne(d => d.IdPointOfDeliveryNavigation).WithMany(p => p.OrderHistories)
                .HasForeignKey(d => d.IdPointOfDelivery)
                .HasConstraintName("order_history_id_point_of_delivery_fkey");

            entity.HasOne(d => d.IdStatusNavigation).WithMany(p => p.OrderHistories)
                .HasForeignKey(d => d.IdStatus)
                .HasConstraintName("order_history_id_status_fkey");

            entity.HasOne(d => d.IdUserNavigation).WithMany(p => p.OrderHistories)
                .HasForeignKey(d => d.IdUser)
                .HasConstraintName("order_history_id_user_fkey");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("order_statuses_pkey");

            entity.ToTable("order_statuses");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.StatusName).HasColumnName("status_name");
        });

        modelBuilder.Entity<OrdersProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_products_pkey");

            entity.ToTable("orders_products");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.IdOrder).HasColumnName("id_order");
            entity.Property(e => e.IdProduct).HasColumnName("id_product");

            entity.HasOne(d => d.IdOrderNavigation).WithMany(p => p.OrdersProducts)
                .HasForeignKey(d => d.IdOrder)
                .HasConstraintName("orders_products_id_order_fkey");

            entity.HasOne(d => d.IdProductNavigation).WithMany(p => p.OrdersProducts)
                .HasForeignKey(d => d.IdProduct)
                .HasConstraintName("orders_products_id_product_fkey");
        });

        modelBuilder.Entity<PointsOfDelivery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("points_of_delivery_pkey");

            entity.ToTable("points_of_delivery");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.PointName).HasColumnName("point_name");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.HasIndex(e => e.Article, "products_article_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Article).HasColumnName("article");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.Discount).HasColumnName("discount");
            entity.Property(e => e.IdManufacturer).HasColumnName("id_manufacturer");
            entity.Property(e => e.IdProductCategory).HasColumnName("id_product_category");
            entity.Property(e => e.IdSupplier).HasColumnName("id_supplier");
            entity.Property(e => e.IdUnitOfMeasurement).HasColumnName("id_unit_of_measurement");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.ProductName).HasColumnName("product_name");

            entity.HasOne(d => d.IdManufacturerNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdManufacturer)
                .HasConstraintName("products_id_manufacturer_fkey");

            entity.HasOne(d => d.IdProductCategoryNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdProductCategory)
                .HasConstraintName("products_id_product_category_fkey");

            entity.HasOne(d => d.IdSupplierNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdSupplier)
                .HasConstraintName("products_id_supplier_fkey");

            entity.HasOne(d => d.IdUnitOfMeasurementNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdUnitOfMeasurement)
                .HasConstraintName("products_id_unit_of_measurement_fkey");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_categories_pkey");

            entity.ToTable("product_categories");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CategoryName).HasColumnName("category_name");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("roles_pkey");

            entity.ToTable("roles");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleName).HasColumnName("role_name");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("suppliers_pkey");

            entity.ToTable("suppliers");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SupplierName).HasColumnName("supplier_name");
        });

        modelBuilder.Entity<UnitsOfMeasurement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("units_of_measurement_pkey");

            entity.ToTable("units_of_measurement");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.UnitName).HasColumnName("unit_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.ToTable("users");

            entity.HasIndex(e => e.Login, "users_login_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdRole).HasColumnName("id_role");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.Patronymic).HasColumnName("patronymic");
            entity.Property(e => e.Surname).HasColumnName("surname");

            entity.HasOne(d => d.IdRoleNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.IdRole)
                .HasConstraintName("users_id_role_fkey");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
