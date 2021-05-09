using System;

namespace Codeacademy_C__Variables2
{
    class Program
    {
        static void Main(string[] args)
        {

// Ask user for fave number
            Console.Write("Enter your favourite number!: ");
            string faveNumber = Console.ReadLine();

// Attempt conversion from char input to integer
            {
                foreach (char value in faveNumber)
                {
                    try
                    {
                        Convert.ToInt32(faveNumber);
                    }
//Catch Format Exceptions - i.e some idiot not putting an integer value in their reply.

                    catch (FormatException)
                    {
                        Console.WriteLine("The {0} value '{1}' is not in a recognizable format.",
                        faveNumber.GetType().Name, faveNumber);

//END OF PROGRAM 
                    }
                }
            }
        }
    }
}
