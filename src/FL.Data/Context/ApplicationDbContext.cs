using FL.Domain.Constant;
using FL.Domain.Model.Auth;
using FL.Domain.Model.Dbo;
using FL.Domain.Model.Master;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FL.Data.Context
{
	public class ApplicationDbContext : IdentityDbContext<User, Role, long>
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
		}


		//dbo
		public DbSet<CorporateCustomer> CorporateCustomer { get; set; }
		public DbSet<OfficeCustomer> OfficeCustomer { get; set; }
		public DbSet<StudentCustomer> StudentCustomer { get; set; }
		public DbSet<ProductItem> ProductItem { get; set; }
		public DbSet<ProductItemColor> ProductItemColor { get; set; }
		public DbSet<ProductOrder> ProductOrder { get; set; }
		public DbSet<ProductStock> ProductStock { get; set; }
		
		//master
		public DbSet<Color> Color { get; set; }
		public DbSet<ProductCategory> ProductCategory { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.HasDefaultSchema(DatabaseSchemaConstant.auth);

			//dbo
			builder.Entity<CorporateCustomer>().ToTable(DefaultTableConstant.CorporateCustomer, DatabaseSchemaConstant.dbo);
			builder.Entity<OfficeCustomer>().ToTable(DefaultTableConstant.OfficeCustomer, DatabaseSchemaConstant.dbo);
			builder.Entity<StudentCustomer>().ToTable(DefaultTableConstant.StudentCustomer, DatabaseSchemaConstant.dbo);
			builder.Entity<ProductItem>().ToTable(DefaultTableConstant.ProductItem, DatabaseSchemaConstant.dbo);
			builder.Entity<ProductItemColor>().ToTable(DefaultTableConstant.ProductItemColor, DatabaseSchemaConstant.dbo);
			builder.Entity<ProductOrder>().ToTable(DefaultTableConstant.ProductOrder, DatabaseSchemaConstant.dbo);
			builder.Entity<ProductStock>().ToTable(DefaultTableConstant.ProductStock, DatabaseSchemaConstant.dbo);
			
			//master
			builder.Entity<Color>().ToTable(DefaultTableConstant.Color, DatabaseSchemaConstant.master);
			builder.Entity<ProductCategory>().ToTable(DefaultTableConstant.ProductCategory, DatabaseSchemaConstant.master);
		}
	}
}
