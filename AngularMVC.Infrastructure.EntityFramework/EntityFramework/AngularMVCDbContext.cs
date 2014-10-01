using System.Data.Entity;
using Abp.Domain.Repositories.EntityFramework;
using AngularMVC.Model;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularMVC.EntityFramework
{
    public class AngularMVCDbContext : AbpDbContext
    {
        public virtual IDbSet<Tag> Tags { get; set; }

        public virtual IDbSet<Site> Sites {get; set; }

        public AngularMVCDbContext()
            : base("MainDb")
        {
            Database.SetInitializer<AngularMVCDbContext>(new CreateDatabaseIfNotExists<AngularMVCDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Tag>().ToTable("Tag");
            //modelBuilder.Entity<Site>().ToTable("Site");

            modelBuilder.Entity<Tag>().HasMany(t => t.Sites).WithMany(s => s.Tags)
                .Map(j => j.MapLeftKey("TagId").MapRightKey("SiteId").ToTable("TagSite"));
        }
    }
}
