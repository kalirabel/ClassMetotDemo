using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer3)
        {
            Console.WriteLine("\n***Müşteri Kaydı Başarılı***");
            Console.WriteLine("Müşteri Ad: " + customer3.FirstName + "Deniz");
            Console.WriteLine("Müşteri Soyad: " + customer3.LastName + "Gök");
            Console.WriteLine("Müşteri Hesap Türü: " + customer3.AccountType + 1);
        }

        public void Update(Customer customer4)
        {
            Console.WriteLine("\n***Müşteri Bilgileri Güncellendi***");
            Console.WriteLine("Müşteri Ad: " + customer4.FirstName + "Seda");
            Console.WriteLine("Müşteri Soyad: " + customer4.LastName + "Şeker");
            Console.WriteLine("Müşteri Hesap Türü: "+ customer4.AccountType + 2);
        }

    }
}
