using OnlineShop_WebApp.Data;

namespace OnlineShop_WebApp.Services
{
    public class ProductService
    {
        public static List<Product> GetProducts()
        {
            List<Product> productsList = new List<Product>()
                {
                new Product() 
                { 
                    ProductId = 1, 
                    ProductName = "Chai",
                    ProductImage = "/images/chai.jpg",
                    UnitInStock = 130, 
                    UnitPrice = 10.5m 
                },
                 new Product() 
                 { 
                     ProductId = 2, 
                     ProductName = "Chang",
                     ProductImage = "/images/chang.jpg",
                     UnitInStock = 0, 
                     UnitPrice = 13m 
                 },
                new Product() 
                { 
                    ProductId = 3, 
                    ProductName = "Aniseed Syrup",
                     ProductImage = "/images/Syrup.jpg",
                    UnitInStock = 1, 
                    UnitPrice = 6m
                },
                new Product() 
                { 
                    ProductId = 4, 
                    ProductName = "Chef Anton's Cajun Seasoning",
                    ProductImage = "/images/Cajun.jpg",
                    UnitInStock = 10, 
                    UnitPrice = 11.2m 
                },
                new Product() 
                { 
                    ProductId = 5, 
                    ProductName = "Gumbo Mix",
                    ProductImage = "/images/gumbo.jpg",
                    UnitInStock = 0, 
                    UnitPrice = 33m 
                },
                new Product() 
                { 
                    ProductId = 6, 
                    ProductName = "Grandma's Boysenberry Spread",
                    ProductImage = "/images/Boysenberry.jpg",
                    UnitInStock = 5, 
                    UnitPrice = 22m
                },
                new Product() 
                { 
                    ProductId = 8, 
                    ProductName = "Northwoods Cranberry Sauce", 
                    ProductImage = "/images/cranberry.jpg", 
                    UnitInStock = 3, 
                    UnitPrice = 15m
                },
                new Product() 
                { 
                    ProductId = 10, 
                    ProductName = "Ikura",
                    ProductImage = "/images/Ikura.png",
                    UnitInStock = 13, 
                    UnitPrice = 8m
                }
                };

            return productsList;
        }
    }
}
