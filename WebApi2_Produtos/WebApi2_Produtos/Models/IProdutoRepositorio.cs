// Exemplo retirado de http://www.macoratti.net/16/06/webapi_cons1.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2_Produtos.Models
{
    interface IProdutoRepositorio
    {
        // Aqui entendi que estamos montando o contrato da API
        IEnumerable<Produto> GetAll();
        Produto Get(int Id);
        Produto Add(Produto item);
        void Remove(int id);
        bool Update(Produto item);
    }
}
