﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ThemeLogic.Theme
{
    public class RedLightTheme : AbstractTheme
    {
        public override Color BackgroundColor => Color.Red;
        public override Color ForegroundColor => Color.Black;
        public override string Name => "RedLight";
    }
}
