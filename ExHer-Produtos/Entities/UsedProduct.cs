using System;
using System.Globalization;

namespace ExHer_Produtos.Entities
{
    class UsedProduct:Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime date) : base(name, price)
        {
            ManufactureDate = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {ManufactureDate.ToShortDateString()})";
        }
    }
}
