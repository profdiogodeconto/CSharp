using BancoDeDados.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.DAL
{
    //A classe Context vai herdar todas as funcionalidades 
    //da principal classe do EF
    class Context : DbContext
    {
        //Opcional: Nomear o arquivo do banco de dados
        public Context() : base("BancoDeDados")
        {

        }

        //Mapear classes que vão virar tabelas no banco
        public DbSet<Funcionario> Funcionarios { get; set; }
        //Inserir todas as classes na sequência
    }
}
