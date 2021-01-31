using MernisDogrulama.Abstract;
using MernisDogrulama.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
