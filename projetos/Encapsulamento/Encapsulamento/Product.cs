using System.Globalization;

namespace Problem2
{
    class Product
    {
        private string _prodName;
        private int _quantity;
        private double _price;

        public Product() { }

        public Product(string prodName, double price, int quantity)
        {
            _prodName = prodName;
            _price = price;
            _quantity = quantity;
        }

        public void SetNome(string prodNome)
        {

            if (prodNome != null && prodNome.Length > 1)
            {
                _prodName = prodNome;
            }
        }
        public string GetNome() { return _prodName; }

        public double GetPrice() { return _price; }

        public int GetQuantity() { return _quantity; }

        public double ValorTotalEmEstoque()
        {
            return _price * _quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantity += quantity;
        }
        public void RemoverProdutos(int quantity)
        {
            _quantity -= quantity;
        }

        public override string ToString()
        {
            return "Produto: " + _prodName +
                 ", \nR$ " + _price.ToString("F2", CultureInfo.InvariantCulture) +
                 "\nQuantidade: " + _quantity +
                "\nValor em estoque: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
