using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ThemeLogic.Theme;

namespace View.ThemeLogic.ThemeFactory
{
    public class DarkThemeFactory : AbstractThemeFactory
    {
        public override AbstractTheme CreateTheme() => new DarkTheme();
    }
}
