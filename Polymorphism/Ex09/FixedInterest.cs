﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Ex09
{
    class FixedInterest : Interest
    {
        public override double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate) + 1500;
        }
    }
}
