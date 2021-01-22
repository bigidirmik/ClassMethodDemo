using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        

        public void AddCustomer(Customer customer) // Müşteri Ekleme
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adındaki müşteri eklendi.");
        }

        public void DelCustomer(Customer customer) // Müşteri Silme
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " adındaki müşteri silindi.");
        }

        public void ListCustomer(Customer customer) // Müşteri Listeleme
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Phone);
            Console.WriteLine(customer.Mail);
        }


    }
}
