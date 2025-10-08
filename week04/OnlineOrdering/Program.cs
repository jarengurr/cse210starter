using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        // products


        Product aProduct1 = new Product("Wheat", 5, 10, "124");
        Product aProduct2 = new Product("Corn", 1, 20, "123");
        Product aProduct3 = new Product("Hammer", 25, 1, "25");
        Product aProduct4 = new Product("Soy Beans", 8, 1, "141");
        Product aProduct5 = new Product("Toy Watch", 6, 8, "9");

        // Customer and address
        Address myAddress1 = new Address("345 Strange Street", "Adelanto", "California", "USA");
        Address myAddress2 = new Address("10 Rue de la Liberte", "Paris", "", "France");
        Address myAddress3 = new Address("1313 Mocking Bird Ln", "Acton", "California", "USA");
        Address myAddress4 = new Address("2525 Main Street", "Alhambra", "California", "USA");

        Customer theCust1 = new Customer("Sam Manger", myAddress1);
        Customer theCust2 = new Customer("Kim shealer", myAddress2);
        Customer theCust3 = new Customer("Tim Merger", myAddress3);
        Customer theCust4 = new Customer("Bill Stiller", myAddress4);


        Order theOrder = new Order(theCust1);
        Order theOrder2 = new Order(theCust2);

        theOrder.AddProduct(aProduct1);
        theOrder.AddProduct(aProduct2);
        theOrder.AddProduct(aProduct4);

        theOrder2.AddProduct(aProduct3);
        theOrder2.AddProduct(aProduct5);
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine(theOrder.PackLabel());
        Console.WriteLine(theOrder.ShipLabel());
        theOrder.PrintTotalCost();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(theOrder2.PackLabel());
        Console.WriteLine(theOrder2.ShipLabel());
        theOrder2.PrintTotalCost();
        
       
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}