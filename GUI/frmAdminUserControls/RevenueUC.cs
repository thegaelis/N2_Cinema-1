using GUI.DAO;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;

namespace GUI.frmAdminUserControls
{
    public partial class RevenueUC : UserControl
    {
        public RevenueUC()
        {
            InitializeComponent();
            LoadRevenue();
        }
        void LoadRevenue()
        {
            LoadMovieIntoCombobox(cboSelectMovie);
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }
        void LoadMovieIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = MovieDAO.GetListMovie();
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "ID";
        }
        void LoadDateTimePickerRevenue()
        {
            dtmFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtmToDate.Value = dtmFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadRevenue(string idMovie, DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dtgvRevenue.DataSource = RevenueDAO.GetRevenue(idMovie, fromDate, toDate);
            txtDoanhThu.Text = GetSumRevenue().ToString("c", culture);
        }
        decimal GetSumRevenue()
        {
            decimal sum = 0;
            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tiền vé"].Value);
            }
            return sum;
        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            LoadRevenue(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
        }

        private void btnReportRevenue_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(cboSelectMovie.SelectedValue.ToString(), dtmFromDate.Value, dtmToDate.Value);
            frm.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 18;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Rạp chiếu phim CGV";

            Excel.Range title = (Excel.Range)exSheet.Cells[4, 4];
            title.Font.Bold = true;
            title.Font.Size = 18;
            title.Font.Color = Color.Red;
            title.Value = "DOANH THU";

            exSheet.Range["B6:F6"].Font.Size = 15;
            exSheet.Range["B6:F6"].Font.Bold = true;
            exSheet.Range["B6"].Value = "Tên phim";
            exSheet.Range["B6"].ColumnWidth = 25;
            exSheet.Range["B6"].HorizontalAlignment = HorizontalAlignment.Center;
            exSheet.Range["B6"].VerticalAlignment = VerticalAlignment.Center;

            exSheet.Range["C6"].Value = "Ngày chiếu";
            exSheet.Range["C6"].ColumnWidth = 25;
            exSheet.Range["C6"].HorizontalAlignment = HorizontalAlignment.Center;
            exSheet.Range["D6"].Value = "Giờ chiếu";
            exSheet.Range["D6"].ColumnWidth = 25;
            exSheet.Range["D6"].HorizontalAlignment = HorizontalAlignment.Center;
            exSheet.Range["E6"].Value = "Số vé đã bán";
            exSheet.Range["E6"].ColumnWidth = 25;
            exSheet.Range["E6"].HorizontalAlignment = HorizontalAlignment.Center;
            exSheet.Range["F6"].Value = "Tiền vé";
            exSheet.Range["F6"].ColumnWidth = 25;
            exSheet.Range["F6"].HorizontalAlignment = HorizontalAlignment.Center;

            int dong = 7;
            for(int i = 0; i < dtgvRevenue.Rows.Count; i++)
            {
                exSheet.Range["B" + (dong+i).ToString()].Value = dtgvRevenue.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["B" + (dong + i).ToString()].HorizontalAlignment = HorizontalAlignment.Center;

                exSheet.Range["C" + (dong+i).ToString()].Value = dtgvRevenue.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].HorizontalAlignment= HorizontalAlignment.Center;

                exSheet.Range["D" + (dong + i).ToString()].Value = dtgvRevenue.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].HorizontalAlignment = HorizontalAlignment.Center;

                exSheet.Range["E" + (dong + i).ToString()].Value = dtgvRevenue.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["E" + (dong + i).ToString()].HorizontalAlignment = HorizontalAlignment.Center;

                exSheet.Range["F" + (dong + i).ToString()].Value = dtgvRevenue.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].HorizontalAlignment = HorizontalAlignment.Center;
            }
            dong = dong + dtgvRevenue.Rows.Count+2;
            exSheet.Range["E" + dong.ToString()].ColumnWidth = 25;
            exSheet.Range["E" + dong.ToString()].Font.Size = 15;
            exSheet.Range["E" + dong.ToString()].Font.Bold = true;
            exSheet.Range["E" + dong.ToString()].Value = "Tổng doanh thu";

            exSheet.Range["F" + dong.ToString()].Value = txtDoanhThu.Text;
            exSheet.Name = cboSelectMovie.SelectedValue.ToString();
            exBook.Activate();

            SaveFileDialog save = new SaveFileDialog(); //save theo dạng là Report_NgàyXuấtBC_GiờXuấtBC.xlsx
            save.Filter = "Exel 97-2002 Workbook| *.xls|Excel Worbook|*.xlsx|All Files|*.*";
            save.FilterIndex = 2;
            if(save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();


        }
    }
}
