
namespace Mee
{
    partial class EditDefect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDefect));
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.vivodAndRecTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.VivodTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.vivod = new DevExpress.XtraEditors.MemoEdit();
            this.RecTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.recommend = new DevExpress.XtraEditors.MemoEdit();
            this.SaveAndClose = new System.Windows.Forms.Button();
            this.CodeUsl = new DevExpress.XtraEditors.ButtonEdit();
            this.CodeDefect = new DevExpress.XtraEditors.TokenEdit();
            this.koef1 = new LibForms.Controls.Koef();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ControlCodeUsl = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vivodAndRecTabControl)).BeginInit();
            this.vivodAndRecTabControl.SuspendLayout();
            this.VivodTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vivod.Properties)).BeginInit();
            this.RecTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recommend.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeUsl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeDefect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlCodeUsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutControl2.Controls.Add(this.vivodAndRecTabControl);
            this.layoutControl2.Controls.Add(this.SaveAndClose);
            this.layoutControl2.Controls.Add(this.CodeUsl);
            this.layoutControl2.Controls.Add(this.CodeDefect);
            this.layoutControl2.Controls.Add(this.koef1);
            this.layoutControl2.Location = new System.Drawing.Point(11, -3);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(873, 684);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // vivodAndRecTabControl
            // 
            this.vivodAndRecTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vivodAndRecTabControl.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.vivodAndRecTabControl.Appearance.Options.UseFont = true;
            this.vivodAndRecTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.vivodAndRecTabControl.AppearancePage.Header.Options.UseFont = true;
            this.vivodAndRecTabControl.Location = new System.Drawing.Point(12, 64);
            this.vivodAndRecTabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vivodAndRecTabControl.Name = "vivodAndRecTabControl";
            this.vivodAndRecTabControl.SelectedTabPage = this.VivodTabPage;
            this.vivodAndRecTabControl.Size = new System.Drawing.Size(849, 555);
            this.vivodAndRecTabControl.TabIndex = 13;
            this.vivodAndRecTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.VivodTabPage,
            this.RecTabPage});
            // 
            // VivodTabPage
            // 
            this.VivodTabPage.Controls.Add(this.vivod);
            this.VivodTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VivodTabPage.Name = "VivodTabPage";
            this.VivodTabPage.Size = new System.Drawing.Size(847, 524);
            this.VivodTabPage.Text = "Вывод";
            // 
            // vivod
            // 
            this.vivod.Location = new System.Drawing.Point(4, 5);
            this.vivod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vivod.Name = "vivod";
            this.vivod.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.vivod.Properties.Appearance.Options.UseFont = true;
            this.vivod.Size = new System.Drawing.Size(840, 510);
            this.vivod.TabIndex = 10;
            // 
            // RecTabPage
            // 
            this.RecTabPage.Controls.Add(this.recommend);
            this.RecTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RecTabPage.Name = "RecTabPage";
            this.RecTabPage.Size = new System.Drawing.Size(847, 524);
            this.RecTabPage.Text = "Рекомендации";
            // 
            // recommend
            // 
            this.recommend.Location = new System.Drawing.Point(4, 5);
            this.recommend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.recommend.Name = "recommend";
            this.recommend.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.recommend.Properties.Appearance.Options.UseFont = true;
            this.recommend.Size = new System.Drawing.Size(840, 510);
            this.recommend.TabIndex = 11;
            // 
            // SaveAndClose
            // 
            this.SaveAndClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SaveAndClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.SaveAndClose.ForeColor = System.Drawing.Color.White;
            this.SaveAndClose.Location = new System.Drawing.Point(12, 623);
            this.SaveAndClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveAndClose.Name = "SaveAndClose";
            this.SaveAndClose.Size = new System.Drawing.Size(849, 49);
            this.SaveAndClose.TabIndex = 2;
            this.SaveAndClose.Text = "Сохранить и закрыть";
            this.SaveAndClose.UseVisualStyleBackColor = false;
            this.SaveAndClose.Click += new System.EventHandler(this.SaveAndClose_Click);
            // 
            // CodeUsl
            // 
            this.CodeUsl.EditValue = "";
            this.CodeUsl.Location = new System.Drawing.Point(12, 34);
            this.CodeUsl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeUsl.Name = "CodeUsl";
            this.CodeUsl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.CodeUsl.Properties.Appearance.Options.UseFont = true;
            this.CodeUsl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.CodeUsl.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.CodeUsl_Properties_ButtonClick);
            this.CodeUsl.Size = new System.Drawing.Size(269, 26);
            this.CodeUsl.StyleController = this.layoutControl2;
            this.CodeUsl.TabIndex = 12;
            // 
            // CodeDefect
            // 
            this.CodeDefect.Location = new System.Drawing.Point(285, 34);
            this.CodeDefect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CodeDefect.Name = "CodeDefect";
            this.CodeDefect.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.CodeDefect.Properties.Appearance.Options.UseFont = true;
            this.CodeDefect.Properties.Separators.AddRange(new string[] {
            ","});
            this.CodeDefect.Size = new System.Drawing.Size(332, 26);
            this.CodeDefect.StyleController = this.layoutControl2;
            this.CodeDefect.TabIndex = 6;
            // 
            // koef1
            // 
            this.koef1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.koef1.KoefType = LibForms.Controls.Koef.KoefTypeEnum.Понижающий;
            this.koef1.Location = new System.Drawing.Point(621, 34);
            this.koef1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.koef1.Name = "koef1";
            this.koef1.Size = new System.Drawing.Size(240, 26);
            this.koef1.TabIndex = 8;
            this.koef1.Value = null;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ControlCodeUsl,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(873, 684);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ControlCodeUsl
            // 
            this.ControlCodeUsl.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.ControlCodeUsl.AppearanceItemCaption.Options.UseFont = true;
            this.ControlCodeUsl.Control = this.CodeUsl;
            this.ControlCodeUsl.Location = new System.Drawing.Point(0, 0);
            this.ControlCodeUsl.Name = "ControlCodeUsl";
            this.ControlCodeUsl.Size = new System.Drawing.Size(273, 52);
            this.ControlCodeUsl.Text = "Код услуги";
            this.ControlCodeUsl.TextLocation = DevExpress.Utils.Locations.Top;
            this.ControlCodeUsl.TextSize = new System.Drawing.Size(197, 19);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SaveAndClose;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 611);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(853, 53);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.vivodAndRecTabControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(853, 559);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.koef1;
            this.layoutControlItem3.Location = new System.Drawing.Point(609, 0);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(201, 46);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(244, 52);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Правильный коэффициент";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(197, 19);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.CodeDefect;
            this.layoutControlItem1.Location = new System.Drawing.Point(273, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(336, 52);
            this.layoutControlItem1.Text = "Код дефекта";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(197, 19);
            // 
            // EditDefect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 691);
            this.Controls.Add(this.layoutControl2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(910, 730);
            this.Name = "EditDefect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование дефектов";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vivodAndRecTabControl)).EndInit();
            this.vivodAndRecTabControl.ResumeLayout(false);
            this.VivodTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vivod.Properties)).EndInit();
            this.RecTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recommend.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeUsl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeDefect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlCodeUsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected DevExpress.XtraLayout.LayoutControl layoutControl2;
        protected DevExpress.XtraEditors.TokenEdit CodeDefect;
        protected DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        protected DevExpress.XtraEditors.MemoEdit recommend;
        protected DevExpress.XtraEditors.MemoEdit vivod;
        protected DevExpress.XtraEditors.ButtonEdit CodeUsl;
        protected System.Windows.Forms.Button SaveAndClose;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        protected DevExpress.XtraTab.XtraTabControl vivodAndRecTabControl;
        protected DevExpress.XtraTab.XtraTabPage VivodTabPage;
        protected DevExpress.XtraTab.XtraTabPage RecTabPage;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        protected DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        protected DevExpress.XtraLayout.LayoutControlItem ControlCodeUsl;
        public LibForms.Controls.Koef koef1;
        public DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}