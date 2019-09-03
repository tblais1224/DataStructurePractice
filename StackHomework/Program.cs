using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var myArr = new DynamicArray();
            myArr.Append(44);
            myArr.Append(44);
            myArr.Append(44);
            Console.WriteLine(myArr.GetItem(2));
            myArr.SetItem(2, 12);
            Console.WriteLine(myArr.GetItem(2));

            for (int i = 0; i < 15; i++)
            {
                myArr.Append(i);
            }

            Console.WriteLine(myArr.GetItem(16));
        }
    }
}
