using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-----Yönetici Banka Kayıt Forum Kontrolü------");
            Customer customer = new Customer();
            customer.Id = 10;
            customer.FirstName = "Ali";
            customer.LastName = "Genç";
            customer.IdCard = "11111111111";
            customer.AccountType = 2;

            Customer customer1 = new Customer();
            customer1.Id = 11;
            customer1.FirstName = "Seda";
            customer1.LastName = "Şeker";
            customer1.IdCard = "22222222222";
            customer1.AccountType = 1;



            Customer[] customers = new Customer[] {customer,customer1 };
            foreach (var Customer in customers)
            {
                Console.WriteLine("\nMüşteri Ad: " + Customer.FirstName );
                Console.WriteLine("Müşteri Soyad: " + Customer.LastName);
                Console.WriteLine("Müşteri Hesap Türü: " + Customer.AccountType);
            }
            
            Customer customer3 = new Customer ();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer3);

            Customer customer4 = new Customer();
            CustomerManager customerManager1 = new CustomerManager();
            customerManager.Update(customer4);
        }

    }
}
