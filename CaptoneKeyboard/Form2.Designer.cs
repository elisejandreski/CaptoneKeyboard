namespace CaptoneKeyboard
{
    partial class frm_OpeningScreen
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
            this.btn_startKeyboard = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_production = new System.Windows.Forms.Label();
            this.btn_changeScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startKeyboard
            // 
            this.btn_startKeyboard.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startKeyboard.Location = new System.Drawing.Point(663, 386);
            this.btn_startKeyboard.Name = "btn_startKeyboard";
            this.btn_startKeyboard.Size = new System.Drawing.Size(96, 52);
            this.btn_startKeyboard.TabIndex = 0;
            this.btn_startKeyboard.Text = "Start";
            this.btn_startKeyboard.UseVisualStyleBackColor = true;
            this.btn_startKeyboard.Click += new System.EventHandler(this.btn_startKeyboard_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe Script", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_title.Location = new System.Drawing.Point(132, 87);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(544, 159);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Keyboard";
            // 
            // lbl_production
            // 
            this.lbl_production.AutoSize = true;
            this.lbl_production.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_production.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_production.Location = new System.Drawing.Point(294, 231);
            this.lbl_production.Name = "lbl_production";
            this.lbl_production.Size = new System.Drawing.Size(221, 15);
            this.lbl_production.TabIndex = 2;
            this.lbl_production.Text = "Better Late Than Never Productions";
            // 
            // btn_changeScreen
            // 
            this.btn_changeScreen.Location = new System.Drawing.Point(12, 388);
            this.btn_changeScreen.Name = "btn_changeScreen";
            this.btn_changeScreen.Size = new System.Drawing.Size(134, 51);
            this.btn_changeScreen.TabIndex = 3;
            this.btn_changeScreen.Text = "Change Theme";
            this.btn_changeScreen.UseVisualStyleBackColor = true;
            this.btn_changeScreen.Click += new System.EventHandler(this.btn_changeScreen_Click);
            // 
            // frm_OpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_changeScreen);
            this.Controls.Add(this.lbl_production);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_startKeyboard);
            this.Name = "frm_OpeningScreen";
            this.Text = "Keyboard, Better Late Than Never Productions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startKeyboard;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_production;
        private System.Windows.Forms.Button btn_changeScreen;
    }
}