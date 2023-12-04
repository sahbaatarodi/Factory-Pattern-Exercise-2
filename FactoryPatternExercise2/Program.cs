using System.Runtime.ConstrainedExecution;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what database would you like to use?");
            var answer = Console.ReadLine();
            var dataAccess = DataAccessFactory.GetDataAccessType(answer);
            List<Product> products = dataAccess.LoadData();
            dataAccess.SaveData();

            Console.WriteLine();
            foreach (var product in products)
            {
                Console.WriteLine($"Product Name: {product.Name} | " +
                    $"Product Price: {product.Price,0:c}");
            }
        }
    }
}
