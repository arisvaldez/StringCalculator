﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculatorMethod
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var total = 0;
            foreach (var number in numbers.Split(','))
            {
                total += int.Parse(number);
            }

            return total;
        }
    }
}
