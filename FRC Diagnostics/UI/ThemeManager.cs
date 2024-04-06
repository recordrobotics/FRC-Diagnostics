using FRCDiagnostics.UI.Themes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI
{
    public class ThemeManager
    {
        public static ThemeManager? Global { get; set; }

        public static readonly ThemeManager Default = new ThemeManager(new DarkTheme());

        public ITheme Theme { get; set; }
        
        public ThemeManager(ITheme theme)
        {
            Theme = theme;
        }
    }
}
