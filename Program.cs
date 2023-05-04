using System;

namespace Inheritance_Hutton_Riley
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new game to print to console
            FPS myFPS = new FPS("E", "ZombCube");

            //Prints the game to console
            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            //Creates another new game and prints it to console
            FPS csGo = new FPS("M", "CS:GO");
            Console.WriteLine(csGo.Describe());
            csGo.PlayGame();
        }
    }
}
