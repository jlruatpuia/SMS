namespace SMS.Win.Reports
{
    partial class Customers
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.lbSNM = new DevExpress.XtraReports.UI.XRLabel();
            this.lbTAG = new DevExpress.XtraReports.UI.XRLabel();
            this.lbADR = new DevExpress.XtraReports.UI.XRLabel();
            this.lbPHN = new DevExpress.XtraReports.UI.XRLabel();
            this.lbEML = new DevExpress.XtraReports.UI.XRLabel();
            this.lbWEB = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 100F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.lbWEB,
            this.lbEML,
            this.lbPHN,
            this.lbADR,
            this.lbTAG,
            this.lbSNM});
            this.ReportHeader.HeightF = 149.3333F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // PageHeader
            // 
            this.PageHeader.HeightF = 100F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lbSNM
            // 
            this.lbSNM.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbSNM.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lbSNM.Name = "lbSNM";
            this.lbSNM.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbSNM.SizeF = new System.Drawing.SizeF(627F, 25.33334F);
            this.lbSNM.StylePriority.UseFont = false;
            this.lbSNM.StylePriority.UseTextAlignment = false;
            this.lbSNM.Text = "SALES MANAGEMENT SYSTEM";
            this.lbSNM.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbTAG
            // 
            this.lbTAG.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Italic);
            this.lbTAG.LocationFloat = new DevExpress.Utils.PointFloat(0F, 25.33334F);
            this.lbTAG.Name = "lbTAG";
            this.lbTAG.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbTAG.SizeF = new System.Drawing.SizeF(627.0001F, 23F);
            this.lbTAG.StylePriority.UseFont = false;
            this.lbTAG.StylePriority.UseTextAlignment = false;
            this.lbTAG.Text = "lbTAG";
            this.lbTAG.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbADR
            // 
            this.lbADR.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbADR.LocationFloat = new DevExpress.Utils.PointFloat(0F, 55.33333F);
            this.lbADR.Name = "lbADR";
            this.lbADR.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbADR.SizeF = new System.Drawing.SizeF(627.0001F, 23F);
            this.lbADR.StylePriority.UseFont = false;
            this.lbADR.StylePriority.UseTextAlignment = false;
            this.lbADR.Text = "lbADR";
            this.lbADR.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbPHN
            // 
            this.lbPHN.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbPHN.LocationFloat = new DevExpress.Utils.PointFloat(0F, 78.33331F);
            this.lbPHN.Name = "lbPHN";
            this.lbPHN.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbPHN.SizeF = new System.Drawing.SizeF(627F, 23F);
            this.lbPHN.StylePriority.UseFont = false;
            this.lbPHN.StylePriority.UseTextAlignment = false;
            this.lbPHN.Text = "lbPHN";
            this.lbPHN.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbEML
            // 
            this.lbEML.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbEML.LocationFloat = new DevExpress.Utils.PointFloat(0F, 101.3333F);
            this.lbEML.Name = "lbEML";
            this.lbEML.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbEML.SizeF = new System.Drawing.SizeF(627.0001F, 23F);
            this.lbEML.StylePriority.UseFont = false;
            this.lbEML.StylePriority.UseTextAlignment = false;
            this.lbEML.Text = "lbEML";
            this.lbEML.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lbWEB
            // 
            this.lbWEB.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbWEB.LocationFloat = new DevExpress.Utils.PointFloat(0F, 124.3333F);
            this.lbWEB.Name = "lbWEB";
            this.lbWEB.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.lbWEB.SizeF = new System.Drawing.SizeF(627.0001F, 22.99999F);
            this.lbWEB.StylePriority.UseFont = false;
            this.lbWEB.StylePriority.UseTextAlignment = false;
            this.lbWEB.Text = "lbWEB";
            this.lbWEB.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 147.3333F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(627F, 2F);
            // 
            // Customers
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader});
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        public DevExpress.XtraReports.UI.XRLabel lbTAG;
        private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        public DevExpress.XtraReports.UI.XRLabel lbEML;
        public DevExpress.XtraReports.UI.XRLabel lbWEB;
        public DevExpress.XtraReports.UI.XRLabel lbPHN;
        public DevExpress.XtraReports.UI.XRLabel lbADR;
        public DevExpress.XtraReports.UI.XRLabel lbSNM;
    }
}
