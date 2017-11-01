using BancoDeDados.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados.View
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            f.Matricula = 123456;
            f.Nome = "Diogo Deconto";
            f.Telefone = "123123";
            f.Cpf = "12321321312";
            f.DataNascimento = DateTime.Now;

            //Gravar objeto no banco
            Context ctx = new Context();
            ctx.Funcionarios.Add(f);
            ctx.SaveChanges();

            Console.WriteLine("Funcionário gravado com sucesso!");
            Console.ReadKey();
        }
    }
}
