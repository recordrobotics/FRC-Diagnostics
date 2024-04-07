using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI
{
    public partial class UIColor
    {
        private readonly Color color;

        public UIColor(Color color)
        {
            this.color = color;
        }

        public UIColor(int red, int blue, int green, int alpha) : this(Color.FromArgb(alpha, red, green, blue))
        {
        }

        public UIColor(string hex)
        {
            if (HexRegex().IsMatch(hex))
            {
                char[] c = hex[1..].ToCharArray();
                if (c.Length == 3)
                {
                    c = [c[0], c[0], c[1], c[1], c[2], c[2]];
                }
                if(c.Length == 6)
                {
                    c = ['f', 'f', .. c];
                }
                string fn = new StringBuilder().Append(c).ToString();
                if(int.TryParse(fn, System.Globalization.NumberStyles.HexNumber, null, out int rgba))
                {
                    color = Color.FromArgb(rgba);
                } else
                {
                    throw new ArgumentException("Could not parse hex color '" + hex + "'");
                }
            } else
            {
                throw new InvalidCastException("Could not cast string '" + hex + "' to Color.");
            }
        }

        public static implicit operator SolidBrush(UIColor c)
        {
            return new SolidBrush(c.color);
        }

        public static implicit operator Pen(UIColor c)
        {
            return new Pen(c.color);
        }

        public static implicit operator UIColor(Color c)
        {
            return new UIColor(c);
        }

        public static implicit operator Color(UIColor c)
        {
            return c.color;
        }

        public static implicit operator UIColor(string hex)
        {
            return new UIColor(hex);
        }

        [GeneratedRegex("^#([A-Fa-f0-9]{3}){1,2}$")]
        private static partial Regex HexRegex();
    }
}
