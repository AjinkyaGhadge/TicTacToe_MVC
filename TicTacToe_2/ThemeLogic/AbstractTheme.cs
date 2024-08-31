using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ThemeLogic
{
    public abstract class AbstractTheme
    {
        public abstract Color BackgroundColor { get; }
        public abstract Color ForegroundColor { get; }
        public abstract string Name { get; }
    }
}
