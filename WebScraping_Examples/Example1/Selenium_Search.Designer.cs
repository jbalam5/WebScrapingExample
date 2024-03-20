namespace WebScraping_Examples.Example1
{
    partial class Selenium_Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Selenium_Search));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ReportGridControl = new DevExpress.XtraGrid.GridControl();
            this.ReportGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemRatingControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemRatingControl();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LinkRepositoryItemHyperLinkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ImageRepositoryItemImageEdit = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.ImageRepositoryItemPictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.TypeSearchComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.SearchSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.TextToSearchTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.TextSearchLayoutControlItem = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WebScraping_Examples.Example1.WaitForm), true, true);
            this.ShowProcessCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkRepositoryItemHyperLinkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRepositoryItemImageEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRepositoryItemPictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeSearchComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextToSearchTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchLayoutControlItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowProcessCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(876, 58);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ShowProcessCheckEdit);
            this.layoutControl1.Controls.Add(this.ReportGridControl);
            this.layoutControl1.Controls.Add(this.TypeSearchComboBoxEdit);
            this.layoutControl1.Controls.Add(this.SearchSimpleButton);
            this.layoutControl1.Controls.Add(this.TextToSearchTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 58);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(876, 403);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ReportGridControl
            // 
            this.ReportGridControl.Location = new System.Drawing.Point(12, 62);
            this.ReportGridControl.MainView = this.ReportGridView;
            this.ReportGridControl.MenuManager = this.ribbonControl1;
            this.ReportGridControl.Name = "ReportGridControl";
            this.ReportGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.LinkRepositoryItemHyperLinkEdit,
            this.ImageRepositoryItemImageEdit,
            this.ImageRepositoryItemPictureEdit,
            this.repositoryItemRatingControl1});
            this.ReportGridControl.Size = new System.Drawing.Size(852, 329);
            this.ReportGridControl.TabIndex = 7;
            this.ReportGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ReportGridView});
            // 
            // ReportGridView
            // 
            this.ReportGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn1,
            this.gridColumn7,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.ReportGridView.GridControl = this.ReportGridControl;
            this.ReportGridView.GroupCount = 1;
            this.ReportGridView.Name = "ReportGridView";
            this.ReportGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn6, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.ReportGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.ReportGridView_CustomUnboundColumnData);
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "No Página";
            this.gridColumn6.FieldName = "Page";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.OptionsColumn.ReadOnly = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Producto";
            this.gridColumn1.FieldName = "Title";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Puntuación";
            this.gridColumn7.FieldName = "Score";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estrellas";
            this.gridColumn2.ColumnEdit = this.repositoryItemRatingControl1;
            this.gridColumn2.FieldName = "Score";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // repositoryItemRatingControl1
            // 
            this.repositoryItemRatingControl1.AutoHeight = false;
            this.repositoryItemRatingControl1.FillPrecision = DevExpress.XtraEditors.RatingItemFillPrecision.Exact;
            this.repositoryItemRatingControl1.Name = "repositoryItemRatingControl1";
            this.repositoryItemRatingControl1.ReadOnly = true;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Precio";
            this.gridColumn3.FieldName = "Price";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Imágen";
            this.gridColumn4.ColumnEdit = this.LinkRepositoryItemHyperLinkEdit;
            this.gridColumn4.FieldName = "Image";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            // 
            // LinkRepositoryItemHyperLinkEdit
            // 
            this.LinkRepositoryItemHyperLinkEdit.AutoHeight = false;
            this.LinkRepositoryItemHyperLinkEdit.Name = "LinkRepositoryItemHyperLinkEdit";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Link";
            this.gridColumn5.ColumnEdit = this.LinkRepositoryItemHyperLinkEdit;
            this.gridColumn5.FieldName = "Link";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            // 
            // ImageRepositoryItemImageEdit
            // 
            this.ImageRepositoryItemImageEdit.AutoHeight = false;
            this.ImageRepositoryItemImageEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ImageRepositoryItemImageEdit.Name = "ImageRepositoryItemImageEdit";
            // 
            // ImageRepositoryItemPictureEdit
            // 
            this.ImageRepositoryItemPictureEdit.Name = "ImageRepositoryItemPictureEdit";
            this.ImageRepositoryItemPictureEdit.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            // 
            // TypeSearchComboBoxEdit
            // 
            this.TypeSearchComboBoxEdit.EditValue = "Ofertas/Promociones";
            this.TypeSearchComboBoxEdit.Location = new System.Drawing.Point(56, 12);
            this.TypeSearchComboBoxEdit.MenuManager = this.ribbonControl1;
            this.TypeSearchComboBoxEdit.Name = "TypeSearchComboBoxEdit";
            this.TypeSearchComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TypeSearchComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Ofertas/Promociones",
            "Búsqueda especifica"});
            this.TypeSearchComboBoxEdit.Size = new System.Drawing.Size(203, 20);
            this.TypeSearchComboBoxEdit.StyleController = this.layoutControl1;
            this.TypeSearchComboBoxEdit.TabIndex = 6;
            this.TypeSearchComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.TypeSearchComboBoxEdit_SelectedIndexChanged);
            // 
            // SearchSimpleButton
            // 
            this.SearchSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SearchSimpleButton.ImageOptions.Image")));
            this.SearchSimpleButton.Location = new System.Drawing.Point(723, 12);
            this.SearchSimpleButton.Name = "SearchSimpleButton";
            this.SearchSimpleButton.Size = new System.Drawing.Size(141, 22);
            this.SearchSimpleButton.StyleController = this.layoutControl1;
            this.SearchSimpleButton.TabIndex = 5;
            this.SearchSimpleButton.Text = "Aceptar";
            this.SearchSimpleButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TextToSearchTextEdit
            // 
            this.TextToSearchTextEdit.Location = new System.Drawing.Point(367, 12);
            this.TextToSearchTextEdit.MenuManager = this.ribbonControl1;
            this.TextToSearchTextEdit.Name = "TextToSearchTextEdit";
            this.TextToSearchTextEdit.Size = new System.Drawing.Size(352, 20);
            this.TextToSearchTextEdit.StyleController = this.layoutControl1;
            this.TextToSearchTextEdit.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.TextSearchLayoutControlItem,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(876, 403);
            this.Root.TextVisible = false;
            // 
            // TextSearchLayoutControlItem
            // 
            this.TextSearchLayoutControlItem.Control = this.TextToSearchTextEdit;
            this.TextSearchLayoutControlItem.Location = new System.Drawing.Point(251, 0);
            this.TextSearchLayoutControlItem.Name = "TextSearchLayoutControlItem";
            this.TextSearchLayoutControlItem.Size = new System.Drawing.Size(460, 26);
            this.TextSearchLayoutControlItem.Text = "Especificar búsqueda";
            this.TextSearchLayoutControlItem.TextSize = new System.Drawing.Size(101, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.SearchSimpleButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(711, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(145, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(145, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(145, 50);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TypeSearchComboBoxEdit;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(251, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(251, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(251, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Buscar: ";
            this.layoutControlItem3.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(39, 13);
            this.layoutControlItem3.TextToControlDistance = 5;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ReportGridControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(856, 333);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // ShowProcessCheckEdit
            // 
            this.ShowProcessCheckEdit.Location = new System.Drawing.Point(12, 38);
            this.ShowProcessCheckEdit.MenuManager = this.ribbonControl1;
            this.ShowProcessCheckEdit.Name = "ShowProcessCheckEdit";
            this.ShowProcessCheckEdit.Properties.Caption = "Mostrar Proceso";
            this.ShowProcessCheckEdit.Size = new System.Drawing.Size(707, 20);
            this.ShowProcessCheckEdit.StyleController = this.layoutControl1;
            this.ShowProcessCheckEdit.TabIndex = 8;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ShowProcessCheckEdit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(711, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Selenium_Search
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 461);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Selenium_Search";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selenium_Busqueda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Selenium_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRatingControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkRepositoryItemHyperLinkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRepositoryItemImageEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageRepositoryItemPictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeSearchComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextToSearchTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchLayoutControlItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowProcessCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.ComboBoxEdit TypeSearchComboBoxEdit;
        private DevExpress.XtraEditors.SimpleButton SearchSimpleButton;
        private DevExpress.XtraEditors.TextEdit TextToSearchTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem TextSearchLayoutControlItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl ReportGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ReportGridView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit ImageRepositoryItemImageEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit LinkRepositoryItemHyperLinkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit ImageRepositoryItemPictureEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemRatingControl repositoryItemRatingControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
        private DevExpress.XtraEditors.CheckEdit ShowProcessCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}