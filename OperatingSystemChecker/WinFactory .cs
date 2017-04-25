using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{
    class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
           return new WinButton();
        }

        public IApperance ApplyBackground()
        {
            return new WinAppearance();
        }
    }
}
