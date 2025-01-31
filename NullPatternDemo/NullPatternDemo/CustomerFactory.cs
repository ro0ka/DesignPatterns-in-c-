﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NullPatternDemo
{
    public class CustomerFactory
    {
        public static readonly string[] names = {"Rob", "Joe", "Julie"};

        public static AbstractCustomer GetCustomer(string name)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
