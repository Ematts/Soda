using System;
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

        public List<Quarter> stockQuarters()
        {

            for (int quarterAmount = 0; quarterAmount < 20; quarterAmount++)
            {

                Quarter quarter = new Quarter();
                quarters.Add(quarter);

            }

            return quarters;
        }

        public List<Dime> stockDimes()
        {

            for (int dimeAmount = 0; dimeAmount < 10; dimeAmount++)
            {

                Dime dime = new Dime();
                dimes.Add(dime);

            }

            return dimes;
        }

        public List<Nickel> stockNickels()
        {

            for (int nickelAmount = 0; nickelAmount < 20; nickelAmount++)
            {

                Nickel nickel = new Nickel();
                nickels.Add(nickel);

            }

            return nickels;
        }
        public List<Penny> stockPennies()
        { 

            for (int pennyAmount = 0; pennyAmount < 50; pennyAmount++)
            {

                Penny penny = new Penny();
                pennies.Add(penny);

            }

            return pennies;
        }

        public List<Orange> stockOranges()
        {

            for (int orangeAmount = 0; orangeAmount < 20; orangeAmount++)
            {

                Orange orange = new Orange();
                oranges.Add(orange);

            }

            return oranges;
        }

        public List<Grape> stockGrapes()
        {

            for (int grapeAmount = 0; grapeAmount < 20; grapeAmount++)
            {

                Grape grape = new Grape();
                grapes.Add(grape);

            }

            return grapes;
        }

        public List<Meat> stockMeats()
        {

            for (int meatAmount = 0; meatAmount < 20; meatAmount++)
            {

                Meat meat = new Meat();
                meats.Add(meat);

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
            }
        }
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