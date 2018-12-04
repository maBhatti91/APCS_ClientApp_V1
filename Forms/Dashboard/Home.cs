using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace APMS_ClientApp.Forms.Dashboard
{
    public partial class Home : OfficeForm
    {
        #region constructor
        public Home()
        {
            InitializeComponent(); 
        }
        #endregion

        #region form-events
        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred.");
            }
        }
        #endregion

    }
}