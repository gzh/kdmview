using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kdmview
{
    public partial class FormAliases : Form
    {
        public FormAliases()
        {
            InitializeComponent();
        }
        public FormAliases(KdmDataSet ds)
        {
            this.kdmDataSet = ds;
            InitializeComponent();
        }
        //public void CopyData(KdmDataSet ds)
        //{
        //    this.kdmDataSet.Clear();
        //    this.kdmDataSet.Merge(ds);
        //}
    }
}
