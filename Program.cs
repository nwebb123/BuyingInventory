using BuyingInventory;

Console.WriteLine("********** NPC Vendor Shop *************\n");
Console.WriteLine("Welcome To Emily's Shop");

int mainMenuChoice = -1;

//Concise way to list inventory of items with prices. Good practice for OOP as well.
List<ShopItem> ShopInventory = new List<ShopItem>
{
    new ShopItem("Rope", 10),
    new ShopItem("Torches", 15),
    new ShopItem("Climbing Gear", 25),
    new ShopItem("Clean Water", 1),
    new ShopItem("Machete", 20),
    new ShopItem("Canoe", 200),
    new ShopItem("Food Supplies", 10),
};

while (mainMenuChoice != 0)
{
    if (mainMenuChoice == -1)
    {
        Console.WriteLine("\nThe following items are available:\n");

        //For loop useful for keeping count of iteration as well as looping through each item in ShopInventory list
        for (int i = 0; i < ShopInventory.Count; i++)
        {
            Console.WriteLine($"{i + 1} - {ShopInventory[i].name}");
        }
        Console.WriteLine("0 - Exit");

        //accept menu choice from keyboard
        Console.Write("\nEnter an item's number to see the price: ");
        mainMenuChoice = ConvertStringToInt(Console.ReadLine());

    }

    //Check these numbers after initial menu
    switch (mainMenuChoice)
    {
        case 1:
            Console.WriteLine("\nRope costs 10g");
            //mainMenuChoice = -1;
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("\nTorches cost 15g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("\nClimbing Gear costs 25g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 4:
            Console.WriteLine("\nClean Water costs 1g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 5:
            Console.WriteLine("\nMachete costs 20g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 6:
            Console.WriteLine("\nCanoe costs 200g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
        case 7:
            Console.WriteLine("\nFood Supplies costs 1g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;

        default:
            if (mainMenuChoice is string)
            {
                Console.Write("\nPlease enter a number listed from the main menu: ");
            }
            Console.Write("\nPlease enter a number listed from the main menu: ");
            mainMenuChoice = ConvertStringToInt(Console.ReadLine());
            break;
    }

}

Console.WriteLine("\nThank you! Visit again.");
Console.ReadKey();

static int ConvertStringToInt(string input)
{
    int result;

    /*  
        TryParse is .NET C# method that allows you to try and parse a string into a specified type.
        It returns a boolean value indicating whether the conversion was successful or not.
        If conversion succeeded, the method will return true and the converted value will be assigned to the output parameter.
    */

    if (!int.TryParse(input, out result))
    {
        return -999;
    }
    else
    {
        return result;
    }
}



