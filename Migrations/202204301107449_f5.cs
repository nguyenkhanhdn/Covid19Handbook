namespace Covid19Handbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.QAs", "question", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.QAs", "question", c => c.String(maxLength: 250, unicode: false));
        }
    }
}
