using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.ThemeLogic.Theme;

namespace View.ThemeLogic.ThemeFactory
{
    public class BlueThemeFactory : AbstractThemeFactory
    {
        public override AbstractTheme CreateTheme() => new BlueTheme();
    }
}
