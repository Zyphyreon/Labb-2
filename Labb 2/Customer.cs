using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Labb_2;
namespace Labb_2
{
    public class Customer
    {
        public string Name { get; private set; }

        public string Password { get; set; }

        private List<Product> _cart;
        public List<Product> Cart { get { return _cart; } }

        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Product>();
        }

        public static Customer AddNew()
        {
            Console.Write("Välj ett Användarnamn: ");
            string login = Console.ReadLine();
            Console.Write("Välj ett lösenord: ");
            string angivet = Convert.ToString(Console.ReadLine());
            Console.Write("Bekräfta ditt lösenord genom att skriva det igen: ");
            string lösenord = Convert.ToString(Console.ReadLine());
            while (lösenord != angivet)
            {
                Console.WriteLine("Lösenorden matchade inte. Vänligen försök igen.");
                Console.Write("Ange lösenord: ");
                angivet = Convert.ToString(Console.ReadLine());
                Console.Write("Bekräfta ditt lösenord genom att skriva det igen: ");
                lösenord = Convert.ToString(Console.ReadLine());
                if (lösenord == angivet)
                {
                    break;
                }
            }
            Customer newCustomer = new Customer(login, lösenord);
            return newCustomer;
            

        }

        public static bool Verify(bool utloggad)
        {
            return false;
        }

        public override string ToString()
        {
            var output = string.Empty;
            output += "Namn: " + Name;
            output += " Lösenord " + Password;
            output += " Kundvagn: ";
            foreach (var product in Cart)
            {
                output += product;
            }

            output += "\n";
            return output;

        }
    }
}
