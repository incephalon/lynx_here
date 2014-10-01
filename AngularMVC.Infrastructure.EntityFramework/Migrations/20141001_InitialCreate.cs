using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tag",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Date = c.DateTime(),
                })
                .PrimaryKey(t => t.Id);

            CreateIndex("dbo.Tag",
                    new[] { "Name" },
                    unique: true,
                    name: "TagName");

            CreateTable(
                "dbo.Site",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Url = c.String(),
                    Note = c.String(),
                    Date = c.DateTime(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TagSite",
                c => new
                {
                    TagId = c.Int(nullable: false),
                    SiteId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.TagId, t.SiteId })
                .ForeignKey("dbo.Tag", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.Site", t => t.SiteId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.SiteId);
        }

        public override void Down()
        {
            DropIndex("dbo.TagName", new[] { "Name" });
            DropTable("dbo.TagSite");
            DropTable("dbo.StsTasks");
            DropTable("dbo.StsPeople");
        }
    }
}
