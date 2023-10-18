﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop1;

public class Receipt
{

    //transaction
    //listofPurchasedProducts

    //totalCost
    public static void TotalCost() //calculate and show total cost
    {


        Dictionary<string, int> cartList = new Dictionary<string, int>();
        string[] shoppingCartList = File.ReadAllLines("../../../ShoppingCart.txt");
        int cartSum = 0;
        int x = 1;

        foreach (var line in shoppingCartList)
        {
            string[] splitLine = line.Split(",");
            int.TryParse(splitLine[1], out int price);
            cartSum += price;
        }
        Console.WriteLine("This is in your receipt: ");
        foreach (string line in shoppingCartList)
        {
            string[] splitLine = line.Split(",");
            Console.WriteLine(x + ". " + splitLine[0]);
            x++;
        }
        Console.WriteLine();
        Console.WriteLine("Total sum: " + cartSum + ":-");
    }

    //timeDateStamp


    public static void ReadReceipt()
    {
        Console.Clear();
        Console.WriteLine("Here are your receipts\n");
        Dictionary<string, int> cartList = new Dictionary<string, int>();
        string[] receiptList = File.ReadAllLines("../../../Receipt.txt");
        string[] loginList = File.ReadAllLines("../../../customer.txt");
        string usernamepass = string.Empty;
        foreach (string usepass in loginList)
        {
            usernamepass = usepass;
        }
        foreach (var line in receiptList)
        {
            if (line.Contains(usernamepass))
            {


                string[] splitLineOne = line.Split("+");
                string[] splitOne = splitLineOne[0].Split(",");
                Console.WriteLine();
                Console.WriteLine("Customer: " + splitOne[0]);

                string split2 = splitLineOne[1];
                string[] artPriceFromRest = split2.Split("/");
                string[] splitTwo = artPriceFromRest[0].Split("_");
                Console.WriteLine();

                for (int i = 0; i < splitTwo.Length -1; i++)
                {
                   string[] artAndPrice = splitTwo[i].Split(",");
                   Console.WriteLine("Prod: " + artAndPrice[0] + "\t" + artAndPrice[1] + ":-");
                }

                string split3 = artPriceFromRest[1];
                string[] splitThree = split3.Split("*");
                Console.WriteLine();
                Console.WriteLine("Total price: " + splitThree[0] + "\n\nDate: " + splitThree[1]);

                Console.WriteLine("\n");
                Console.WriteLine("****************************");
            }
            else if (!line.Contains(usernamepass))
            {
                continue;
            }
        }
        Console.WriteLine("Press enter to return");
        Console.ReadKey();
    }



}
