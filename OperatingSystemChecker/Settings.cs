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
}
