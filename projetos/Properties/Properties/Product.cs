using System.Globalization;

namespace Properties
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

        public string ProdName
        {
            get { return _prodName; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _prodName = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }
        }

        public int Quantity
        {
            get { return _quantity; }
        }

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
