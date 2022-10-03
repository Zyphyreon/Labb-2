using System.ComponentModel;
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





while (true)
{
    Console.Write("Välkommen. Vill du logga in(1), eller skapa en ny användare(2)? ");
    string val = Console.ReadLine();
    if (val == "1")
    {
        Console.Write("Ange användarnamn: ");
        string angivetNamn = Console.ReadLine();


        IEnumerable<Customer> userQuery = from användare in Customers
            where användare.Name == angivetNamn
            select användare;




    }
    Console.Write("Ange lösenord: ");
    string angivetLösen = Console.ReadLine();


    IEnumerable<Customer> passwordQuery = from lösen in Customers
        where lösen.Name == angivetLösen
        select lösen;








    if (val == "2")
    {
        Customers.Add(Customer.AddNew());

    }

}





foreach (Product product in Products)
{
    Console.WriteLine("Produkt: " + product.Name + ", Pris: " + product.Price + " SEK");
}

foreach (Customer customer in Customers)
{
    Console.WriteLine(customer.Name);
}

//  Meny: Val 1 Logga in, Val 2 Skapa ny användare

// När man ska Registrera en ny kund ska man ange Namn och lösenord. Dessa ska sparas och namnet ska inte gå att ändra.

// Väljer man Logga In så ska man skriva in namn och lösenord. Om användaren inte finns registrerad ska programmet skriva ut att kunden inte
// finns och fråga ifall man vill registrera ny kund.
// Om lösenordet inte stämmer så ska programmet skriva ut att lösenordet är fel och låta användaren försöka igen.

//  Meny: Val 1 handla, Val 2 se kundvagn, Val 3: gå till kassan.


// Handla: Visa minst 3 olika produkter att köpa. Man ska se pris för varje produkt och kunna lägga till vara i kundvagn.

//Kundvagnen ska visa alla produkter man lagt i den, styckpriset, antalet och totalpriset samt totala kostnaden för hela kundvagnen.
//Kundvagnen skall sparas i kund och finnas tillgänglig när man loggar in.


