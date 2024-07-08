using System.Text.Json;

namespace Assignment10._1
{
 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> clients = new List<Customer>();
            clients.Add(new Customer("John", "Doe", "john.doe@gmail.com", 1234567890, 1));
            clients.Add(new Customer("Jane", "Doe", "jane.doe@gmail.com", 234567890, 2));
            clients.Add(new Customer("James", "Smith", "james.smith@gmail.com", 234567890, 3));
            string jsonString = JsonSerializer.Serialize(clients);
            Console.WriteLine(jsonString);
        }
    }
}
