using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25PoderDosSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Coleções", "Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            csharpColecoes.Adiciona(new Aula("Criando uma aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com coleções", 24));

            Aluno a1 = new Aluno("Vanessa Tonini", 34672);
            Aluno a2 = new Aluno("Ana Losnak", 5617);
            Aluno a3 = new Aluno("Rafael Nercessian", 17645);

            csharpColecoes.Matricula(a1);
            csharpColecoes.Matricula(a2);
            csharpColecoes.Matricula(a3);

            Console.WriteLine("Imprimindo os alunos matriculados");
            foreach (var aluno in csharpColecoes.Alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine($"O aluno a1 {a1.Nome} está matriculado?");
            Console.WriteLine(csharpColecoes.EstaMatriculado(a1));

            Aluno tonini = new Aluno("Vanessa Tonini", 34672);
            Console.WriteLine($"Tonini está matriculada? {csharpColecoes.EstaMatriculado(tonini)}");

            Console.WriteLine($"a1 == Tonini? {a1.Equals(tonini)}");

            // Aula 04, sobre dicionários.
            Console.WriteLine("Quem é o aluno com matricula 5617?");
            Aluno aluno5617 = csharpColecoes.BuscaMatriculado(5617);
            Console.WriteLine($"aluno5617: {aluno5617}");

            Console.WriteLine("Quem é o aluno com matricula 5618?");
            Console.WriteLine($"aluno5618: {csharpColecoes.BuscaMatriculado(5618)}");

            // tentando cadastrar com matrícula que já existe.
            Aluno fabio = new Aluno("Fabio Gushiken", 5617);
            //csharpColecoes.Matricula(fabio);

            csharpColecoes.SubstituiAluno(fabio);
            Console.WriteLine($"Quem é o aluno 5617 agora? {csharpColecoes.BuscaMatriculado(5617)}");

            Console.ReadLine();
        }
    }
}
