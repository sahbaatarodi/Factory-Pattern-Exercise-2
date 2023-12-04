using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product() { Name = "Pearl Jam Ten", Price = 12.99 },
            new Product() { Name = "Megaman X Collection", Price = 59.99 },
            new Product() { Name = "Keyboard", Price = 120.99 },
            new Product() { Name = "Monitor", Price = 159.99 },
            new Product() { Name = "Mouse", Price = 65.99 },
            new Product() { Name = "Desk", Price = 250.99 },
            new Product() { Name = "Power Supply", Price = 120.99 }
        };

        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from the list");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a list database");
        }
    }
}
