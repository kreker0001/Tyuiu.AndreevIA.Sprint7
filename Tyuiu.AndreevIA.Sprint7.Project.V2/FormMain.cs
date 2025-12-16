using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AndreevIA.Sprint7.Project.V2;
using Tyuiu.AndreevIA.Sprint7.Project.V2.Lib;
using WMPLib;



namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{

    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();

        }

        public FormMain(FormMain formMain)
        {

            InitializeComponent();



        }



        DataService ds = new DataService();
        string openFilePath;
        int cols, rows;

        private void aboutProgramToolStripMenuItem_SAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* ·        номер, название, адрес и телефон магазина;", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_SAD_Click(object sender, EventArgs e)
        {
            openFileDialogTable_SAD.ShowDialog();
            openFilePath = openFileDialogTable_SAD.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_SAD.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_SAD.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_SAD.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewTableOrders_SAD.Rows.Count != 0) { buttonRemoveRows_SAD.Enabled = true; }
        }

        private void buttonDownload_SAD_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_SAD.FileName = "DataBase.csv";
            saveFileDialogTable_SAD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_SAD.ShowDialog();


            string path = saveFileDialogTable_SAD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_SAD.RowCount;
            int columns = dataGridViewTableOrders_SAD.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_SAD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_SAD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }


        private void buttonAdd_SAD_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_SAD.Rows.Add();
            buttonRemoveRows_SAD.Enabled = true;
        }

        private void buttonInfo_SAD_Click(object sender, EventArgs e)
        {
            //FormAbout formAbout = new FormAbout();
            //formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_SAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveRows_SAD_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_SAD.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_SAD.Rows.RemoveAt(ind);
            if (dataGridViewTableOrders_SAD.Rows.Count == 0) { buttonRemoveRows_SAD.Enabled = false; }
        }

        private void buttonFilter_SAD_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewTableOrders_SAD.Rows)
            {
                if ((r.Cells[comboBoxColsNames_SAD.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_SAD.Text.ToUpper()))
                {
                    dataGridViewTableOrders_SAD.Rows[r.Index].Visible = true;
                    dataGridViewTableOrders_SAD.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewTableOrders_SAD.CurrentCell = null;
                    dataGridViewTableOrders_SAD.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxColsNames_SAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColsNames_SAD.SelectedIndex != 0)
            {
                textBoxFilter_SAD.Enabled = true;
                buttonFilter_SAD.Enabled = true;
            }
            else
            {
                textBoxFilter_SAD.Enabled = false;
                buttonFilter_SAD.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Ежемесячная выручка");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_SAD.Rows)
            {
                if (!row.IsNewRow && row.Cells[3] != null && row.Cells[3].Value != null)
                {
                    string label = row.Cells[0].Value.ToString();
                    double hours = Convert.ToDouble(row.Cells[3].Value);
                    series.Points.AddXY(label, hours);
                }
            }
            this.chart1.Series.Add(series);
        }

        private void toolStripMenuItemInstruction_SAD_Click(object sender, EventArgs e)
        {
            //FormInstruction formInstruction = new FormInstruction();
            //formInstruction.ShowDialog();
        }

        private void textBoxSearch_SAD_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxSearch_SAD != null)
            {
                string currentText = textBoxSearch_SAD.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_SAD.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_SAD.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_SAD.Text))
                        {
                            cell.Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void toolStripTextBoxSearch_SAD_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_SAD != null)
            {
                string currentText = toolStripTextBoxSearch_SAD.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_SAD.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_SAD.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_SAD.Text))
                        {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelSearch_SAD_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFilter_SAD_TextChanged(object sender, EventArgs e)
        {

        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FormHelpDevWin formHelpDevWin = new FormHelpDevWin();
            //formHelpDevWin.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)

        {


        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }





        private void dataGridViewTable_SAD_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewTableOrders_SAD.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_SAD.Rows[index].HeaderCell.Value = indexStr;
        }

    }
}
