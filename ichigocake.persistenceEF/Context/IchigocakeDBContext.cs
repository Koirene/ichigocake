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

namespace ichigocake.persistenceEF.Context
{
    class IchigocakeDbContext : DbContext
    {
        public IDbSet<User> Users { get; set; }
        public IDbSet<Cake> Cakes { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<Membership> Memberships { get; set; }
        public IDbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //AUTO GENERATED FIELDS
            modelBuilder.Entity<User>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            modelBuilder.Entity<Cake>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();
            modelBuilder.Entity<Order>().Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity).IsRequired();

            //AUDIT ENTITIES
            modelBuilder.Entity<User>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Cake>().Property(t => t.TimeStamp).IsRowVersion();
            modelBuilder.Entity<Order>().Property(t => t.TimeStamp).IsRowVersion();

            modelBuilder.Entity<User>()
                .HasMany<Role>(r => r.Roles)
                .WithMany(u => u.Users)
                .Map(m =>
                {
                    m.ToTable("webpages_UsersInRoles");
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

        public override int SaveChanges()
        {
            //if (DependencyEngine.CurrentResolver != null)
            //{
            //    var currentWorkContext = DependencyEngine.CurrentResolver.Resolve<IWorkContextAccessor>().CurrentContext as IMdtWorkContext;
            //    if (currentWorkContext == null)
            //        throw new InvalidOperationException("Please use MDT Context in a Work Context!");
            //    foreach (var item in this.ChangeTracker.Entries())
            //    {
            //        if ((item.State == System.Data.EntityState.Added || item.State == System.Data.EntityState.Modified) && item.Entity is AuditEntity)
            //        {
            //            var auditEntity = item.Entity as AuditEntity;
            //            var curDate = DateTime.Now;

            //            if (item.State == System.Data.EntityState.Added)
            //            {
            //                if (!auditEntity.CreatedBy.HasValue)
            //                    auditEntity.CreatedBy = currentWorkContext.CurrentUserId;
            //                if (!auditEntity.CreatedDate.HasValue)
            //                    auditEntity.CreatedDate = curDate;
            //            }

            //            if (!auditEntity.LastModifiedBy.HasValue)
            //                auditEntity.LastModifiedBy = currentWorkContext.CurrentUserId;
            //            if (!auditEntity.LastModifiedDate.HasValue)
            //                auditEntity.LastModifiedDate = curDate;
            //        }
            //    }
            //}
            return base.SaveChanges();
        }
    }
}
