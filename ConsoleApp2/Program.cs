using System;

namespace CapstoneProject
{
    // **************************************************
    //
    // Title: Capstone Project - Menu Starter
    // Description: Calculate the square footage of 
    //              house and then calculate the cost
    //              to refloor
    // Application Type: Console
    // Author: John Mawby
    // Dated Created: 4/8/2021
    // Last Modified: 4/10/2020
    //
    // **************************************************
    class Program
    {
        
        static void Main(string[] args)
        {
           
            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();

        }

       
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            double totalArea = 0;
            bool quitApplication = false;
            string menuChoice;


            do
            {
                DisplayScreenHeader("Main Menu");

                Console.WriteLine();
                Console.WriteLine("\ta) First Calculate the Area of Building");
                Console.WriteLine("\tb) Calculate the Cost to Refloor Building");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

            
                switch (menuChoice)
                {
                    case "a":
                      totalArea =  AreaOfBuilding();
                        break;

                    case "b":
                        CostToRemodelFloor(totalArea);
                        break;

                    case "q":
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }


            } while (!quitApplication);




        }

        #region SQUARE FOOT CALCULATIONS

        static double AreaOfBuilding()
        {
            double totalArea;

            double WidthRoom1, WidthRoom2, WidthRoom3, WidthRoom4, WidthRoom5, WidthRoom6;
            double LengthRoom1, LengthRoom2, LengthRoom3, LengthRoom4, LengthRoom5, LengthRoom6;
            double AreaRoom1, AreaRoom2, AreaRoom3, AreaRoom4, AreaRoom5, AreaRoom6;
            bool validResponse;

            string userResponse;


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tSquare Foot Calculator");
            DisplayContinuePrompt();

           

            Console.WriteLine();
            Console.WriteLine("\tEnter the dimensions of each room.");
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 1:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom1);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 1:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom1);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 2:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom2);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 2:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom2);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 3:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom3);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 3:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom3);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 4:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom4);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 4:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom4);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 5:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom5);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 5:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom5);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
            Console.WriteLine();

            do
            {
                Console.Write("Width of Room 6:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out WidthRoom6);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);

            Console.WriteLine();

            do
            {
                Console.Write("Length of Room 6:");
                userResponse = Console.ReadLine();

                validResponse = double.TryParse(userResponse, out LengthRoom6);

                if (!validResponse)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter a number.");
                }

            } while (!validResponse);
     
                
            AreaRoom1 = LengthRoom1 * WidthRoom1;
            AreaRoom2 = LengthRoom2 * WidthRoom2;
            AreaRoom3 = LengthRoom3 * WidthRoom3;
            AreaRoom4 = LengthRoom4 * WidthRoom4;
            AreaRoom5 = LengthRoom5 * WidthRoom5;
            AreaRoom6 = LengthRoom6 * WidthRoom6;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The Area of Each Room and Total Building Area");
            Console.WriteLine();
            Console.WriteLine();

            
            Console.WriteLine(
                "Room ##".PadLeft(10) +
                "Length".PadLeft(10) +
                "Width".PadLeft(10) +
                "Area".PadLeft(10) );

            Console.WriteLine(
                 "---------".PadLeft(10) +
                 "---------".PadLeft(10) +
                 "---------".PadLeft(10) +
                 "---------".PadLeft(10));

            
                Console.WriteLine("Room #1".PadLeft(10) +
          LengthRoom1.ToString("n2").PadLeft(10) +
          WidthRoom1.ToString("n2").PadLeft(10) +
          AreaRoom1.ToString("n2").PadLeft(10) );

                        Console.WriteLine("Room #2".PadLeft(10) +
                LengthRoom2.ToString("n2").PadLeft(10) +
                WidthRoom2.ToString("n2").PadLeft(10) +
                AreaRoom2.ToString("n2").PadLeft(10) );

                Console.WriteLine("Room #3".PadLeft(10) +
         LengthRoom3.ToString("n2").PadLeft(10) +
         WidthRoom3.ToString("n2").PadLeft(10) +
         AreaRoom3.ToString("n2").PadLeft(10) );

                Console.WriteLine( "Room #4".PadLeft(10) +
         LengthRoom4.ToString("n2").PadLeft(10) +
         WidthRoom4.ToString("n2").PadLeft(10) +
         AreaRoom4.ToString("n2").PadLeft(10) );

                Console.WriteLine( "Room #5".PadLeft(10) +
         LengthRoom5.ToString("n2").PadLeft(10) +
         WidthRoom5.ToString("n2").PadLeft(10) +
         AreaRoom5.ToString("n2").PadLeft(10) );

            Console.WriteLine("Room #6".PadLeft(10) +
                  LengthRoom6.ToString("n2").PadLeft(10) +
                  WidthRoom6.ToString("n2").PadLeft(10) +
                  AreaRoom6.ToString("n2").PadLeft(10));

            Console.WriteLine();
            Console.WriteLine("Total Area: "  .PadLeft(10) + (AreaRoom1 + AreaRoom2 + AreaRoom3 + AreaRoom4 + AreaRoom5 + AreaRoom6).ToString().PadLeft(5) + " ft^2");
            Console.WriteLine();

            totalArea = AreaRoom1 + AreaRoom2 + AreaRoom3 + AreaRoom4 + AreaRoom5 + AreaRoom6;
           
            DisplayContinuePrompt();

            return totalArea;
        }

        #endregion

        #region REFLOORING COST

        static void CostToRemodelFloor(double totalArea)
        {
           

            
            double ECONOMYCARPET = 1.75;
            double LUXURYCARPET = 5.50;
            double LUXURYHARDWOOD = 15.00;
            double ECONOMYHARDWOOD = 11.50;
            double ECONOMYTILE = 6.50;
            double LUXERYTILE = 8.25;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"\tThe total area to be remodeled and refloored is: {totalArea} ft^2");
            Console.WriteLine();
            Console.WriteLine("\t\tThe Cost of Each Material (ft^2)");
            Console.WriteLine("\tEconomy Carpet - $1.75");
            Console.WriteLine("\tLuzury Carpet - $5.50");
            Console.WriteLine("\tEconomy Hardwood - $11.50");
            Console.WriteLine("\tLuzury Hardwood - $15.00");
            Console.WriteLine("\tEconomy Tile - $6.50");
            Console.WriteLine("\tLuzury Tile - $8.25");

            DisplayContinuePrompt();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tReflooring Cost");
            Console.WriteLine();

           
            Console.WriteLine(
                "Material".PadLeft(15) +
                "Cost".PadLeft(10) );

            Console.WriteLine(
                "--------".PadLeft(15) +
                "--------".PadLeft(15) );


            Console.WriteLine("Economey Tiles".PadLeft(15) + (totalArea * ECONOMYTILE).ToString("c").PadLeft(15) );

            Console.WriteLine("Luxury Tiles".PadLeft(15) + (totalArea * LUXERYTILE).ToString("c").PadLeft(15) );

            Console.WriteLine("Economy Carpet".PadLeft(15) + (totalArea * ECONOMYCARPET).ToString("c").PadLeft(15) );

            Console.WriteLine( "Luxury Carpet".PadLeft(15) + (totalArea * LUXURYCARPET).ToString("c").PadLeft(15) );

            Console.WriteLine("Economy Hardwood Floors".PadLeft(15) + (totalArea * ECONOMYHARDWOOD).ToString("c").PadLeft(15) );

            Console.WriteLine( "Luxury Hardwood Floors".PadLeft(15) + (totalArea * LUXURYHARDWOOD).ToString("c").PadLeft(15) );

            DisplayContinuePrompt();
        }

        #endregion

        #region USER INTERFACE


        static void DisplayWelcomeScreen()
        {
           

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThe Capstone Project");


            DisplayContinuePrompt();
        }

        
        static void DisplayClosingScreen()
        {
         

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\tThank you for using the program.");

            DisplayContinuePrompt();
        }

        
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

       
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

       
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine("\t" + headerText);
        }

        #endregion
    }
}
