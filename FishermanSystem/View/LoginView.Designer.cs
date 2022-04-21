namespace FishermanSystem.View
{
    partial class LoginView
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
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.FSlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(293, 18);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(233, 45);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome\r\n\r\n\r\n";
            this.Welcomelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(326, 145);
            this.Usernametxt.Multiline = true;
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(169, 39);
            this.Usernametxt.TabIndex = 1;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(311, 130);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(109, 17);
            this.Usernamelbl.TabIndex = 2;
            this.Usernamelbl.Text = "Username";
            this.Usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(326, 203);
            this.Passwordtxt.Multiline = true;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(169, 39);
            this.Passwordtxt.TabIndex = 3;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.BackColor = System.Drawing.Color.Transparent;
            this.Passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(309, 187);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(109, 17);
            this.Passwordlbl.TabIndex = 4;
            this.Passwordlbl.Text = "Password";
            this.Passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Loginbtn
            // 
            this.Loginbtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(326, 248);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(72, 32);
            this.Loginbtn.TabIndex = 5;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            // 
            // Registerbtn
            // 
            this.Registerbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.Location = new System.Drawing.Point(404, 248);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(91, 32);
            this.Registerbtn.TabIndex = 6;
            this.Registerbtn.Text = "Register";
            this.Registerbtn.UseVisualStyleBackColor = true;
            // 
            // FSlbl
            // 
            this.FSlbl.BackColor = System.Drawing.Color.Transparent;
            this.FSlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FSlbl.ForeColor = System.Drawing.Color.Black;
            this.FSlbl.Location = new System.Drawing.Point(254, 71);
            this.FSlbl.Name = "FSlbl";
            this.FSlbl.Size = new System.Drawing.Size(316, 33);
            this.FSlbl.TabIndex = 7;
            this.FSlbl.Text = "FishermanSystem";
            this.FSlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FishermanSystem.Properties.Resources.Fishing_Wallpaper_HD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 418);
            this.Controls.Add(this.FSlbl);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Passwordlbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Usernametxt);
            this.Controls.Add(this.Welcomelbl);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.Label FSlbl;
    }
}