using System;

namespace ProceduralProject1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //The program begins executing here
            //Order of execution is based on the order in which the lines of code appear

            Console.WriteLine("Good morning. I can do mathematical calculations for you. ");
            //Using a do-while loop means we can specify that something must happen UNTIL a condition is met
            //In this case, we will show the menu and get the user's response
            //As long as the condition choice=="Q" is NOT true, the program will continue
            //Use do-while when collecting input that may need to be repeated, but will definitely
            //happen at least once
            string menuChoice;
            do
            {
                ShowMenu();
                menuChoice = GetMenuChoice();
                if (menuChoice == "1")
                {
                    CalculateCircleArea();
                }
                else if (menuChoice == "2")
                {
                    CalculateCylinderArea();
                }
                
            } while (menuChoice != "Q");
        }

        //This is a procedure - there is no returned data from it (void)
        //It is a named block of code - ShowMenu - that will serve a single purpose
        public static void ShowMenu()
        {
            Console.WriteLine("Choose a calculation to make");
            Console.WriteLine("1) Calculate the area of a circle");
            Console.WriteLine("2) Calculate the volume of a cylinder");
            Console.WriteLine("Q) Quit the application");
            return;
        }

        //This is a FUNCTION because it returns a piece of information -
        //in this case a STRING
        public static string GetMenuChoice()
        {
            string option;
            do
            {
                option = Console.ReadLine();
            }
            while (!"12Q".Contains(option) && option != "");
            return option;
        }

        public static void CalculateCircleArea()
        {
            Console.WriteLine("What is the radius? ");
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2); //PI * r to the power of two (r squared)
            //Show the area to TWO decimal places
            Console.WriteLine("The area is " + Math.Round(area, 2));
        }

        public static void CalculateCylinderArea()
        {
            //Volume of a cylinder is:
            //Area * height
            //Area is the area of a circle with radius 'r'
            //You will need to ask for two inputs this time
            //Display the answer to two DP
        }
    }
}
