// Exemplo retirado de http://www.macoratti.net/16/06/webapi_cons1.htm

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi2_Produtos.Models
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private List<Produto> produtos = new List<Produto>();
        private int _nextId = 1;

        public ProdutoRepositorio()
        {
            Add(new Produto { Nome = "Guaraná", Categoria = "Refrigerantes", Preco = 4.59M });
            Add(new Produto { Nome = "Suco de Laranja", Categoria = "Sucos", Preco = 5.75M });
            Add(new Produto { Nome = "Mostarda", Categoria = "Condimentos", Preco = 3.90M });
            Add(new Produto { Nome = "Villa-Lobos Gran Reserva", Categoria = "Vinhos", Preco = 130.00M });

        }
        
        
        // Implementando a Interface IProdutoRepositorio.

        public Produto Add(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            produtos.Add(item);
            return item;
        }

        public Produto Get(int Id)
        {
            return produtos.Find(p => p.Id == Id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return produtos;
        }

        public void Remove(int id)
        {
            produtos.RemoveAll(p => p.Id == id);
        }

        public bool Update(Produto item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            int index = produtos.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            produtos.RemoveAt(index);
            produtos.Add(item);
            return true;
        }
    }
}