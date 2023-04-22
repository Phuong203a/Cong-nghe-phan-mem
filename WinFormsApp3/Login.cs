using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnLogin_Click (object sender, EventArgs e)
        {
            //lay gia tri textbox
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPass.Text.Trim();


            //lay 2 bien 
            UserModel userModel = new UserModel();
            userModel.email = email;
            userModel.password = password;

            //ton tai email khon
            SqlConnection sqlConnection = ConnectionSingleton.GetConnection();
            bool isExisted = userModel.CheckIfUserExists(sqlConnection);
            if (isExisted == false)
            {
                MessageBox.Show("Email không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // ktra email va mat khau dung khong
            bool isLogin = userModel.CheckIfUserLogin(sqlConnection);
            if (isLogin == false)
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Main formMain = new Main();
            formMain.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}