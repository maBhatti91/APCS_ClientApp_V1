using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.SuperGrid;

namespace APMS_ClientApp.Forms.Dashboard
{
    public partial class Main : Form
    {
        #region constructor
        public Main()
        {
            InitializeComponent();
            sideNav_Home.Focus();
        }
        #endregion

        #region form-events
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
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

        private void ctl_TranscationList1_Load(object sender, EventArgs e)
        {

        }
    }
}