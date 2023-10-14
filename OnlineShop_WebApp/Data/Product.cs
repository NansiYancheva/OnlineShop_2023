namespace OnlineShop_WebApp.Data
{
    public class Product
    {
        public Product()
        {
        }

        public int? ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductImage { get; set; }

        public decimal UnitPrice { get; set; }

        public short? UnitInStock { get; set; }

    }
}
