namespace APMS_ClientApp.Forms.Dashboard
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dashboard = new DevComponents.DotNetBar.Controls.SideNav();
            this.contentPanel_Favorites = new DevComponents.DotNetBar.Controls.SideNavPanel();
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
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.metroTilePanel1 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.metroTileItem1 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTilePanel2 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.metroTileItem2 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTilePanel3 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.metroTileItem4 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem3 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.metroTilePanel4 = new DevComponents.DotNetBar.Metro.MetroTilePanel();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer4 = new DevComponents.DotNetBar.ItemContainer();
            this.contentPanel_Home = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.metroTileItem6 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.metroTileItem7 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.dashboard.SuspendLayout();
            this.contentPanel_Favorites.SuspendLayout();
            this.contentPanel_Collection.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
            this.contentPanel_Home.SuspendLayout();
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
            this.dashboard.Size = new System.Drawing.Size(1256, 744);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "DashBoard";
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
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(10, 11);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(127, 10);
            this.line2.TabIndex = 4;
            this.line2.Text = "line2";
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
            // metroTilePanel1
            // 
            // 
            // 
            // 
            this.metroTilePanel1.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel1.ContainerControlProcessDialogKey = true;
            this.metroTilePanel1.DragDropSupport = true;
            this.metroTilePanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.metroTilePanel1.Location = new System.Drawing.Point(97, 32);
            this.metroTilePanel1.Name = "metroTilePanel1";
            this.metroTilePanel1.ReserveLeftSpace = false;
            this.metroTilePanel1.Size = new System.Drawing.Size(416, 364);
            this.metroTilePanel1.TabIndex = 15;
            this.metroTilePanel1.Text = "metroTilePanel1";
            // 
            // metroTileItem1
            // 
            this.metroTileItem1.Name = "metroTileItem1";
            this.metroTileItem1.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem1.TileSize = new System.Drawing.Size(380, 320);
            // 
            // 
            // 
            this.metroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
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
            // metroTilePanel2
            // 
            // 
            // 
            // 
            this.metroTilePanel2.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel2.ContainerControlProcessDialogKey = true;
            this.metroTilePanel2.DragDropSupport = true;
            this.metroTilePanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer2});
            this.metroTilePanel2.ItemSpacing = 10;
            this.metroTilePanel2.Location = new System.Drawing.Point(495, 35);
            this.metroTilePanel2.Name = "metroTilePanel2";
            this.metroTilePanel2.ReserveLeftSpace = false;
            this.metroTilePanel2.Size = new System.Drawing.Size(416, 187);
            this.metroTilePanel2.TabIndex = 16;
            this.metroTilePanel2.Text = "metroTilePanel2";
            // 
            // metroTileItem2
            // 
            this.metroTileItem2.Name = "metroTileItem2";
            this.metroTileItem2.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem2.TileSize = new System.Drawing.Size(380, 150);
            // 
            // 
            // 
            this.metroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.MultiLine = true;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem2});
            // 
            // 
            // 
            this.itemContainer2.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTilePanel3
            // 
            // 
            // 
            // 
            this.metroTilePanel3.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel3.ContainerControlProcessDialogKey = true;
            this.metroTilePanel3.DragDropSupport = true;
            this.metroTilePanel3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer3,
            this.metroTileItem4});
            this.metroTilePanel3.ItemSpacing = 10;
            this.metroTilePanel3.Location = new System.Drawing.Point(494, 202);
            this.metroTilePanel3.Name = "metroTilePanel3";
            this.metroTilePanel3.ReserveLeftSpace = false;
            this.metroTilePanel3.Size = new System.Drawing.Size(416, 183);
            this.metroTilePanel3.TabIndex = 17;
            this.metroTilePanel3.Text = "metroTilePanel3";
            // 
            // metroTileItem4
            // 
            this.metroTileItem4.Name = "metroTileItem4";
            this.metroTileItem4.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem4.TileSize = new System.Drawing.Size(185, 150);
            // 
            // 
            // 
            this.metroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem3
            // 
            this.metroTileItem3.Name = "metroTileItem3";
            this.metroTileItem3.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem3.TileSize = new System.Drawing.Size(186, 150);
            // 
            // 
            // 
            this.metroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.MultiLine = true;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem3});
            // 
            // 
            // 
            this.itemContainer3.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTilePanel4
            // 
            // 
            // 
            // 
            this.metroTilePanel4.BackgroundStyle.Class = "MetroTilePanel";
            this.metroTilePanel4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroTilePanel4.ContainerControlProcessDialogKey = true;
            this.metroTilePanel4.DragDropSupport = true;
            this.metroTilePanel4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer4,
            this.metroTileItem6,
            this.metroTileItem7});
            this.metroTilePanel4.ItemSpacing = 10;
            this.metroTilePanel4.Location = new System.Drawing.Point(97, 367);
            this.metroTilePanel4.Name = "metroTilePanel4";
            this.metroTilePanel4.ReserveLeftSpace = false;
            this.metroTilePanel4.Size = new System.Drawing.Size(814, 187);
            this.metroTilePanel4.TabIndex = 18;
            this.metroTilePanel4.Text = "metroTilePanel4";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem5.TileSize = new System.Drawing.Size(186, 150);
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // itemContainer4
            // 
            // 
            // 
            // 
            this.itemContainer4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer4.MultiLine = true;
            this.itemContainer4.Name = "itemContainer4";
            this.itemContainer4.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.metroTileItem5});
            // 
            // 
            // 
            this.itemContainer4.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer4.TitleStyle.Class = "MetroTileGroupTitle";
            this.itemContainer4.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // contentPanel_Home
            // 
            this.contentPanel_Home.AutoScroll = true;
            this.contentPanel_Home.Controls.Add(this.metroTilePanel4);
            this.contentPanel_Home.Controls.Add(this.metroTilePanel3);
            this.contentPanel_Home.Controls.Add(this.metroTilePanel2);
            this.contentPanel_Home.Controls.Add(this.metroTilePanel1);
            this.contentPanel_Home.Controls.Add(this.labelX13);
            this.contentPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Home.Location = new System.Drawing.Point(1, 1);
            this.contentPanel_Home.Name = "contentPanel_Home";
            this.contentPanel_Home.Size = new System.Drawing.Size(1254, 742);
            this.contentPanel_Home.TabIndex = 2;
            // 
            // metroTileItem6
            // 
            this.metroTileItem6.Name = "metroTileItem6";
            this.metroTileItem6.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem6.TileSize = new System.Drawing.Size(386, 150);
            // 
            // 
            // 
            this.metroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // metroTileItem7
            // 
            this.metroTileItem7.Name = "metroTileItem7";
            this.metroTileItem7.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            this.metroTileItem7.TileSize = new System.Drawing.Size(186, 150);
            // 
            // 
            // 
            this.metroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1256, 744);
            this.Controls.Add(this.dashboard);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.contentPanel_Favorites.ResumeLayout(false);
            this.contentPanel_Collection.ResumeLayout(false);
            this.sideNavPanel4.ResumeLayout(false);
            this.contentPanel_Home.ResumeLayout(false);
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
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel4;
        private DevComponents.DotNetBar.ItemContainer itemContainer4;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem6;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem7;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel3;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem3;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem4;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel2;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem2;
        private DevComponents.DotNetBar.Metro.MetroTilePanel metroTilePanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem1;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.Line line2;
    }
}

