
namespace Mee
{
    partial class CodeDefect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeDefect));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Osn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Caption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.DateBeg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Osn,
            this.Caption,
            this.DateBeg,
            this.DateEnd});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.RowAutoHeight = true;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Osn
            // 
            this.Osn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Osn.AppearanceCell.Options.UseFont = true;
            this.Osn.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Osn.AppearanceHeader.Options.UseFont = true;
            this.Osn.Caption = "Основание отказа";
            this.Osn.FieldName = "Osn";
            this.Osn.Name = "Osn";
            this.Osn.OptionsColumn.AllowMove = false;
            this.Osn.Visible = true;
            this.Osn.VisibleIndex = 0;
            this.Osn.Width = 52;
            // 
            // Caption
            // 
            this.Caption.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Caption.AppearanceHeader.Options.UseFont = true;
            this.Caption.Caption = "Наименование причины отказа";
            this.Caption.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Caption.FieldName = "Caption";
            this.Caption.Name = "Caption";
            this.Caption.OptionsColumn.AllowMove = false;
            this.Caption.Visible = true;
            this.Caption.VisibleIndex = 1;
            this.Caption.Width = 601;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // DateBeg
            // 
            this.DateBeg.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateBeg.AppearanceHeader.Options.UseFont = true;
            this.DateBeg.Caption = "Дата начала действия записи";
            this.DateBeg.FieldName = "DateBeg";
            this.DateBeg.Name = "DateBeg";
            this.DateBeg.OptionsColumn.AllowMove = false;
            this.DateBeg.Visible = true;
            this.DateBeg.VisibleIndex = 2;
            this.DateBeg.Width = 41;
            // 
            // DateEnd
            // 
            this.DateEnd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateEnd.AppearanceHeader.Options.UseFont = true;
            this.DateEnd.Caption = "Дата окончания действия записи";
            this.DateEnd.FieldName = "DateEnd";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.OptionsColumn.AllowMove = false;
            this.DateEnd.Visible = true;
            this.DateEnd.VisibleIndex = 3;
            this.DateEnd.Width = 81;
            // 
            // CodeDefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "CodeDefect";
            this.Text = "Коды дефектов F014";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Caption;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn Osn;
        private DevExpress.XtraGrid.Columns.GridColumn DateBeg;
        private DevExpress.XtraGrid.Columns.GridColumn DateEnd;
    }
}