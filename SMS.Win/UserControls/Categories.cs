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
        }
    }
}
