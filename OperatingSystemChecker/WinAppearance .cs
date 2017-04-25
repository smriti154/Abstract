using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class WinAppearance : IApperance
    {

        public void SetBackground()
        {
            Console.WriteLine("Windows Background set of Color " + BackgroundColor());
            Console.WriteLine();
        }

        public string BackgroundColor()
        {
            return "BLUE";
        }
    }
}
