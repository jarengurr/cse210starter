using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        // products
       
        
        Product aProduct1 = new Product("Wheat", 5, 1, "124");
        Product aProduct2 = new Product("Corn", 1, 1, "123");
        Product aProduct3 = new Product("Hammer", 25, 1, "25");
        Product aProduct4 = new Product("Soy Beans", 8, 1, "141");
        Product aProduct5 = new Product("Toy Watch", 6, 1, "9");

        // Customer and address
        Address myAddress1 = new Address("345 Strange Street", "Adelanto", "California", "USA");
        Address myAddress2 = new Address("10 Rue de la Liberte", "Paris", "", "France");
        Address myAddress3 = new Address("1313 Mocking Bird Ln", "Acton", "California", "USA");
        Address myAddress4 = new Address("2525 Main Street", "Alhambra", "California", "USA");

        Customer theCust1 = new Customer("Sam Manger", myAddress1);
        Customer theCust2 = new Customer("Kim shealer", myAddress2);
        Customer theCust3 = new Customer("Tim Merger", myAddress3);
        Customer theCust4 = new Customer("Bill Stiller", myAddress4);





        
       
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
    }
}