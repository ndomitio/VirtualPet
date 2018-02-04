using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Class1
    {
        public class Dragon
        {

            //fields 
            private bool isHungry;
            private bool canFly;
            //private string mood;
            private string color;
            private bool canBreatheFire;
            private int tickerCount;
            //properties 


            public int TickerCount
            {
                get { return this.tickerCount; }
                set { this.tickerCount = value; }
            }
            public bool IsHungry
            {
                get { return this.isHungry; }
                set { this.isHungry = value; }
            }

            public bool CanFly
            {
                get { return this.canFly; }
                set { this.canFly = value; }
            }

            //public string Mood
            //{
            //    get { return this.mood; }
            //    set { this.mood = value; }
            //}

            public string Color
            {
                get { return this.color; }
                set { this.color = value; }
            }

            public bool CanBreatheFire
            {
                get { return this.canBreatheFire; }
                set { this.canBreatheFire = value; }
            }

            //constructors 

            public Dragon()
            {

            }

            public Dragon(string color, bool isHungry, bool canFly)
            {
                this.color = color;
                this.IsHungry = isHungry;
                this.canFly = canFly;
            }

            public Dragon(bool canBreatheFire, bool canFly, bool isHungry, string mood, string color)
            {
                this.canBreatheFire = canBreatheFire;
                this.canFly = canFly;
                this.isHungry = isHungry;
            }

            //methods

            public void Conquer()
            {
                if ((canFly == true) && (CanBreatheFire == true) && (tickerCount < 4))
                {
                    Console.Clear();
                    Console.WriteLine("Good luck on your conquest!");

                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, you will not be able to conquer any new lands today");
                }

            }

            public string Feed()
            {
                if ((isHungry == true) && (canFly == true))
                {
                    isHungry = false;
                    return "You don't have to feed your dragon, he will fly and grab his own food.";
                }

                else if (tickerCount > 5)
                {
                    isHungry = false;
                    return "Your dragon has had a long day, better feed your pet before they eat you!";

                }

                else if (isHungry == true)
                {
                    isHungry = false;
                    return "Time to go feed, be careful not to be eaten yourself.";

                }

                else
                {
                    isHungry = false;
                    return "I guess your dragon isn't that hungry ¯\\_(ツ)_/¯ ";
                }


            }

            public void tick()
            {
                tickerCount++;
            }

            public static void clear()
            {

            }

            public bool Transport()
            {

                if ((canFly == true) && (isHungry == false) && (tickerCount < 5))
                {
                    Console.WriteLine("Looks like your dragon is ready to fly, hold on tight!");
                    return isHungry = true;


                }
                else if (isHungry == true)
                {
                    Console.WriteLine("You should probably feed your dragon first, I would not want to fly on a hungry dragon.");
                    return canFly = true;
                }
                else
                {
                    Console.WriteLine("Let's do something else!");
                    return isHungry = true;
                }

            }
        }
    }
}
