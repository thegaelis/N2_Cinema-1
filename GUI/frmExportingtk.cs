using GUI.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmExportingtk : Form
    {
        public frmExportingtk()
        {
            InitializeComponent();
        }

        private void frmExportingtk_Load(object sender, EventArgs e)
        {
            rptExportingtk.LocalReport.ReportPath = "rptticket.rdlc";
            var source = new ReportDataSource("DataSet1", ListExportingtk.ExportingtkList);
            rptExportingtk.LocalReport.DataSources.Clear();
            rptExportingtk.LocalReport.DataSources.Add(source);
            this.rptExportingtk.RefreshReport();
        }
    }
}
