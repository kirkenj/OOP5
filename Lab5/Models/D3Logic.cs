using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5.Models
{
    class D3Logic
    {
        bool Prime(uint a)
        {
            uint i;
            if (a == 2)
                return true;
            if (a == 0 || a == 1 || a % 2 == 0)
                return false;
            for (i = 3; i * i <= a && a % i == 0; i += 2)
                ;
            return i * i > a;
        }
    }
}
