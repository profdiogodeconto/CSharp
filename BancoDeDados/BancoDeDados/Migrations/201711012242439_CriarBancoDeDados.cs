namespace BancoDeDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBancoDeDados : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        FuncionarioId = c.Int(nullable: false, identity: true),
                        Matricula = c.Int(nullable: false),
                        Nome = c.String(),
                        Cpf = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Telefone = c.String(),
                        Endereco = c.String(),
                    })
                .PrimaryKey(t => t.FuncionarioId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
