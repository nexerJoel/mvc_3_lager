namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tigers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Color = c.String(),
                        Weight = c.Int(nullable: false),
                        Age = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tigers");
        }
    }
}
