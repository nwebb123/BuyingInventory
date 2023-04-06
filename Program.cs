// See https://aka.ms/new-console-template for more information

//Application execution starts here


//display title
using BuyingInventory;

System.Console.WriteLine("********** NPC Vendor Shop *************\n");
System.Console.WriteLine("Welcome To Toruga's Shop");

/*//declare variables to store username and password;
string userName = null, password = null;

//read userName from keyboard
System.Console.Write("Username: ");
userName = System.Console.ReadLine();

//read password from keyboard only if username is entered
if (userName != "")
{
System.Console.Write("Password: ");
password = System.Console.ReadLine();
}

//check username and password
if (userName == "system" && password == "manager")
{
*/
//declare variable to store menu choice

int mainMenuChoice = -1;

//Region containing instances of shop items. TODO: Add items to array/list.
#region 
ShopItem Rope = new ShopItem();
Rope.Name = "Rope";
Rope.Price = 10;

ShopItem Torches = new ShopItem();
Rope.Name = "Torches";
Rope.Price = 15;

ShopItem ClimbingGear = new ShopItem();
Rope.Name = "Climbing Gear";
Rope.Price = 25;

ShopItem Machete = new ShopItem();
Rope.Name = "Machete";
Rope.Price = 20;

ShopItem CleanWater = new ShopItem();
Rope.Name = "Clean Water";
Rope.Price = 1;

ShopItem FoodSupplies = new ShopItem();
Rope.Name = "Food Supplies";
Rope.Price = 1;

ShopItem Canoe = new ShopItem();
Rope.Name = "Canoe";
Rope.Price = 200;

//List<ShopItem> ShopInventory = { Rope, Torches, ClimbingGear, CleanWater, Machete, Canoe, FoodSupplies }

//Console.WriteLine(Rope.Name);
//Console.WriteLine();

#endregion
//Replace this later with list of shop item objects (created from ShopItem class)
string[] shopInventory = { "Rope", "Torches", "Climbing Gear", "Clean Water", "Machete", "Canoe", "Food Supplies" };

while (mainMenuChoice != 0)
{
    if (mainMenuChoice == -1)
    {
        System.Console.WriteLine("\nThe following items are available:\n");
        //Need to iterate through each ShopItem, but each ShopItem is an instance of the class. Do i Need a List or Ienumerable?
        for (int i = 0; i < shopInventory.Length; i++)
        {
            System.Console.WriteLine($"{i + 1} - {shopInventory[i]}");
        }
        System.Console.WriteLine("0 - Exit");

        //accept menu choice from keyboard
        System.Console.Write("\nEnter an item's number to see the price: ");
        mainMenuChoice = int.Parse(System.Console.ReadLine());

        //switch-case to check menu choice

        //show main menu

    };
    switch (mainMenuChoice)
    {
        case 1:
            Console.WriteLine("Rope costs 10g");
            //mainMenuChoice = -1;
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("Torches cost 15g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 3:
            Console.WriteLine("Climbing Gear costs 25g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 4:
            Console.WriteLine("Clean Water costs 1g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 5:
            Console.WriteLine("Machete costs 20g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 6:
            Console.WriteLine("Canoe costs 200g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
        case 7:
            Console.WriteLine("Food Supplies costs 1g");
            Console.Write("\nEnter an item's number to see the price: ");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;

        default:
            Console.WriteLine("Please enter a number listed from the main menu.");
            mainMenuChoice = int.Parse(System.Console.ReadLine());
            break;
    }

}
//}
//else
//{
//    System.Console.WriteLine("Invalid username or password");
//}

//about to exit
System.Console.WriteLine("\nThank you! Visit again.");
System.Console.ReadKey();


//static void CustomersMenu()
//{
//    //variable to store customers menu choice
//    int customerMenuChoice = -1;

//    //do-while loop starts
//    do
//    {
//        //print customers menu
//        System.Console.WriteLine("\nCustomers menu:");
//        System.Console.WriteLine("1. Add Customer");
//        System.Console.WriteLine("2. Delete Customer");
//        System.Console.WriteLine("3. Update Customer");
//        System.Console.WriteLine("4. View Customers");
//        System.Console.WriteLine("0. Back to Main Menu");

//        //accept customers menu choice
//        System.Console.Write("Enter choice: ");
//        customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
//    } while (customerMenuChoice != 0);
//}

//static void AccountsMenu()
//{
//    //variable to store accounts menu choice
//    int accountsMenuChoice = -1;

//    //do-while loop starts
//    do
//    {
//        //print  accounts menu
//        System.Console.WriteLine("\n:::Accounts menu:::");
//        System.Console.WriteLine("1. Add Account");
//        System.Console.WriteLine("2. Delete Account");
//        System.Console.WriteLine("3. Update Account");
//        System.Console.WriteLine("4. View Accounts");
//        System.Console.WriteLine("0. Back to Main Menu");

//        //accept accounts menu choice
//        System.Console.Write("Enter choice: ");
//        accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
//    } while (accountsMenuChoice != 0);
//}


