
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace View.ThemeLogic.Theme
{
    public class BlueTheme : AbstractTheme
    {
        public override Color BackgroundColor => Color.LightBlue;
        public override Color ForegroundColor => Color.DarkBlue;
        public override string Name => "Blue";
    }
}
