namespace WinFormsApp3
{
    partial class Form_Change_Pass
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxQuestionPass = new System.Windows.Forms.ComboBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxReNewPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.textBoxAnswerPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxAnswerPass);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxQuestionPass);
            this.groupBox1.Controls.Add(this.textBoxNewPass);
            this.groupBox1.Controls.Add(this.textBoxReNewPass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnChangePass);
            this.groupBox1.Location = new System.Drawing.Point(47, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forgot your Password";
            this.groupBox1.UseCompatibleTextRendering = true;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chose question";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // comboBoxQuestionPass
            // 
            this.comboBoxQuestionPass.FormattingEnabled = true;
            this.comboBoxQuestionPass.Location = new System.Drawing.Point(501, 66);
            this.comboBoxQuestionPass.Name = "comboBoxQuestionPass";
            this.comboBoxQuestionPass.Size = new System.Drawing.Size(189, 23);
            this.comboBoxQuestionPass.TabIndex = 10;
            this.comboBoxQuestionPass.Text = "Chose";
            this.comboBoxQuestionPass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Location = new System.Drawing.Point(146, 135);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.Size = new System.Drawing.Size(189, 23);
            this.textBoxNewPass.TabIndex = 9;
            // 
            // textBoxReNewPass
            // 
            this.textBoxReNewPass.Location = new System.Drawing.Point(146, 202);
            this.textBoxReNewPass.Name = "textBoxReNewPass";
            this.textBoxReNewPass.Size = new System.Drawing.Size(189, 23);
            this.textBoxReNewPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Re new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(146, 61);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(189, 23);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Location = new System.Drawing.Point(276, 285);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(113, 23);
            this.btnChangePass.TabIndex = 0;
            this.btnChangePass.Text = "Change password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAnswerPass
            // 
            this.textBoxAnswerPass.Location = new System.Drawing.Point(501, 143);
            this.textBoxAnswerPass.Name = "textBoxAnswerPass";
            this.textBoxAnswerPass.Size = new System.Drawing.Size(189, 23);
            this.textBoxAnswerPass.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Answer";
            // 
            // Form_Change_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Change_Pass";
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxNewPass;
        private TextBox textBoxReNewPass;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnChangePass;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label5;
        private ComboBox comboBoxQuestionPass;
        private Label label6;
        private TextBox textBoxAnswerPass;
    }
}