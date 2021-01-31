using MernisDogrulama.Abstract;
using MernisDogrulama.Adapters;
using MernisDogrulama.Concrete;
using MernisDogrulama.Entities;
using System;

namespace MernisDogrulama
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter()); //Starbucks ya da Nero hangisinde işlemimize yaparsak buraya ya da
            customerManager.Save(new Customer { DateOfBirth=new DateTime(1998,4,15),FirstName="Fırat",LastName="İKE",NationalityId=11111111111}); //Mernisten Bilgileri kontrol edecek doğru ise işleme devam edecek

            Console.ReadKey();
        }
    }
}
