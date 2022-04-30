namespace Covid19Handbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Thankfuls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Thankfuls");
        }
    }
}
