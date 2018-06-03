namespace ControleChamados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelasIniciais : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chamadoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeDoSistema = c.String(nullable: false),
                        ModuloDoSistema = c.String(nullable: false),
                        Criticidade = c.Int(nullable: false),
                        DescricaoDoSistema = c.String(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chamadoes", "UsuarioId", "dbo.Usuarios");
            DropIndex("dbo.Chamadoes", new[] { "UsuarioId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Chamadoes");
        }
    }
}
