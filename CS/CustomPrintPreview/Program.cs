using System;
using DevExpress.Skins;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.Collections.Generic;

namespace CustomPrintPreview {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SkinName = "Caramel";
            Application.Run(new MainForm());
        }
    }
}