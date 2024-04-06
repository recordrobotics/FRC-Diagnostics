using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRCDiagnostics.UI.Themes
{
    public class DarkTheme : ITheme
    {
        public UIColor BackgroundPrimary => "#060606";

        public UIColor BackgroundTertiary => "#1f1f1f";

        public UIColor BackgroundPopup => "#000000";

        public UIColor BackgroundSecondary => "#262626";

        public UIColor BorderDefault => "#484848";

        public UIColor BorderSecondary => "#757575";

        public UIColor TextNormal => "#e9e9e9";

        public UIColor TextMuted => "#a5a5a5";

        public UIColor HeaderNormal => "#ffffff";

        public UIColor HeaderMuted => "#bebebe";
    }
}
