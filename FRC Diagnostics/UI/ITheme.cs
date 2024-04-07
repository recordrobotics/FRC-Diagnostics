using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI
{
    public interface ITheme
    {
        UIColor BackgroundPrimary { get; }
        UIColor BackgroundTertiary { get; }
        UIColor BackgroundPopup { get; }
        UIColor BackgroundSecondary { get; }

        UIColor BorderDefault { get; }
        UIColor BorderSecondary { get; }

        UIColor TextNormal { get; }
        UIColor TextMuted { get; }

        UIColor HeaderNormal { get; }
        UIColor HeaderMuted { get; }

        UIColor TextSuccess { get; }
        UIColor TextWarning { get; }
        UIColor TextError { get; }
        UIColor TextUnkonwn { get; }
    }
}
