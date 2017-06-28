using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazendo UPCAST
            Console.WriteLine("Fazendo UPCAST");
            Console.WriteLine("Variavel Pessoa foi declarada:");
            Pessoa v_Pessoa;
            Console.WriteLine("Feito o UPCAST do objeto Paciente para a variável pessoa");
            v_Pessoa = new Paciente();
            v_Pessoa.Nome = "Paciente 1";
            v_Pessoa.Sexo = "Feminino";
            Console.WriteLine("ToString() do objeto v_Pessoa:");
            Console.WriteLine(v_Pessoa.ToString());
            Console.Read();
        }
    }
}
