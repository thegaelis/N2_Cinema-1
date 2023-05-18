using GUI.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 2) mtQL.Visible = false;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSeller frm = new frmSeller();
            frm.ShowDialog();
            this.Show();
        }

        private void đặtPhimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdminNewDesign frm = new frmAdminNewDesign();
            frm.ShowDialog();
            this.Show();
        }

        private void lấyLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountSettings frm = new frmAccountSettings(loginAccount);
            frm.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin lg = new frmLogin();
            lg.Show();
            this.Hide();
        }
    }
}