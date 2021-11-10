using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace XML
{
    public class Product
    {
        private int id;
        private string name;
        private decimal price;
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Precio
        {
            get { return price; }
            set { price = value; }
        }
    }
}