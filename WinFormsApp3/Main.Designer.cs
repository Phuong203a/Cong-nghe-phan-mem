namespace WinFormsApp3
{
    partial class Main
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
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.Forgot_passwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(307, 89);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(149, 51);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.btnLoginClick);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(307, 215);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(149, 46);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Forgot_passwork
            // 
            this.Forgot_passwork.Location = new System.Drawing.Point(307, 336);
            this.Forgot_passwork.Name = "Forgot_passwork";
            this.Forgot_passwork.Size = new System.Drawing.Size(149, 46);
            this.Forgot_passwork.TabIndex = 2;
            this.Forgot_passwork.Text = "Forgot password";
            this.Forgot_passwork.UseVisualStyleBackColor = true;
            this.Forgot_passwork.Click += new System.EventHandler(this.btnForgotPasswordClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Forgot_passwork);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Login;
        private Button Register;
        private Button Forgot_passwork;
    }
}