using MernisDogrulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
