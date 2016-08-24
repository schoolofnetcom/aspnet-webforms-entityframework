namespace Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.CLIENTE",
            //    c => new
            //        {
            //            ID = c.Int(nullable: false, identity: true),
            //            CPF = c.String(),
            //            Nome = c.String(),
            //            Telefone = c.String(),
            //            Endereco = c.String(),
            //        })
            //    .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dependentes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CPF = c.String(),
                        Nome = c.String(),
                        Cliente_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.CLIENTE", t => t.Cliente_ID)
                .Index(t => t.Cliente_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dependentes", "Cliente_ID", "dbo.CLIENTE");
            DropIndex("dbo.Dependentes", new[] { "Cliente_ID" });
            DropTable("dbo.Dependentes");
            DropTable("dbo.CLIENTE");
        }
    }
}
