using GUI.DAO;
using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class frmAccountSettings : Form
    {
        Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public frmAccountSettings(Account account)
        {
            InitializeComponent();

            LoginAccount = account;
        }

        void ChangeAccount(Account account)
        {
            txtStaffID.Text = account.StaffID.ToString();
            txtUsername.Text = account.UserName.ToString();
        }

        void ApplyChanges()
        {
            string username = txtUsername.Text;
            string newPass = txtNewPass.Text;
            string reEnterPass = txtReEnter.Text;
            string confirmPass = txtConfirmPass.Text;

            if (newPass != reEnterPass)
            {
                MessageBox.Show("Hai mật khẩu mới chưa trùng nhau!");
            }
            else if (newPass == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.");
            }
            else
            {
                if (AccountDAO.UpdatePasswordForAccount(username, confirmPass, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool ValidatePassword(string password)
        {
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]+");
            if (password.Length < 6)
            {
                return false;
            }

            if (!password.Any(char.IsUpper))
            {
                return false;
            }

            if (!password.Any(char.IsLower))
            {
                return false;
            }

            if (!hasSymbols.IsMatch(password))
            {
                return false;
            }

            return true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string newpass = txtNewPass.Text;
            if(ValidatePassword(newpass))
            {
                ApplyChanges();
            }
            else 
            {
                MessageBox.Show("Mật khẩu phải ít nhất 6 kí tự và bắc buộc phải có ít nhất một kí tự thường, hoa, đặt biệt");
            }
        }
    }
}
