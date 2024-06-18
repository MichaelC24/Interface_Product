namespace Interface_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phone1 = new Phone() { ProductName = "Samsung", ProductPrice = 100};
            Phone phone2 = new Phone() {ProductName = "Apple", ProductPrice = 200 };
            Car car1 = new Car() { ProductName = "Ford", ProductPrice = 1000};
            Car car2 = new Car() { ProductName = "Chevy", ProductPrice = 1500};
            Apple apple1 = new Apple() { ProductName = "Green Apple", ProductPrice = 5.25m };
            Apple apple2 = new Apple() { ProductName = "Red Apple", ProductPrice = 10};

            List<IProduct> products = new List<IProduct>();
            products.AddRange(new IProduct[] { phone1, phone2, car1, car2, apple1, apple2 });

            foreach (IProduct product in products)
            {
                Console.WriteLine($"This is the product: {product.ProductName, -20} This is the price: {product.ProductPrice}");

            }

        }
    }
}
