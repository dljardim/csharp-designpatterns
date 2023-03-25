/*Beginner Project:
Create a console application that calculates the total price of a shopping cart. 
The application should have two classes: ShoppingCart and PriceCalculator. 
The ShoppingCart class should contain a list of products and have a method to add products to the cart. 
The PriceCalculator class should take a ShoppingCart object as a dependency and calculate the total price of the products in the cart. 
The application should print the total price to the console.
*/

namespace DependencyInjection
{
    public class DependencyInjectionExample1
    {
        ShoppingCart cart = new ShoppingCart();

        Product p1 = new Product(1, "1productName", "1productDesc", 0.00M);
        Product p2 = new Product(2, "2productName", "2productDesc", 0.00M);
        Product p3 = new Product(3, "3productName", "3productDesc", 0.00M);
        Product p4 = new Product(4, "4productName", "4productDesc", 0.00M);
    }


    

    public class ShoppingCart
    {

        // list of products
        ICollection<IProduct> ProductList { get; set; }
        PriceCalculator priceCalculator { get; set; }

        // method to add products to the cart
        public void AddProduct(IProduct productToAdd)
        {
            ProductList.Add(productToAdd);
        }

        public decimal GetPriceTotal()
        {
            return 1.00M;
        }

    }

    public class PriceCalculator
    {

        ICollection<IProduct> ProductList { get; set; }

        public PriceCalculator(ICollection<IProduct> products)
        {
            ProductList = products;
        }

        public void Add(IProduct product)
        {
            ProductList.Add(product);
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0.00M;

            foreach (IProduct product in ProductList)
            {
                totalPrice += product.ProductPrice;
            }

            return totalPrice;
        }
        // take a shopping cart object
        // calculate totol price of products in the car
    }



    public interface IProduct
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
    }

    public class Product : IProduct
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; } = 0.00M;

        public Product(int productId, string productName, string ProductDescription, decimal productPrice)
        {

            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductDescription = ProductDescription;
            this.ProductPrice = productPrice;
        }
    }

    public class Writer
    {
        public void Write(string toWrite)
        {
            Console.WriteLine(toWrite);
        }
    }

    public class Reader
    {
        public string Read()
        {
            // null coalescing operator ?? ""
            return Console.ReadLine() ?? "";
        }
    }
}