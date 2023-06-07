using Zadanie_ME;

public interface IProduktRepository
{
    public IEnumerable<Produkt> GetAllProducts();
    public void AddProduct(Produkt product);
}