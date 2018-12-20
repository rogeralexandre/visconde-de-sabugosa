using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Linq;

namespace JSONSCHEMA_VALIDADOR
{
    static public class Validar
    {
        public static void Executar()
        {
            // JSON Schema
            string schemaJSON = @"{
                                                  'description': 'A person',
                                                  'type'       : 'object',
                                                  'properties' : {
                                                                  'name' : {'type':['string','null']},
                                                                  'hobbies' : {
                                                                               'type'  : 'array',
                                                                               'items' : {'type' : 'string'}
                                                                              }
                                                                 }
                                                 }";

            JSchema schema = JSchema.Parse(schemaJSON);

            // JSON Object
            JObject person = JObject.Parse(@"{
                                              'name' : 'James',
                                              'hobbies' : ['.NET', 'Blogging', 'Reading', 'Xbox', 'LOLCATS']
                                             }");

            // validate JSON (the simplest way)
            bool valid = person.IsValid(schema);

            // validate JSON getting validation error messages
            JObject person1 = JObject.Parse(@"{
                                               'name'    : 00,
                                               'hobbies' : ['invalid content', 0.123456789]
                                              }");

            Console.WriteLine($"1 - Validação do schema retornou {valid}");

            IList<string> messages;
            valid = person1.IsValid(schema, out messages);

            Console.WriteLine("Mensagens de erro da validação do segundo JSON Object.");
            foreach (var item in messages)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
