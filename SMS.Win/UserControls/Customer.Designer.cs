namespace SMS.Win.UserControls
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.bDetails = new DevExpress.XtraBars.BarButtonItem();
            this.bCash = new DevExpress.XtraBars.BarButtonItem();
            this.bPPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bExport = new DevExpress.XtraBars.BarSubItem();
            this.bPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bXLS = new DevExpress.XtraBars.BarButtonItem();
            this.bXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.bFirst = new DevExpress.XtraBars.BarButtonItem();
            this.bPrev = new DevExpress.XtraBars.BarButtonItem();
            this.bNext = new DevExpress.XtraBars.BarButtonItem();
            this.bLast = new DevExpress.XtraBars.BarButtonItem();
            this.bFind = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarSubItem();
            this.bDelSel = new DevExpress.XtraBars.BarButtonItem();
            this.bDelAll = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dm = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dp = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.colCash = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            this.dp.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.barButtonItem3,
            this.bDetails,
            this.bCash,
            this.bPPreview,
            this.barButtonItem7,
            this.bExport,
            this.bPDF,
            this.bXLS,
            this.bXLSX,
            this.bFirst,
            this.bPrev,
            this.bNext,
            this.bLast,
            this.bFind,
            this.bDel,
            this.bDelSel,
            this.bDelAll});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(748, 141);
            // 
            // bNew
            // 
            this.bNew.Caption = "New";
            this.bNew.Glyph = ((System.Drawing.Image)(resources.GetObject("bNew.Glyph")));
            this.bNew.Id = 1;
            this.bNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNew.LargeGlyph")));
            this.bNew.Name = "bNew";
            this.bNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNew_ItemClick);
            // 
            // bEdit
            // 
            this.bEdit.Caption = "Edit";
            this.bEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("bEdit.Glyph")));
            this.bEdit.Id = 2;
            this.bEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEdit.LargeGlyph")));
            this.bEdit.Name = "bEdit";
            this.bEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bEdit_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Delete";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 3;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // bDetails
            // 
            this.bDetails.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bDetails.Caption = "Details";
            this.bDetails.Down = true;
            this.bDetails.Glyph = ((System.Drawing.Image)(resources.GetObject("bDetails.Glyph")));
            this.bDetails.Id = 4;
            this.bDetails.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDetails.LargeGlyph")));
            this.bDetails.Name = "bDetails";
            this.bDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDetails_ItemClick);
            // 
            // bCash
            // 
            this.bCash.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bCash.Caption = "Cash in Hand";
            this.bCash.Glyph = ((System.Drawing.Image)(resources.GetObject("bCash.Glyph")));
            this.bCash.Id = 5;
            this.bCash.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bCash.LargeGlyph")));
            this.bCash.Name = "bCash";
            this.bCash.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bCash_ItemClick);
            // 
            // bPPreview
            // 
            this.bPPreview.Caption = "Print Preview";
            this.bPPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("bPPreview.Glyph")));
            this.bPPreview.Id = 6;
            this.bPPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPPreview.LargeGlyph")));
            this.bPPreview.Name = "bPPreview";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bExport
            // 
            this.bExport.Caption = "Export";
            this.bExport.Glyph = ((System.Drawing.Image)(resources.GetObject("bExport.Glyph")));
            this.bExport.Id = 8;
            this.bExport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bExport.LargeGlyph")));
            this.bExport.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLS),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLSX)});
            this.bExport.Name = "bExport";
            // 
            // bPDF
            // 
            this.bPDF.Caption = "Portable Document Format (PDF)";
            this.bPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("bPDF.Glyph")));
            this.bPDF.Id = 9;
            this.bPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPDF.LargeGlyph")));
            this.bPDF.Name = "bPDF";
            // 
            // bXLS
            // 
            this.bXLS.Caption = "MS Excel 2003 Format (XLS)";
            this.bXLS.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLS.Glyph")));
            this.bXLS.Id = 10;
            this.bXLS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLS.LargeGlyph")));
            this.bXLS.Name = "bXLS";
            // 
            // bXLSX
            // 
            this.bXLSX.Caption = "MS Excel 2007 Format (XLSX)";
            this.bXLSX.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.Glyph")));
            this.bXLSX.Id = 11;
            this.bXLSX.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.LargeGlyph")));
            this.bXLSX.Name = "bXLSX";
            // 
            // bFirst
            // 
            this.bFirst.Caption = "First";
            this.bFirst.Glyph = ((System.Drawing.Image)(resources.GetObject("bFirst.Glyph")));
            this.bFirst.Id = 12;
            this.bFirst.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFirst.LargeGlyph")));
            this.bFirst.Name = "bFirst";
            this.bFirst.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bFirst_ItemClick);
            // 
            // bPrev
            // 
            this.bPrev.Caption = "Previous";
            this.bPrev.Glyph = ((System.Drawing.Image)(resources.GetObject("bPrev.Glyph")));
            this.bPrev.Id = 13;
            this.bPrev.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPrev.LargeGlyph")));
            this.bPrev.Name = "bPrev";
            this.bPrev.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPrev_ItemClick);
            // 
            // bNext
            // 
            this.bNext.Caption = "Next";
            this.bNext.Glyph = ((System.Drawing.Image)(resources.GetObject("bNext.Glyph")));
            this.bNext.Id = 14;
            this.bNext.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNext.LargeGlyph")));
            this.bNext.Name = "bNext";
            this.bNext.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNext_ItemClick);
            // 
            // bLast
            // 
            this.bLast.Caption = "Last";
            this.bLast.Glyph = ((System.Drawing.Image)(resources.GetObject("bLast.Glyph")));
            this.bLast.Id = 15;
            this.bLast.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bLast.LargeGlyph")));
            this.bLast.Name = "bLast";
            this.bLast.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bLast_ItemClick);
            // 
            // bFind
            // 
            this.bFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bFind.Caption = "Find";
            this.bFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bFind.Glyph")));
            this.bFind.Id = 16;
            this.bFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFind.LargeGlyph")));
            this.bFind.Name = "bFind";
            this.bFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bFind_ItemClick);
            // 
            // bDel
            // 
            this.bDel.Caption = "Delete";
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 17;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bDelSel),
            new DevExpress.XtraBars.LinkPersistInfo(this.bDelAll)});
            this.bDel.Name = "bDel";
            // 
            // bDelSel
            // 
            this.bDelSel.Caption = "Delete Selected";
            this.bDelSel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelSel.Glyph")));
            this.bDelSel.Id = 18;
            this.bDelSel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelSel.LargeGlyph")));
            this.bDelSel.Name = "bDelSel";
            this.bDelSel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDelSel_ItemClick);
            // 
            // bDelAll
            // 
            this.bDelAll.Caption = "Delete All";
            this.bDelAll.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelAll.Glyph")));
            this.bDelAll.Id = 19;
            this.bDelAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelAll.LargeGlyph")));
            this.bDelAll.Name = "bDelAll";
            this.bDelAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bDelAll_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Customers";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Management";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.bFirst);
            this.ribbonPageGroup4.ItemLinks.Add(this.bPrev);
            this.ribbonPageGroup4.ItemLinks.Add(this.bNext);
            this.ribbonPageGroup4.ItemLinks.Add(this.bLast);
            this.ribbonPageGroup4.ItemLinks.Add(this.bFind, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Navigation";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bDetails);
            this.ribbonPageGroup2.ItemLinks.Add(this.bCash);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Details";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bPPreview);
            this.ribbonPageGroup3.ItemLinks.Add(this.bExport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Print && Export";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 141);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl1;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(489, 326);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colEmail,
            this.colCash,
            this.colPHO});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
            this.grv.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grv_FocusedRowChanged);
            this.grv.RowCountChanged += new System.EventHandler(this.grv_RowCountChanged);
            // 
            // colID
            // 
            this.colID.Caption = "gridColumn1";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.AllowFocus = false;
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "CustomerName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.OptionsColumn.AllowFocus = false;
            this.colName.OptionsColumn.ReadOnly = true;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 274;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Address";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.OptionsColumn.AllowFocus = false;
            this.colAddress.OptionsColumn.ReadOnly = true;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 1;
            this.colAddress.Width = 297;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone No";
            this.colPhone.FieldName = "PhoneNo";
            this.colPhone.Name = "colPhone";
            this.colPhone.OptionsColumn.AllowEdit = false;
            this.colPhone.OptionsColumn.AllowFocus = false;
            this.colPhone.OptionsColumn.ReadOnly = true;
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 144;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.OptionsColumn.AllowFocus = false;
            this.colEmail.OptionsColumn.ReadOnly = true;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 125;
            // 
            // colPHO
            // 
            this.colPHO.Caption = "gridColumn1";
            this.colPHO.FieldName = "Photo";
            this.colPHO.Name = "colPHO";
            // 
            // dm
            // 
            this.dm.Form = this;
            this.dm.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dp});
            this.dm.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dp
            // 
            this.dp.Controls.Add(this.dockPanel2_Container);
            this.dp.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dp.ID = new System.Guid("63984f28-3ba9-49c6-8706-9acc50ec26ff");
            this.dp.Location = new System.Drawing.Point(489, 141);
            this.dp.Name = "dp";
            this.dp.Options.ShowAutoHideButton = false;
            this.dp.OriginalSize = new System.Drawing.Size(259, 200);
            this.dp.Size = new System.Drawing.Size(259, 326);
            this.dp.Text = "Customer Details";
            this.dp.VisibilityChanged += new DevExpress.XtraBars.Docking.VisibilityChangedEventHandler(this.dp_VisibilityChanged_1);
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(251, 299);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // colCash
            // 
            this.colCash.Caption = "Cash in Hand";
            this.colCash.FieldName = "Balance";
            this.colCash.Name = "colCash";
            this.colCash.OptionsColumn.AllowEdit = false;
            this.colCash.OptionsColumn.AllowFocus = false;
            this.colCash.OptionsColumn.ReadOnly = true;
            this.colCash.Visible = true;
            this.colCash.VisibleIndex = 4;
            this.colCash.Width = 238;
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.dp);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(748, 467);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            this.dp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        public DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bDetails;
        private DevExpress.XtraBars.BarButtonItem bCash;
        private DevExpress.XtraBars.BarButtonItem bPPreview;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarSubItem bExport;
        private DevExpress.XtraBars.BarButtonItem bPDF;
        private DevExpress.XtraBars.BarButtonItem bXLS;
        private DevExpress.XtraBars.BarButtonItem bXLSX;
        private DevExpress.XtraBars.BarButtonItem bFirst;
        private DevExpress.XtraBars.BarButtonItem bPrev;
        private DevExpress.XtraBars.BarButtonItem bNext;
        private DevExpress.XtraBars.BarButtonItem bLast;
        private DevExpress.XtraBars.BarButtonItem bFind;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarSubItem bDel;
        private DevExpress.XtraBars.BarButtonItem bDelSel;
        private DevExpress.XtraBars.BarButtonItem bDelAll;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPHO;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dp;
        private DevExpress.XtraBars.Docking.DockManager dm;
        private DevExpress.XtraGrid.Columns.GridColumn colCash;
    }
}
