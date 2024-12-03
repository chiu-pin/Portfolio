
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using static System.Reflection.Metadata.BlobBuilder;

namespace ProductStore_Application
{
    internal class Program
    {
        class Product
        {
            //Two public static arrays that hold codes (categoryCodes) and descriptions of the popular Product categories (categoryNames) 
            public static string[] categoryCodes = { "a-", "b-", "f-", "t-", "o-" };
            public static string[] categoryNames = { "Apparel", "Books", "Foods", "Toys", "Others" };

            //Data fields for product id (productID) and product category name(productCategoryName)
            private string productID;
            private string productCategoryName;

            // Auto-implemented properties
            public string ProductName { get; set; }
            public int ProductQuantity { get; set; }
            public double ProductPrice { get; set; }

            //setting productid
            public string ProductID
            {
                get { return productID; }
                set
                {
                    productID = value;

                    bool haveCategory = false;
                    for (int i = 0; i < categoryCodes.Length; i++)
                    {
                        if (productID.StartsWith(categoryCodes[i]))
                        {
                            productCategoryName = categoryNames[i];
                            haveCategory = true;
                            break;
                        }
                    }
                    if (!haveCategory)
                    {
                        productID = "o-" + productID.Substring(2, 2);
                        productCategoryName = "Others";
                    }
                }
            }
            public string ProductCategoryName
            {
                get { return productCategoryName; }
            }

            public Product() { }

            public Product(string id, string name, int quantity, double price)
            {
                ProductID = id;
                ProductName = name;
                ProductQuantity = quantity;
                ProductPrice = price;
            }
            public override string ToString()
            {
                
                return $"\t{ProductID,-15}" +
                       $" {ProductName,-30}"+
                       $"{ProductCategoryName,-15}" + 
                       $"{ProductPrice,-15}"+
                       $"{ProductQuantity,-15}" ;
                      
            }


        }

        class Application
        {
            public static void DisplayIntroduction()
            {
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+this project is display the name of product and the information about it+");
                Console.WriteLine("+PinChieh CHIU N11532360                                                 +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            public static int InputValue(int min, int max)
            {
                int result;

                while (true)
                {
                    Console.Write($"Plese enter an intergret which is in the range of  {min} and {max} >>");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out result) && result >= min && result <= max)
                    {
                        break;
                    }

                    Console.WriteLine("Invalid input! Please try again.");
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                return result;
            }

            public static bool CheckString(string id)
            {
                if (id.Length != 4)
                    return false;
                if (!char.IsLower(id[0]))
                    return false;
                if (id[1] != '-')
                    return false;
                if (!char.IsDigit(id[2]) || !char.IsDigit(id[3]))
                    return false;
                if ((id[0] != 'a')&& (id[0] != 'b')&& (id[0] != 'f')&&(id[0] != 't')&& (id[0] != 'o'))
                    return false;

                return true;
            }
            public static void GetProductData(Product[] products)
            {
                for (int i = 0; i < products.Length; i++)
                {
                    Console.Write("Enter Product name>> ");
                    string name = Console.ReadLine();
                    while (string.IsNullOrEmpty(name))
                    {
                        Console.Write("Enter Product name>> ");
                        name = Console.ReadLine();
                    }
                    Console.WriteLine("\t\tProduct category codes are:");
                    Console.WriteLine("\t\ta - Apparel");
                    Console.WriteLine("\t\tb - Books");
                    Console.WriteLine("\t\tf - Foods");
                    Console.WriteLine("\t\tt - Toys");
                    Console.WriteLine("\t\to - Others");
                    
                   
                    string id;
                    do
                    {
                        Console.Write("Enter product id which starts with a category code and ends with a 2-digit number >> ");
                        id = Console.ReadLine();
                    } while (!CheckString(id));

                    Console.Write("Enter Product price>>");
                    string input = Console.ReadLine();
                    double price;

                    // 嘗試解析輸入，如果成功且輸入為浮點數，則繼續執行，否則提示用戶輸入錯誤
                    while (!double.TryParse(input, out price))
                    {
                        Console.WriteLine("please enter double number:");
                        input = Console.ReadLine();
                    }
                    Console.Write("Enter Product quantity>> ");
                    input = Console.ReadLine();
                    int quantity;
                    while (!int.TryParse(input, out quantity))
                    {
                        Console.WriteLine("need to be intergret:");
                        input = Console.ReadLine();
                    }
                    Console.WriteLine();

                    products[i] = new Product(id, name, quantity, price);
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            public static void DisplayAllProducts(Product[] products)
            {
                Console.WriteLine("information of all products:");


                Console.WriteLine(
                    $"{"\tProduct ID",-15}" +
                    $"{"Product Name",-30}" +
                    $"{"Product Category",-15}" +
                    $"{"Product Price",-15}" +
                    $"{"Product Quantity",-15}");

                foreach (var product in products)
                {
                    Console.WriteLine(product.ToString());
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            }

            public static void GetProductLists(Product[] products)
            {
                Console.WriteLine("Enter product category code to see the list of product in the category>>");
                while (true)
                {
                    Console.WriteLine("Enter product category code or type Z to quit>>");
                    string code = Console.ReadLine();

                    if (code == "Z") break;
                    while(code != "a-" && code!="b-" && code != "f-" && code != "t-" && code != "o-")
                    {
                        Console.WriteLine("[0] is not a valid category code",code);
                        Console.WriteLine("Enter product category code or type Z to quit>>");
                        if (code == "Z") break;
                        code = Console.ReadLine();
                    }
                    var productsInCategory = products.Where(p => p.ProductID.StartsWith(code)).ToArray();
                    if (code == "Z") break;
                    if (productsInCategory.Length == 0)
                    {
                        Console.WriteLine("No products in this category.");
                        continue;
                    }
                    string categoryname="";
                    switch (code)
                    {
                        case "a-":
                            categoryname = "Apparel";
                        break;
                        case "b-":
                            categoryname = "Books";
                        break;
                        case "f-":
                            categoryname = "Foods";
                        break;
                        case "t-":
                            categoryname = "Toys";
                        break;
                        case "o-":
                            categoryname = "Others";
                        break;

                    }
                    Console.WriteLine("Number of products in the category[0]: [1]",categoryname ,productsInCategory.Length);
                    foreach (var product in productsInCategory)
                    {
                        Console.WriteLine(product.ToString());
                    }
                   

                }
            }


        }

        static void Main()
        {
            Application.DisplayIntroduction();

            int numProducts = Application.InputValue(1, 30);

            Product[] products = new Product[numProducts];
            Application.GetProductData(products);

            Application.DisplayAllProducts(products);
            Application.GetProductLists(products);
        }
      





     }

}