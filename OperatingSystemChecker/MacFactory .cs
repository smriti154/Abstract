using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{
    class MacFactory  : IGUIFactory
{
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public IApperance ApplyBackground()
        {
            return new MacAppearance();
        }
}
   
}
