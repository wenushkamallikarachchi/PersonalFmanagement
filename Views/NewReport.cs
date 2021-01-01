using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using w1673746.Models;

namespace w1673746.Views
{
    public partial class NewReport : Form
    {
        ReportModel reportModel = new ReportModel();
        private int id;

        public void setId(int id)
        {
            this.id = id;
        }

        public NewReport()
        {
            InitializeComponent();
        }

        private void NewReport_Load(object sender, EventArgs e)
        {

        }

        private void createReport_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to save the record?", "Save Data & Create New Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime createdDate = DateTime.Today.Date;
                reportModel.executeAddReportData(reportName.Text, comboBoxType.Text, startDate.Value, endDate.Value, createdDate, id);
                MessageBox.Show("The record has been saved successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
