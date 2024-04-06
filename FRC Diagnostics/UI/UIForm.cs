using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI
{
    public class UIForm : Form
    {
        public ThemeManager ThemeManager { get; set; }
        public ITheme Theme { get => ThemeManager.Theme; }

        public UIForm() : this(ThemeManager.Default)
        { 
        }

        public UIForm(ThemeManager themeManager)
        {
            ThemeManager = themeManager;
        }

        public override Color BackColor { get => Theme.BackgroundTertiary; }
        public override Color ForeColor { get => Theme.TextNormal; }
    }
}
