using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnForgotPasswordClick(object sender, EventArgs e)
        {
            Form_Change_Pass formForgotPass = new Form_Change_Pass();
            formForgotPass.Show();
            this.Hide();
        }

       

        private void btnLoginClick(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            formLogin.Show();
            this.Hide();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form_Register formRegister = new Form_Register();
            formRegister.Show();
            this.Hide();
        }
    }
}
