using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount<int> intClient = new Client<int>();
            intClient.SetSum(300);
            intClient.Display();

            IAccount<double> doubleClient = new Client<double>();
            doubleClient.SetSum(500.09);
            doubleClient.Display();
        }
    }
}

