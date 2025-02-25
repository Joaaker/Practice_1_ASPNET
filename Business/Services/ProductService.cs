using System.Xml.Linq;
using Business.Models;

namespace Business.Services;

public class ProductService
{
    private readonly static List<Product> _products = [
    new Product { Id = 1, Name = "Produkt 1", Price = 100 },
    new Product { Id = 2, Name = "Produkt 2", Price = 150 },
    new Product { Id = 3, Name = "Produkt 3", Price = 200 }
    ];

    public static List<Product> GetProducts() 
    {
        return _products;
    }
}