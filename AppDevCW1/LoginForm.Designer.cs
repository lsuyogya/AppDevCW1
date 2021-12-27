
namespace AppDevCW1
{
    partial class LoginForm
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
            this.LoginTitleLbl = new System.Windows.Forms.Label();
            this.UNameLbl = new System.Windows.Forms.Label();
            this.PWordLbl = new System.Windows.Forms.Label();
            this.UNameTF = new System.Windows.Forms.TextBox();
            this.PWordTF = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginTitleLbl
            // 
            this.LoginTitleLbl.AutoSize = true;
            this.LoginTitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitleLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LoginTitleLbl.Location = new System.Drawing.Point(209, 34);
            this.LoginTitleLbl.Name = "LoginTitleLbl";
            this.LoginTitleLbl.Size = new System.Drawing.Size(95, 31);
            this.LoginTitleLbl.TabIndex = 0;
            this.LoginTitleLbl.Text = "Log In";
            // 
            // UNameLbl
            // 
            this.UNameLbl.AutoSize = true;
            this.UNameLbl.Location = new System.Drawing.Point(92, 123);
            this.UNameLbl.Name = "UNameLbl";
            this.UNameLbl.Size = new System.Drawing.Size(55, 13);
            this.UNameLbl.TabIndex = 1;
            this.UNameLbl.Text = "Username";
            // 
            // PWordLbl
            // 
            this.PWordLbl.AutoSize = true;
            this.PWordLbl.Location = new System.Drawing.Point(92, 171);
            this.PWordLbl.Name = "PWordLbl";
            this.PWordLbl.Size = new System.Drawing.Size(53, 13);
            this.PWordLbl.TabIndex = 1;
            this.PWordLbl.Text = "Password";
            // 
            // UNameTF
            // 
            this.UNameTF.Location = new System.Drawing.Point(153, 120);
            this.UNameTF.Name = "UNameTF";
            this.UNameTF.Size = new System.Drawing.Size(231, 20);
            this.UNameTF.TabIndex = 2;
            // 
            // PWordTF
            // 
            this.PWordTF.Location = new System.Drawing.Point(153, 168);
            this.PWordTF.Name = "PWordTF";
            this.PWordTF.PasswordChar = '*';
            this.PWordTF.Size = new System.Drawing.Size(231, 20);
            this.PWordTF.TabIndex = 2;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(219, 249);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Log In\r\n";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 349);
            this.Controls.Add(this.UNameTF);
            this.Controls.Add(this.PWordTF);
            this.Controls.Add(this.PWordLbl);
            this.Controls.Add(this.UNameLbl);
            this.Controls.Add(this.LoginTitleLbl);
            this.Controls.Add(this.LoginBtn);
            this.Name = "LoginForm";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLbl;
        private System.Windows.Forms.Label UNameLbl;
        private System.Windows.Forms.Label PWordLbl;
        private System.Windows.Forms.TextBox UNameTF;
        private System.Windows.Forms.TextBox PWordTF;
        private System.Windows.Forms.Button LoginBtn;
    }
}