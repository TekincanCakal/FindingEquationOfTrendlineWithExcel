using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace TrendLineFinder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if(e.KeyChar == (Char)Keys.Enter)
            {
                try
                {
                    float num = float.Parse(textBox.Text);
                    textBox.Text = "";
                    ListBox listBox = (ListBox)midPanel.Controls["dataListBox" + textBox.Name.Replace("dataTextBox", "")];
                    listBox.Items.Add(num);
                }
                catch(Exception ex)
                {

                }
            }
        }

        private void dataListBox_DoubleClick(object sender, EventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            if (listBox.SelectedIndex != -1)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if(dataListBox1.Items.Count == 0 || dataListBox2.Items.Count == 0)
            {
                MessageBox.Show("Bir tarafın verisini girmediniz");
                return;
            }
            if (dataListBox1.Items.Count != dataListBox1.Items.Count)
            {
                MessageBox.Show("Verilerin countları eşit olmalı");
                return;
            }

            int count = dataListBox1.Items.Count;

            List<float> data1 = new List<float>();
            List<float> data2 = new List<float>();
            for(int i = 0; i < count; i++)
            {
                data1.Add(float.Parse(dataListBox1.Items[i].ToString()));
                data2.Add(float.Parse(dataListBox2.Items[i].ToString()));
            }

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Add(Missing.Value);
            Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            #region 
            xlWorkSheet.Cells[1, 1] = "X";
            xlWorkSheet.Cells[1, 2] = "Y";
            for (int row = 2, i = 0; i < count; i++, row++)
            {
                xlWorkSheet.Cells[row, 1] = dataListBox1.Items[i];
                xlWorkSheet.Cells[row, 2] = dataListBox2.Items[i];
            }
            #endregion

            #region 
            xlWorkSheet.Cells[count + 2, 1] = "x̄";
            xlWorkSheet.Cells[count + 3, 1] = String.Format("=SUM(A2:A{0}) / {1}", count + 1, count);

            xlWorkSheet.Cells[count + 2, 2] = "ȳ";
            xlWorkSheet.Cells[count + 3, 2] = String.Format("=SUM(B2:B{0}) / {1}", count + 1, count);
            #endregion

            #region 
            xlWorkSheet.Cells[1, 3] = "Xi - x̄";
            xlWorkSheet.Cells[1, 4] = "Yi - ȳ";
            for (int row = 2, i = 0; i < count; i++, row++)
            {
                xlWorkSheet.Cells[row, 3] = String.Format("=A{0}-$A${1}", row, count + 3);
                xlWorkSheet.Cells[row, 4] = String.Format("=B{0}-$B${1}", row, count + 3);
            }
            #endregion

            #region
            xlWorkSheet.Cells[1, 5] = "Xi - x̄ * Yi - ȳ";
            for (int row = 2, i = 0; i < count; i++, row++)
            {
                xlWorkSheet.Cells[row, 5] = String.Format("=C{0}*D{1}", row, row);
            }
            #endregion

            #region
            xlWorkSheet.Cells[1, 6] = "(Xi - x̄) ^ 2";
            xlWorkSheet.Cells[1, 7] = "(Yi - ȳ) ^ 2";
            for (int row = 2, i = 0; i < count; i++, row++)
            {
                xlWorkSheet.Cells[row, 6] = String.Format("=C{0}*C{1}", row, row);
                xlWorkSheet.Cells[row, 7] = String.Format("=D{0}*D{1}", row, row);
            }
            #endregion

            #region
            xlWorkSheet.Cells[1, 8] = "Variance X";
            xlWorkSheet.Cells[1, 9] = "Variance Y";

            xlWorkSheet.Cells[2, 8] = String.Format("=SUM(F2:F{0})/{1}", count + 1, count - 1);
            xlWorkSheet.Cells[2, 9] = String.Format("=SUM(G2:G{0})/{1}", count + 1, count - 1);
            #endregion

            #region
            xlWorkSheet.Cells[1, 10] = "Standart Deviation X";
            xlWorkSheet.Cells[1, 11] = "Standart Deviation Y";

            xlWorkSheet.Cells[2, 10] = "=SQRT(H2)";
            xlWorkSheet.Cells[2, 11] = "=SQRT(I2)";
            #endregion

            #region
            xlWorkSheet.Cells[1, 12] = "Covariance XY";

            xlWorkSheet.Cells[2, 12] = String.Format("=SUM(E2:E{0})/{1}", count + 1, count - 1);
            #endregion

            #region
            xlWorkSheet.Cells[1, 13] = "Sample Correlation Coefficient XY";

            xlWorkSheet.Cells[2, 13] = "=L2/(J2*K2)";
            #endregion

            #region
            xlWorkSheet.Cells[1, 14] = "Regression Coefficient";

            xlWorkSheet.Cells[2, 14] = String.Format("=M2*(K2/J2)", count + 3);
            #endregion

            #region
            xlWorkSheet.Cells[1, 15] = "Intercept";

            xlWorkSheet.Cells[2, 15] = String.Format("=B{0}-(N2*A{1})", count + 3, count + 3);
            #endregion

            #region
            xlWorkSheet.Cells[1, 16] = "Regression Line";

            xlWorkSheet.Cells[2, 16] = "=CONCATENATE(\"Y = \", O2,\" + (\", N2, \")x\")";
            #endregion

            xlWorkSheet.get_Range("A1", "P" + (count + 3)).ColumnWidth = 20;
            xlWorkBook.SaveAs(Application.StartupPath + "\\answer.xls", Excel.XlFileFormat.xlWorkbookNormal, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Excel.XlSaveAsAccessMode.xlExclusive, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
            xlWorkBook.Close(true, Missing.Value, Missing.Value);
            xlApp.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);
            Process.Start(Application.StartupPath + "\\answer.xls");
        }

        Point mousedownpoint = Point.Empty;
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mousedownpoint.IsEmpty)
            {
                Location = new Point(Location.X + (e.X - mousedownpoint.X), Location.Y + (e.Y - mousedownpoint.Y));
            }
        }
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void hideButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
