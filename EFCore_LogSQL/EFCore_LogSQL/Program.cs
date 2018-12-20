using System;
using EFCore_LogSQL.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// Exemplo retirado do site iMasters, artigo do Macoratti.
// https://imasters.com.br/banco-de-dados/ef-core-logando-os-comandos-sql-no-console?utm_source=iMasters&utm_campaign=3d70527834-EMAIL_CAMPAIGN_2017_11_27_COPY_01&utm_medium=email&utm_term=0_c1528e6ab3-3d70527834-360724009
//
namespace EFCore_LogSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AppDBContext())
            {
                // Trecho inserido por mim, para adicionar alguns dados
                //Autor clarice = new Autor()
                //{
                //    Nome = "Clarice Lispector",
                //    Email = "clarice@email.com"
                //};
                //contexto.Autores.Add(clarice);

                //Autor chico = new Autor()
                //{
                //    Nome = "Chico Buarque",
                //    Email = "chico@email.com"
                //};
                //contexto.Autores.Add(chico);

                //Autor rey = new Autor()
                //{
                //    Nome = "Marcos Rey",
                //    Email = "marcos@email.com"
                //};
                //contexto.Autores.Add(rey);
                //contexto.SaveChanges();

                //Livro paixao = new Livro()
                //{
                //    Titulo = "A paixão segundo G.H.",
                //    AnoLancamento = 1964,
                //    AutorId = 1
                //};
                //contexto.Livros.Add(paixao);

                //Livro budapeste = new Livro()
                //{
                //    Titulo = "Budapeste",
                //    AnoLancamento = 2003,
                //    AutorId = 2
                //};
                //contexto.Livros.Add(budapeste);

                //Livro cadaver = new Livro()
                //{
                //    Titulo = "Um cadáver ouve rádio",
                //    AnoLancamento = 1983,
                //    Autor = rey
                //};
                //contexto.Livros.Add(cadaver);

                //contexto.SaveChanges();
                // Fim da adição de dados.

                // Query
                var resultado = contexto.Autores
                                .Include(l => l.Livros);

                foreach(var item in resultado)
                {
                    Console.WriteLine($"{item.Nome}");
                    Console.WriteLine($"{item.Email}");
                    foreach (var l in item.Livros)
                    {
                        Console.WriteLine("\t\t" + l.Titulo);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
