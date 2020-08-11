﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SampleBank
{
    public class Account
    {
        public decimal Balance
        {
            get;
            private set;
        }
        
        public void AddTransaction(decimal amount)
        {
            Balance += amount;
        }
    }
}
