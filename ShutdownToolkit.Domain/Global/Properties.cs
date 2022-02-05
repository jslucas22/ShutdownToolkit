using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ShutdownToolkit.Domain.Global
{
    public static class Properties
    {
        #region ..:: Integers ::..

        [Description("Default hour value to use in the service layer.")]
        public static int Hours { get { return 0; } }

        [Description("Default minute value to use in the service layer.")]
        public static int Minutes { get { return 0; } }

        [Description("Default seconds value to use in the service layer.")]
        public static int Seconds { get { return 0; } }

        [Description("The action that will be executed in the factory.")]
        public static int Action { get; set; }

        #endregion

        #region ..:: Strings ::..

        [Description("My github profile.")]
        public static string GithubProfile { get { return "https://github.com/jslucas22"; } }

        [Description("Main Directory.")]
        public static string Directory { get { return $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\SHUTDOWN_TOOLKIT"; } }

        [Description("File Path.")]
        public static string FileName { get { return $"{Directory}\\LOG_{DateTime.Now:dd_MM_yyyy}.txt"; } }

        #endregion

        #region ..:: Windows Forms Components ::..

        #region ..:: Radio Button ::..

        [Description("RadioButton")]
        public static RadioButton RadioButton { get; set; }

        #endregion

        #region ..:: TextBox ::..

        [Description("Collection of textboxes")]
        public static TextBox[] TextBox { get; set; }

        #endregion

        #region ..:: Time Span ::..

        [Description("TimeSpan")]
        public static TimeSpan TimeSpan { get; set; }

        [Description("Auxiliary property to not lose TimeSpan value")]
        public static TimeSpan AuxTimeSpan { get; set; }

        #endregion

        #endregion
    }
}
