using FRCDiagnostics.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.Controls
{
    public enum Status
    {
        Unknown,
        Success,
        Warning,
        Error
    }

    public class StatusLabel : UILabel
    {
        private string status = "";
        public string Status
        {
            get => status; set
            {
                status = value;
                ResizeForAutoSize();
                Invalidate();
            }
        }

        private Status state = FRCDiagnostics.Controls.Status.Unknown;
        public Status State
        {
            get => state; set
            {
                state = value;
                Invalidate();
            }
        }

        private void ResizeForAutoSize()
        {
            if (this.AutoSize)
                this.SetBoundsCore(this.Left, this.Top, this.Width, this.Height,
                            BoundsSpecified.Size);
        }

        private Size GetAutoSize()
        {
            Size baseSize = base.GetPreferredSize(base.Size);
            Size additionalSize = TextRenderer.MeasureText(Status, Font);

            baseSize.Width += additionalSize.Width;
            baseSize.Height = Math.Max(baseSize.Height, additionalSize.Height);

            return baseSize;
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            return GetAutoSize();
        }

        protected override void SetBoundsCore(int x, int y, int width, int height,
                BoundsSpecified specified)
        {
            if (this.AutoSize && (specified & BoundsSpecified.Size) != BoundsSpecified.None)
            {
                Size size = GetAutoSize();

                width = size.Width;
                height = size.Height;
            }

            base.SetBoundsCore(x, y, width, height, specified);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var baseSize = e.Graphics.MeasureString(Text, Font);

            using SolidBrush brush =
                State == FRCDiagnostics.Controls.Status.Success ? Theme.TextSuccess :
                State == FRCDiagnostics.Controls.Status.Error ? Theme.TextError :
                State == FRCDiagnostics.Controls.Status.Warning ? Theme.TextWarning :
                State == FRCDiagnostics.Controls.Status.Unknown ? Theme.TextUnkonwn :
                Theme.TextUnkonwn;
            e.Graphics.DrawString(Status, Font, brush, baseSize.Width, 0);
        }
    }
}
