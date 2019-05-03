using System;

namespace ColorBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int numBalls = 3;
            int maxThrows = 20;
            Ball[] balls;

            Color red = new Color(255, 0, 0);

            // Initialize array with the number of balls given
            balls = new Ball[numBalls];

            // Creates 3 different balls to throw and pop, using different
            // overload os the Ball constructor
            balls[0] = new Ball(255, 255, 255, 10.0f);
            balls[1] = new Ball(140, 50, 200, 5.2f);
            balls[2] = new Ball(red, 20.9f);

            // int i is set as 1 as to make checking/changing the throws
            // at which the balls are popped more direct, being that it will
            // print the same values as are shown in the code
            for (int i = 1; i <= maxThrows; i++)
            {
                balls[0].Throw();
                balls[1].Throw();
                balls[2].Throw();
                if (i == 1) balls[0].Pop();
                else if (i == 15) balls[2].Pop();
            }

            // Check balls[0] status
            Console.WriteLine($"1st ball's throw count: " +
                $"{balls[0].ThrowCount}");

            // Check balls[1] status
            Console.WriteLine($"2nd ball's throw count: " +
                $"{balls[1].ThrowCount}");

            // Check balls[2] status
            Console.WriteLine($"3rd ball's throw count: " +
                $"{balls[2].ThrowCount}");


            // Test Color creation and Color value gettin
            /*
            Color Color = new Color(129, 5, 240);

            Console.WriteLine($"Red: {Color.GetRedValue()}\nGreen: " +
                $"{Color.GetGreenValue()}\nBlue: {Color.GetBlueValue()}\n" +
                $"Grayscale: {Color.GetGrayscaleValue()}");
            */

            // Test Color value setting
            /*
            Color.SetRedValue(255);
            Color.SetGreenValue(100);
            Color.SetBlueValue(210);

            Console.WriteLine($"Red: {Color.GetRedValue()}\nGreen: " +
                $"{Color.GetGreenValue()}\nBlue: {Color.GetBlueValue()}\n" +
                $"Grayscale: {Color.GetGrayscaleValue()}");
               */
        }
    }
}
