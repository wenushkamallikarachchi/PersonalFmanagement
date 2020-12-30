using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace w1673746.Views
{
    public partial class UpdateIncomeForm : Form
    {
        public int id;


        public void setIncomeId(int id)
        {
            this.id = id;
            //displayContactDetails(id);
        }
        public UpdateIncomeForm()
        {
            InitializeComponent();
        }

        private void UpdateIncomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
