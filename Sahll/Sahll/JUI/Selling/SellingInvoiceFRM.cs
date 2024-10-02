using ClosedXML.Excel;
using Sahll.JUI.Car.InfoForms;
using Sahll.JUI.Car.SubForms;
using Sahll.JUI.PL;
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

namespace Sahll.JUI.Selling
{
    public partial class SellingInvoiceFRM : Form
    {
        public SellingInvoiceFRM()
        {
            InitializeComponent();
            dgvSelling.Rows.Add(new object[] { "2651231", "28/12/2004", 2156, 2156, 2156 });
            dgvSelling.Rows.Add(new object[] { " محمد علي", "28/12/2004" ,2156, 2156, 2156 });
            dgvSelling.Rows.Add(new object[] { "465645645", "28/12/2004" ,2156, 2156, 2156 });
            dgvSelling.Rows.Add(new object[] { "ا/هشام", "28/12/2004", 2156, 2156, 2156 });
        }

        #region ButtonsMethods
        private void btnAddSelling_Click(object sender, EventArgs e)
        {
            SellingAddEditFRM FRM = new SellingAddEditFRM();


            //JUI
            FRM.Show();
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "delete":

                        DialogFRM fRM = new DialogFRM("سيتم ارجاع هذه الكميه من الصنف الي المخزن؟", Color.FromArgb(64, 0, 0));
                        fRM.Show();
                        break;

                    case "edit":

                        SellingEditFRM FRM = new SellingEditFRM();


                        //JUI
                        FRM.Show();
                        break;
                    case "returnd":


                        SellingReturnFRM Frm = new SellingReturnFRM();


                        //JUI
                        Frm.Show();
                        break;
                    case "info":

                        SellingInfoProductFRM FRm = new SellingInfoProductFRM();


                        //JUI
                        FRm.Show();
                        break;
                }
            }
        }

        #endregion

        #region JUI
        private void dgvSelling_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Hand;
                switch (columnName)
                {
                    case "delete":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deleted1;
                        break;

                    case "edit":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editd;
                        break;
                    case "returnd":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedd;
                        break;

                    case "info":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infod;
                        break;
                }
            }
        }

        private void dgvSelling_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSelling.Columns[e.ColumnIndex] is DataGridViewImageColumn)
            {
                string columnName = dgvSelling.Columns[e.ColumnIndex].Name;
                Cursor = Cursors.Default;
                switch (columnName)
                {
                    case "delete":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.deletel1;
                        break;

                    case "edit":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.editl;
                        break;
                    case "returnd":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.returnedl;
                        break;

                    case "info":
                        dgvSelling.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Properties.Resources.infol;
                        break;
                }
            }
        }
        #endregion

        private void btnreport_Click(object sender, EventArgs e)
        {

            ReportToExcel(dgvSelling);
        }
        private void ReportToExcel(DataGridView dgv)
        {
            var title = $"تقرير ببيع المحل ليوم {DateTime.Now:dddd} بتاريخ {DateTime.Now:yyyy-MM-dd}";

            // تحديد مسار مجلد "تقارير سهل" داخل "سطح المكتب"
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string easyReportsFolder = Path.Combine(desktopPath, "تقارير سهل");
            string salesReportsFolder = Path.Combine(easyReportsFolder, "مبيعات المحل");

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
                var worksheet = workbook.Worksheets.Add("مبيعات المحل");

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
                titleCell.Style.Font.FontSize = 13;
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
                int totalsEndColumn = 4; // تغيير حسب عمود الإجماليات

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

        private void pnlselling_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
