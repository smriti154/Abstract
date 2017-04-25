using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{

    class Settings
    {
        private IButton button;
        private IApperance appearance;
        private string backgroundColor;

        public Settings(IGUIFactory factory)
        {
            button = factory.CreateButton();
            button.Command();
            appearance = factory.ApplyBackground();
            appearance.SetBackground();
        }

        public void applyBackgroundToButton()
        {
            button.paint(appearance);
        }
    }

    class Program
    {
        static void Main(string[] args)
    {

        var appearance = Console.ReadLine().ToLower();

        IGUIFactory factory;
        switch (appearance)
        {
            case "windows":
                factory = new WinFactory();
                break;
            case "mac":
                factory = new MacFactory();
                break;
            default:
                throw new System.NotImplementedException();

        }

        Settings settingForButton = new Settings(factory);
        settingForButton.applyBackgroundToButton();
        Console.ReadKey();
    }
        
    }
}
