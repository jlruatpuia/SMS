using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SMS.Win.UserForms
{
    public partial class Category : DevExpress.XtraEditors.XtraForm
    {
        public Category()
        {
            InitializeComponent();
        }

        public string CategoryName
        {
            get { return txtCNM.Text; }
            set { txtCNM.Text = value; }
        }

        public string Description
        {
            get { return txtDSC.Text; }
            set { txtDSC.Text = value; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}