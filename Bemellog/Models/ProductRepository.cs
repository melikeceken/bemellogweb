using Bemellog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bemellog.Models
{
    public static class ProductRepository
    {
        private static List<Product> _products;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                new Product(){ID=1,Name="Don Quixote",Description="Miguel de Cervantes",Price=17,Category="Paperback"},
                new Product(){ID=2,Name="Harry Potter",Description="J.K Rowling",Price=20,Category="Paperback"},
                new Product(){ID=3,Name="The Hunger Games",Description="Suzanne Collins",Price=20,Category="Paperback"}
            };
        }
        public static List<Product> Product
        {
            get { return _products; }
        }

        public static void AddProduct(Product entity)
        {

            _products.Add(entity);
        }


    }
}
