namespace Covid19Handbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class d81 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.documents", "link", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.documents", "link", c => c.String(maxLength: 100));
        }
    }
}
