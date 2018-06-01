using Caelum.CaixaEletronico.Modelo.Contas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CaixaEletronico
{
    class Serializer
    {
        public static string AsXml(Conta resource)
        {

            var stringWriter = new StringWriter();
            new XmlSerializer(resource.GetType()).Serialize(stringWriter, resource);
            return stringWriter.ToString();
        }
    }
}
