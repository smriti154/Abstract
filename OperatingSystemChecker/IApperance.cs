using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{
    interface IApperance
    {
        void SetBackground();
        string BackgroundColor();
    }

    class WinAppearance : IApperance
    {

        public void SetBackground()
        {
            Console.WriteLine("Windows Background set of Color " + BackgroundColor());
            Console.WriteLine();
        }

        public string BackgroundColor()
        {

			//hello commited by Smriti Gupta
            return "BLUE1";

    }

    class MacAppearance : IApperance
    {
        public void SetBackground()
        {
            Console.WriteLine("Mac Background set of color " + BackgroundColor());
            Console.WriteLine();
        }

        public string BackgroundColor()
        {
            return "WHITE222222222";
        }

    }
}
