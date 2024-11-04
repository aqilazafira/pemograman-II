﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230068
{
    public abstract class Product_714230068
    {
        private string myType;
        private string myTitle;


        public Product_714230068()
        {

        }

        //constructor
        public Product_714230068(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //properti untuk MyType
        public string MyType
        {
            get { return myType; }
            set { myType = value; }
        }

        //properti untuk MyTitle
        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }

        //metode abstrak untuk menampilkan informasi produk
        public abstract void DisplayInfo();
    }
}
