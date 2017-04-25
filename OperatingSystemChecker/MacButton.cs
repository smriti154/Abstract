using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appearance
{
    class MacButton : IButton
    {
        public void Command()
        {
            //Render a button in a Mac style
            Console.WriteLine("Mac Command button of " + buttonShape() + " shape created!!");
            Console.WriteLine();
        }

        public void paint(IApperance app)
        {
            Console.WriteLine("{0} coloured with {1}", this.buttonShape(), app.BackgroundColor());
            Console.WriteLine();
        }

        public string buttonShape()
        {
            return "CIRCLE";
        }
    }
}
