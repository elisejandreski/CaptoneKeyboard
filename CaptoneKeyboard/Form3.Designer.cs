namespace CaptoneKeyboard
{
    partial class frm_themeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonLightTheme = new System.Windows.Forms.RadioButton();
            this.radioButtonDarkTheme = new System.Windows.Forms.RadioButton();
            this.lbl_themeSettingsTitle = new System.Windows.Forms.Label();
            this.btn_returnToOpeningScreenFromThemeSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonLightTheme
            // 
            this.radioButtonLightTheme.AutoSize = true;
            this.radioButtonLightTheme.Location = new System.Drawing.Point(82, 141);
            this.radioButtonLightTheme.Name = "radioButtonLightTheme";
            this.radioButtonLightTheme.Size = new System.Drawing.Size(89, 17);
            this.radioButtonLightTheme.TabIndex = 0;
            this.radioButtonLightTheme.TabStop = true;
            this.radioButtonLightTheme.Text = "Light (default)";
            this.radioButtonLightTheme.UseVisualStyleBackColor = true;
            this.radioButtonLightTheme.CheckedChanged += new System.EventHandler(this.radioButtonLightTheme_CheckedChanged);
            // 
            // radioButtonDarkTheme
            // 
            this.radioButtonDarkTheme.AutoSize = true;
            this.radioButtonDarkTheme.Location = new System.Drawing.Point(82, 173);
            this.radioButtonDarkTheme.Name = "radioButtonDarkTheme";
            this.radioButtonDarkTheme.Size = new System.Drawing.Size(48, 17);
            this.radioButtonDarkTheme.TabIndex = 1;
            this.radioButtonDarkTheme.TabStop = true;
            this.radioButtonDarkTheme.Text = "Dark";
            this.radioButtonDarkTheme.UseVisualStyleBackColor = true;
            this.radioButtonDarkTheme.CheckedChanged += new System.EventHandler(this.radioButtonDarkTheme_CheckedChanged);
            // 
            // lbl_themeSettingsTitle
            // 
            this.lbl_themeSettingsTitle.AutoSize = true;
            this.lbl_themeSettingsTitle.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_themeSettingsTitle.ForeColor = System.Drawing.Color.White;
            this.lbl_themeSettingsTitle.Location = new System.Drawing.Point(12, 9);
            this.lbl_themeSettingsTitle.Name = "lbl_themeSettingsTitle";
            this.lbl_themeSettingsTitle.Size = new System.Drawing.Size(274, 57);
            this.lbl_themeSettingsTitle.TabIndex = 3;
            this.lbl_themeSettingsTitle.Text = "Theme Settings";
            // 
            // btn_returnToOpeningScreenFromThemeSettings
            // 
            this.btn_returnToOpeningScreenFromThemeSettings.Location = new System.Drawing.Point(546, 405);
            this.btn_returnToOpeningScreenFromThemeSettings.Name = "btn_returnToOpeningScreenFromThemeSettings";
            this.btn_returnToOpeningScreenFromThemeSettings.Size = new System.Drawing.Size(152, 33);
            this.btn_returnToOpeningScreenFromThemeSettings.TabIndex = 4;
            this.btn_returnToOpeningScreenFromThemeSettings.Text = "Return to Opening Screen";
            this.btn_returnToOpeningScreenFromThemeSettings.UseVisualStyleBackColor = true;
            this.btn_returnToOpeningScreenFromThemeSettings.Click += new System.EventHandler(this.btn_returnToOpeningScreenFromThemeSettings_Click);
            // 
            // frm_themeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_returnToOpeningScreenFromThemeSettings);
            this.Controls.Add(this.lbl_themeSettingsTitle);
            this.Controls.Add(this.radioButtonDarkTheme);
            this.Controls.Add(this.radioButtonLightTheme);
            this.Name = "frm_themeMenu";
            this.Text = "Theme Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonLightTheme;
        private System.Windows.Forms.RadioButton radioButtonDarkTheme;
        private System.Windows.Forms.Label lbl_themeSettingsTitle;
        private System.Windows.Forms.Button btn_returnToOpeningScreenFromThemeSettings;
    }
}