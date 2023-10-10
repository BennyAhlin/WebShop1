namespace WebShop1;

public class ShoppingCart
{
    public static void ReadCart()

    {
        Dictionary<string, int> cartList = new Dictionary<string, int>();
        string[] shoppingCartList = File.ReadAllLines("../../../ShoppingCart.txt");

        foreach (var line in shoppingCartList)
        {
            string[] splitLine = line.Split(",");
            if (int.TryParse(splitLine[1], out int price))
            {

                cartList.Add(splitLine[0], price);
            }
            Console.WriteLine(splitLine[0] + " " + splitLine[1] + ":-");
        }
    }


    public static void AddCart()

    {
        Dictionary<string, int> cartList = new Dictionary<string, int>();
        string[] productList = File.ReadAllLines("../../../product.txt");
        string[] shoppingCartList = File.ReadAllLines("../../../ShoppingCart.txt");
        string? input = Console.ReadLine();

        Console.WriteLine("This is the product list:");
        Product.productList(); //read productList
        Console.WriteLine();
        Console.WriteLine("Add item: ");
        Console.WriteLine();


        //add shoppingCartList
        for (int i = 1; i <= productList.Length; i++)
        {

            if (input == productList[i])
            {

                File.AppendAllText("../../../ShoppingCart.txt", input + Environment.NewLine);

            }

        }

  

          
        




    }


    public static void RemoveCart()

    {
        ReadCart();



    }

}
