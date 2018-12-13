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

            //int scrrenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            //int scrrenWidth = Screen.PrimaryScreen.WorkingArea.Width;

            //mtp_TilePanel.Left = (this.ClientSize.Width - mtp_TilePanel.Width) / 2;
            //panel_tran_fotage.Left = (this.ClientSize.Width - panel_tran_fotage.Width) / 2;

            //for (int i = 0; i < 15; i++)
            //{
            //    var dummyRow = new GridRow("001", "ACS001", "2018-12-01 08:30 AM", "2018-12-01 09:30 AM", "Edit");
            //    this.grid_RecentTransactions.PrimaryGrid.Rows.Add(dummyRow);
            //}
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