﻿
// <product list CSV or txt>
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using WebShop1;

// <customer list csv or txt>
List<string> customer = new List<string>();
Dictionary<string, int> cartList = new Dictionary<string, int>();
string[] productList = File.ReadAllLines("../../../product.txt");
string[] shoppingCartList = File.ReadAllLines("../../../ShoppingCart.txt");










ShoppingCart.AddCart();







//FUNCTION for the menu choices - Menu Class? 
while (true)

{

    Console.WriteLine("Hello and welcome to the BEST shop in the world\n");
    Console.WriteLine("Please choose from below:\n");
    Console.WriteLine("1. Products");
    Console.WriteLine("2. Login/Register");
    Console.WriteLine("3. Exit");
    switch (Console.ReadLine())
    {
        case "1":  //Products
            //productList 
            //addToCartFunction
            //removeFromCartFunction

            Console.Clear();
            Console.WriteLine("Here is the list of available items for sale:\n");
            Product.NrAndReadProductList(); //print productList
            Console.WriteLine("\nWhat would you like to add to your cart?\n");
            switch (Console.ReadLine())
            {
                case "1": // pick first product  
                    
                    Product.cart();
                    break;
            }

            Console.ReadKey();

            Console.Clear();
            break;

        case "2": //Menu2
            Console.Clear();
            Console.WriteLine("Welcome to our login page.\n");
            Console.WriteLine("Do you want to: ");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Return to main page");
            switch (Console.ReadLine())
            {
                case "1":
                    //go to login class  
                    Console.Clear();
                    Console.WriteLine("case 1");

                    Console.ReadKey();
                    Console.Clear();


                    break;
                case "2":
                    //go to register class
                    Console.Clear();
                    Console.WriteLine("Register");
                    Register.Insert();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "3":
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("You didn't pick a valid option.");
                    Console.WriteLine("Please choose 1, 2 or 3.");
                    Console.WriteLine("Please press enter to continue!");

                    //void function return to menu2
                    Console.ReadKey();
                    Console.Clear();
                    continue;
            }
            Console.Clear();
            break;

        case "3":
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Thank you for shopping in the BEST shop.");
            Console.WriteLine("Please come again!");
            break;

            //Det krashar efter denna har visats en gång kvittar om man skriver rätt eller fel igen 
        default:
            Console.Clear();
            Console.WriteLine("You didn't pick a valid option.");
            Console.WriteLine("Please choose 1, 2 or 3.");
            Console.WriteLine("Please press enter to continue!");
            Console.ReadKey();
            Console.Clear();
            break;

    }
    
    //if option 1
    //foreach
    //Pickoption
    //add to cart -> you need to be on login customerprofile // run option 2
    //go back

    //extra searchfunction!



    //IF option 2
    //switch
    //<login option>
    // login || register
    //Login start customer or admin
    //If register start registerOption







}