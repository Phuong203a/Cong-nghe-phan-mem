using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WinFormsApp3
{
    internal class UserModel
    {

        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string birthDay { get; set; }
        public string numberPhone { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string path { get; set; }



        public UserModel() { }

        public UserModel(string email, string firstName, string lastName, string password,
            string birthDay, string numberPhone, string newPassword, string question,
            string answer, string path)
        {
            this.email = email;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.birthDay = birthDay;
            this.numberPhone = numberPhone;
            this.question = question;
            this.answer = answer;
            this.path = path;

        }

        public void InsertUser(SqlConnection connection)
        {
            string query = "INSERT INTO users (email, first_name, last_name, password,birth_day,phone_number,answer,question,Image) " +
                           "VALUES (@Email, @FirstName, @LastName,@Password,@BirthDay, @PhoneNumber, @Answer, @Question, @Image)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);
                command.Parameters.AddWithValue("@FirstName", this.firstName);
                command.Parameters.AddWithValue("@LastName", this.lastName);
                command.Parameters.AddWithValue("@Password", this.password);
                command.Parameters.AddWithValue("@BirthDay", this.birthDay);
                command.Parameters.AddWithValue("@PhoneNumber", this.numberPhone);
                command.Parameters.AddWithValue("@Answer", this.answer);
                command.Parameters.AddWithValue("@Question", this.question);
                command.Parameters.AddWithValue("@Image", this.path);

                command.ExecuteNonQuery();
            }
        }
      
        public void UpdateUser(SqlConnection connection)
        {
            string query = "UPDATE users SET password = @Password WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);
                command.Parameters.AddWithValue("@Password", this.password);
              

                command.ExecuteNonQuery();
            }
        }

        public bool CheckIfUserExists(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool CheckIfUserLogin(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email and password = @Password";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);
                command.Parameters.AddWithValue("@Password", this.password);
                

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool CheckIfNewPasswordIsSameAsOld(SqlConnection connection)
        {
            string query = "SELECT password FROM users WHERE email = @Email and question=@question and answer=@answer";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);
                command.Parameters.AddWithValue("@Question", this.question);
                command.Parameters.AddWithValue("@answer", this.answer);

                string oldPassword = (string)command.ExecuteScalar();
                return this.password == oldPassword;


            }
        }
        public bool CheckIfUserQuestionChangePass(SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM users WHERE email = @Email and question=@Question and answer=@Answer";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", this.email);
                command.Parameters.AddWithValue("@Question", this.question);
                command.Parameters.AddWithValue("@Answer",this.answer);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


    }
}
        
    
