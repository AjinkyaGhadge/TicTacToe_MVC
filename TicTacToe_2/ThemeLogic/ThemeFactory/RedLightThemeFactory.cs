using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ThemeLogic.Theme;
using View;

namespace View.ThemeLogic.ThemeFactory
{
    public class RedLightThemeFactory:AbstractThemeFactory
    {
        public override AbstractTheme CreateTheme() => new RedLightTheme();
    }
}
