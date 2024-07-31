using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete; 
    namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ilan ilan1 = new Ilan.GetById(1);
            Console.WriteLine("");
         
        }
    }
}
