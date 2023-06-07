namespace Zadanie_ME.Repositories
{
    public class ProduktRepository : IProduktRepository
    {
        private static readonly List<Produkt> _products = new List<Produkt>();

        public IEnumerable<Produkt> GetAllProducts()
        {
            return _products;
        }

        public void AddProduct(Produkt product)
        {
            int newProductId = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            product.Id = newProductId;
            _products.Add(product);
        }
    }
}
