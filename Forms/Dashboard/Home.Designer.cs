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
            this.contentPanel_Collection = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line3 = new DevComponents.DotNetBar.Controls.Line();
            this.contentPanel_Home = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line5 = new DevComponents.DotNetBar.Controls.Line();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.contentPanel_Favorites = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line2 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNavPanel4 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.sideNav_MainMenu = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNav_Home = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Collection = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Favorites = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNav_Setting = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.styleManager_Dasbord = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dashboard.SuspendLayout();
            this.contentPanel_Collection.SuspendLayout();
            this.contentPanel_Home.SuspendLayout();
            this.contentPanel_Favorites.SuspendLayout();
            this.sideNavPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.contentPanel_Favorites);
            this.dashboard.Controls.Add(this.contentPanel_Collection);
            this.dashboard.Controls.Add(this.contentPanel_Home);
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
            this.dashboard.Size = new System.Drawing.Size(953, 405);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "DashBoard";
            // 
            // contentPanel_Collection
            // 
            this.contentPanel_Collection.Controls.Add(this.line3);
            this.contentPanel_Collection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Collection.Location = new System.Drawing.Point(96, 31);
            this.contentPanel_Collection.Name = "contentPanel_Collection";
            this.contentPanel_Collection.Size = new System.Drawing.Size(856, 373);
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
            // contentPanel_Home
            // 
            this.contentPanel_Home.AutoScroll = true;
            this.contentPanel_Home.Controls.Add(this.line5);
            this.contentPanel_Home.Controls.Add(this.labelX13);
            this.contentPanel_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel_Home.Location = new System.Drawing.Point(96, 31);
            this.contentPanel_Home.Name = "contentPanel_Home";
            this.contentPanel_Home.Size = new System.Drawing.Size(856, 373);
            this.contentPanel_Home.TabIndex = 2;
            this.contentPanel_Home.Visible = false;
            // 
            // line5
            // 
            this.line5.Location = new System.Drawing.Point(10, 11);
            this.line5.Name = "line5";
            this.line5.Size = new System.Drawing.Size(439, 10);
            this.line5.TabIndex = 13;
            this.line5.Text = "line5";
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
            this.contentPanel_Favorites.Location = new System.Drawing.Point(96, 31);
            this.contentPanel_Favorites.Name = "contentPanel_Favorites";
            this.contentPanel_Favorites.Size = new System.Drawing.Size(856, 373);
            this.contentPanel_Favorites.TabIndex = 10;
            // 
            // line2
            // 
            this.line2.Location = new System.Drawing.Point(10, 11);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(127, 10);
            this.line2.TabIndex = 4;
            this.line2.Text = "line2";
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
            this.sideNav_Favorites.Checked = true;
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(953, 405);
            this.Controls.Add(this.dashboard);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.contentPanel_Collection.ResumeLayout(false);
            this.contentPanel_Home.ResumeLayout(false);
            this.contentPanel_Favorites.ResumeLayout(false);
            this.sideNavPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SideNav dashboard;
        private DevComponents.DotNetBar.Controls.SideNavPanel contentPanel_Home;
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
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.Line line5;
        private DevComponents.DotNetBar.Controls.Line line3;
        private DevComponents.DotNetBar.Controls.Line line2;
    }
}

