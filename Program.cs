using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_og_datatyper_opgave_1
{
    internal class Program
    {
        static void Main()
        {

            //opg a
            int length = 16;
            double width = 5.1;
            //Console.WriteLine(length * width);

            //opg b
            int area = length * width;
            //Man kan ikke sætte en int til en double,
            //og da "width" er en double vil det blive en double når den har ganget det

            //opg c

            double d = length * width;
            //Da "d" er en double vil den godt kunne sættes til hvad length * width blive da det vil gi en double
            //da "width" er en double



            Console.Read();




        }
    }
}
