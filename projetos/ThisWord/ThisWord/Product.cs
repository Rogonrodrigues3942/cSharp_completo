using System.Globalization;

namespace Problem2
{
    class Product
    {
        public string ProdName;
        public double Price;
        public int Quantity;

        public Product()
        {
            Quantity = 10;
        }

        public Product(string prodName, double price) : this()
        {
            ProdName = prodName;
            Price = price;
        }

        public Product(string prodName, double price, int quantity  ): this(prodName, price) 
        {
            ProdName = prodName;
            Quantity = quantity;
            Price = price;
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return "Produto: " + ProdName +
                 ", \nR$ " + Price.ToString("F2", CultureInfo.InvariantCulture) +
                 "\nQuantidade: " + Quantity +
                "\nValor em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
