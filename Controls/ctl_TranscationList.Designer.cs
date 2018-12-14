namespace APMS_ClientApp.Controls
{
    partial class ctl_TranscationList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevComponents.DotNetBar.SuperGrid.Style.BorderColor borderColor1 = new DevComponents.DotNetBar.SuperGrid.Style.BorderColor();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctl_TranscationList));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.gridRow1 = new DevComponents.DotNetBar.SuperGrid.GridRow();
            this.gridCell6 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell7 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell8 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell9 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.gridCell10 = new DevComponents.DotNetBar.SuperGrid.GridCell();
            this.grid_TransactionList = new DevExpress.XtraGrid.GridControl();
            this.unboundSource1 = new DevExpress.Data.UnboundSource(this.components);
            this.view_TransactionList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_TransactionId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_VehicleNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CheckInTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CheckOutTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Remove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_Edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TransactionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TransactionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            this.SuspendLayout();
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
            borderColor1.Bottom = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor1.Left = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor1.Right = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            borderColor1.Top = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gridCell10.CellStyles.Default.BorderColor = borderColor1;
            this.gridCell10.EditorType = typeof(DevComponents.DotNetBar.SuperGrid.GridButtonXEditControl);
            this.gridCell10.Value = "Edit";
            // 
            // grid_TransactionList
            // 
            this.grid_TransactionList.DataSource = this.unboundSource1;
            this.grid_TransactionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_TransactionList.Location = new System.Drawing.Point(0, 0);
            this.grid_TransactionList.MainView = this.view_TransactionList;
            this.grid_TransactionList.Name = "grid_TransactionList";
            this.grid_TransactionList.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.grid_TransactionList.Size = new System.Drawing.Size(1260, 472);
            this.grid_TransactionList.TabIndex = 0;
            this.grid_TransactionList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.view_TransactionList});
            // 
            // view_TransactionList
            // 
            this.view_TransactionList.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.GroupPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.GroupPanel.Options.UseBackColor = true;
            this.view_TransactionList.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.view_TransactionList.Appearance.TopNewRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.TopNewRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.TopNewRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(247)))));
            this.view_TransactionList.Appearance.TopNewRow.ForeColor = System.Drawing.Color.White;
            this.view_TransactionList.Appearance.TopNewRow.Options.UseBackColor = true;
            this.view_TransactionList.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.view_TransactionList.Appearance.TopNewRow.Options.UseForeColor = true;
            this.view_TransactionList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id,
            this.col_TransactionId,
            this.col_VehicleNumber,
            this.col_CheckInTime,
            this.col_CheckOutTime,
            this.col_Remove,
            this.col_Edit});
            this.view_TransactionList.GridControl = this.grid_TransactionList;
            this.view_TransactionList.Name = "view_TransactionList";
            this.view_TransactionList.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.view_TransactionList.OptionsBehavior.Editable = false;
            this.view_TransactionList.OptionsDetail.AllowExpandEmptyDetails = true;
            this.view_TransactionList.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.view_TransactionList.RowHeight = 20;
            // 
            // col_Id
            // 
            this.col_Id.Caption = "Id";
            this.col_Id.FieldName = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.col_Id.Visible = true;
            this.col_Id.VisibleIndex = 0;
            // 
            // col_TransactionId
            // 
            this.col_TransactionId.Caption = "Transaction Id";
            this.col_TransactionId.FieldName = "TransactionId";
            this.col_TransactionId.Name = "col_TransactionId";
            this.col_TransactionId.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.col_TransactionId.Visible = true;
            this.col_TransactionId.VisibleIndex = 1;
            // 
            // col_VehicleNumber
            // 
            this.col_VehicleNumber.Caption = "Vehicle Number";
            this.col_VehicleNumber.FieldName = "col_VehicleNumber";
            this.col_VehicleNumber.Name = "col_VehicleNumber";
            this.col_VehicleNumber.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.col_VehicleNumber.Visible = true;
            this.col_VehicleNumber.VisibleIndex = 2;
            // 
            // col_CheckInTime
            // 
            this.col_CheckInTime.Caption = "CheckIn Time";
            this.col_CheckInTime.FieldName = "CheckInTime";
            this.col_CheckInTime.Name = "col_CheckInTime";
            this.col_CheckInTime.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.col_CheckInTime.Visible = true;
            this.col_CheckInTime.VisibleIndex = 3;
            // 
            // col_CheckOutTime
            // 
            this.col_CheckOutTime.Caption = "CheckOut Time";
            this.col_CheckOutTime.FieldName = "CheckOutTime";
            this.col_CheckOutTime.Name = "col_CheckOutTime";
            this.col_CheckOutTime.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.col_CheckOutTime.Visible = true;
            this.col_CheckOutTime.VisibleIndex = 4;
            // 
            // col_Remove
            // 
            this.col_Remove.Caption = " ";
            this.col_Remove.ColumnEdit = this.repositoryItemButtonEdit1;
            this.col_Remove.MaxWidth = 35;
            this.col_Remove.Name = "col_Remove";
            this.col_Remove.Visible = true;
            this.col_Remove.VisibleIndex = 5;
            this.col_Remove.Width = 35;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // col_Edit
            // 
            this.col_Edit.Caption = " ";
            this.col_Edit.ColumnEdit = this.repositoryItemButtonEdit2;
            this.col_Edit.MaxWidth = 35;
            this.col_Edit.Name = "col_Edit";
            this.col_Edit.Visible = true;
            this.col_Edit.VisibleIndex = 6;
            this.col_Edit.Width = 35;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // ctl_TranscationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grid_TransactionList);
            this.Name = "ctl_TranscationList";
            this.Size = new System.Drawing.Size(1260, 472);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TransactionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unboundSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TransactionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.SuperGrid.GridRow gridRow1;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell6;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell7;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell8;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell9;
        private DevComponents.DotNetBar.SuperGrid.GridCell gridCell10;
        private DevExpress.XtraGrid.GridControl grid_TransactionList;
        private DevExpress.XtraGrid.Views.Grid.GridView view_TransactionList;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id;
        private DevExpress.XtraGrid.Columns.GridColumn col_TransactionId;
        private DevExpress.XtraGrid.Columns.GridColumn col_VehicleNumber;
        private DevExpress.XtraGrid.Columns.GridColumn col_CheckInTime;
        private DevExpress.XtraGrid.Columns.GridColumn col_CheckOutTime;
        private DevExpress.XtraGrid.Columns.GridColumn col_Remove;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.Data.UnboundSource unboundSource1;
    }
}
