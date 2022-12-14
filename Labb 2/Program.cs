using System.ComponentModel;
using System.Net.Mime;
using Labb_2;

List<Product> Products = new List<Product>();
List<Customer> Customers = new List<Customer>();

Products.Add(new Product { Name = "Äpple", Price = 11.95 });
Products.Add(new Product { Name = "Päron", Price = 13.95 });
Products.Add(new Product { Name = "Banan", Price = 16.95 });

Customer customer1 = new Customer("Knatte", "123");
Customer customer2 = new Customer("Fnatte", "321" );
Customer customer3 = new Customer("Tjatte", "213");

Customers.Add(customer1);
Customers.Add(customer2);
Customers.Add(customer3);

bool utloggad = true;
string val = string.Empty;
int x = 1;
string y = string.Empty;
int index = -1;

while(true)
{
    while (utloggad == true)
    {
        Console.Write("Välkommen. Vill du logga in(1), eller skapa en ny användare(2)? ");
        val = Console.ReadLine();
        if (val == "1")
        {
            while (utloggad = true)
            {
                Console.Write("Ange användarnamn: ");
                string angivetNamn = Console.ReadLine();

                index = Customers.FindIndex(customer => customer.Name == angivetNamn);
                if (index < 0)
                {
                    Console.WriteLine("Du har inte angivit ett existerande användarnamn. Vill du skapa en ny användare(1) eller försöka igen(2)?");
                    val = Console.ReadLine();
                    if (val == "1")
                    {
                        Customers.Add(Customer.AddNew());
                    }
                    else if (val == "2")
                    {
                        
                    }
                    else
                    {
                        Console.Write("Vänligen välj alternativ 1 eller 2: ");
                    }
                    

                }
                else
                {
                    while (true)
                    {
                        Console.Write("Ange lösenord: ");
                        string angivetLösen = Console.ReadLine();
                        if (angivetLösen == Customers[index].Password)
                        {
                            utloggad = Customer.Verify(utloggad);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Felaktigt lösenord. Vänligen försök igen.");
                        }

                    }

                }

                if (utloggad == false)
                {
                    break;
                }


            }
            if (utloggad == false)
            {
               break;
            }


        }
        if (val == "2")
        {
            Customers.Add(Customer.AddNew());

        }
        
    }
    Console.WriteLine("Inloggad!");
    
    while (utloggad == false)
    {
        Console.Write("Välj vad du vill göra: Handla(1), Se kundvagn(2), gå till kassan(3), Logga ut(8): ");
        val = Console.ReadLine();
        Console.Clear();
        if (val == "1")
        {
            while (true)
            {
                
                foreach (Product product in Products)
                {

                    Console.WriteLine("\nProdukt: " + product.Name + ", Pris: " + product.Price + " SEK");
                    Console.WriteLine("Klicka på " + x + " för att lägga varan i kundvagn.");

                    x++;
                }

                Console.WriteLine("\nKlicka på " + (x + 1) + " för att gå till huvudmenyn.");
                y = Convert.ToString(x + 1);
                val = Console.ReadLine();

                if (val == "1")
                {
                    Customers[index].Cart.Add(Products[0]);
                    Console.Clear();

                }
                if (val == "2")
                {
                    Customers[index].Cart.Add(Products[1]);
                    Console.Clear();

                }
                if (val == "3")
                {
                    Customers[index].Cart.Add(Products[2]);
                    Console.Clear();

                }

                if (val == y)
                {
                    
                    break;
                }
                else
                {
                    Console.WriteLine("Vänligen välj ett av de presenterade alternativen.");
                }

                x = 1;
            }

        }

        if (val == "2")
        {
            double totalpris = 0;
            int frukt1 = 0;
            int frukt2 = 0;
            int frukt3 = 0;
            Console.WriteLine("Din Kundvagn: ");
            foreach (Product product in Products)
            {

                 frukt1 = Customers[index].Cart.Count(product => product.Name == "Äpple");
                 frukt2 = Customers[index].Cart.Count(product => product.Name == "Päron");
                 frukt3 = Customers[index].Cart.Count(product => product.Name == "Banan");
                 
                

            }
            foreach (Product product in Customers[index].Cart)
            {
                totalpris += product.Price;
            }

            if (frukt1 > 0)
            {
                Console.WriteLine(frukt1 + "st Äpplen");
            }
            if (frukt2 > 0)
            {
                Console.WriteLine(frukt2 + "st Päron");
            }
            if (frukt3 > 0)
            {
                Console.WriteLine(frukt3 + "st Bananer");
            }
            if (frukt1 >= 1)
            {
                Console.WriteLine(Products[0].Price + " SEK per Äpple");
            }
            if (frukt2 >= 1)
            {
                Console.WriteLine(Products[1].Price + " SEK per Päron");
            }
            if (frukt3 >= 1)
            {
                Console.WriteLine(Products[2].Price + " SEK per Banan");
            }



            Console.WriteLine("\nSumma: " + totalpris + " SEK");
        }

        if (val == "3")
        {
            Console.WriteLine("Ha en trevlig dag!");
            Environment.Exit(1);
        }
        if (val == "8")
        {
            Console.WriteLine("Du har loggats ut.");
            utloggad = true;
        }
        else
        {
            Console.WriteLine("Vänligen välj ett av de presenterade alternativen.");
        }
    }
}
