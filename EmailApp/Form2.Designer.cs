namespace EmailApp
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbPoruka = new System.Windows.Forms.Label();
            this.cbPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogin.Location = new System.Drawing.Point(115, 190);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(348, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(112, 47);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(93, 17);
            this.lbUser.TabIndex = 1;
            this.lbUser.Text = "Email adress:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Location = new System.Drawing.Point(112, 102);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(73, 17);
            this.lbPass.TabIndex = 2;
            this.lbPass.Text = "Password:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(210, 47);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(240, 22);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "";
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(210, 102);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(240, 22);
            this.tbPass.TabIndex = 4;
            this.tbPass.Text = "";
            // 
            // lbPoruka
            // 
            this.lbPoruka.AutoSize = true;
            this.lbPoruka.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPoruka.Location = new System.Drawing.Point(233, 243);
            this.lbPoruka.Name = "lbPoruka";
            this.lbPoruka.Size = new System.Drawing.Size(0, 17);
            this.lbPoruka.TabIndex = 6;
            // 
            // cbPass
            // 
            this.cbPass.AutoSize = true;
            this.cbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPass.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cbPass.Location = new System.Drawing.Point(329, 130);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(121, 19);
            this.cbPass.TabIndex = 8;
            this.cbPass.Text = "prikazi password";
            this.cbPass.UseVisualStyleBackColor = true;
            this.cbPass.CheckedChanged += new System.EventHandler(this.cbPass_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(558, 317);
            this.Controls.Add(this.cbPass);
            this.Controls.Add(this.lbPoruka);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbPoruka;
        public System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.CheckBox cbPass;
    }
}
