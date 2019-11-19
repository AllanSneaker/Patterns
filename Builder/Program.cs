using Builder.Models;
using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>()
            {
                new Product{Id = 1, Name = "Product 1", Price = 100},
                new Product{Id = 2, Name = "Product 2", Price = 200}
            };

            var builder = new ProductStockReportBuilder(products);
            var director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetProductStockReport();
            Console.WriteLine(report);
        }
    }
}
