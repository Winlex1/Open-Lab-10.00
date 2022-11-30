using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Open_Lab_10._03
{
    internal class Book
    {
        private string title;
        private int pages;
        private string category;
        private string author;
        private string releaseDate;
        public string Title { get { return title; } set { title = value; } }
        public int Pages { get { return pages;} set {
                if (value < 0)
                {
                    this.pages = 1;
                }
                else
                {
                    this.pages = value;
                }
            } }

        public string Category { get { return category; } set { category = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string ReleaseDate { get { return releaseDate; } 
            set {
                int n = Convert.ToInt32(value);
                if(n < 1450 || n > 2021)
                {
                    this.releaseDate = "-1";
                    
                }
                else
                {
                    this.releaseDate = value;
                }
                
                
            } }



        

    }

}
