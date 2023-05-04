using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Hutton_Riley
{
    abstract class Game
    {
        public string Esrb { get; set; }

        public string Title { get; set; }


        /// <summary>
        /// Creates the parameters for ESRB and Title
        /// </summary>
        /// <param name="esrbParam"></param>
        /// <param name="titleParam"></param>
        public Game(string esrbParam, String titleParam)
        {
            Esrb = esrbParam;
            Title = titleParam;
        }

        /// <summary>
        /// Prints the title and says it is starting
        /// </summary>
        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();
    }
}
