namespace KolokwiumWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        IdPerson = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Surname = c.String(nullable: false, maxLength: 100),
                        IdRabat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPerson)
                .ForeignKey("dbo.Rabats", t => t.IdRabat, cascadeDelete: true)
                .Index(t => t.IdRabat);
            
            CreateTable(
                "dbo.Rabats",
                c => new
                    {
                        IdRabat = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.IdRabat);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "IdRabat", "dbo.Rabats");
            DropIndex("dbo.People", new[] { "IdRabat" });
            DropTable("dbo.Rabats");
            DropTable("dbo.People");
        }
    }
}
