using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Client<T> : IAccount<T>
    {
        T sum = default(T);
        public void SetSum(T _sum)
        {
            this.sum = _sum;
        }
        public void Display()
        {
            Console.WriteLine(sum);
        }
    }
}
