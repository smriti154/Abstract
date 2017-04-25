using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{
    interface IButton
    {
        void Command();
        void paint(IApperance app);
        string buttonShape();
    }

    class WinButton : IButton
    {
        public void Command()
        {
            //Render a button in a Windows style
            Console.WriteLine("Windows Command button of " + buttonShape() + " shape created!!");
            Console.ReadLine();
        }

        public void paint(IApperance app)
        {
            Console.WriteLine("{0} button coloured with {1}", this.buttonShape(), app.BackgroundColor());
            Console.WriteLine();
			Console.WriteLine();
        }

        public string buttonShape()
        {
            return "SQUARE";
        }
    }

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
