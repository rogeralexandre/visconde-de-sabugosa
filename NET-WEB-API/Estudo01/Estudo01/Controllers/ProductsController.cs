using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Estudo01.Models;
using System.Web.Http;

namespace Estudo01.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Fone de ouvido", Category = "Eletrônico", Price = 10 },
            new Product { Id = 2, Name = "Nexus 5X", Category = "Eletronico", Price = 345.7M },
            new Product { Id = 3, Name = "Oneplus 3", Category = "Eletrônico", Price = 330.9M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

    }
}
