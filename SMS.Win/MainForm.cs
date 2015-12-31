using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using SMS.Win.UserClass;
using SMS.Win.UserControls;
using System.Drawing;
using System.Windows.Forms;

namespace SMS.Win
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            dlaf.LookAndFeel.SkinName = Properties.Settings.Default.WindowTheme;
            MainFormSettings.GeometryFromString(Properties.Settings.Default.WindowGeometry, this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WindowTheme = dlaf.LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.WindowGeometry = MainFormSettings.GeometryToString(this);
            Properties.Settings.Default.Save();
        }

        #region Form Location
        void InitLocation()
        {
            if ((ModifierKeys & Keys.Shift) == 0)
            {
                string initLocation = Properties.Settings.Default.WindowGeometry;
                Point il = new Point(0, 0);
                Size sz = Size;
                if (!string.IsNullOrWhiteSpace(initLocation))
                {
                    string[] parts = initLocation.Split(',');
                    if (parts.Length >= 2)
                    {
                        il = new Point(int.Parse(parts[0]), int.Parse(parts[1]));
                    }
                    if (parts.Length >= 4)
                    {
                        sz = new Size(int.Parse(parts[2]), int.Parse(parts[3]));
                    }
                }
                Size = sz;
                Location = il;
            }
        } 
        #endregion

        void LoadUserControl(XtraUserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            spl.Panel2.Controls.Clear();
            spl.Panel2.Controls.Add(userControl);
        }

        private void nbiCategories_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Categories uc = new Categories();
            LoadUserControl(uc);
            ribbonControl1.MergeRibbon(uc.ribbonControl1);
        }

        private void bShopDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SMS.Win.UserForms.ShopDetails frm = new UserForms.ShopDetails();
            frm.ShowDialog();
        }

        
    }
}
