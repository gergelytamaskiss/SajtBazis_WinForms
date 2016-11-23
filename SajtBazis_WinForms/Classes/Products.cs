using System;

namespace SajtBazis_WinForms.Classes
{
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
        Pannónia,
        Milkana,
        Tihany,
        Bakony,
        Krajcár,
        Mackó,
        Sajtmester,
        Francia_sajtok,
        Olasz_sajtok
    }

    enum Markets
    {
        Retail,
        MDD,
        Gasztro,
        Export
    }
    class Products
    {
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
                else { throw new ArgumentException("Partnumber can't be empty!"); }
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

        //DateTime dateCreated;

        //public DateTime DateCreated
        //{
        //    get { return dateCreated; }
        //    //set { dateCreated = value; }
        //}

        public Products(int partNumber, string description, Brands brand, Markets market, Factories factory, Types type, int barCode, int width, int height, int length, int pieces, int temperature)
        {
            PartNumber = partNumber;
            Description = description;
            this.brand = brand;
            this.market = market;
            this.factory = factory;
            this.type = type;
            BarCode = barCode;
            Width = width;
            Height = height;
            Length = length;
            Pieces = pieces;
            Temperature = temperature;
            //this.dateCreated = dateCreated;
        }

        public override string ToString()
        {
            return partNumber + " - " + description;
        }
    }
}
