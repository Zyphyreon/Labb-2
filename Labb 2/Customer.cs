using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Labb_2;
// Både kund och produkt ska vara separata klasser med Properties för information och metoder för att räkna ut
// totalpris och verifiera lösenord.
// I klassen Kund skall det finnas en ToString() som skriver ut Namn, lösenord och kundvagnen på ett snyggt sätt.
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

        
        

    }
}


/*
 Exempel:

    public class Customer 
    {
        public string Name { get; private set; }

        private string Password { get; set }

        private List<Product> _cart;
        public List<Product> Cart { get { return _cart; } }

        public Kund(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Product>();
        }
    }
    Kund1: Namn="Knatte", Password="123"
    Kund2: Namn="Fnatte", Password="321"
    Kund3: Namn="Tjatte", Password="213"
 */