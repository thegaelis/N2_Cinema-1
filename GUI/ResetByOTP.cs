using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GUI.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class ResetByOTP : Form
    {
        String randomCode;
        public static String to;
        private static string connectionSTR = Properties.Settings.Default.QLRPConnectionString;
        public ResetByOTP()
        {
            InitializeComponent();
        }

        private void sendOTP_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "gcvcinema@gmail.com";
            pass = "jgdmavmsfhurgmat";
            messageBody = "Mã xác nhận của bạn là: " + randomCode + " . Sao khi khôi phục mật khẩu thì mật khẩu mặt định sẽ là Abc@123";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Mã CODE khôi phục mật khẩu";
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(from,pass);

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Mã xác nhận đã được giử thành công. Xin vui lòng kiểm tra Gmail của bạn");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResetPw_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionSTR);
            try
            {
                connection.Open();
                string tk = txtUsername.Text;
                string sql = "select * from TaiKhoan where UserName = '" + tk + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                if(reader.Read())
                {
                    if (randomCode == (txtOTP.Text).ToString())
                    {
                        if (AccountDAO.ResetPassword(tk))
                        {
                            MessageBox.Show("Khôi phục mật khẩu thành công, mật khẩu mặt định: Abc@123");
                        }
                        else
                        {
                            MessageBox.Show("Khôi phục mật khẩu thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai mã xác thực");
                    }
                }
                else
                {
                    MessageBox.Show("UeserName không tồn tại, Vui lòng kiểm tra lại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }

        private void ResetByOTP_Load(object sender, EventArgs e)
        {

        }
    }
}
