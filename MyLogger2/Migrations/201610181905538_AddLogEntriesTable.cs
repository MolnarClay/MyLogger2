namespace MyLogger2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogEntriesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Application = c.String(maxLength: 255),
                        Level = c.String(maxLength: 255),
                        Logger = c.String(),
                        Message = c.String(),
                        MachineName = c.String(),
                        UserName = c.String(maxLength: 255),
                        Thread = c.String(),
                        Exception = c.String(),
                        DateCreated = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogEntries");
        }
    }
}
