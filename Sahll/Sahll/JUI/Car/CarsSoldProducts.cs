using ClosedXML.Excel;
using Sahll.JUI.Car.InfoForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahll.JUI.Car
{
    public partial class CarsSoldProducts : Form
    {
        public CarsSoldProducts()
        {
            InitializeComponent();
            CarsButtonsSynchronization();
            dgvcarsoldproduct.Rows.Add(new object[] { "صابون سائل", 26345, 23156, 23156 });
            dgvcarsoldproduct.Rows.Add(new object[] { " اريال", 26345, 2156, 23156 });
            dgvcarsoldproduct.Rows.Add(new object[] { "زيت دابر املا 100 عادي", 26345, 2156, 23156 });
            dgvcarsoldproduct.Rows.Add(new object[] { " دابر املا 100 دهبي", 26345, 2156, 23156 });

        }

        #region ButtonsMethods
        private void btncar1_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 1;
        }

        private void btncar2_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 2;
        }

        private void btncar3_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 3;
        }

        private void btncar4_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 4;
        }

        private void btncar5_Click(object sender, EventArgs e)
        {
            SetButtonActive(sender as System.Windows.Forms.Button);
            CarsButtonsTransitions.SelectedCar = 5;
        }

        private void dgvcarsoldproduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "info":
                        //JUI
                        InfoForms.CarInfoProduct IFRM = new InfoForms.CarInfoProduct();
                        IFRM.Show();
                        break;
                }
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnreport_Click(object sender, EventArgs e)
        {

            ReportToExcel(dgvcarsoldproduct);
        }

        #endregion

        #region JUI
        public void CarsButtonsSynchronization()
        {
            var num = CarsButtonsTransitions.SelectedCar;

            // تحقق من السيارة المختارة واستدعاء دالة الزر المناسب
            switch (num)
            {
                case 1:
                    btncar1_Click(btncar1, EventArgs.Empty);
                    break;
                case 2:
                    btncar2_Click(btncar2, EventArgs.Empty);
                    break;
                case 3:
                    btncar3_Click(btncar3, EventArgs.Empty);
                    break;
                case 4:
                    btncar4_Click(btncar4, EventArgs.Empty);
                    break;
                case 5:
                    btncar5_Click(btncar5, EventArgs.Empty);
                    break;
                default:
                    break;
            }
        }

        private void pnlcarsoldproduct_Resize(object sender, EventArgs e)
        {
            int buttonWidth = (pnlcarsoldproduct.Size.Width) / 5;
            btncar5.Size = new Size(buttonWidth, 41);
            btncar4.Size = new Size(buttonWidth, 40);
            btncar3.Size = new Size(buttonWidth, 40);
            btncar2.Size = new Size(buttonWidth, 40);
            btncar1.Size = new Size(buttonWidth, 41);


            btncar5.Location = new Point(15, 73);
            btncar4.Location = new Point(btncar5.Width - 8, 74);
            btncar3.Location = new Point(btncar5.Width * 2 - 9, 74);
            btncar2.Location = new Point(btncar5.Width * 3 - 10, 74);
            btncar1.Location = new Point(btncar5.Width * 4 - 18, 73);
        }

        private void dgvcarsoldproduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvcarsoldproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvcarsoldproduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvcarsoldproduct.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvcarsoldproduct.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "info":
                        dgvcarsoldproduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }

        private void SetButtonActive(Button clickedButton)
        {
            btncar1.BackColor = Color.Transparent;
            btncar2.BackColor = Color.Transparent;
            btncar3.BackColor = Color.Transparent;
            btncar4.BackColor = Color.Transparent;
            btncar5.BackColor = Color.Transparent;

            btncar1.ForeColor = Color.FromArgb(63, 36, 114);
            btncar2.ForeColor = Color.FromArgb(63, 36, 114);
            btncar3.ForeColor = Color.FromArgb(63, 36, 114);
            btncar4.ForeColor = Color.FromArgb(63, 36, 114);
            btncar5.ForeColor = Color.FromArgb(63, 36, 114);

            clickedButton.BackColor = Color.FromArgb(203, 150, 233);
            clickedButton.ForeColor = Color.White;

        }
        #endregion

        #region HelpFunctions
        private void ReportToExcel(DataGridView dgv)
        {
            var title = $"تقرير بالبضاعه المباعه للسياره ليوم {DateTime.Now:dddd} بتاريخ {DateTime.Now:yyyy-MM-dd}";

            // تحديد مسار مجلد "تقارير سهل" داخل "سطح المكتب"
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string easyReportsFolder = Path.Combine(desktopPath, "تقارير سهل");
            string cars = Path.Combine(easyReportsFolder, "السيارات");
            string salesReportsFolder = Path.Combine(cars, "البضاعه المباعه");

            // إنشاء المجلدات إذا لم تكن موجودة
            if (!Directory.Exists(easyReportsFolder))
            {
                Directory.CreateDirectory(easyReportsFolder);
            }
            if (!Directory.Exists(salesReportsFolder))
            {
                Directory.CreateDirectory(salesReportsFolder);
            }
            // إضافة الوقت الحالي بصيغة 12 ساعة مع AM/PM إلى اسم الملف
            string currentTime = DateTime.Now.ToString("hh-mm-ss tt");
            string excelFilePath = Path.Combine(salesReportsFolder, $"{title}_{currentTime}.xlsx");
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("بيع السيارات");

                worksheet.RightToLeft = true;

                // الحصول على عدد الأعمدة الحقيقية (بدون أعمدة الصور)
                int lastNonEmptyColumn = dgv.Columns.Cast<DataGridViewColumn>().Count(c => !(c is DataGridViewImageColumn));

                // إضافة اسم الشركة في أعلى اليمين
                var companyName = "شركة سهل للمنظفات المتطورة";
                var companyCell = worksheet.Cell(1, 1);
                companyCell.Value = companyName;
                companyCell.Style.Font.FontSize = 10;
                companyCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                companyCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                companyCell.Style.Font.FontColor = XLColor.FromHtml("#2F1464");
                companyCell.Style.Font.FontName = "Hacen Egypt";

                // دمج الخلايا فقط للأعمدة الحقيقية بدون الأعمدة الإضافية
                worksheet.Range(1, 1, 1, lastNonEmptyColumn).Merge();

                // إضافة العنوان الرئيسي
                var titleCell = worksheet.Cell(2, 1);
                titleCell.Value = title;
                titleCell.Style.Font.FontSize = 8;
                titleCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                titleCell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                titleCell.Style.Font.FontColor = XLColor.FromHtml("#2F1464");
                titleCell.Style.Font.FontName = "Hacen Egypt";

                // دمج الخلايا فقط للأعمدة الحقيقية بدون الأعمدة الإضافية
                worksheet.Range(2, 1, 2, lastNonEmptyColumn).Merge();

                // زيادة المسافة بين العنوان والجدول
                worksheet.Row(3).Height = 30; // تغيير الارتفاع لزيادة المسافة

                // إضافة رؤوس الأعمدة
                for (int colIndex = 0; colIndex < dgv.Columns.Count; colIndex++)
                {
                    if (dgv.Columns[colIndex] is DataGridViewImageColumn) // تجاهل أعمدة الصور
                        continue;

                    var cell = worksheet.Cell(4, colIndex + 1);
                    cell.Value = dgv.Columns[colIndex].HeaderText;
                    cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#472A81"); // لون الخلفية للهيدر
                    cell.Style.Font.FontColor = XLColor.White; // لون النص أبيض
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Font.FontName = "Hacen Egypt"; // تغيير الخط
                }

                // إضافة بيانات الجدول
                for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
                {
                    for (int colIndex = 0; colIndex < dgv.Columns.Count; colIndex++)
                    {
                        if (dgv.Columns[colIndex] is DataGridViewImageColumn) // تجاهل أعمدة الصور
                            continue;

                        var value = dgv.Rows[rowIndex].Cells[colIndex].Value?.ToString();
                        var cell = worksheet.Cell(rowIndex + 5, colIndex + 1);
                        cell.Value = value;
                        cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#FFFBF5"); // لون الخلفية العادية
                        cell.Style.Font.FontColor = XLColor.FromHtml("#2F1464"); // لون النص
                        cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cell.Style.Font.FontName = "Hacen Egypt"; // تغيير الخط
                    }
                }

                // حساب الإجماليات وإضافتها
                int totalsStartColumn = 2; // تغيير حسب عمود الإجماليات
                int totalsEndColumn = 3; // تغيير حسب عمود الإجماليات

                int totalsRow = dgv.Rows.Count + 5;
                worksheet.Cell(totalsRow, totalsStartColumn).Value = "إجمالي";
                worksheet.Cell(totalsRow, totalsStartColumn).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                worksheet.Cell(totalsRow, totalsStartColumn).Style.Font.FontColor = XLColor.FromHtml("#2F1464");
                worksheet.Cell(totalsRow, totalsStartColumn).Style.Font.FontName = "Hacen Egypt"; // تغيير الخط

                for (int colIndex = totalsStartColumn; colIndex <= totalsEndColumn; colIndex++)
                {
                    decimal total = 0;
                    for (int rowIndex = 0; rowIndex < dgv.Rows.Count; rowIndex++)
                    {
                        if (decimal.TryParse(dgv.Rows[rowIndex].Cells[colIndex - 1].Value?.ToString(), out decimal cellValue))
                        {
                            total += cellValue;
                        }
                    }
                    var cell = worksheet.Cell(totalsRow, colIndex);
                    cell.Value = total;
                    cell.Style.Fill.BackgroundColor = XLColor.FromHtml("#CB96E9"); // لون الخلفية للإجمالي
                    cell.Style.Font.FontColor = XLColor.White; // لون النص أبيض
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Font.FontName = "Hacen Egypt"; // تغيير الخط
                }

                // إضافة إطار خارجي حول التقرير
                var lastRow = dgv.Rows.Count + 5;
                var reportRange = worksheet.Range(1, 1, lastRow, lastNonEmptyColumn);
                reportRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thick;
                reportRange.Style.Border.OutsideBorderColor = XLColor.Black;

                // ضبط حجم الخلايا لتناسب المحتوى
                worksheet.Columns(1, lastNonEmptyColumn).AdjustToContents();
                worksheet.Rows().AdjustToContents();

                // حفظ الملف
                workbook.SaveAs(excelFilePath);
            }

            // فتح ملف Excel بعد إنشائه
            Process.Start(new ProcessStartInfo
            {
                FileName = excelFilePath,
                UseShellExecute = true
            });
        }
        #endregion

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }
    }
}
