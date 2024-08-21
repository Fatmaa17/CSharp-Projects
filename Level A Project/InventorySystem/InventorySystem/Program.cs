namespace InventorySystem
{
    internal class Program
    {
        const int numberOfProducts = 50;
        static string[,] products = new string[numberOfProducts, 3];
        static int numberOfProductsCounter = 0;

        static void Main(string[] args)
        {
            // Inventory System Menu
            Console.WriteLine("Welcome to this inventory system\n\n");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Update Product");
                Console.WriteLine("3. View Product");
                Console.WriteLine("4. Exit\n");

                string userInput = Console.ReadLine();
                int choice = Convert.ToInt32(userInput);

                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        UpdateProduct();
                        break;
                    case 3:
                        ViewProduct();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please select an option from 1 to 4.");
                        break;
                }
            }
        }

        private static void AddProduct()
        {
            Console.WriteLine("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Product Quantity: ");
            string quantity = Console.ReadLine();

            Console.WriteLine("Enter Product Price: ");
            string price = Console.ReadLine();

            products[numberOfProductsCounter, 0] = name;
            products[numberOfProductsCounter, 1] = quantity;
            products[numberOfProductsCounter, 2] = price;

            numberOfProductsCounter++;
            Console.WriteLine("Product Added Successfully");
        }

        private static void UpdateProduct()
        {
            Console.WriteLine("Enter Product Name to Update: ");
            string searchProduct = Console.ReadLine();
            int foundProductId = -1;

            if (numberOfProductsCounter > 0)
            {
                for (int i = 0; i < numberOfProductsCounter; i++)
                {
                    if (products[i, 0] == searchProduct)
                    {
                        foundProductId = i;
                        break;
                    }
                }

                if (foundProductId != -1)
                {
                    Console.WriteLine("Enter New Quantity: ");
                    string newQuan = Console.ReadLine();
                    products[foundProductId, 1] = newQuan;
                    Console.WriteLine("Quantity Updated Successfully");
                }
                else
                {
                    Console.WriteLine("Product Not Found");
                }
            }
            else
            {
                Console.WriteLine("No Products Available");
            }
        }

        private static void ViewProduct()
        {
            if (numberOfProductsCounter > 0)
            {
                Console.WriteLine("Products List:");
                for (int i = 0; i < numberOfProductsCounter; i++)
                {
                    Console.WriteLine($"Product ID: {i + 1} \nProduct Name: {products[i, 0]} \nProduct Quantity: {products[i, 1]} \nProduct Price: {products[i, 2]}\n");
                }
            }
            else
            {
                Console.WriteLine("No Products to Display");
            }
        }
    }
}
