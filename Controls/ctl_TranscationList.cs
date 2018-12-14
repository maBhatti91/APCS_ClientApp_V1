using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APMS_ClientApp.DataSource;

namespace APMS_ClientApp.Controls
{
    public partial class ctl_TranscationList : UserControl
    {
        #region constructor
        public ctl_TranscationList()
        {
            InitializeComponent();

            // Intializing grid control with dummy data
            grid_TransactionList.DataSource = DummyData.GetData(8);
        }
        #endregion

        #region control-events
        #endregion
    }
}
