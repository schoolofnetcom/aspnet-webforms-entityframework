namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dependentes", "Info", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Dependentes", "Info");
        }
    }
}
