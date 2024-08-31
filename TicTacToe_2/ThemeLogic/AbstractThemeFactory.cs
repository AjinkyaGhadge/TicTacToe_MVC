using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ThemeLogic.Theme;

namespace View.ThemeLogic
{
    public abstract class AbstractThemeFactory
    {
        public abstract AbstractTheme CreateTheme();
    }
}
