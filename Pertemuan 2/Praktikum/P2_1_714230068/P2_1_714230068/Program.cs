using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714230068
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Angka Pertama: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Kedua: ");
            double input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Angka Pertama =" + input1);
            Console.WriteLine("Angka Kedua =" + input2);

            Console.WriteLine(input1 + "+" +  input2 + "=" +(input1 + input2));
            Console.WriteLine(input1 + "-" + input2 + "=" + (input1 - input2));
            Console.WriteLine(input1 + "*" + input2 + "=" + (input1 * input2));
            Console.WriteLine(input1 + "/" + input2 + "=" + (input1 / input2));






        }
    }
}
