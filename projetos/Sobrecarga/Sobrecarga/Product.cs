using System.Globalization;

namespace Problem2
{
    class Product
    {
        public string ProdName;
        public int Quantity;
        public double Price;

        public Product(string prodName, int quantity, double price)
        {
            ProdName = prodName;
            Quantity = quantity;
            Price = price;
        }
        public Product(string prodName, double price)
        {
            ProdName = prodName;
            Price = price;
            Quantity = 5;
        }

        public Product() { }

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
