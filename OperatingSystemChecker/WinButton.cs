using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class WinButton : IButton
    {
        public void Command()
        {
            //Render a button in a Windows style
            Console.WriteLine("Windows Command button of " + buttonShape() + " shape created!!");
            Console.WriteLine();
        }

        public void paint(IApperance app)
        {
            Console.WriteLine("{0} button coloured with {1} color", this.buttonShape(), app.BackgroundColor());
            Console.WriteLine();
        }

        public string buttonShape()
        {
            return "SQUARE";
        }
    }
}
