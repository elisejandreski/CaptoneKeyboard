using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaptoneKeyboard
{
    public partial class frm_themeMenu : Form
    {
        public frm_themeMenu()
        {
            InitializeComponent();
        }

        private void radioButtonLightTheme_CheckedChanged(object sender, EventArgs e)
        {   
            //
            // Write backColor for theme into Theme.txt
            //
            string dataPath = @"Data/Theme.txt";
            File.WriteAllText(dataPath, "ActiveCaption");
        }

        private void radioButtonDarkTheme_CheckedChanged(object sender, EventArgs e)
        {
            //
            // Write backColor for theme into Theme.txt
            //
            string dataPath = @"Data/Theme.txt";
            File.WriteAllText(dataPath, "ControlText");
        }

        private void btn_returnToOpeningScreenFromThemeSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_OpeningScreen().Show();
        }
    }
}
