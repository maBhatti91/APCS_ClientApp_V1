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
    public partial class Main2 : OfficeForm
    {
        #region constructor
        public Main2()
        {
            InitializeComponent();

            int scrrenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int scrrenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            this.ClientSize = new Size(scrrenWidth, scrrenHeight);

            contentPanel_Home.Location = new Point(
                    this.ClientSize.Width / 2 - contentPanel_Home.Size.Width / 2,
                    this.ClientSize.Height / 2 - contentPanel_Home.Size.Height / 2);
            contentPanel_Home.Anchor = AnchorStyles.None;
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