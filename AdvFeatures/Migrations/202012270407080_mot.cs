namespace AdvFeatures.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mot : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                {
                    StudentId = c.Int(nullable: false, identity: true),
                    StudentName = c.String(nullable: false),
                    StudentAddress = c.String(nullable: false),
                })
                .PrimaryKey(t => t.StudentId);

        }

        public override void Down()
        {
            DropTable("dbo.Students");
        }
        
    }
}
