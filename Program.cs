using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //set up stuff
            ConsoleKeyInfo key;
            Boolean stop = false;
            Boolean WantingToStop = false;
            //write instruction
            Console.WriteLine("Press esc to exit \n");
            do
            {
                key = Console.ReadKey(true);
                //look for the pressing of the esc key
                if (key.Key == ConsoleKey.Escape)
                {
                    //ask for confirmation
                    Console.WriteLine("Are you sure? \n Y/N");
                    do
                    {
                            //for some weird reason i need to record the character again....
                            key = Console.ReadKey(true);
                            //makes it so this thing doesn't fire 200000000000000 times
                            WantingToStop = true;
                            //looking for Y, if so end the program
                            if (key.Key.ToString() == "Y")
                            {
                                Environment.Exit(0);
                            }
                            //if N continue and exit the exit cycle
                            if (key.Key.ToString() == "N")
                            {
                                WantingToStop = false;
                                continue;
                            }
                            //if neither Y or N, tell the user
                        if (key.Key != ConsoleKey.Escape && key.Key.ToString() != "J" && key.Key.ToString() != "N")
                        {
                            Console.WriteLine(key.Key.ToString() + " is not a valid response");
                        }
                    } while (WantingToStop == true);
                }
            } while (stop != true);
        }
    }
}