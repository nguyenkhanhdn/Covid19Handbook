namespace Covid19Handbook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        comment = c.String(),
                        date = c.DateTime(storeType: "date"),
                        author = c.String(maxLength: 50),
                        note = c.String(maxLength: 200),
                        likes = c.Short(),
                        QAId = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        phone = c.String(maxLength: 20, unicode: false),
                        doctorName = c.String(maxLength: 100),
                        description = c.String(maxLength: 150),
                        note = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.documents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        docNo = c.String(maxLength: 20, unicode: false),
                        title = c.String(maxLength: 200),
                        date = c.DateTime(storeType: "date"),
                        content = c.String(),
                        link = c.String(maxLength: 100),
                        status = c.String(maxLength: 3, unicode: false),
                        note = c.String(maxLength: 200),
                        views = c.Short(),
                        officer = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.F01s",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        content = c.String(),
                        date = c.DateTime(storeType: "date"),
                        type = c.String(maxLength: 50),
                        status = c.String(maxLength: 3, unicode: false),
                        views = c.Short(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.hotlines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        hotline = c.String(maxLength: 20, unicode: false),
                        office = c.String(maxLength: 200),
                        contactname = c.String(maxLength: 50),
                        address = c.String(maxLength: 100),
                        note = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Monitoring",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        patientId = c.Int(nullable: false),
                        reportDate = c.DateTime(nullable: false, storeType: "date"),
                        bodytemp = c.Double(nullable: false),
                        spo2 = c.Double(nullable: false),
                        symtomps = c.String(nullable: false, maxLength: 100),
                        doctoradv = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 200),
                        Brief = c.String(nullable: false),
                        Date = c.DateTime(nullable: false, storeType: "date"),
                        Content = c.String(nullable: false),
                        Author = c.String(maxLength: 50),
                        Status = c.String(maxLength: 3, unicode: false),
                        View = c.Short(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Fullname = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(nullable: false, maxLength: 10),
                        YearofBirth = c.String(nullable: false, maxLength: 4, unicode: false),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 50, unicode: false),
                        Note = c.String(maxLength: 250),
                        Address = c.String(nullable: false, maxLength: 50),
                        Ward = c.String(nullable: false, maxLength: 50),
                        District = c.String(nullable: false, maxLength: 50),
                        Province = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.QAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        question = c.String(maxLength: 250, unicode: false),
                        Answer = c.String(),
                        description = c.String(maxLength: 250),
                        date = c.DateTime(storeType: "date"),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QAs");
            DropTable("dbo.Patients");
            DropTable("dbo.News");
            DropTable("dbo.Monitoring");
            DropTable("dbo.hotlines");
            DropTable("dbo.F01s");
            DropTable("dbo.documents");
            DropTable("dbo.doctors");
            DropTable("dbo.comments");
        }
    }
}
