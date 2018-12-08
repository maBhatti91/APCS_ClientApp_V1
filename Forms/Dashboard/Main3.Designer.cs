namespace APMS_ClientApp.Forms.Dashboard
{
    partial class Main3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main3));
            this.dashboard = new DevComponents.DotNetBar.Controls.SideNav();
            this.contentPanel_Home = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.contentPanel_Favorites = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.contentPanel_Collection = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNav_MainMenu = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNav_Home = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Collection = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Favorites = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Setting = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.styleManager_Dasbord = new DevComponents.DotNetBar.StyleManager(this.components);
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_RecentTransactions = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridCell1 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell2 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell3 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell4 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell5 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dashboard.SuspendLayout();
            this.contentPanel_Home.SuspendLayout();
            this.contentPanel_Favorites.SuspendLayout();
            this.contentPanel_Collection.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.contentPanel_Home);
            this.dashboard.Controls.Add(this.contentPanel_Favorites);
            this.dashboard.Controls.Add(this.contentPanel_Collection);
            this.dashboard.Controls.Add(this.sideNavPanel4);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard.EnableClose = false;
            this.dashboard.EnableMaximize = false;
            this.dashboard.EnableSplitter = false;
            this.dashboard.ForeColor = System.Drawing.Color.Black;
            this.dashboard.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNav_MainMenu,
            this.separator1,
            this.sideNav_Home,
            this.sideNav_Collection,
            this.sideNav_Favorites,
            this.sideNav_Setting});
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(1);
            this.dashboard.Size = new System.Drawing.Size(1153, 657);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "DashBoard";
            // 
            // contentPanel_Home
            // 
            this.contentPanel_Home.AutoScroll = true;
            this.contentPanel_Home.BackColor = System.Drawing.Color.Gainsboro;
            this.contentPanel_Home.Controls.Add(this.panel2);
            this.contentPanel_Home.Controls.Add(this.panel1);
            this.contentPanel_Home.Controls.Add(this.metroTilePanel1);
            this.contentPanel_Home.Controls.Add(this.labelX13);
            this.contentPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contentPanel_Home.Location = new System.Drawing.Point(96, 31);
            this.contentPanel_Home.Name = "contentPanel_Home";
            this.contentPanel_Home.Size = new System.Drawing.Size(1056, 625);
            this.contentPanel_Home.TabIndex = 2;
            // 
            // metroTilePanel1
            // 
            this.metroTilePanel1.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.metroTileItem2,
            this.metroTileItem3});
            this.metroTilePanel1.Location = new System.Drawing.Point(0, 0);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ReserveLeftSpace = false;
            this.metroTilePanel1.Size = new System.Drawing.Size(1056, 192);
            this.metroTilePanel1.TabIndex = 15;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.MultiLine = true;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1});
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem1.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelX13
            // 
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(0, 0);
            this.labelX13.Name = "labelX13";
            this.labelX13.Size = new System.Drawing.Size(0, 0);
            this.labelX13.TabIndex = 14;
            // 
            // contentPanel_Favorites
            // 
            this.contentPanel_Favorites.Controls.Add(this.line2);
            this.contentPanel_Favorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Favorites.Location = new System.Drawing.Point(1, 1);
            this.contentPanel_Favorites.Name = "contentPanel_Favorites";
            this.contentPanel_Favorites.Size = new System.Drawing.Size(1254, 742);
            this.contentPanel_Favorites.TabIndex = 10;
            this.contentPanel_Favorites.Visible = false;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(10, 11);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(127, 10);
            this.line2.TabIndex = 4;
            this.line2.Text = "line2";
            // 
            // contentPanel_Collection
            // 
            this.contentPanel_Collection.Controls.Add(this.line3);
            this.contentPanel_Collection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Collection.Location = new System.Drawing.Point(1, 1);
            this.contentPanel_Collection.Name = "contentPanel_Collection";
            this.contentPanel_Collection.Size = new System.Drawing.Size(1254, 742);
            this.contentPanel_Collection.TabIndex = 6;
            this.contentPanel_Collection.Visible = false;
            // 
            // line3
            // 
            this.line3.Location = new System.Drawing.Point(10, 11);
            this.line3.Name = "line3";
            this.line3.Size = new System.Drawing.Size(236, 10);
            this.line3.TabIndex = 4;
            this.line3.Text = "line3";
            // 
            // sideNavPanel4
            // 
            this.sideNavPanel4.AutoScroll = true;
            this.sideNavPanel4.Controls.Add(this.line1);
            this.sideNavPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel4.Location = new System.Drawing.Point(96, 31);
            this.sideNavPanel4.Name = "sideNavPanel4";
            this.sideNavPanel4.Size = new System.Drawing.Size(856, 373);
            this.sideNavPanel4.TabIndex = 14;
            this.sideNavPanel4.Visible = false;
            // 
            // line1
            // 
            this.line1.Location = new System.Drawing.Point(10, 27);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(236, 10);
            this.line1.TabIndex = 3;
            this.line1.Text = "line1";
            // 
            // sideNav_MainMenu
            // 
            this.sideNav_MainMenu.IsSystemMenu = true;
            this.sideNav_MainMenu.Name = "sideNav_MainMenu";
            this.sideNav_MainMenu.Symbol = "";
            this.sideNav_MainMenu.Text = "Menu";
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNav_Home
            // 
            this.sideNav_Home.Checked = true;
            this.sideNav_Home.Name = "sideNav_Home";
            this.sideNav_Home.Panel = this.contentPanel_Home;
            this.sideNav_Home.Symbol = "";
            this.sideNav_Home.Text = "Home";
            // 
            // sideNav_Collection
            // 
            this.sideNav_Collection.Name = "sideNav_Collection";
            this.sideNav_Collection.Panel = this.contentPanel_Collection;
            this.sideNav_Collection.Symbol = "";
            this.sideNav_Collection.Text = "Collection";
            // 
            // sideNav_Favorites
            // 
            this.sideNav_Favorites.Name = "sideNav_Favorites";
            this.sideNav_Favorites.Panel = this.contentPanel_Favorites;
            this.sideNav_Favorites.Symbol = "";
            this.sideNav_Favorites.Text = "Favorites";
            // 
            // sideNav_Setting
            // 
            this.sideNav_Setting.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.sideNav_Setting.Name = "sideNav_Setting";
            this.sideNav_Setting.Panel = this.sideNavPanel4;
            this.sideNav_Setting.Symbol = "";
            this.sideNav_Setting.Text = "Settings";
            // 
            // styleManager_Dasbord
            // 
            this.styleManager_Dasbord.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager_Dasbord.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(63)))), ((int)(((byte)(84))))));
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem2.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem3.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.grid_RecentTransactions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 415);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recent Transactions";
            // 
            // grid_RecentTransactions
            // 
            this.grid_RecentTransactions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grid_RecentTransactions.FilterExprColors.SysFunction = System.Drawing.Color.DarkRed;
            this.grid_RecentTransactions.ForeColor = System.Drawing.Color.Black;
            this.grid_RecentTransactions.Location = new System.Drawing.Point(0, 56);
            this.grid_RecentTransactions.Name = "grid_RecentTransactions";
            // 
            // 
            // 
            this.grid_RecentTransactions.PrimaryGrid.Columns.Add(this.gridColumn1);
            this.grid_RecentTransactions.PrimaryGrid.Columns.Add(this.gridColumn2);
            this.grid_RecentTransactions.PrimaryGrid.Columns.Add(this.gridColumn3);
            this.grid_RecentTransactions.PrimaryGrid.Columns.Add(this.gridColumn4);
            this.grid_RecentTransactions.PrimaryGrid.Columns.Add(this.gridColumn6);
            this.grid_RecentTransactions.PrimaryGrid.GridLines = DevComponents.DotNetBar.SuperGrid.GridLines.Horizontal;
            this.grid_RecentTransactions.Size = new System.Drawing.Size(538, 359);
            this.grid_RecentTransactions.TabIndex = 1;
            this.grid_RecentTransactions.Text = "superGridControl1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Name = "Transaction Id";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Name = "Vehicle Number";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Name = "CheckIn Time";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "CheckOut Time";
            // 
            // gridColumn6
            // 
            this.gridColumn6.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            this.gridColumn6.Name = "";
            // 
            // gridCell1
            // 
            this.gridCell1.Value = "001";
            // 
            // gridCell2
            // 
            this.gridCell2.Value = "ACS001";
            // 
            // gridCell3
            // 
            this.gridCell3.Value = "2018-02-01";
            // 
            // gridCell4
            // 
            this.gridCell4.Value = "2018-02-01";
            // 
            // gridCell5
            // 
            this.gridCell5.Value = "Edit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(566, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 415);
            this.panel2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "CCTV Cam";
            // 
            // Main3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1153, 657);
            this.Controls.Add(this.dashboard);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1169, 696);
            this.Name = "Main3";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.contentPanel_Home.ResumeLayout(false);
            this.contentPanel_Favorites.ResumeLayout(false);
            this.contentPanel_Collection.ResumeLayout(false);
            this.sideNavPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SideNav dashboard;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNav_MainMenu;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNav_Home;
        private DevComponents.DotNetBar.StyleManager styleManager_Dasbord;
        private DevComponents.DotNetBar.Controls.SideNavPanel contentPanel_Collection;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel4;
        private DevComponents.DotNetBar.Controls.SideNavPanel contentPanel_Favorites;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNav_Collection;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNav_Favorites;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNav_Setting;
        private DevComponents.DotNetBar.Controls.Line line1;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.SideNavPanel contentPanel_Home;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid_RecentTransactions;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell1;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell2;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell3;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell4;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

