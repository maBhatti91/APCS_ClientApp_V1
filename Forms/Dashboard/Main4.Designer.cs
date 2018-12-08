namespace APMS_ClientApp.Forms.Dashboard
{
    partial class Main4
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
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor2 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame1;
            DevComponents.DotNetBar.Metro.MetroTileFrame metroTileFrame2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main4));
            this.dashboard = new DevComponents.DotNetBar.Controls.SideNav();
            this.contentPanel_Home = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.panel_tran_fotage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_RecentTransactions = new DevComponents.DotNetBar.SuperGrid.SuperGridControl();
            this.gridColumn1 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn2 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn3 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn4 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridColumn6 = new DevComponents.DotNetBar.SuperGrid.GridColumn();
            this.gridRow1 = new DevComponents.DotNetBar.SuperGrid.GridRow();
            this.gridCell6 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell7 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell8 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell9 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell10 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.label1 = new System.Windows.Forms.Label();
            this.mtp_TilePanel = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.tileContainer = new DevComponents.DotNetBar.ItemContainer();
            this.metroItem_invoices = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroItem_RFID = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.gridCell1 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell2 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell3 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell4 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell5 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            metroTileFrame1 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            metroTileFrame2 = new DevComponents.DotNetBar.Metro.MetroTileFrame();
            this.dashboard.SuspendLayout();
            this.contentPanel_Home.SuspendLayout();
            this.panel_tran_fotage.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contentPanel_Favorites.SuspendLayout();
            this.contentPanel_Collection.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
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
            this.contentPanel_Home.Controls.Add(this.panel_tran_fotage);
            this.contentPanel_Home.Controls.Add(this.mtp_TilePanel);
            this.contentPanel_Home.Controls.Add(this.labelX13);
            this.contentPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contentPanel_Home.Location = new System.Drawing.Point(96, 31);
            this.contentPanel_Home.Name = "contentPanel_Home";
            this.contentPanel_Home.Size = new System.Drawing.Size(1056, 625);
            this.contentPanel_Home.TabIndex = 2;
            // 
            // panel_tran_fotage
            // 
            this.panel_tran_fotage.Controls.Add(this.panel2);
            this.panel_tran_fotage.Controls.Add(this.panel1);
            this.panel_tran_fotage.Location = new System.Drawing.Point(14, 198);
            this.panel_tran_fotage.Name = "panel_tran_fotage";
            this.panel_tran_fotage.Size = new System.Drawing.Size(1031, 424);
            this.panel_tran_fotage.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(549, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 415);
            this.panel2.TabIndex = 19;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.grid_RecentTransactions);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 415);
            this.panel1.TabIndex = 18;
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
            this.grid_RecentTransactions.PrimaryGrid.Rows.Add(this.gridRow1);
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
            // gridRow1
            // 
            this.gridRow1.Cells.Add(this.gridCell6);
            this.gridRow1.Cells.Add(this.gridCell7);
            this.gridRow1.Cells.Add(this.gridCell8);
            this.gridRow1.Cells.Add(this.gridCell9);
            this.gridRow1.Cells.Add(this.gridCell10);
            // 
            // gridCell6
            // 
            this.gridCell6.Value = "004";
            // 
            // gridCell7
            // 
            this.gridCell7.Value = "EDR004";
            // 
            // gridCell8
            // 
            this.gridCell8.Value = "2018-04-01";
            // 
            // gridCell9
            // 
            this.gridCell9.Value = "2018-04-02";
            // 
            // gridCell10
            // 
            borderColor2.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor2.Left = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor2.Right = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor2.Top = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridCell10.CellStyles.Default.BorderColor = borderColor2;
            this.gridCell10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            this.gridCell10.Value = "Edit";
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
            // mtp_TilePanel
            // 
            this.mtp_TilePanel.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.mtp_TilePanel.BackgroundStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.mtp_TilePanel.BackgroundStyle.Class = "MetroTilePanel";
            this.mtp_TilePanel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtp_TilePanel.ContainerControlProcessDialogKey = true;
            this.mtp_TilePanel.DragDropSupport = true;
            this.mtp_TilePanel.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tileContainer,
            this.metroItem_invoices,
            this.metroItem_RFID});
            this.mtp_TilePanel.Location = new System.Drawing.Point(0, 0);
            this.mtp_TilePanel.Name = "mtp_TilePanel";
            this.mtp_TilePanel.ReserveLeftSpace = false;
            this.mtp_TilePanel.Size = new System.Drawing.Size(1056, 192);
            this.mtp_TilePanel.TabIndex = 15;
            this.mtp_TilePanel.Text = "metroTilePanel1";
            // 
            // tileContainer
            // 
            // 
            // 
            // 
            this.tileContainer.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tileContainer.MultiLine = true;
            this.tileContainer.Name = "tileContainer";
            this.tileContainer.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem1});
            // 
            // 
            // 
            this.tileContainer.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.tileContainer.TitleStyle.Class = "MetroTileGroupTitle";
            this.tileContainer.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroItem_invoices
            // 
            this.metroItem_invoices.Image = ((System.Drawing.Image)(resources.GetObject("metroItem_invoices.Image")));
            this.metroItem_invoices.ImageIndent = new System.Drawing.Point(6, 3);
            this.metroItem_invoices.ImageTextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.metroItem_invoices.Name = "metroItem_invoices";
            this.metroItem_invoices.SymbolColor = System.Drawing.Color.Empty;
            this.metroItem_invoices.Text = "<br/><br/><br/><font size=\"+8\" color=\"White\">Add Billing Invoice</font>";
            this.metroItem_invoices.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            this.metroItem_invoices.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroItem_invoices.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroItem_invoices.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroItem_invoices.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroItem_RFID
            // 
            this.metroItem_RFID.Image = ((System.Drawing.Image)(resources.GetObject("metroItem_RFID.Image")));
            this.metroItem_RFID.ImageIndent = new System.Drawing.Point(6, 3);
            this.metroItem_RFID.ImageTextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.metroItem_RFID.Name = "metroItem_RFID";
            this.metroItem_RFID.SymbolColor = System.Drawing.Color.Empty;
            this.metroItem_RFID.Text = "<br/><br/><br/><font size=\"+8\" color=\"White\">Manage RFID Tage</font>";
            this.metroItem_RFID.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue;
            this.metroItem_RFID.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroItem_RFID.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroItem_RFID.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroItem_RFID.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            // metroTileFrame1
            // 
            metroTileFrame1.ImageIndent = new System.Drawing.Point(6, 3);
            metroTileFrame1.ImageTextAlignment = System.Drawing.ContentAlignment.TopRight;
            metroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            metroTileFrame1.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            metroTileFrame1.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            metroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            metroTileFrame1.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.AutoRotateFramesInterval = 3000;
            this.metroTileItem1.Frames.Add(metroTileFrame2);
            this.metroTileItem1.Image = ((System.Drawing.Image)(resources.GetObject("metroTileItem1.Image")));
            this.metroTileItem1.ImageIndent = new System.Drawing.Point(6, 3);
            this.metroTileItem1.ImageTextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.Text = "<br/><br/><br/><font size=\"+8\" color=\"White\">Total Slots : 200</font><br/><font s" +
    "ize=\"+8\" color=\"White\">Pccupied Slots : 60</font>";
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            this.metroTileItem1.TileSize = new System.Drawing.Size(320, 150);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroTileItem1.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTileItem1.TitleTextAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTileItem1.TitleTextColor = System.Drawing.Color.Gainsboro;
            this.metroTileItem1.TitleTextFont = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroTileFrame2
            // 
            metroTileFrame2.Image = ((System.Drawing.Image)(resources.GetObject("metroTileFrame2.Image")));
            metroTileFrame2.ImageIndent = new System.Drawing.Point(6, 3);
            metroTileFrame2.ImageTextAlignment = System.Drawing.ContentAlignment.TopRight;
            metroTileFrame2.Text = "<br/><br/><br/><font size=\"+8\" color=\"White\">Total Slots : 200</font><br/><font s" +
    "ize=\"+8\" color=\"White\">Pccupied Slots : 60</font>";
            metroTileFrame2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            metroTileFrame2.TileStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            metroTileFrame2.TileStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            metroTileFrame2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Main4
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
            this.Name = "Main4";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.contentPanel_Home.ResumeLayout(false);
            this.panel_tran_fotage.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contentPanel_Favorites.ResumeLayout(false);
            this.contentPanel_Collection.ResumeLayout(false);
            this.sideNavPanel4.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Metro.MetroTilePanel mtp_TilePanel;
        private DevComponents.DotNetBar.ItemContainer tileContainer;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.Line line2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroItem_invoices;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroItem_RFID;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell1;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell2;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell3;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell4;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell5;
        private System.Windows.Forms.Panel panel_tran_fotage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.SuperGrid.SuperGridControl grid_RecentTransactions;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn1;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn2;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn3;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn4;
        private DevComponents.DotNetBar.SuperGrid.GridColumn gridColumn6;
        private DevComponents.DotNetBar.SuperGrid.GridRow gridRow1;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell6;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell7;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell8;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell9;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell10;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
    }
}

