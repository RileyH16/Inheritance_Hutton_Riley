using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Hutton_Riley
{
    class FPS : Game
    {
        /// <summary>
        /// Assigns Parameters to the strings
        /// </summary>
        public FPS(string esrbParam, String titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }
        /// <summary>
        /// Prints a sentence that tells you the title of the game and the ESRB rating
        /// </summary>>
        public override string Describe()
        {
            return $"{Title} is a FPS game rated {Esrb}!";
        }
    }
}
