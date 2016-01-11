namespace SMS.Win.UserControls
{
    partial class Categories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Categories));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bNew = new DevExpress.XtraBars.BarButtonItem();
            this.bEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bDel = new DevExpress.XtraBars.BarButtonItem();
            this.popDel = new DevExpress.XtraBars.PopupMenu();
            this.bDelSel = new DevExpress.XtraBars.BarButtonItem();
            this.bDelAll = new DevExpress.XtraBars.BarButtonItem();
            this.bFind = new DevExpress.XtraBars.BarButtonItem();
            this.bREV = new DevExpress.XtraBars.BarButtonItem();
            this.bPRV = new DevExpress.XtraBars.BarButtonItem();
            this.bNXT = new DevExpress.XtraBars.BarButtonItem();
            this.bFFW = new DevExpress.XtraBars.BarButtonItem();
            this.bPreview = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bEXP = new DevExpress.XtraBars.BarSubItem();
            this.bPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bXLS = new DevExpress.XtraBars.BarButtonItem();
            this.bXLSX = new DevExpress.XtraBars.BarButtonItem();
            this.rpCategories = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grd = new DevExpress.XtraGrid.GridControl();
            this.grv = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.bNew,
            this.bEdit,
            this.bDel,
            this.bDelSel,
            this.bDelAll,
            this.bFind,
            this.bREV,
            this.bPRV,
            this.bNXT,
            this.bFFW,
            this.bPreview,
            this.barButtonItem6,
            this.barButtonItem7,
            this.bEXP,
            this.bPDF,
            this.bXLS,
            this.bXLSX});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpCategories});
            this.ribbonControl1.Size = new System.Drawing.Size(731, 144);
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
            // bDel
            // 
            this.bDel.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bDel.Caption = "Delete";
            this.bDel.DropDownControl = this.popDel;
            this.bDel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDel.Glyph")));
            this.bDel.Id = 3;
            this.bDel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDel.LargeGlyph")));
            this.bDel.Name = "bDel";
            // 
            // popDel
            // 
            this.popDel.ItemLinks.Add(this.bDelSel);
            this.popDel.ItemLinks.Add(this.bDelAll);
            this.popDel.Name = "popDel";
            this.popDel.Ribbon = this.ribbonControl1;
            // 
            // bDelSel
            // 
            this.bDelSel.Caption = "Delete Selected";
            this.bDelSel.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelSel.Glyph")));
            this.bDelSel.Id = 4;
            this.bDelSel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelSel.LargeGlyph")));
            this.bDelSel.Name = "bDelSel";
            // 
            // bDelAll
            // 
            this.bDelAll.Caption = "Delete All";
            this.bDelAll.Glyph = ((System.Drawing.Image)(resources.GetObject("bDelAll.Glyph")));
            this.bDelAll.Id = 5;
            this.bDelAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bDelAll.LargeGlyph")));
            this.bDelAll.Name = "bDelAll";
            // 
            // bFind
            // 
            this.bFind.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.bFind.Caption = "Find";
            this.bFind.Glyph = ((System.Drawing.Image)(resources.GetObject("bFind.Glyph")));
            this.bFind.Id = 6;
            this.bFind.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFind.LargeGlyph")));
            this.bFind.Name = "bFind";
            this.bFind.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bFind_ItemClick);
            // 
            // bREV
            // 
            this.bREV.Caption = "First";
            this.bREV.Glyph = ((System.Drawing.Image)(resources.GetObject("bREV.Glyph")));
            this.bREV.Id = 7;
            this.bREV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bREV.LargeGlyph")));
            this.bREV.Name = "bREV";
            this.bREV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bREV_ItemClick);
            // 
            // bPRV
            // 
            this.bPRV.Caption = "Previous";
            this.bPRV.Glyph = ((System.Drawing.Image)(resources.GetObject("bPRV.Glyph")));
            this.bPRV.Id = 8;
            this.bPRV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPRV.LargeGlyph")));
            this.bPRV.Name = "bPRV";
            this.bPRV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bPRV_ItemClick);
            // 
            // bNXT
            // 
            this.bNXT.Caption = "Next";
            this.bNXT.Glyph = ((System.Drawing.Image)(resources.GetObject("bNXT.Glyph")));
            this.bNXT.Id = 9;
            this.bNXT.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bNXT.LargeGlyph")));
            this.bNXT.Name = "bNXT";
            this.bNXT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bNXT_ItemClick);
            // 
            // bFFW
            // 
            this.bFFW.Caption = "Last";
            this.bFFW.Glyph = ((System.Drawing.Image)(resources.GetObject("bFFW.Glyph")));
            this.bFFW.Id = 10;
            this.bFFW.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bFFW.LargeGlyph")));
            this.bFFW.Name = "bFFW";
            this.bFFW.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bFFW_ItemClick);
            // 
            // bPreview
            // 
            this.bPreview.Caption = "Preview";
            this.bPreview.Glyph = ((System.Drawing.Image)(resources.GetObject("bPreview.Glyph")));
            this.bPreview.Id = 11;
            this.bPreview.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPreview.LargeGlyph")));
            this.bPreview.Name = "bPreview";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Expo";
            this.barButtonItem6.Id = 12;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "barButtonItem7";
            this.barButtonItem7.Id = 13;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bEXP
            // 
            this.bEXP.Caption = "Export";
            this.bEXP.Glyph = ((System.Drawing.Image)(resources.GetObject("bEXP.Glyph")));
            this.bEXP.Id = 14;
            this.bEXP.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bEXP.LargeGlyph")));
            this.bEXP.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLS),
            new DevExpress.XtraBars.LinkPersistInfo(this.bXLSX)});
            this.bEXP.Name = "bEXP";
            // 
            // bPDF
            // 
            this.bPDF.Caption = "Portable Document Format (PDF)";
            this.bPDF.Glyph = ((System.Drawing.Image)(resources.GetObject("bPDF.Glyph")));
            this.bPDF.Id = 15;
            this.bPDF.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bPDF.LargeGlyph")));
            this.bPDF.Name = "bPDF";
            // 
            // bXLS
            // 
            this.bXLS.Caption = "Excel Worksheet 2003 Format (XLS)";
            this.bXLS.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLS.Glyph")));
            this.bXLS.Id = 16;
            this.bXLS.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLS.LargeGlyph")));
            this.bXLS.Name = "bXLS";
            // 
            // bXLSX
            // 
            this.bXLSX.Caption = "Excel Worksheet 2007 Format (XLSX)";
            this.bXLSX.Glyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.Glyph")));
            this.bXLSX.Id = 17;
            this.bXLSX.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bXLSX.LargeGlyph")));
            this.bXLSX.Name = "bXLSX";
            // 
            // rpCategories
            // 
            this.rpCategories.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.rpCategories.Image = ((System.Drawing.Image)(resources.GetObject("rpCategories.Image")));
            this.rpCategories.MergeOrder = 0;
            this.rpCategories.Name = "rpCategories";
            this.rpCategories.Text = "Categories";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bDel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Data Management";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bREV);
            this.ribbonPageGroup2.ItemLinks.Add(this.bPRV);
            this.ribbonPageGroup2.ItemLinks.Add(this.bNXT);
            this.ribbonPageGroup2.ItemLinks.Add(this.bFFW);
            this.ribbonPageGroup2.ItemLinks.Add(this.bFind, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Navigation";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bPreview);
            this.ribbonPageGroup3.ItemLinks.Add(this.bEXP);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Print && Export";
            // 
            // grd
            // 
            this.grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd.Location = new System.Drawing.Point(0, 144);
            this.grd.MainView = this.grv;
            this.grd.MenuManager = this.ribbonControl1;
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(731, 357);
            this.grd.TabIndex = 1;
            this.grd.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grv});
            // 
            // grv
            // 
            this.grv.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCatName,
            this.colCatDesc});
            this.grv.GridControl = this.grd;
            this.grv.Name = "grv";
            this.grv.OptionsView.ShowGroupPanel = false;
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
            // colCatName
            // 
            this.colCatName.Caption = "Name";
            this.colCatName.FieldName = "CategoryName";
            this.colCatName.Name = "colCatName";
            this.colCatName.OptionsColumn.AllowEdit = false;
            this.colCatName.OptionsColumn.AllowFocus = false;
            this.colCatName.OptionsColumn.ReadOnly = true;
            this.colCatName.Visible = true;
            this.colCatName.VisibleIndex = 0;
            // 
            // colCatDesc
            // 
            this.colCatDesc.Caption = "Description";
            this.colCatDesc.FieldName = "Description";
            this.colCatDesc.Name = "colCatDesc";
            this.colCatDesc.OptionsColumn.AllowEdit = false;
            this.colCatDesc.OptionsColumn.AllowFocus = false;
            this.colCatDesc.OptionsColumn.ReadOnly = true;
            this.colCatDesc.Visible = true;
            this.colCatDesc.VisibleIndex = 1;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grd);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Categories";
            this.Size = new System.Drawing.Size(731, 501);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage rpCategories;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bNew;
        private DevExpress.XtraBars.BarButtonItem bEdit;
        private DevExpress.XtraBars.BarButtonItem bDel;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem bDelSel;
        private DevExpress.XtraBars.BarButtonItem bDelAll;
        private DevExpress.XtraBars.PopupMenu popDel;
        private DevExpress.XtraGrid.GridControl grd;
        private DevExpress.XtraGrid.Views.Grid.GridView grv;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCatName;
        private DevExpress.XtraGrid.Columns.GridColumn colCatDesc;
        private DevExpress.XtraBars.BarButtonItem bFind;
        private DevExpress.XtraBars.BarButtonItem bREV;
        private DevExpress.XtraBars.BarButtonItem bPRV;
        private DevExpress.XtraBars.BarButtonItem bNXT;
        private DevExpress.XtraBars.BarButtonItem bFFW;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bPreview;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarSubItem bEXP;
        private DevExpress.XtraBars.BarButtonItem bPDF;
        private DevExpress.XtraBars.BarButtonItem bXLS;
        private DevExpress.XtraBars.BarButtonItem bXLSX;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}
