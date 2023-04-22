namespace WinFormsApp3
{
    partial class Form_Register
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
            System.Windows.Forms.GroupBox Gr_Register;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQuestion = new System.Windows.Forms.ComboBox();
            this.Lable_Email = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxNumberPhone = new System.Windows.Forms.TextBox();
            this.Lable_phone = new System.Windows.Forms.Label();
            this.Regisname = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Lable_BD = new System.Windows.Forms.Label();
            this.lnb_Password = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.First_Name = new System.Windows.Forms.Label();
            this.Last_Name = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Gr_Register = new System.Windows.Forms.GroupBox();
            Gr_Register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Gr_Register
            // 
            Gr_Register.Controls.Add(this.pictureBox1);
            Gr_Register.Controls.Add(this.label2);
            Gr_Register.Controls.Add(this.textBoxAnswer);
            Gr_Register.Controls.Add(this.label1);
            Gr_Register.Controls.Add(this.comboBoxQuestion);
            Gr_Register.Controls.Add(this.Lable_Email);
            Gr_Register.Controls.Add(this.textBoxEmail);
            Gr_Register.Controls.Add(this.textBoxNumberPhone);
            Gr_Register.Controls.Add(this.Lable_phone);
            Gr_Register.Controls.Add(this.Regisname);
            Gr_Register.Controls.Add(this.dateTimePicker1);
            Gr_Register.Controls.Add(this.Lable_BD);
            Gr_Register.Controls.Add(this.lnb_Password);
            Gr_Register.Controls.Add(this.textBoxPass);
            Gr_Register.Controls.Add(this.textBoxLastName);
            Gr_Register.Controls.Add(this.textBoxFirstName);
            Gr_Register.Controls.Add(this.First_Name);
            Gr_Register.Controls.Add(this.Last_Name);
            Gr_Register.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Gr_Register.ForeColor = System.Drawing.Color.Black;
            Gr_Register.Location = new System.Drawing.Point(73, 53);
            Gr_Register.Name = "Gr_Register";
            Gr_Register.Size = new System.Drawing.Size(852, 679);
            Gr_Register.TabIndex = 0;
            Gr_Register.TabStop = false;
            Gr_Register.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(285, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 255);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxAnswer.Location = new System.Drawing.Point(480, 219);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(200, 22);
            this.textBoxAnswer.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Question";
            // 
            // comboBoxQuestion
            // 
            this.comboBoxQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuestion.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.comboBoxQuestion.FormattingEnabled = true;
            this.comboBoxQuestion.Location = new System.Drawing.Point(155, 219);
            this.comboBoxQuestion.Name = "comboBoxQuestion";
            this.comboBoxQuestion.Size = new System.Drawing.Size(200, 24);
            this.comboBoxQuestion.TabIndex = 14;
            this.comboBoxQuestion.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuestion_SelectedIndexChanged);
            // 
            // Lable_Email
            // 
            this.Lable_Email.AutoSize = true;
            this.Lable_Email.Location = new System.Drawing.Point(377, 162);
            this.Lable_Email.Name = "Lable_Email";
            this.Lable_Email.Size = new System.Drawing.Size(42, 17);
            this.Lable_Email.TabIndex = 12;
            this.Lable_Email.Text = "Email";
            this.Lable_Email.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxEmail.Location = new System.Drawing.Point(480, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 22);
            this.textBoxEmail.TabIndex = 11;
            // 
            // textBoxNumberPhone
            // 
            this.textBoxNumberPhone.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxNumberPhone.Location = new System.Drawing.Point(480, 100);
            this.textBoxNumberPhone.Name = "textBoxNumberPhone";
            this.textBoxNumberPhone.Size = new System.Drawing.Size(200, 22);
            this.textBoxNumberPhone.TabIndex = 10;
            // 
            // Lable_phone
            // 
            this.Lable_phone.AutoSize = true;
            this.Lable_phone.Location = new System.Drawing.Point(377, 108);
            this.Lable_phone.Name = "Lable_phone";
            this.Lable_phone.Size = new System.Drawing.Size(101, 17);
            this.Lable_phone.TabIndex = 9;
            this.Lable_phone.Text = "Number Phone";
            // 
            // Regisname
            // 
            this.Regisname.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Regisname.ForeColor = System.Drawing.Color.Black;
            this.Regisname.Location = new System.Drawing.Point(307, 570);
            this.Regisname.Name = "Regisname";
            this.Regisname.Size = new System.Drawing.Size(202, 64);
            this.Regisname.TabIndex = 8;
            this.Regisname.Text = "Register";
            this.Regisname.UseVisualStyleBackColor = true;
            this.Regisname.Click += new System.EventHandler(this.btnRegister);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Lable_BD
            // 
            this.Lable_BD.AutoSize = true;
            this.Lable_BD.Location = new System.Drawing.Point(68, 103);
            this.Lable_BD.Name = "Lable_BD";
            this.Lable_BD.Size = new System.Drawing.Size(66, 17);
            this.Lable_BD.TabIndex = 6;
            this.Lable_BD.Text = "Birth Day";
            // 
            // lnb_Password
            // 
            this.lnb_Password.AutoSize = true;
            this.lnb_Password.Location = new System.Drawing.Point(68, 159);
            this.lnb_Password.Name = "lnb_Password";
            this.lnb_Password.Size = new System.Drawing.Size(66, 17);
            this.lnb_Password.TabIndex = 5;
            this.lnb_Password.Text = "Password";
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxPass.Location = new System.Drawing.Point(155, 159);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(200, 25);
            this.textBoxPass.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxLastName.Location = new System.Drawing.Point(480, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 22);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBoxFirstName.Location = new System.Drawing.Point(155, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 22);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // First_Name
            // 
            this.First_Name.AutoSize = true;
            this.First_Name.Location = new System.Drawing.Point(377, 52);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(73, 17);
            this.First_Name.TabIndex = 1;
            this.First_Name.Text = "Last Name";
            // 
            // Last_Name
            // 
            this.Last_Name.AutoSize = true;
            this.Last_Name.Location = new System.Drawing.Point(68, 52);
            this.Last_Name.Name = "Last_Name";
            this.Last_Name.Size = new System.Drawing.Size(75, 17);
            this.Last_Name.TabIndex = 0;
            this.Last_Name.Text = "First Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 764);
            this.Controls.Add(Gr_Register);
            this.Name = "Form_Register";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Register_Load);
            Gr_Register.ResumeLayout(false);
            Gr_Register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox Gr_Register;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label First_Name;
        private Label Last_Name;
        private Label Lable_Email;
        private TextBox textBoxEmail;
        private TextBox textBoxNumberPhone;
        private Label Lable_phone;
        private Button Regisname;
        private DateTimePicker dateTimePicker1;
        private Label Lable_BD;
        private Label lnb_Password;
        private TextBox textBoxPass;
        private TextBox textBoxAnswer;
        private Label label1;
        private ComboBox comboBoxQuestion;
        private Label label2;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
    }
}