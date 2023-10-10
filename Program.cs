using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _24.Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {//vehicle car1= new vehicle();// this is not possible as parent class abstract: to increase security
            Corsa car2  = new Corsa();

            Console.WriteLine(car2.wheels);

            Console.ReadLine();


        }
    }
}
