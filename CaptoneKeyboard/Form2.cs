using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaptoneKeyboard
{
    public partial class frm_OpeningScreen : Form 
    {
        public frm_OpeningScreen()
        {
            InitializeComponent();
        }

        private void btn_startKeyboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Frm_Keyboard().Show();
        }

        private void btn_changeScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_themeMenu().Show();
        }
    }
}
