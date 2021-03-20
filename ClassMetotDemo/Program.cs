using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123456;
            customer1.UserName = " sudesavass";
            customer1.job = "junior software";
            customer1.BirthYear = 2001;

            Customer customer2 = new Customer();
            customer2.Id = 121212;
            customer2.UserName = "minaysude";
            customer2.job = "İç mimar";
            customer2.BirthYear = 2001;

            Customer customer3 = new Customer();
            customer3.Id = 1515475;
            customer3.UserName = "sılasvs";
            customer3.job = "Yöentici";
            customer3.BirthYear = 1998;

            Customer customer4 = new Customer();
            customer4.Id = 18022020;
            customer4.UserName = "SemirS";
            customer4.job = "software developer";
            customer4.BirthYear = 1997;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("---------------");
            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };
            customerManager.List(customers);
            customerManager.Delete(customer3);

        }
    }
}
