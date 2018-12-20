using System;


namespace JSONSCHEMA_VALIDADOR
{
    class Program
    {
        static void Main(string[] args)
        {

            //Validar.Executar();
            //Console.Clear();

            // INICIAR SEÇÃO DE GERAÇÃO DE JSON SCHEMA.
            // *****
            // gerar um JSON Schema
            //Gerar.Executar();
            //Console.Clear();

            // Testes para o BLOG
            Cliente.Validar();
            Console.ReadKey();

            Console.Clear();

            Cliente.ValidarComDetalhes();
            Console.ReadKey();

            Console.Clear();

            Cliente.ValidarComMaisDetalhes();
            Console.ReadKey();

        }
    }

}
