using System;

namespace testmidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            //ข้อ5
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string menu = Console.ReadLine();
            while (menu != "End") 
            {
                int BreakfastSet = 5;
                int WeekendSet = 2;
                int Coffee = 3;
                string Set2 = Console.ReadLine();
                menu = Set2;

                if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)  
                {
                    if (menu == "Breakfast Set") 
                    {
                        if (BreakfastSet == 0) 
                        {
                            Console.Write("Sorry your order is out of stock");
                        }
                        if (time > 11)
                        {
                            Console.Write("Sorry your order is not available");
                        }
                        else 
                        {
                            Console.Write(BreakfastSet--);
                        }
                    }
                    if (menu == "Weekend Set") 
                    {
                        Console.Write("Sorry your order is not available ");
                    }
                    if (menu == "Coffee")
                    {
                        if (Coffee == 0)
                        {
                            Console.Write("Sorry your order is out of stock");
                        }
                        else
                        {
                            Console.Write(Coffee--);
                        }
                    }
                    else 
                    {
                        Console.Write("Please enter a valid menu");
                    }
                }
                if (day == 6 || day == 7)
                {
                    if (menu == "Breakfast Set")
                    {
                        if (BreakfastSet == 0)
                        {
                            Console.Write("Sorry your order is out of stock");
                        }
                        if (time > 11)
                        {
                            Console.Write("Sorry your order is not available ");
                        }
                        else
                        {
                            Console.Write(BreakfastSet--);
                        }
                    }
                    if (menu == "Coffee")
                    {
                        if (Coffee == 0)
                        {
                            Console.Write("Sorry your order is out of stock");
                        }
                        else
                        {
                            Console.Write(Coffee--);
                        }
                    }
                    if (menu == "Weekend Set")
                    {
                        if (WeekendSet == 0)
                        {
                            Console.Write("Sorry your order is out of stock");
                        }
                        else
                        {
                            Console.Write(WeekendSet--);
                        }
                    }
                    else
                    {
                        Console.Write("Please enter a valid menu");
                    }
                }
                else { }

            }
            Console.ReadLine();
        }
    }
}
