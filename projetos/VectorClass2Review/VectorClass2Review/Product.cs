using System.Globalization;

namespace VectorClass2Review
{
     class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return "Produto: " + Name
                + "\nPreço: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
