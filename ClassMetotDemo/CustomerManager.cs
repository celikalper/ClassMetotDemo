using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer()
        {
            Console.WriteLine("Müşteri eklendi.");
            Console.WriteLine(" ");
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisi silindi.");
            Console.WriteLine(" ");
        }
        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisinin bilgileri güncellendi.");
            Console.WriteLine(" ");
        }

        public void ListCustomers(Customer[] customers)
        {
            Console.WriteLine("---------For Döngüsü Müşteri Listesi---------");
            Console.WriteLine(" ");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i].FirstName + " " + customers[i].LastName);
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------Foreach Döngüsü Müşteri Listesi---------");
            Console.WriteLine(" ");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName);
            }
            Console.WriteLine(" ");
            Console.WriteLine("---------While Döngüsü Müşteri Listesi---------");
            Console.WriteLine(" ");
            int j = 0;
            while (j<customers.Length)
            {
                Console.WriteLine(customers[j].FirstName + " " + customers[j].LastName);
                j++;
            }
        }
    }
}
