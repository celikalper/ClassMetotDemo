using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Çelik";
            customer1.City = "Ankara";
            customer1.Ballance = 5250.75;

            Customer customer2 = new Customer();
            customer2.FirstName = "Ali";
            customer2.LastName = "Veli";
            customer2.City = "İzmir";
            customer2.Ballance = 7367.25;

            Customer customer3 = new Customer();
            customer3.FirstName = "Osman";
            customer3.LastName = "Çilek";
            customer3.City = "İstanbul";
            customer3.Ballance = 9513;

            Customer customer4 = new Customer();
            customer4.FirstName = "Mehmet";
            customer4.LastName = "Küçük";
            customer4.City = "Adana";
            customer4.Ballance = 4597;

            Customer[] customers = {customer1, customer2, customer3, customer4};

            foreach (var customer in customers)
            {
                Console.WriteLine("Merhaba " + customer.FirstName+" "+customer.LastName);
                Console.WriteLine("Mevcut bakiye : " + customer.Ballance);
                Console.WriteLine(customer.City);
                Console.WriteLine("-----------------------------------------");

            }

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer();
            Console.WriteLine("---------------------------------");
            customerManager.RemoveCustomer(customer2);
            Console.WriteLine("---------------------------------");
            customerManager.UpdateCustomer(customer4);
            



        }
    }
}
