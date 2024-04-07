using FRCDiagnostics.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FRCDiagnostics.Controls
{
    public class ComponentSection : GroupBox
    {
        public ThemeManager ThemeManager { get; set; }
        public ITheme Theme { get => ThemeManager.Theme; }

        public ComponentSection() : this(ThemeManager.Default)
        {
        }

        public ComponentSection(ThemeManager themeManager)
        {
            ThemeManager = themeManager;
        }

        public override Color BackColor { get => Color.Transparent; }

        private readonly Font headerFont = new("Segoe UI", 16);

        protected override void OnPaint(PaintEventArgs e)
        {
            using SolidBrush header = Theme.HeaderNormal;
            e.Graphics.DrawString(Text, headerFont, header, Padding.Left, Padding.Top);
            var title = e.Graphics.MeasureString(Text, headerFont);

            using SolidBrush border = Theme.BorderDefault;
            e.Graphics.FillRectangle(border, 0, title.Height + 10, Width, 3);
        }
    }
}
