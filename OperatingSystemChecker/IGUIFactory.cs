using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatingSystemChecker
{
    interface IGUIFactory
    {
        IButton CreateButton();
        IApperance ApplyBackground();
    }
}
