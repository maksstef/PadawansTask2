﻿using System;

namespace PadawansTask2
{
    public static class ArithmeticSequence
    {
        public static int Calculate(int number, int add, int count)
        {
            // put your code here
            int sum = 0;
            for(int i = 0; i < count; ++i)
            {
                sum += number + add * i;
            }
            return sum;
            throw new NotImplementedException();
        }
    }
}
