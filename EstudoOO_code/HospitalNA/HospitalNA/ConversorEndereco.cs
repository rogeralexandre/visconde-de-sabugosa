using CasaDoCodigo.LivroOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasaDoCodigo.LivroOO.Util
{
    public sealed class ConversorEndereco
    {
        public static Endereco ConverterEndereco(String endereco)
        {
            Endereco end = new Endereco();
            end.logradouro = endereco.Split(',')[0];
            end.numero = Int32.Parse(endereco.Split(',')[1].Split(' ')[1]);
            end.bairro = endereco.Split(',')[2];
            end.cep = endereco.Split(',')[3];

            return end;
        }
    }
}
