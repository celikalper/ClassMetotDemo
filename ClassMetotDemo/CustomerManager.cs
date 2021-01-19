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
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisi silindi.");
        }
        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " Müşterisinin bilgileri güncellendi.");
        }

        public void ListCustomer(Customer[] customers)
        {
            Console.WriteLine("---------for döngüsü---------");
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Merhaba " + customers[i].FirstName + " " + customers[i].LastName);
                Console.WriteLine("Mevcut bakiye : " + customers[i].Ballance);
                Console.WriteLine(customers[i].City);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("---------foreach döngüsü---------");
            foreach (var customer in customers)
            {
                
                Console.WriteLine("Merhaba " + customer.FirstName + " " + customer.LastName);
                Console.WriteLine("Mevcut bakiye : " + customer.Ballance);
                Console.WriteLine(customer.City);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("---------while döngüsü---------");
            int j = 0;
            while (j<customers.Length)
            {
                Console.WriteLine("Merhaba " + customers[j].FirstName + " " + customers[j].LastName);
                Console.WriteLine("Mevcut bakiye : " + customers[j].Ballance);
                Console.WriteLine(customers[j].City);
                Console.WriteLine("-----------------------------------------");
                j++;
            }
        }
    }
}
