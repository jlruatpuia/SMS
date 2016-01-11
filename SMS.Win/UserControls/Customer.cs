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
    public partial class Customer : DevExpress.XtraEditors.XtraUserControl
    {
        Customers cus = new Customers();

        public Customer()
        {
            InitializeComponent();
        }

    }
}
