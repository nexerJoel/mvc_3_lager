namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nests : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nests",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.Int(nullable: false),
                        FirstChoice = c.Boolean(nullable: false),
                        Tiger_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tigers", t => t.Tiger_Id)
                .Index(t => t.Tiger_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Nests", "Tiger_Id", "dbo.Tigers");
            DropIndex("dbo.Nests", new[] { "Tiger_Id" });
            DropTable("dbo.Nests");
        }
    }
}
