using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ThemeLogic.Theme
{
    public class DarkTheme : AbstractTheme
    {
        public override Color BackgroundColor => Color.Black;
        public override Color ForegroundColor => Color.White;
        public override string Name => "Dark";
    }
}
