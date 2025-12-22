using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGFramework.Display
{
    public static class DisplaySettings
    {
        public static string AnnouncementColor { get; set; } = "[red]";

        #region Map Settings
        public static string RoomMapIcon { get; set; } = "■";
        public static string RoomMapIconColor { get; set; } = "[green]";
        public static string YouAreHereMapIcon { get; set; } = "🙂";
        public static string YouAreHereMapIconColor { get; set; } = "[bold black]";
        #endregion
    }
}
