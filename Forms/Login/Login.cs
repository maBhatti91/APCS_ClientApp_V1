using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using APMS_ClientApp.Forms.Dashboard;

namespace APMS_ClientApp.Forms
{
    public partial class Login : Form
    {
        #region constructor
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region controls-events
        private void btn_login_MouseDown(object sender, MouseEventArgs e)
        {
            txt_Password.PasswordChar = '\0';
        }
        private void btn_login_MouseUp(object sender, MouseEventArgs e)
        {
            txt_Password.PasswordChar = '*';
        }
        private void lbl_LostPassword_MouseEnter(object sender, EventArgs e)
        {
            lbl_LostPassword.Font = new Font(lbl_LostPassword.Font.Name, lbl_LostPassword.Font.SizeInPoints, FontStyle.Underline);
        }
        private void lbl_LostPassword_MouseLeave(object sender, EventArgs e)
        {
            lbl_LostPassword.Font = new Font(lbl_LostPassword.Font.Name, lbl_LostPassword.Font.SizeInPoints, FontStyle.Regular);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            //Main dashboardScreen = new Main();
            Main4 dashboardScreen = new Main4();
            dashboardScreen.Show();
            this.Hide();
        }
        #endregion
    }
}
