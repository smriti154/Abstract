using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class MacAppearance : IApperance
    {
        public void SetBackground()
        {
            Console.WriteLine("Mac Background set of color " + BackgroundColor());
            Console.WriteLine();
        }

        public string BackgroundColor()
        {
            return "WHITE";
        }
      
    }
}
