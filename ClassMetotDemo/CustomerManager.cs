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
    }
}
