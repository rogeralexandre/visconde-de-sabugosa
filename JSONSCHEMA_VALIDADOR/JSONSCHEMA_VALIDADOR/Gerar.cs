using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using Newtonsoft.Json.Serialization;

namespace JSONSCHEMA_VALIDADOR
{
    public static class Gerar
    {
        public static void Executar()
        {
            JSchemaGenerator generator = new JSchemaGenerator();
            JSchema schema1 = generator.Generate(typeof(Person));
            Console.WriteLine(schema1.ToString());

            // opções para geração do schema
            // alterando configurações do generator
            generator.ContractResolver = new CamelCasePropertyNamesContractResolver();
            schema1 = generator.Generate(typeof(Person));
            Console.WriteLine("--");
            Console.WriteLine(schema1.ToString());

            // definir ID para o tipo como o nome da classe.
            generator.SchemaIdGenerationHandling = SchemaIdGenerationHandling.TypeName;
            schema1 = generator.Generate(typeof(Person));
            Console.WriteLine("--");
            Console.WriteLine(schema1.ToString());

            Console.ReadKey();

            Console.WriteLine("Usando atributos de anotação de dados");
            schema1 = generator.Generate(typeof(Building));
            Console.WriteLine(schema1.ToString());

            Console.ReadKey();

            Console.WriteLine("Controlando a geração do schema usando JSchemaGenerationProvider");
            schema1 = generator.Generate(typeof(BuildingReport));
            Console.WriteLine(schema1.ToString());

            JSchemaGenerator stringEnumGenerator = new JSchemaGenerator();
            stringEnumGenerator.GenerationProviders.Add(new StringEnumGenerationProvider());
            JSchema stringEnumSchema = stringEnumGenerator.Generate(typeof(BuildingReport));
            Console.WriteLine(stringEnumSchema.ToString());

            Console.ReadKey();

        }
    }
}
