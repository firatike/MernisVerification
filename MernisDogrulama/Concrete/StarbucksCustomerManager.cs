﻿using MernisDogrulama.Abstract;
using MernisDogrulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisDogrulama.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("User Information Incorrect");
            }
        }
    }
}