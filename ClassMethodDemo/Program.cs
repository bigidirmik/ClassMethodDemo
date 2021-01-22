using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Bilal";
            customer1.Surname = "Dırmık";
            customer1.Phone = "05332109876";
            customer1.Mail = "bigisivri@outlook.com";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Hikmet";
            customer2.Surname = "Dırmık";
            customer2.Phone = "01234567890";
            customer2.Mail = "hikmetdirmik@hotmail.com";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Engin";
            customer3.Surname = "Dermiroğ";
            customer3.Phone = "01928374656";
            customer3.Mail = "engindemirog@gmail.com";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager manager = new CustomerManager();

            Console.WriteLine("---------------------------------------------------------------------");
            manager.AddCustomer(customer1);
            Console.WriteLine("---------------------------------------------------------------------");
            manager.DelCustomer(customer2);
            Console.WriteLine("---------------------------Müşteri Listesi---------------------------");
            for (int i = 0; i < customers.Length ; i++)
            {
                manager.ListCustomer(customers[i]);
                Console.WriteLine("-------------------------------");
            }
            

        }
    }
}
