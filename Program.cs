using System;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor originalForeground = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"               .__                                  __             __  .__                        
__  _  __ ____ |  |   ____  ____   _____   ____   _/  |_  ____   _/  |_|  |__   ____              
\ \/ \/ // __ \|  | _/ ___\/  _ \ /     \_/ __ \  \   __\/  _ \  \   __\  |  \_/ __ \             
 \     /\  ___/|  |_\  \__(  <_> )  Y Y  \  ___/   |  | (  <_> )  |  | |   Y  \  ___/             
  \/\_/  \___  >____/\___  >____/|__|_|  /\___  >  |__|  \____/   |__| |___|  /\___  >            
             \/          \/            \/     \/                            \/     \/             
  _________.__               .__           ___________                     __  .__                
 /   _____/|__| _____ ______ |  |   ____   \_   _____/___________    _____/  |_|__| ____   ____   
 \_____  \ |  |/     \\____ \|  | _/ __ \   |    __) \_  __ \__  \ _/ ___\   __\  |/  _ \ /    \  
/        \|  |  Y Y  \  |_> >  |_\  ___/   |     \   |  | \// __ \\  \___|  | |  (  <_> )   |  \ 
/_______  /|__|__|_|  /   __/|____/\___  >  \___  /   |__|  (____  /\___  >__| |__|\____/|___|  / 
        \/          \/|__|             \/       \/               \/     \/                    \/  
_________        .__               .__          __                                                
\_   ___ \_____  |  |   ____  __ __|  | _____ _/  |_  ___________                                 
/    \  \/\__  \ |  | _/ ___\|  |  \  | \__  \\   __\/  _ \_  __ \                                
\     \____/ __ \|  |_\  \___|  |  /  |__/ __ \|  | (  <_> )  | \/                                
 \______  (____  /____/\___  >____/|____(____  /__|  \____/|__|                                   
        \/     \/          \/                \/                                                   ");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = originalForeground;

            Console.WriteLine("Welcome to the Simple Fraction Calculator!");
            Console.WriteLine("Please choose an option by entering the corresponding number:");

            Console.WriteLine("1. Reduce a fraction");
            Console.WriteLine("2. Add fractions");
            Console.WriteLine("3. Subtract fractions");
            Console.WriteLine("4. Multiply fractions");
            Console.WriteLine("5. Divide fractions");
            Console.WriteLine("6. Exit");

            int userChoice = int.Parse(Console.ReadLine());
            ConsoleColor originalForegroundColor = Console.ForegroundColor;
            ConsoleColor originalBackgroundColor = Console.BackgroundColor;
            int originalCursorLeft = Console.CursorLeft;
            int originalCursorTop = Console.CursorTop;

            while (userChoice != 6)
            {
                originalForegroundColor = Console.ForegroundColor;
                int cursorTop = userChoice;
                originalCursorLeft = Console.CursorLeft;
                originalCursorTop = Console.CursorTop;

                Console.SetCursorPosition(0, cursorTop - 1);

                originalBackgroundColor = Console.BackgroundColor;

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine($"{userChoice}");

                Console.ForegroundColor = originalForegroundColor;
                Console.BackgroundColor = originalBackgroundColor;
                Console.SetCursorPosition(originalCursorLeft, originalCursorTop);

                if (userChoice == 1)
                {
                    Console.WriteLine("Please enter the numerator:");
                    int nominator = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator:");
                    int denominator = int.Parse(Console.ReadLine());
                    Fraction frToReduce = new Fraction(nominator, denominator);

                    frToReduce.Reduce();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*************************************");
                    Console.WriteLine($"The reduced fraction is: {frToReduce}");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Add(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("*************************************");
                    Console.WriteLine($"The result of adding {fraction1} and {fraction2} is: {result}");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Subtract(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*************************************");
                    Console.WriteLine($"The result of subtracting {fraction2} from {fraction1} is: {result}");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fraction1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fraction2 = new Fraction(nominator2, denominator2);

                    Fraction result = fraction1.Multiply(fraction2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*************************************");
                    Console.WriteLine($"The result of multiplying {fraction1} and {fraction2} is: {result}");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                else if (userChoice == 5)
                {
                    Console.WriteLine("Please enter the numerator of the first fraction:");
                    int nominator1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the first fraction:");
                    int denominator1 = int.Parse(Console.ReadLine());
                    Fraction fra1 = new Fraction(nominator1, denominator1);

                    Console.WriteLine("Please enter the numerator of the second fraction:");
                    int nominator2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the denominator of the second fraction:");
                    int denominator2 = int.Parse(Console.ReadLine());
                    Fraction fra2 = new Fraction(nominator2, denominator2);
                    Fraction result = fra1.Divide(fra2);
                    result.Reduce();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("*************************************");
                    Console.WriteLine($"The result of dividing {fra1} by {fra2} is: {result}");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                }
                    Console.Clear();
                    Console.WriteLine("Welcome to the Simple Fraction Calculator!");
                    Console.WriteLine("Please choose an option by entering the corresponding number:");

                    Console.WriteLine("1. Reduce a fraction");
                    Console.WriteLine("2. Add fractions");
                    Console.WriteLine("3. Subtract fractions");
                    Console.WriteLine("4. Multiply fractions");
                    Console.WriteLine("5. Divide fractions");
                    Console.WriteLine("6. Exit");

                    Console.Write("Enter your choice: ");
                    userChoice = int.Parse(Console.ReadLine());
                }

                if (userChoice == 6)
                {
                    Console.SetCursorPosition(0, 5);

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine($"{userChoice}");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                    Console.SetCursorPosition(originalCursorLeft, originalCursorTop);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Thank you for using the Simple Fraction Calculator!");
                    Console.WriteLine("*************************************");
                    Console.ForegroundColor = originalForegroundColor;
                    Console.BackgroundColor = originalBackgroundColor;
                }
            }
        }
    }

                