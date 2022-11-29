using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._00
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Appslab");
            Book LOTR = new Book();
            LOTR.title = "LOTR";
            
            Console.WriteLine(LOTR.title);
            
                

        }
    }
}
