using System;

namespace ExecptionTask
{
    class Program
    {
        static void Main(string[] args)
        {       
                Console.WriteLine("Enter Room Number: ");
                string room = Console.ReadLine();

                if (room.Trim() == String.Empty)
                throw new ArgumentException("Input cannot be empty", "Enter Room Number");


                System.Console.WriteLine("Enter Name: ");
                string name = Console.ReadLine();

                if (name.Trim() == String.Empty)
                throw new ArgumentException("Input cannot be empty", "Enter Name");

            try {

                System.Console.WriteLine("Enter Date: Day");
                int day = Int32.Parse(Console.ReadLine()); 

                System.Console.WriteLine("Enter Date: Month");
                int month = Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter Date: Year");
                int year = Int32.Parse(Console.ReadLine());

                System.Console.WriteLine("Enter Time");
                double Time = Convert.ToDouble(Console.ReadLine());

                System.Console.WriteLine("Enter amount of time student stayed in the room (IN MINUTES): ");
                double stay = Convert.ToDouble(Console.ReadLine()); 
            
            }
            
            catch (FormatException e) {
                System.Console.WriteLine($"Date - Time only uses numbers - {e.Message}");
                }

            catch (NullReferenceException ex) {
                System.Console.WriteLine($"Object doesn't exist :( Closing Program - {ex.Message}");
            }
            catch (Exception ex) {
                System.Console.WriteLine($"Something went wrong :( Closing Program - {ex.Message}");
            }

            System.Console.WriteLine($"Student {name} was in classroom {room}");

            
            
        }
    }
}
