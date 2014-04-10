using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ichigocake.domain;
using ichigocake.domain.Base;
using ichigocake.domain.Content;
using ichigocake.domain.Lookup;

namespace ichigocake.persistenceEF.Context
{
    internal class IchigocakeDbContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Cake> Cakes { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Reference> References { get; set; }
        public IDbSet<Message> Messages { get; set; }
        public IDbSet<Image> Images { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<District> Districts { get; set; }
        public IDbSet<Membership> Memberships { get; set; }
        public IDbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //AUTO GENERATED FIELDS
            modelBuilder.Entity<User>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<Cake>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<Order>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<Reference>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<Message>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<Image>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<City>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();
            modelBuilder.Entity<District>()
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .IsRequired();

            
            //AUDIT ENTITIES
            modelBuilder.Entity<User>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Cake>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Order>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Reference>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Message>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Image>().Property(t => t.TimeStamp).IsRowVersion();
           
            modelBuilder.Entity<User>()
                .HasMany<Role>(r => r.Roles)
                .WithMany(u => u.Users)
                .Map(m =>
                     {
                         m.ToTable("Roles");
                         m.MapLeftKey("UserId");
                         m.MapRightKey("RoleId");
                     });
        }

        public IchigocakeDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        public IchigocakeDbContext()
        {
        }

        //public override int SaveChanges()
        //{

        //    //    var currentWorkContext = new  IMdtWorkContext;
        //    //    if (currentWorkContext == null)
        //    //        throw new InvalidOperationException("Please use MDT Context in a Work Context!");
        //    //    foreach (var item in this.ChangeTracker.Entries())
        //    //    {
        //    //        if ((item.State == System.Data.EntityState.Added || item.State == System.Data.EntityState.Modified) && item.Entity is AuditEntity)
        //    //        {
        //    //            var auditEntity = item.Entity as AuditEntity;
        //    //            var curDate = DateTime.Now;

        //    //            if (item.State == System.Data.EntityState.Added)
        //    //            {
        //    //                if (!auditEntity.CreatedBy.HasValue)
        //    //                    auditEntity.CreatedBy = currentWorkContext.CurrentUserId;
        //    //                if (!auditEntity.CreatedDate.HasValue)
        //    //                    auditEntity.CreatedDate = curDate;
        //    //            }

        //    //            if (!auditEntity.LastModifiedBy.HasValue)
        //    //                auditEntity.LastModifiedBy = currentWorkContext.CurrentUserId;
        //    //            if (!auditEntity.LastModifiedDate.HasValue)
        //    //                auditEntity.LastModifiedDate = curDate;
        //    //        }
        //    //    }

        //    return base.SaveChanges();
        //}
    }
}
