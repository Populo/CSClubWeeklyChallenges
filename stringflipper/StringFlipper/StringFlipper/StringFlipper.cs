using System;

namespace StringFlipper
{
    /**
     * https://pastebin.com/ryVaNuhk
     * 
     * Chris Staudigel
     * 2018-08-25
     */

    class StringFlipper
    {
        static void Main(string[] args)
        {
            var p = new StringFlipper();
            p.Run();
        }

        void Run()
        {
            var done = false;

            while (!done)
            {
                Console.Write("Please enter a string to flip or -1 to exit: ");
                var input = Console.ReadLine();

                if (CheckDone(input)) break;

                var inputArray = input.Split(' ');

                // print array backwards
                for (var i = inputArray.Length - 1; i >= 0; --i)
                {
                    var word = i == 0 ? inputArray[i] : inputArray[i] + " ";

                    Console.Write(word);
                }

                Console.Write("\n");
            }
        }

        bool CheckDone(string input)
        {
            var done = false;

            try
            {
                var number = int.Parse(input);

                if (number == -1) done = true;
            }
            catch (FormatException) { }

            
            return done;
        }
    }
}
