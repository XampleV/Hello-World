using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            helloWorldHomework();
            dataTypesCC();
        }
        static void helloWorldHomework()
        {
            Console.WriteLine("Hello there\nwhat are you doing?");
            string userAnswer = Console.ReadLine();
            Console.WriteLine($"That's cool.. You said: '{ userAnswer}'");
        }
        static void dataTypesCC()
        {
            // first part
            Console.Write("Enter your favorite number!: ");
            int faveNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write(faveNumber - 10);


            // working with numbers
            double numberOne = 6.5;
            double numberTwo = 4;

            // Raise numberOne to the numberTwo power
            Console.WriteLine(Math.Pow(numberOne, numberTwo));

            // Round numberOne up
            Console.WriteLine(Math.Ceiling(numberOne));

            // Find the larger number between numberOne and numberTwo
            Console.WriteLine(Math.Max(numberOne, numberTwo));

        }
        static void workingWithText()
        {
            {
                // Script line
                string script = "Close on a portrait of the HANDSOME PRINCE -- as the BEAST'S giant paw slashes it.";

                // Get camera directions
                int charPosition = script.IndexOf("Close");
                int length = "Close on".Length;
                string cameraDirections = script.Substring(charPosition, length);
                Console.WriteLine(cameraDirections);

                // Get scene description
                charPosition = script.IndexOf("a portrait");
                string sceneDescription = script.Substring(charPosition);

                // Make camera directions uppercase
                cameraDirections = cameraDirections.ToUpper();
                sceneDescription = sceneDescription.ToLower();


            }
        }
    }
}
