using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SajtBazis_WinForms.Classes
{
    enum Categories
    {
        Kördobozos140g,
        Kördobozos200g,
        Kördobozos280g,
        Tömlős100g,
        Tömb_kicsi,
        Tömb_nagy
    }

    enum Factories
    {
        Répcelak,
        Zalaegerszeg,
        Veszprém
    }

    enum Types
    {
        Product,
        Carton,
        Palette
    }

    enum Brands
    {
        Medve,
        Karaván,
        Pannónia
    }

    enum Markets
    {
        Retail,
        MDD,
        Export
    }
    class Products
    {
        Categories category;

        internal Categories Category
        {
            get { return category; }
            //set { category = value; }
        }

        Factories factory;

        internal Factories Factory
        {
            get { return factory; }
            //set { factory = value; }
        }

        Types type;

        internal Types Type
        {
            get { return type; }
            //set { type = value; }
        }

        Brands brand;

        internal Brands Brand
        {
            get { return brand; }
            //set { brand = value; }
        }

        Markets market;

        internal Markets Market
        {
            get { return market; }
            //set { market = value; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set
            {
                if (value.Trim().Length > 0) { description = value; }
                else { throw new ArgumentException("Product description can't be empty!"); }
            }
        }

        int partNumber;

        public int PartNumber
        {
            get { return partNumber; }
            set
            {
                if (value > 0) { partNumber = value; }
                else { throw new ArgumentException("Part number can't be empty!"); }
            }
        }

        int barCode;

        public int BarCode
        {
            get { return barCode; }
            set
            {
                if (value > 0) { barCode = value; }
                else { throw new ArgumentException("Barcode can't be empty!"); }
            }
        }

        int length;

        public int Length
        {
            get { return length; }
            set
            {
                if (value > 0) { length = value; }
                else { throw new ArgumentException("Length can't be empty!"); }
            }
        }

        int width;

        public int Width
        {
            get { return width; }
            set
            {
                if (value > 0) { width = value; }
                else { throw new ArgumentException("Width can't be empty!"); }
            }
        }

        int height;

        public int Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { throw new ArgumentException("Height can't be empty!"); }
            }
        }

        int pieces;

        public int Pieces
        {
            get { return pieces; }
            set { pieces = value; }
        }

        int temperature;

        public int Temperature
        {
            get { return temperature; }
            set
            {
                if (value > 0) { temperature = value; }
                else { throw new ArgumentException("Temperature can't be empty!"); }
            }
        }

        DateTime dateCreated;

        public DateTime DateCreated
        {
            get { return dateCreated; }
            //set { dateCreated = value; }
        }

        public Products(Categories category, Factories factory, Types type, Brands brand, Markets market, string description, int partNumber, int barCode, int legth, int width, int height, int pieces, int temperature, DateTime dateCreated)
        {
            this.category = category;
            this.factory = factory;
            this.type = type;
            this.brand = brand;
            this.market = market;
            Description = description;
            PartNumber = partNumber;
            BarCode = barCode;
            Length = length;
            Width = width;
            Height = height;
            Pieces = pieces;
            Temperature = temperature;
        }

        //public override XElement ToXML()
        //{
        //   
        //}

    }
}
