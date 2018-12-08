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
    public partial class Main3 : OfficeForm
    {
        #region constructor
        public Main3()
        {
            InitializeComponent();

            int scrrenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int scrrenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            //this.ClientSize = new Size(scrrenWidth, scrrenHeight);


            for (int i = 0; i < 15; i++)
            {
                var dummyRow = new GridRow("001", "ACS001", "2018-12-01 08:30 AM", "2018-12-01 09:30 AM", "Edit");
                this.grid_RecentTransactions.PrimaryGrid.Rows.Add(dummyRow);
            }
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