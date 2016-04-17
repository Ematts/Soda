﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
   class Machine
    {
        
        List<Quarter> quarters = new List<Quarter>();
        List<Dime> dimes = new List<Dime>();
        List<Nickel> nickels = new List<Nickel>();
        List<Penny> pennies = new List<Penny>();
        List<Orange> oranges = new List<Orange>();
        List<Grape> grapes = new List<Grape>();
        List<Meat> meats = new List<Meat>();
        List<Coin> coins = new List<Coin>();
        List<Soda> sodas = new List<Soda>();
        List<Coin> depositedCoins = new List<Coin>();
        List<Quarter> depositedQuarters = new List<Quarter>();
        List<Dime> depositedDimes = new List<Dime>();
        List<Nickel> depositedNickels = new List<Nickel>();
        List<Penny> depositedPennies = new List<Penny>();
        decimal deposit = 0m;
        



        public Machine()
        {
            quarters = stockQuarters();
            dimes = stockDimes();
            nickels = stockNickels();
            pennies = stockPennies();
            oranges = stockOranges();
            grapes = stockGrapes();
            meats = stockMeats();
        }




        public decimal getMachineTotalChange()
        {
            decimal totalChange = (quarters.Count * .25m) + (dimes.Count * .10m) + (nickels.Count * .05m) + (pennies.Count * .01m);
            Console.WriteLine("Quarters in machine = " + quarters.Count);
            Console.WriteLine("Dimes in machine = " + dimes.Count);
            Console.WriteLine("Nickels in machine = " + nickels.Count);
            Console.WriteLine("Pennies in machine = " + pennies.Count);
            Console.WriteLine("Total money = $" + totalChange);

            return totalChange;
        }

        public void runMenu()
        {
            Console.WriteLine("Press 1 to insert money, press 2 to make a selection.");
            string choice = Console.ReadLine();
            if(choice == "1")
            {
                buyMenu();
            }

            else if (choice == "2")

            {

                sodaMenu();

            }


            else
     
            {
                Console.WriteLine("That is not a valid option in this menu.");
                runMenu();
            }
            
        }

        public decimal buyMenu()
        {

            Console.WriteLine("Press 1 to insert quarters, 2 to insert dimes, 3 to insert nickels, 4 to insert pennies, 5 to return to main menu, or 6 to exit.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                int depositedQuarters = addQuarters();
                decimal quarterWorth = 0.25m;
                decimal depositedQuartersValue = (depositedQuarters * quarterWorth);
                deposit += depositedQuartersValue;
                Console.WriteLine("Total inserted: " + deposit);
                Console.WriteLine("Press 1 to add more money, press any other key to return to main menu.");
                string addMoreMoneyChoice = Console.ReadLine();
                if (addMoreMoneyChoice == "1")

                {
                    buyMenu();
                }

                else

                {
                    runMenu();
                }

                return depositedQuartersValue;

            }

            else if (choice == "2")

            {

                int depositedDimes = addDimes();
                decimal dimeWorth = 0.10m;
                decimal depositedDimesValue = (depositedDimes * dimeWorth);
                deposit += depositedDimesValue;
                Console.WriteLine("Total inserted: " + deposit);
                Console.WriteLine("Press 1 to add more money, press any other key to return to main menu.");
                string addMoreMoneyChoice = Console.ReadLine();
                if (addMoreMoneyChoice == "1")

                {
                    buyMenu();
                }

                else

                {
                    runMenu();
                }

                
                return depositedDimesValue;

            }



            else if (choice == "3")

            {
                int depositedNickels = addNickels();
                decimal nickelWorth = 0.05m;
                decimal depositedNickelsValue = (depositedNickels * nickelWorth);
                deposit += depositedNickelsValue;
                Console.WriteLine("Total inserted: " + deposit);
                Console.WriteLine("Press 1 to add more money, press any other key to return to main menu.");
                string addMoreMoneyChoice = Console.ReadLine();
                if (addMoreMoneyChoice == "1")

                {
                    buyMenu();
                }

                else

                {
                    runMenu();
                }

                return depositedNickelsValue;
            }

            else if (choice == "4")
            {

                int depositedPennies = addPennies();
                decimal pennyWorth = 0.01m;
                decimal depositedPenniesValue = (depositedPennies * pennyWorth);
                deposit += depositedPenniesValue;
                Console.WriteLine("Total inserted: " + deposit);
                Console.WriteLine("Press 1 to add more money, press any other key to return to main menu.");
                string addMoreMoneyChoice = Console.ReadLine();
                if (addMoreMoneyChoice == "1")

                {
                    buyMenu();
                }

                else

                {
                    runMenu();
                }

                return depositedPenniesValue;

            }

            else if (choice == "5")

            {
                
                 runMenu();
                 return 0;
            }

            else if (choice == "6")
            {
                deposit = 0m;
                depositedCoins.Clear();
                depositedQuarters.Clear();
                depositedDimes.Clear();
                depositedNickels.Clear();
                depositedPennies.Clear();
                Environment.Exit(0);
                return 0;
            }

            else

            {

                Console.WriteLine("That is not a valid option in this menu");
                buyMenu();
                return 0;
            }

            
        }
     
        public List<Quarter>stockQuarters()
        {

            for (int quarterAmount = 0; quarterAmount < 20; quarterAmount++)
            {

                Quarter quarter = new Quarter();
                quarters.Add(quarter);
                coins.Add(quarter);

               

            }

            return quarters;
        }

        public List<Dime> stockDimes()
        {

            for (int dimeAmount = 0; dimeAmount < 10; dimeAmount++)
            {

                Dime dime = new Dime();
                dimes.Add(dime);
                coins.Add(dime);
                

            }

            return dimes;
        }

        public List<Nickel> stockNickels()
        {

            for (int nickelAmount = 0; nickelAmount < 20; nickelAmount++)
            {

                Nickel nickel = new Nickel();
                nickels.Add(nickel);
                coins.Add(nickel);

            }

            return nickels;
        }
        public List<Penny> stockPennies()
        { 

            for (int pennyAmount = 0; pennyAmount < 50; pennyAmount++)
            {

                Penny penny = new Penny();
                pennies.Add(penny);
                coins.Add(penny);
            }

            return pennies;
        }

        public List<Orange> stockOranges()
        {

            for (int orangeAmount = 0; orangeAmount < 20; orangeAmount++)
            {

                Orange orange = new Orange();
                oranges.Add(orange);
                sodas.Add(orange);


            }

            return oranges;
        }

        public List<Grape> stockGrapes()
        {

            for (int grapeAmount = 0; grapeAmount < 20; grapeAmount++)
            {


                Grape grape = new Grape();
                grapes.Add(grape);
                sodas.Add(grape);

            }

            return grapes;
        }

        public List<Meat> stockMeats()
        {

            for (int meatAmount = 0; meatAmount < 20; meatAmount++)
            {

                Meat meat = new Meat();
                meats.Add(meat);
                sodas.Add(meat);

            }

            return meats;
        }
        public void addOrange()
        {
            Console.WriteLine("How many orange sodas are you putting in the machine?");
            int addition = int.Parse(Console.ReadLine());

            for (int newOranges = 0; newOranges < addition; newOranges++)

            {
                Orange orange = new Orange();
                oranges.Add(orange);
                sodas.Add(orange);
            }
        }
        public void addGrape()
        {
            Console.WriteLine("How many grape sodas are you putting in the machine?");
            int addition = int.Parse(Console.ReadLine());

            for (int newGrapes = 0; newGrapes < addition; newGrapes++)

            {
                Grape grape = new Grape();
                grapes.Add(grape);
                sodas.Add(grape);
            }
        }

        public void addMeat()
        {
            Console.WriteLine("How many meat sodas are you putting in the machine?");
            int addition = int.Parse(Console.ReadLine());

            for (int newMeats = 0; newMeats < addition; newMeats++)

            {
                Meat meat = new Meat();
                meats.Add(meat);
                sodas.Add(meat);
            }
        }

        public int addQuarters()
        {
            Console.WriteLine("How many quarters are you putting in the machine?");
            int addition = 0;

            try

            {

                addition = int.Parse(Console.ReadLine());

            }
                  catch (FormatException)
              {
                    Console.WriteLine("That is not a valid option in this menu.");
                    buyMenu();

              }
           

            for (int newQuarters = 0; newQuarters < addition; newQuarters++)

            {
                Quarter quarter = new Quarter();
                depositedCoins.Add(quarter);
                depositedQuarters.Add(quarter);
            }

            return addition;
        }
        public int addDimes()
        {
            Console.WriteLine("How many dimes are you putting in the machine?");
            int addition = 0;

            try

            {

                addition = int.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option in this menu.");
                buyMenu();

            }

            for (int newdimes = 0; newdimes < addition; newdimes++)

            {
                Dime dime = new Dime();
                depositedCoins.Add(dime);
                depositedDimes.Add(dime);
            }

            return addition;
        }
        public int addNickels()
        {
            Console.WriteLine("How many nickels are you putting in the machine?");
            int addition = 0;

            try

            {

                addition = int.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option in this menu.");
                buyMenu();

            }

            for (int newNickels = 0; newNickels < addition; newNickels++)

            {
                Nickel nickel = new Nickel();
                depositedCoins.Add(nickel);
                depositedNickels.Add(nickel);
            }

            return addition;
        }

        public int addPennies()
        {
            Console.WriteLine("How many pennies are you putting in the machine?");
            int addition = 0;

            try

            {

                addition = int.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("That is not a valid option in this menu.");
                buyMenu();

            }

            for (int newPennies = 0; newPennies < addition; newPennies++)

            {
                Penny penny = new Penny();
                depositedCoins.Add(penny);
                depositedPennies.Add(penny);
            }

            return addition;
        }

        public void sellGrape()
        {

            if ((grapes.Count > 0) && (deposit == .60m))
               
            {
                foreach (Coin coin in depositedCoins)
                {
                    coins.Add(coin);
                }

                foreach (Quarter quarter in depositedQuarters)
                {
                    quarters.Add(quarter);
                }

                foreach (Dime dime in depositedDimes)
                {
                    dimes.Add(dime);
                }

                foreach (Nickel nickel in depositedNickels)
                {
                    nickels.Add(nickel);
                }

                foreach (Penny penny in depositedPennies)
                {
                    pennies.Add(penny);
                }

                deposit = 0m;
                depositedCoins.Clear();
                depositedQuarters.Clear();
                depositedDimes.Clear();
                depositedNickels.Clear();
                depositedPennies.Clear();
                foreach (Grape grape in grapes)
                {
                    grapes.Remove(grape);
                    break;
                }
                foreach (Soda grape in sodas)
                {
                    sodas.Remove(grape);
                    break;
                }

                Console.WriteLine("Grape soda dispensed.  Change returned = 0");

                getMachineTotalChange();

                Console.WriteLine("Remaining grape sodas = " + grapes.Count);
                runMenu();

            }

            else if (deposit < .60m)
            {
                Console.WriteLine("You have not inserted enough money.  The money you inserted has been returned");
                deposit = 0m;
                depositedCoins.Clear();
                depositedQuarters.Clear();
                depositedDimes.Clear();
                depositedNickels.Clear();
                depositedPennies.Clear();
                buyMenu();

            }

            else if (grapes.Count < 1)

            {
                Console.WriteLine("Grape soda is sold out.  The money you inserted has been returned");
                deposit = 0m;
                depositedCoins.Clear();
                depositedQuarters.Clear();
                depositedDimes.Clear();
                depositedNickels.Clear();
                depositedPennies.Clear();
                buyMenu();
            }

            else
            {
                Console.WriteLine("Cannot complete transaction");

            }
        }

        public void sodaMenu()

        {

            Console.WriteLine("Press 1 for grape (.60), press 2 for orange (.35), press 3 for meat (.06)");
            string choice = Console.ReadLine();

            if (choice == "1")

            {
                sellGrape();
            }
        }




        //public void getMenu()
        //{
            
        //}

        //public decimal collectMoney(List<Coin> coin)
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
        //    if (menuChoice == 1)
        //    {

        //        int depositedQuarters = addQuarters();
        //        decimal quarterWorth = 0.25m;
        //        decimal depositedQuartersValue = (depositedQuarters * quarterWorth);
        //        Console.WriteLine("Total inserted: " + depositedQuartersValue);
        //        return depositedQuartersValue;
        //    }

        //    else

        //    {
        //        return 0;
        //    }
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