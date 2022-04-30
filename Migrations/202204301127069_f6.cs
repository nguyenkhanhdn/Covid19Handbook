namespace Covid19Handbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class f6 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.documents", "date", c => c.DateTime());
            AlterColumn("dbo.Patients", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Patients", "Id");
            CreateIndex("dbo.Monitoring", "PatientId");
            AddForeignKey("dbo.Monitoring", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Monitoring", "PatientId", "dbo.Patients");
            DropIndex("dbo.Monitoring", new[] { "PatientId" });
            DropPrimaryKey("dbo.Patients");
            AlterColumn("dbo.Patients", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.documents", "date", c => c.DateTime(storeType: "date"));
            AddPrimaryKey("dbo.Patients", "Id");
        }
    }
}
