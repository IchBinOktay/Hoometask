using task2;
class Program
{
    static void Main(string[] args)
    {
        Shop shop = new Shop();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Sell Product");
            Console.WriteLine("3.Check Income");
            Console.WriteLine("4. Check rest of the products");
            Console.WriteLine("Choose:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddProduct(shop);
                    break;
                case "2":
                    SellProduct(shop);
                    break;
                case "3":
                    Console.WriteLine($"Total Income: {shop.TotalIncome}");
                    break;
                case "4":
                    ViewProducts(shop);
                    break;
                default:
                    Console.WriteLine("Wrong, Try again.");
                    break;
            }
        }
    }

    static void AddProduct(Shop shop)
    {
        Console.WriteLine("Add Product Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Add Product Price:");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Add Product Count:");
        int count = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Add Product Type (c for Coffee, t for Tea):");
        string type = Console.ReadLine();

        if (type == "c")
        {
            shop.AddProduct(new Coffee { Name = name, Price = price, Count = count });
        }
        else if (type == "t")
        {
            shop.AddProduct(new Tea { Name = name, Price = price, Count = count });
        }
        else
        {
            Console.WriteLine("Yincorrect product type, Try again.");
        }
    }

    static void SellProduct(Shop shop)
    {
        Console.WriteLine("insert the name of the product that you will sell:");
        string name = Console.ReadLine();

        Console.WriteLine("product amount");
        int count = Convert.ToInt32(Console.ReadLine());

        bool result = shop.SellProduct(name, count);

        if (!result)
        {
            Console.WriteLine("sell was a fail. not enough product or couldnt find.");
        }
    }

    static void ViewProducts(Shop shop)
    {
        foreach (var product in shop.Products)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}, Count: {product.Count}");
        }
    }
}
