﻿using System;
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
        List<Product> Listproducts = new List<Product>
        {
            new Product { Id = 1, Name = "Fone de ouvido", Category = "Eletrônico", Price = 10 },
            new Product { Id = 2, Name = "Nexus 5X", Category = "Eletronico", Price = 345.7M },
            new Product { Id = 3, Name = "Oneplus 3", Category = "Eletrônico", Price = 330.9M }
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return Listproducts;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = Listproducts.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //public HttpResponseMessage PostProduct(Product item)
        //{
        //    Listproducts.Add(item);
     
        //    var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);
        //    string uri = Url.Link("DefaultApi", new { id = item.Id });
        //    response.Headers.Location = new Uri(uri);

        //    return response;
        //}

        public IHttpActionResult PostProduct(Product item)
        {
            Listproducts.Add(item);

            string uri = Url.Link("DefaultApi", new { id = item.Id });

            return Created(uri, item);
        }

        public IHttpActionResult PutProduct(int id, Product item)
        {
            //Product ProdutoEncontrado = Listproducts.Find(x => x.Id == id);
            Product ProdutoEncontrado = Listproducts.Find(x => x.Id == id);
            Listproducts.Remove(ProdutoEncontrado);
            Listproducts.Add(item);
            return Ok(item);
        }

        public void DeleteProduct(int id)
        {
            // segundo este artigo https://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/action-results
            // para eu retornar o DELETE com NO CONTENT tenho que declarar o método com o retorno VOID
            // Se eu utilizar o IHttpActionResult deverei obrigatoriamente retornar OK + a entidade 
            Product ProdutoEncontrado = Listproducts.Find(x => x.Id == id);
            Listproducts.Remove(ProdutoEncontrado);
            
        }
    }
}
