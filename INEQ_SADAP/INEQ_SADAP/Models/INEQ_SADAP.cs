namespace INEQ_SADAP.Models
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class INEQ_SADAP : DbContext
	{
		public INEQ_SADAP()
			: base("name=INEQ_SADAP")
		{
		}

		public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
		public virtual DbSet<Brand> Brands { get; set; }
		public virtual DbSet<Component> Components { get; set; }
		public virtual DbSet<ComponentType> ComponentTypes { get; set; }
		public virtual DbSet<Equipment> Equipments { get; set; }
		public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }
		public virtual DbSet<Model> Models { get; set; }
		public virtual DbSet<Status> Status { get; set; }
		public virtual DbSet<User> Users { get; set; }
		public virtual DbSet<Warehouse> Warehouses { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Equipment>()
				.HasMany(e => e.Components)
				.WithOptional(e => e.Equipment)
				.HasForeignKey(e => e.Equipment_Id);

			modelBuilder.Entity<EquipmentType>()
				.HasMany(e => e.Components)
				.WithOptional(e => e.EquipmentType)
				.HasForeignKey(e => e.EquipmentType_Id);

			modelBuilder.Entity<User>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.LastName)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Username)
				.IsUnicode(false);

			modelBuilder.Entity<User>()
				.Property(e => e.Password)
				.IsUnicode(false);
		}
	}
}
