using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SMS.DAL;
using DevExpress.XtraReports.UI;

namespace SMS.Win.UserControls
{
    public partial class Customer : DevExpress.XtraEditors.XtraUserControl
    {
        Customers cus = new Customers();

        public Customer()
        {
            InitializeComponent();
            grd.DataSource = cus.GetAllCustomers();
        }

        private void grv_RowCountChanged(object sender, EventArgs e)
        {
            if(grv.RowCount == 0)
            {
                bEdit.Enabled = false;
                bDel.Enabled = false;
            }
            else
            {
                bEdit.Enabled = true;
                bDel.Enabled = true;
            }
            grv_FocusedRowChanged(null, null);
        }

        private void grv_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(grv.FocusedRowHandle == 0)
            {
                bFirst.Enabled = false;
                bPrev.Enabled = false;
            }
            else
            {
                bFirst.Enabled = true;
                bPrev.Enabled = true;
            }
            if(grv.FocusedRowHandle == grv.RowCount - 1)
            {
                bNext.Enabled = false;
                bLast.Enabled = false;
            }
            else
            {
                bNext.Enabled = true;
                bLast.Enabled = true;
            }
        }

        private void bFirst_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveFirst();
        }

        private void bPrev_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MovePrev();
        }

        private void bNext_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveNext();
        }

        private void bLast_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveLast();
        }

        private void bFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Down)
                grv.OptionsFind.AlwaysVisible = true;
            else
                grv.OptionsFind.AlwaysVisible = false;
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForms.Customer frm = new UserForms.Customer();
            if(frm.ShowDialog() == DialogResult.Yes)
            {
                if(cus.CreateCustomer(
                    frm.CustomerName,
                    frm.Address,
                    frm.PhoneNo,
                    frm.Email,
                    UserClass.Utils.ConvertImage(frm.ImageLocation)) == null)
                {
                    XtraMessageBox.Show("New Customer created!");
                }
                else
                {
                    XtraMessageBox.Show(cus.CreateCustomer(
                    frm.CustomerName,
                    frm.Address,
                    frm.PhoneNo,
                    frm.Email,
                    UserClass.Utils.ConvertImage(frm.ImageLocation)));
                }
            }
        }

        private void bDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bDetails.Down)
                dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            else
                dp.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
        }


        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)grv.GetFocusedRowCellValue(colID);
            string cnm = grv.GetFocusedRowCellValue(colName).ToString();
            string adr = grv.GetFocusedRowCellValue(colAddress).ToString();
            string phn = grv.GetFocusedRowCellValue(colPhone).ToString();
            string eml = grv.GetFocusedRowCellValue(colEmail).ToString();
            byte[] pho = (byte[])grv.GetFocusedRowCellValue(colPHO);
            UserForms.Customer frm = new UserForms.Customer(true);
            frm.CustomerName = cnm;
            frm.Address = adr;
            frm.PhoneNo = phn;
            frm.Email = eml;
            frm.CustomerPhoto = UserClass.Utils.ConvertImage(pho);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(frm.ImageLocation != null)
                    cus.UpdateCustomer(frm.CustomerName, frm.Address, frm.PhoneNo, frm.Email, UserClass.Utils.ConvertImage(frm.ImageLocation), id);
                else
                    cus.UpdateCustomerWoPhoto(frm.CustomerName, frm.Address, frm.PhoneNo, frm.Email, id);
            }
            grd.DataSource = cus.GetAllCustomers();
        }

        private void bDelSel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)grv.GetFocusedRowCellValue(colID);
            if (XtraMessageBox.Show("Do you really want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cus.DeleteCustomer(id) == null)
                {
                    XtraMessageBox.Show("Customer Deleted!");
                }
            }
        }

        private void bDelAll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete all customers?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (cus.DeleteCustomers() == null)
                {
                    XtraMessageBox.Show("Customers Deleted!");
                }
            }
        }

        private void dp_VisibilityChanged_1(object sender, DevExpress.XtraBars.Docking.VisibilityChangedEventArgs e)
        {
            if (dp.Visibility == DevExpress.XtraBars.Docking.DockVisibility.Visible)
                bDetails.Down = true;
            else
                bDetails.Down = false;
        }

        private void bCash_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bCash.Down)
            {
                colCash.Visible = true;
                colCash.VisibleIndex = 4;
            }
            else
            {
                colCash.Visible = false;
                //colCash.VisibleIndex =
            }
        }

        private void grv_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            int id = (int)grv.GetFocusedRowCellValue(colID);
            lbCNM.Text = cus.GetCustomer(id).CustomerName;
            lbADR.Text = cus.GetCustomer(id).Address;
            lbPHN.Text = cus.GetCustomer(id).PhoneNo;
            lbEML.Text = cus.GetCustomer(id).Email;
            lbCSH.Text = cus.GetCustomer(id).Balance.ToString();
            picPHO.Image = UserClass.Utils.ConvertImage(cus.GetCustomer(id).Photo);
        }

        private void bPPreview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reports.Customers rpt = new Reports.Customers();
            rpt.lbSNM.Text = Properties.Settings.Default.ShopName;
            rpt.lbTAG.Text = Properties.Settings.Default.TagLine;
            rpt.ShowPreviewDialog();
        }
    }
}
