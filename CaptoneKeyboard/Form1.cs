using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace CaptoneKeyboard
{
    public partial class Frm_Keyboard : Form
    {
        public Frm_Keyboard()
        {
            InitializeComponent();

            //
            // set theme
            //
            string dataPath = @"Data/Theme.txt";
            string[] themeColor;

            themeColor = File.ReadAllLines(dataPath);

            
            if (themeColor[0] == "ControlText")
            {
                this.BackColor = System.Drawing.SystemColors.ControlText;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            }
        }

        //
        // Assign notes to buttons
        //
        void CKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeC);
        }

        void DKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeD);
        }

        
        void EKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeE);
        }

        void FKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeF);
        }
        private void GKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeG);
        }

        void AKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeA);
        }

        void BKey_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeB);
        }

        private void CSharp_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeCSharp);
        }

        private void DSharp_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeDSharp);
        }

        private void FSharp_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeFSharp);
        }

        private void GSharp_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeGSharp);
        }

        private void ASharp_Click(object sender, EventArgs e)
        {
            PlayNoteOnInstrument(ukuleleKeyboardRadioButton, Properties.Resources.UkeASharp);
        }

        private void btn_returnToOpeningScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frm_OpeningScreen().Show();
        }

        /// <summary>
        /// Play notes from wave files for each instrument radio button
        /// </summary>
        /// <param name="instrumentKeyboardRadioButton"></param>
        /// <param name="instrumentNote"></param>
        void PlayNoteOnInstrument(RadioButton instrumentKeyboardRadioButton, System.IO.UnmanagedMemoryStream instrumentNote)
        {
            if (instrumentKeyboardRadioButton.Checked)
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(instrumentNote);
                sound.Load();
                sound.Play();
            }

        }

        private void ukuleleKeyboardRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
