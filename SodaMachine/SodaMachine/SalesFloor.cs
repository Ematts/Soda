using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SalesFloor
    {
        //public Machine machine = new Machine();

        //public void getMenu()
        //{
        //    Console.WriteLine("Press 1 to buy soda");
        //    int menuChoice = 0;

        //    try
        //    {

        //        menuChoice = int.Parse(Console.ReadLine());

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("That is not a valid option in this menu.");
        //        getMenu();

        //    }

        //         if (menuChoice == 1)
        //        {
        //        collectMoney();
        //        }
        //}

        //public decimal collectMoney()
        //{
            
        //    Console.WriteLine("Press 1 to insert quarters, 2 to insert dimes, 3 to insert nickels, and 4 to insert pennies.");
        //    Console.WriteLine("Press 1 to buy soda");
        //    int menuChoice = 0;

        //    try
        //    {

        //        menuChoice = int.Parse(Console.ReadLine());

        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("That is not a valid option in this menu.");
        //        getMenu();

        //    }
        //   if(menuChoice ==1)
        //        {

        //        int saleQuarters = machine.addQuarters();
        //        decimal totalQuartersValue = (saleQuarters * quarter.worth);
        //        Console.WriteLine("Total inserted: " + totalQuartersValue);
        //        return totalQuartersValue;
        //        }

        //        else

        //        {
        //        return 0;
        //        }
        //}
    }

    
 }





//Using proper code design, write a SodaMachine class that accepts coins as payment, returns coins from its limited register as change, and dispenses soda cans from its limited inventory.
//Make a class for each coin(penny, nickel, dime, quarter) that sets its value in its constructor.Allow payment via passing a List of coins into a public function on the SodaMachine class.
//If not enough money is passed in, don't complete transaction: give the money back
//If exact change is passed in, accept payment and dispense a soda from the limited inventory.
//If too much money is passed in, accept the payment, return change as a list of coins from internal, limited register, and return a soda instance from internal, limited inventory.
//If too much money is passed in but there isn't sufficient change in the machine's internal register, don't complete transaction: give the money back
//If exact or too much money is passed in but there isn't sufficient inventory for that soda, don't complete the transaction: give the money back

//The machine should start with:
//Coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
//Cans: Grape-flavored(60¢ per), Orange-flavored(35¢ per), Meat-flavored(6¢ per)