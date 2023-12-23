
using System.Drawing;

namespace Mee
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Lpu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Im = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nhistory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateBeg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Defect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.Doc = new DevExpress.XtraBars.BarSubItem();
            this.OpenDoc = new DevExpress.XtraBars.BarButtonItem();
            this.UploadReport = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.NoDefect = new DevExpress.XtraBars.BarButtonItem();
            this.HaveDefect = new DevExpress.XtraBars.BarButtonItem();
            this.HaveDefectEkmp = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteDefect = new DevExpress.XtraBars.BarButtonItem();
            this.Options = new DevExpress.XtraBars.BarSubItem();
            this.Dic = new DevExpress.XtraBars.BarSubItem();
            this.updateDic = new DevExpress.XtraBars.BarButtonItem();
            this.CodeDefectF014 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.EditDoc = new DevExpress.XtraBars.BarButtonItem();
            this.buttonOptions = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.Report = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Mee.WaitForm1), true, true);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.IsSplitterFixed = true;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 26);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.statusStrip1);
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.MinSize = 900;
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.propertyGridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1248, 424);
            this.splitContainerControl1.SplitterPosition = 322;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 402);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(900, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseFont = true;
            this.gridControl1.EmbeddedNavigator.Appearance.Options.UseTextOptions = true;
            this.gridControl1.EmbeddedNavigator.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(900, 424);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ToolTipController = this.toolTipController1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.FooterPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.GroupFooter.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupRow.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HotTrackedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HotTrackedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Lpu,
            this.Status,
            this.Fam,
            this.Im,
            this.Ot,
            this.Dr,
            this.Nhistory,
            this.DateBeg,
            this.DateEnd,
            this.Defect});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsFilter.AllowAutoFilterConditionChange = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsFilter.ColumnFilterPopupMode = DevExpress.XtraGrid.Columns.ColumnFilterPopupMode.Excel;
            this.gridView1.OptionsNavigation.AutoFocusNewRow = true;
            this.gridView1.OptionsNavigation.UseTabKey = false;
            this.gridView1.OptionsScrollAnnotations.ShowSelectedRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 30;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHotTrackedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = true;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.AllowHtmlDrawHeaders = true;
            this.gridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.Lpu, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView1_RowStyle);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseWheel);
            // 
            // Lpu
            // 
            this.Lpu.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Lpu.AppearanceCell.Options.UseFont = true;
            this.Lpu.Caption = "ЛПУ";
            this.Lpu.FieldName = "NAME_MO";
            this.Lpu.Name = "Lpu";
            this.Lpu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Lpu.OptionsColumn.AllowMove = false;
            this.Lpu.OptionsColumn.ReadOnly = true;
            this.Lpu.Visible = true;
            this.Lpu.VisibleIndex = 1;
            this.Lpu.Width = 331;
            // 
            // Status
            // 
            this.Status.AppearanceCell.ForeColor = System.Drawing.Color.Transparent;
            this.Status.AppearanceCell.Options.UseForeColor = true;
            this.Status.Caption = "Статус";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Status.OptionsColumn.AllowMove = false;
            this.Status.OptionsColumn.ReadOnly = true;
            this.Status.OptionsColumn.ShowCaption = false;
            this.Status.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 1;
            this.Status.Width = 20;
            this.Status.MaxWidth = 20;
          
            // 
            // Fam
            // 
            this.Fam.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Fam.AppearanceCell.Options.UseFont = true;
            this.Fam.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Fam.AppearanceHeader.Options.UseFont = true;
            this.Fam.AppearanceHeader.Options.UseTextOptions = true;
            this.Fam.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Fam.Caption = "Фамилия";
            this.Fam.FieldName = "FAM";
            this.Fam.Name = "Fam";
            this.Fam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Fam.OptionsColumn.AllowMove = false;
            this.Fam.OptionsColumn.ReadOnly = true;
            this.Fam.Visible = true;
            this.Fam.VisibleIndex = 2;
            this.Fam.Width = 130;
            // 
            // Im
            // 
            this.Im.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Im.AppearanceCell.Options.UseFont = true;
            this.Im.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Im.AppearanceHeader.Options.UseFont = true;
            this.Im.AppearanceHeader.Options.UseTextOptions = true;
            this.Im.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Im.Caption = "Имя";
            this.Im.FieldName = "IM";
            this.Im.Name = "Im";
            this.Im.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Im.OptionsColumn.AllowMove = false;
            this.Im.OptionsColumn.ReadOnly = true;
            this.Im.Visible = true;
            this.Im.VisibleIndex = 3;
            this.Im.Width = 105;
            // 
            // Ot
            // 
            this.Ot.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Ot.AppearanceCell.Options.UseFont = true;
            this.Ot.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Ot.AppearanceHeader.Options.UseFont = true;
            this.Ot.AppearanceHeader.Options.UseTextOptions = true;
            this.Ot.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Ot.Caption = "Отчество";
            this.Ot.FieldName = "OT";
            this.Ot.Name = "Ot";
            this.Ot.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Ot.OptionsColumn.AllowMove = false;
            this.Ot.OptionsColumn.ReadOnly = true;
            this.Ot.Visible = true;
            this.Ot.VisibleIndex = 4;
            this.Ot.Width = 114;
            // 
            // Dr
            // 
            this.Dr.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Dr.AppearanceCell.Options.UseFont = true;
            this.Dr.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Dr.AppearanceHeader.Options.UseFont = true;
            this.Dr.AppearanceHeader.Options.UseTextOptions = true;
            this.Dr.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Dr.Caption = "Дата рождения";
            this.Dr.FieldName = "DR";
            this.Dr.Name = "Dr";
            this.Dr.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Dr.OptionsColumn.AllowMove = false;
            this.Dr.OptionsColumn.ReadOnly = true;
            this.Dr.Visible = true;
            this.Dr.VisibleIndex = 5;
            this.Dr.Width = 92;
            // 
            // Nhistory
            // 
            this.Nhistory.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Nhistory.AppearanceCell.Options.UseFont = true;
            this.Nhistory.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Nhistory.AppearanceHeader.Options.UseFont = true;
            this.Nhistory.AppearanceHeader.Options.UseTextOptions = true;
            this.Nhistory.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.Nhistory.Caption = "№";
            this.Nhistory.FieldName = "NHISTORY";
            this.Nhistory.Name = "Nhistory";
            this.Nhistory.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.Nhistory.OptionsColumn.AllowMove = false;
            this.Nhistory.OptionsColumn.ReadOnly = true;
            this.Nhistory.Visible = true;
            this.Nhistory.VisibleIndex = 6;
            this.Nhistory.Width = 107;
            // 
            // DateBeg
            // 
            this.DateBeg.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateBeg.AppearanceCell.Options.UseFont = true;
            this.DateBeg.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateBeg.AppearanceHeader.Options.UseFont = true;
            this.DateBeg.AppearanceHeader.Options.UseTextOptions = true;
            this.DateBeg.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DateBeg.Caption = "Дата начала";
            this.DateBeg.FieldName = "DATE_1";
            this.DateBeg.Name = "DateBeg";
            this.DateBeg.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.DateBeg.OptionsColumn.AllowMove = false;
            this.DateBeg.OptionsColumn.ReadOnly = true;
            this.DateBeg.OptionsColumn.ShowInExpressionEditor = false;
            this.DateBeg.Visible = true;
            this.DateBeg.VisibleIndex = 7;
            this.DateBeg.Width = 110;
            // 
            // DateEnd
            // 
            this.DateEnd.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateEnd.AppearanceCell.Options.UseFont = true;
            this.DateEnd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DateEnd.AppearanceHeader.Options.UseFont = true;
            this.DateEnd.AppearanceHeader.Options.UseTextOptions = true;
            this.DateEnd.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DateEnd.Caption = "Дата конец";
            this.DateEnd.FieldName = "DATE_2";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.DateEnd.OptionsColumn.AllowMove = false;
            this.DateEnd.OptionsColumn.ReadOnly = true;
            this.DateEnd.Visible = true;
            this.DateEnd.VisibleIndex = 8;
            this.DateEnd.Width = 92;
            // 
            // Defect
            // 
            this.Defect.Caption = "Дефект";
            this.Defect.FieldName = "CodeDef";
            this.Defect.Name = "Defect";
            this.Defect.OptionsColumn.AllowMove = false;
            this.Defect.OptionsColumn.ReadOnly = true;
            this.Defect.Visible = true;
            this.Defect.VisibleIndex = 9;
            this.Defect.Width = 77;
            // 
            // toolTipController1
            // 
            this.toolTipController1.InitialDelay = 1;
            this.toolTipController1.ReshowDelay = 1;
            this.toolTipController1.GetActiveObjectInfo += new DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventHandler(this.toolTipController1_GetActiveObjectInfo);
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Appearance.Caption.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Bold);
            this.propertyGridControl1.Appearance.Caption.Options.UseFont = true;
            this.propertyGridControl1.Appearance.Category.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.propertyGridControl1.Appearance.Category.Options.UseFont = true;
            this.propertyGridControl1.Appearance.DisabledRecordValue.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.DisabledRecordValue.Options.UseFont = true;
            this.propertyGridControl1.Appearance.DisabledRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.DisabledRow.Options.UseFont = true;
            this.propertyGridControl1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.FocusedCell.Options.UseFont = true;
            this.propertyGridControl1.Appearance.FocusedRecord.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.FocusedRecord.Options.UseFont = true;
            this.propertyGridControl1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.FocusedRow.Options.UseFont = true;
            this.propertyGridControl1.Appearance.ModifiedRecordValue.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.ModifiedRecordValue.Options.UseFont = true;
            this.propertyGridControl1.Appearance.ModifiedRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.ModifiedRow.Options.UseFont = true;
            this.propertyGridControl1.Appearance.ReadOnlyRecordValue.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.ReadOnlyRecordValue.ForeColor = System.Drawing.Color.Black;
            this.propertyGridControl1.Appearance.ReadOnlyRecordValue.Options.UseFont = true;
            this.propertyGridControl1.Appearance.ReadOnlyRecordValue.Options.UseForeColor = true;
            this.propertyGridControl1.Appearance.ReadOnlyRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.ReadOnlyRow.ForeColor = System.Drawing.Color.Black;
            this.propertyGridControl1.Appearance.ReadOnlyRow.Options.UseFont = true;
            this.propertyGridControl1.Appearance.ReadOnlyRow.Options.UseForeColor = true;
            this.propertyGridControl1.Appearance.RecordValue.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.RecordValue.Options.UseFont = true;
            this.propertyGridControl1.Appearance.RowHeaderPanel.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.RowHeaderPanel.Options.UseFont = true;
            this.propertyGridControl1.Appearance.SelectedCategory.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.SelectedCategory.Options.UseFont = true;
            this.propertyGridControl1.Appearance.SelectedCell.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.SelectedCell.Options.UseFont = true;
            this.propertyGridControl1.Appearance.SelectedRecord.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.SelectedRecord.Options.UseFont = true;
            this.propertyGridControl1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.propertyGridControl1.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Appearance.SelectedRow.Options.UseBackColor = true;
            this.propertyGridControl1.Appearance.SelectedRow.Options.UseFont = true;
            this.propertyGridControl1.AppearanceTab.Hovered.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.AppearanceTab.Hovered.Options.UseFont = true;
            this.propertyGridControl1.AppearanceTab.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.AppearanceTab.Normal.Options.UseFont = true;
            this.propertyGridControl1.AppearanceTab.Pressed.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.AppearanceTab.Pressed.Options.UseFont = true;
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.MenuManager = this.barManager1;
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.OptionsBehavior.AutoSelectAllInEditor = false;
            this.propertyGridControl1.OptionsBehavior.ResizeHeaderPanel = false;
            this.propertyGridControl1.OptionsBehavior.ResizeRowHeaders = false;
            this.propertyGridControl1.OptionsBehavior.ResizeRowValues = false;
            this.propertyGridControl1.OptionsSelectionAndFocus.EnableAppearanceSelectedRowHeader = false;
            this.propertyGridControl1.OptionsSelectionAndFocus.MultiSelect = true;
            this.propertyGridControl1.OptionsSelectionAndFocus.MultiSelectMode = DevExpress.XtraVerticalGrid.MultiSelectMode.RowSelect;
            this.propertyGridControl1.OptionsView.AllowReadOnlyRowAppearance = DevExpress.Utils.DefaultBoolean.True;
            this.propertyGridControl1.OptionsView.AllowRowHeaderReadOnlyAppearance = DevExpress.Utils.DefaultBoolean.False;
            this.propertyGridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.propertyGridControl1.Size = new System.Drawing.Size(336, 424);
            this.propertyGridControl1.TabIndex = 0;
            this.propertyGridControl1.FocusedRowChanged += new DevExpress.XtraVerticalGrid.Events.FocusedRowChangedEventHandler(this.propertyGridControl1_FocusedRowChanged);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.Doc,
            this.OpenDoc,
            this.barButtonItem5,
            this.EditDoc,
            this.buttonOptions,
            this.barButtonItem4,
            this.Options,
            this.Dic,
            this.updateDic,
            this.CodeDefectF014,
            this.barSubItem1,
            this.NoDefect,
            this.HaveDefect,
            this.DeleteDefect,
            this.HaveDefectEkmp,
            this.Report,
            this.UploadReport});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 21;
            // 
            // bar1
            // 
            this.bar1.BarName = "Пользовательская 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Doc),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.Options)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Пользовательская 2";
            // 
            // Doc
            // 
            this.Doc.Caption = "Файл";
            this.Doc.Id = 3;
            this.Doc.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Doc.ItemAppearance.Disabled.Options.UseFont = true;
            this.Doc.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Doc.ItemAppearance.Hovered.Options.UseFont = true;
            this.Doc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Doc.ItemAppearance.Normal.Options.UseFont = true;
            this.Doc.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Doc.ItemAppearance.Pressed.Options.UseFont = true;
            this.Doc.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenDoc),
            new DevExpress.XtraBars.LinkPersistInfo(this.UploadReport)});
            this.Doc.Name = "Doc";
            // 
            // OpenDoc
            // 
            this.OpenDoc.Caption = "Открыть файл";
            this.OpenDoc.Id = 4;
            this.OpenDoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("OpenDoc.ImageOptions.SvgImage")));
            this.OpenDoc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.OpenDoc.ItemAppearance.Normal.Options.UseFont = true;
            this.OpenDoc.Name = "OpenDoc";
            this.OpenDoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenDoc_ItemClick);
            // 
            // UploadReport
            // 
            this.UploadReport.Caption = "Выгрузить отчет";
            this.UploadReport.Id = 20;
            this.UploadReport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("UploadReport.ImageOptions.Image")));
            this.UploadReport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("UploadReport.ImageOptions.LargeImage")));
            this.UploadReport.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.UploadReport.ItemAppearance.Normal.Options.UseFont = true;
            this.UploadReport.Name = "UploadReport";
            this.UploadReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.UploadReport_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Редактировать";
            this.barSubItem1.Id = 14;
            this.barSubItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.barSubItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.NoDefect),
            new DevExpress.XtraBars.LinkPersistInfo(this.HaveDefect),
            new DevExpress.XtraBars.LinkPersistInfo(this.HaveDefectEkmp),
            new DevExpress.XtraBars.LinkPersistInfo(this.DeleteDefect)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // NoDefect
            // 
            this.NoDefect.Caption = "Нет дефектов";
            this.NoDefect.Id = 15;
            this.NoDefect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("NoDefect.ImageOptions.Image")));
            this.NoDefect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("NoDefect.ImageOptions.LargeImage")));
            this.NoDefect.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.NoDefect.ItemAppearance.Normal.Options.UseFont = true;
            this.NoDefect.Name = "NoDefect";
            this.NoDefect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NoDefect_ItemClick);
            // 
            // HaveDefect
            // 
            this.HaveDefect.Caption = "Есть дефект МЭЭ";
            this.HaveDefect.Id = 16;
            this.HaveDefect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HaveDefect.ImageOptions.Image")));
            this.HaveDefect.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HaveDefect.ImageOptions.LargeImage")));
            this.HaveDefect.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.HaveDefect.ItemAppearance.Normal.Options.UseFont = true;
            this.HaveDefect.Name = "HaveDefect";
            this.HaveDefect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HaveDefect_ItemClick);
            // 
            // HaveDefectEkmp
            // 
            this.HaveDefectEkmp.Caption = "Есть дефект ЭКМП";
            this.HaveDefectEkmp.Id = 18;
            this.HaveDefectEkmp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HaveDefectEkmp.ImageOptions.Image")));
            this.HaveDefectEkmp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HaveDefectEkmp.ImageOptions.LargeImage")));
            this.HaveDefectEkmp.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.HaveDefectEkmp.ItemAppearance.Normal.Options.UseFont = true;
            this.HaveDefectEkmp.Name = "HaveDefectEkmp";
            this.HaveDefectEkmp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HaveDefectEkmp_ItemClick);
            // 
            // DeleteDefect
            // 
            this.DeleteDefect.Caption = "Удалить заключение";
            this.DeleteDefect.Id = 17;
            this.DeleteDefect.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DeleteDefect.ImageOptions.SvgImage")));
            this.DeleteDefect.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.DeleteDefect.ItemAppearance.Normal.Options.UseFont = true;
            this.DeleteDefect.Name = "DeleteDefect";
            this.DeleteDefect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteDefect_ItemClick);
            // 
            // Options
            // 
            this.Options.Caption = "Настройки";
            this.Options.Id = 10;
            this.Options.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Options.ItemAppearance.Normal.Options.UseFont = true;
            this.Options.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Dic)});
            this.Options.Name = "Options";
            // 
            // Dic
            // 
            this.Dic.Caption = "Справочники";
            this.Dic.Id = 11;
            this.Dic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dic.ImageOptions.Image")));
            this.Dic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Dic.ImageOptions.LargeImage")));
            this.Dic.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Dic.ItemAppearance.Normal.Options.UseFont = true;
            this.Dic.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.updateDic),
            new DevExpress.XtraBars.LinkPersistInfo(this.CodeDefectF014)});
            this.Dic.Name = "Dic";
            // 
            // updateDic
            // 
            this.updateDic.Caption = "Обновить справочники";
            this.updateDic.Id = 12;
            this.updateDic.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("updateDic.ImageOptions.Image")));
            this.updateDic.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("updateDic.ImageOptions.LargeImage")));
            this.updateDic.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.updateDic.ItemAppearance.Normal.Options.UseFont = true;
            this.updateDic.Name = "updateDic";
            this.updateDic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.updateDic_ItemClick);
            // 
            // CodeDefectF014
            // 
            this.CodeDefectF014.Caption = "Коды дефектов (F014)";
            this.CodeDefectF014.Id = 13;
            this.CodeDefectF014.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CodeDefectF014.ImageOptions.Image")));
            this.CodeDefectF014.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CodeDefectF014.ImageOptions.LargeImage")));
            this.CodeDefectF014.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.CodeDefectF014.ItemAppearance.Normal.Options.UseFont = true;
            this.CodeDefectF014.Name = "CodeDefectF014";
            this.CodeDefectF014.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CodeDefectF014_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1248, 26);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 450);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1248, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1248, 26);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 2;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // EditDoc
            // 
            this.EditDoc.Caption = "Редактировать";
            this.EditDoc.Id = 6;
            this.EditDoc.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.EditDoc.ItemAppearance.Normal.Options.UseFont = true;
            this.EditDoc.Name = "EditDoc";
            // 
            // buttonOptions
            // 
            this.buttonOptions.ActAsDropDown = true;
            this.buttonOptions.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.buttonOptions.Caption = "Настройки";
            this.buttonOptions.Id = 8;
            this.buttonOptions.Name = "buttonOptions";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Настройки";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // Report
            // 
            this.Report.Caption = "Отчет";
            this.Report.Id = 19;
            this.Report.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.Report.ItemAppearance.Normal.Options.UseFont = true;
            this.Report.Name = "Report";
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.applicationMenu1.Name = "applicationMenu1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 450);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ОМС-Экспертиза";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem Doc;
        private DevExpress.XtraBars.BarButtonItem OpenDoc;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem EditDoc;
        private DevExpress.XtraGrid.Columns.GridColumn Lpu;
        private DevExpress.XtraGrid.Columns.GridColumn Fam;
        private DevExpress.XtraGrid.Columns.GridColumn Dr;
        private DevExpress.XtraGrid.Columns.GridColumn Nhistory;
        private DevExpress.XtraGrid.Columns.GridColumn DateBeg;
        private DevExpress.XtraGrid.Columns.GridColumn DateEnd;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn Im;
        private DevExpress.XtraGrid.Columns.GridColumn Ot;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem buttonOptions;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarSubItem Options;
        private DevExpress.XtraBars.BarSubItem Dic;
        private DevExpress.XtraBars.BarButtonItem updateDic;
        private DevExpress.XtraBars.BarButtonItem CodeDefectF014;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem NoDefect;
        private DevExpress.XtraBars.BarButtonItem HaveDefect;
        private DevExpress.XtraBars.BarButtonItem DeleteDefect;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraGrid.Columns.GridColumn Defect;
        private DevExpress.XtraBars.BarButtonItem HaveDefectEkmp;
        private DevExpress.XtraBars.BarButtonItem UploadReport;
        private DevExpress.XtraBars.BarButtonItem Report;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

