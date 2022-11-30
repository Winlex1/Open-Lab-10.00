using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Open_Lab_10._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book LOTR = new Book();

            LOTR.Author = "Winlex__";
            LOTR.ReleaseDate = "2000";
            LOTR.Title = "LOTR";
            LOTR.Pages = 100;
            LOTR.Category = "Fantasy";

            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.ReleaseDate);
            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Pages);
            Console.WriteLine(LOTR.Category);

            
            
                

        }
        
    }
}
