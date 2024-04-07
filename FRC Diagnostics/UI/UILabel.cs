using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI
{
    public class UILabel : Label
    {
        private bool isHeader = false;
        public bool Header
        {
            get => isHeader;
            set
            {
                isHeader = value;
                Invalidate();
            }
        }

        private bool isMuted = false;
        public bool Muted
        {
            get => isMuted;
            set
            {
                isMuted = value;
                Invalidate();
            }
        }

        public ThemeManager ThemeManager { get; set; }
        public ITheme Theme { get => ThemeManager.Theme; }

        public UILabel() : this(ThemeManager.Default)
        {
        }

        public UILabel(ThemeManager themeManager)
        {
            ThemeManager = themeManager;
        }

        public override Color BackColor { get => Color.Transparent; }
        public override Color ForeColor { get => Header ? (Muted ? Theme.HeaderMuted : Theme.HeaderNormal) : (Muted ? Theme.TextMuted : Theme.TextNormal); }
    }
}
