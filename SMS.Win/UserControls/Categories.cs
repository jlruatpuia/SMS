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

namespace SMS.Win.UserControls
{
    public partial class Categories : XtraUserControl
    {
        SMS.DAL.Categories cat = new DAL.Categories();
        public Categories()
        {
            InitializeComponent();
            grd.DataSource = cat.GetAllCategories();
        }

        private void bFind_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bFind.Down)
                grv.OptionsFind.AlwaysVisible = true;
            else grv.OptionsFind.AlwaysVisible = false;
        }

        private void bREV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveFirst();
        }

        private void bPRV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MovePrev();
        }

        private void bNXT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveNext();
        }

        private void bFFW_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            grv.MoveLast();
        }

        private void grv_RowCountChanged(object sender, EventArgs e)
        {
            if(grv.RowCount == 0)
            {
                bEdit.Enabled = false;
                bDel.Enabled = false;
                bPreview.Enabled = false;
                bEXP.Enabled = false;
                bREV.Enabled = false;
                bPRV.Enabled = false;
                bNXT.Enabled = false;
                bFFW.Enabled = false;
            }
            else
            {
                bEdit.Enabled = true;
                bDel.Enabled = true;
                bPreview.Enabled = true;
                bEXP.Enabled = true;
                bREV.Enabled = true;
                bPRV.Enabled = true;
                bNXT.Enabled = true;
                bFFW.Enabled = true;
            }
        }

        private void bNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DAL.Categories cat = new DAL.Categories();
            UserForms.Category frm = new UserForms.Category();
            frm.btnUpdate.Visible = false;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                cat.CreateCategory(frm.CategoryName, frm.Description);
            }
            else if(frm.ShowDialog() == DialogResult.Retry)
            {
                cat.CreateCategory(frm.CategoryName, frm.Description);
                //new (frm.ShowDialog());
            }
        }

        private void bEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserForms.Category frm = new UserForms.Category();
            int ID = (int)grv.GetFocusedRowCellValue(colID);
            frm.CategoryName = grv.GetFocusedRowCellValue(colCatName).ToString();
            frm.Description = grv.GetFocusedRowCellValue(colCatDesc).ToString();
            frm.btnSave.Visible = false;
            frm.btnSaveNew.Visible = false;
            if(frm.ShowDialog() == DialogResult.Yes)
            {
                cat.UpdateCategory(frm.CategoryName, frm.Description, ID);
            }
        }
    }
}
