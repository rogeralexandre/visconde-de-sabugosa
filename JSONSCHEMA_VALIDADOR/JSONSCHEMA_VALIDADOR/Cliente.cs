using System;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace JSONSCHEMA_VALIDADOR
{
    static public class Cliente
    {
        public static void Validar()
        {
            // JSON Schema
            // String com um SCHEMA em JSON
            string schemaJSON = @"{
                                   'description': 'Cliente',
                                   'type'       : 'object',
                                   'properties' : {
                                                   'nome'      : {'type':['string','null']},
                                                   'cpf'       : {'type': 'integer' },
                                                   'telefones' : {
                                                                  'type'  : 'array',
                                                                  'items' : {'type' : 'string'},
                                                                  'format': 'phone' 
                                                                 }
                                                  }
                                  }";
            // Criando o objeto de parse.
            JSchema schema = JSchema.Parse(schemaJSON);

            // Um Cliente escrito em JSON
            string ClienteEmJSON = @"{
                                      'nome'      : 'Bianca',
                                      'cpf'       : 123456789,
                                      'telefones' : ['1234-5678', '9012-3456']
                                     }";
            // Fazendo o Parse do Cliente com o Schema.
            JObject cliente = JObject.Parse(ClienteEmJSON);
            // Verificando se é válido.
            bool valido = cliente.IsValid(schema);
            // Retorna TRUE
            Console.WriteLine($"Validação retornou: {valido}");

            // Um exemplo de Cliente inválido
            string ClienteEmJSON_Invalido = @"{
                                                'nome'      : 00,
                                                'cpf'       : 'fsd',
                                                'telefones' : ['1234-5678', 6667]
                                              }";
            JObject clienteInvalido = JObject.Parse(ClienteEmJSON_Invalido);
            valido = clienteInvalido.IsValid(schema);

            // Retorna FALSE
            Console.WriteLine($"Validação retornou: {valido}");

        }

        public static void ValidarComDetalhes()
        {
            // JSON Schema
            // String com um SCHEMA em JSON
            string schemaJSON = @"{
                                   'description': 'Cliente',
                                   'type'       : 'object',
                                   'properties' : {
                                                   'nome'      : {'type':['string','null']},
                                                   'cpf'       : {'type': 'integer' },
                                                   'telefones' : {
                                                                  'type'  : 'array',
                                                                  'items' : {'type' : 'string'},
                                                                  'format': 'phone' 
                                                                 }
                                                  }
                                  }";
            // Criando o objeto de parse.
            JSchema schema = JSchema.Parse(schemaJSON);

            // Um exemplo de Cliente inválido
            string ClienteEmJSON_Invalido = @"{
                                                'nome'      : 00,
                                                'cpf'       : 'fsd',
                                                'telefones' : ['1234-5678', 6667]
                                              }";
            JObject clienteInvalido = JObject.Parse(ClienteEmJSON_Invalido);

            IList<string> mensagens;
            bool valid = clienteInvalido.IsValid(schema, out mensagens);

            Console.WriteLine("Mensagens de erro da validação do JSON Object.");
            foreach (var item in mensagens)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void ValidarComMaisDetalhes()
        {
            // JSON Schema
            // String com um SCHEMA em JSON
            string schemaJSON = @"{
                                   'description': 'Cliente',
                                   'type'       : 'object',
                                   'properties' : {
                                                   'nome'      : {'type':['string','null']},
                                                   'cpf'       : {'type': 'integer' },
                                                   'telefones' : {
                                                                  'type'  : 'array',
                                                                  'items' : {'type' : 'string'},
                                                                  'format': 'phone' 
                                                                 }
                                                  }
                                  }";
            // Criando o objeto de parse.
            JSchema schema = JSchema.Parse(schemaJSON);

            // Um exemplo de Cliente inválido
            string ClienteEmJSON_Invalido = @"{
                                                'nome'      : 00,
                                                'cpf'       : 'fsd',
                                                'telefones' : ['1234-5678', 6667]
                                              }";
            JObject clienteInvalido = JObject.Parse(ClienteEmJSON_Invalido);

            // Aqui começa a diferença, o uso da classe ValidationError
            IList<ValidationError> erros;
            bool valid = clienteInvalido.IsValid(schema, out erros);
            foreach (var item in erros)
            {
                Console.WriteLine($"Tipo de erro: {item.ErrorType.ToString()}");
                Console.WriteLine($"Mensagem    : {item.Message}");
                Console.WriteLine($"Linha       : {item.LineNumber}");
                Console.WriteLine($"Caminho     : {item.Path}");
                Console.WriteLine($"Schema      : {item.Schema.ToString()}");
            }
        }
    }
}
