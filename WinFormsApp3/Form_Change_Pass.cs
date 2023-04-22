using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form_Change_Pass : Form
    {
        public Form_Change_Pass()
        {
            InitializeComponent();
            comboBoxQuestionPass.Items.Add("Bạn sinh ngày nào?");
            comboBoxQuestionPass.Items.Add("Bạn có người yêu chưa?");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



            string email = textBoxEmail.Text.Trim();
            string newPassword = textBoxNewPass.Text.Trim();
            string reNewpassword = textBoxReNewPass.Text.Trim();
            string answer = textBoxAnswerPass.Text.Trim();
            if ( newPassword.Equals("") || reNewpassword.Equals("") || email.Equals("")|| answer.Equals(""))
            {
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxQuestionPass.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn Question.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string question = comboBoxQuestionPass.Items[comboBoxQuestionPass.SelectedIndex].ToString();





            UserModel userModel = new UserModel();

            userModel.email = email;
            userModel.password = newPassword;
            userModel.question = question;
            userModel.answer= answer;

            SqlConnection sqlConnection = ConnectionSingleton.GetConnection();
            bool isExisted = userModel.CheckIfUserExists(sqlConnection);
            if (isExisted == false)
            { 

                
                    MessageBox.Show("Tài khoản không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                bool result = newPassword.Equals(reNewpassword);
                if (!newPassword.Equals(reNewpassword))
                {
                    MessageBox.Show("Mật khẩu nhập lại không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            bool isAnswer = userModel.CheckIfUserQuestionChangePass(sqlConnection);
            if (isAnswer == false)
            {


                MessageBox.Show("Answer or Question false", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            userModel.UpdateUser(sqlConnection);
                sqlConnection.Close();
                MessageBox.Show("Bạn đã đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);



                Main formMain = new Main();
                formMain.Show();
                this.Hide();

            


        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

            // lay gia tri textbox
            // ktra email xac thuc.neu k ton tai thi hien thong bao khong ton tai email nay. neu ton tai thi tiep tuc 
            //ktra new password so sanh xem giong new pass da nhap khong. khong dung thi hien thi thong bao nhap lai
            // Update password moi cua email


