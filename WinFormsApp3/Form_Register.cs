using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WinFormsApp3
{
    public partial class Form_Register : Form
    {
        private string filePath ="";
        
        public Form_Register()
        {
            InitializeComponent();
            comboBoxQuestion.Items.Add("Bạn sinh ngày nào?");
            comboBoxQuestion.Items.Add("Bạn có người yêu chưa?");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister(object sender, EventArgs e)
        {

                string firstName = textBoxFirstName.Text.Trim();
                string birthDay = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                string lastName = textBoxLastName.Text.Trim();
                string numberPhone = textBoxNumberPhone.Text.Trim();
                string email = textBoxEmail.Text.Trim();
                string password = textBoxPass.Text.Trim();
                string answer = textBoxAnswer.Text.Trim();
            if (firstName.Equals("")|| birthDay.Equals("")||lastName.Equals("") || numberPhone.Equals("") || email.Equals("") || password.Equals("") || answer.Equals(""))
            {
                MessageBox.Show("Bạn hãy điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxQuestion.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn Question.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string question = comboBoxQuestion.Items[comboBoxQuestion.SelectedIndex].ToString();



            UserModel userModel = new UserModel();
                userModel.firstName = firstName;
                userModel.birthDay = birthDay;
                userModel.lastName = lastName;
                userModel.numberPhone = numberPhone;
                userModel.email = email;
                userModel.password = password;
                userModel.answer = answer;
                userModel.question = question;
                userModel.path = filePath;


            SqlConnection sqlConnection = ConnectionSingleton.GetConnection();
                bool isExisted = userModel.CheckIfUserExists(sqlConnection);
                if(isExisted == true)
                {
                    MessageBox.Show("Tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                

                userModel.InsertUser(sqlConnection);
                sqlConnection.Close();
          
                MessageBox.Show("Bạn đã đăng kí thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Main formMain= new Main();
                formMain.Show();
                this.Hide();
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form_Register_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(filePath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
