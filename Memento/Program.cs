using System;
using Memento.Models;
using Memento.Services;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            HistoryService<Product> historyService = new HistoryService<Product>();

            for (int i = 1; i <= 5; i++)
            {
                var product = new Product { Id = i, Name = $"Product{i}", Price = 123 + i };
                historyService.SaveState(product);
                Console.WriteLine($"{product.Id}: {product.Name} with {product.Price} was added");
            }

            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                var previous = historyService.Undo();
                Console.WriteLine($"Undo {previous.Name}");
            }

            Console.WriteLine(new string('_', 30));
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                var previous = historyService.Redo();
                Console.WriteLine($"Redo {previous.Name}");
            }

            Console.WriteLine();
        }
    }
}
