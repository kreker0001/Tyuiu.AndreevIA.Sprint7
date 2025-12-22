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

        private void aboutProgramToolStripMenuItem_AIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта программа содержит в себе данные:\r* ·        номер, название, адрес и телефон магазина;", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_AIA_Click(object sender, EventArgs e)
        {
            openFileDialogTable_AIA.ShowDialog();
            openFilePath = openFileDialogTable_AIA.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);
            dataGridViewTableOrders_AIA.ColumnCount = cols = arrayValues.GetLength(1);
            dataGridViewTableOrders_AIA.RowCount = rows = arrayValues.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewTableOrders_AIA.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
            if (dataGridViewTableOrders_AIA.Rows.Count != 0) { buttonRemoveRows_AIA.Enabled = true; }
        }

        private void buttonDownload_AIA_Click(object sender, EventArgs e)
        {
            saveFileDialogTable_AIA.FileName = "DataBase.csv";
            saveFileDialogTable_AIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTable_AIA.ShowDialog();


            string path = saveFileDialogTable_AIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewTableOrders_AIA.RowCount;
            int columns = dataGridViewTableOrders_AIA.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewTableOrders_AIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewTableOrders_AIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }


        private void buttonAdd_AIA_Click(object sender, EventArgs e)
        {
            dataGridViewTableOrders_AIA.Rows.Add();
            buttonRemoveRows_AIA.Enabled = true;
        }

        private void buttonInfo_AIA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripMenuItemExit_AIA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRemoveRows_AIA_Click(object sender, EventArgs e)
        {
            int ind = dataGridViewTableOrders_AIA.SelectedCells[0].RowIndex;
            dataGridViewTableOrders_AIA.Rows.RemoveAt(ind);
            if (dataGridViewTableOrders_AIA.Rows.Count == 0) { buttonRemoveRows_AIA.Enabled = false; }
        }

        private void buttonFilter_AIA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewTableOrders_AIA.Rows)
            {
                if ((r.Cells[comboBoxColsNames_AIA.SelectedIndex - 1].Value).ToString().ToUpper().Contains(textBoxFilter_AIA.Text.ToUpper()))
                {
                    dataGridViewTableOrders_AIA.Rows[r.Index].Visible = true;
                    dataGridViewTableOrders_AIA.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewTableOrders_AIA.CurrentCell = null;
                    dataGridViewTableOrders_AIA.Rows[r.Index].Visible = false;
                }
            }
        }

        private void comboBoxColsNames_AIA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColsNames_AIA.SelectedIndex != 0)
            {
                textBoxFilter_AIA.Enabled = true;
                buttonFilter_AIA.Enabled = true;
            }
            else
            {
                textBoxFilter_AIA.Enabled = false;
                buttonFilter_AIA.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Ежемесячная выручка");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            foreach (DataGridViewRow row in this.dataGridViewTableOrders_AIA.Rows)
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

        private void toolStripMenuItemInstruction_AIA_Click(object sender, EventArgs e)
        {
            //FormInstruction formInstruction = new FormInstruction();
            //formInstruction.ShowDialog();
        }

        private void textBoxSearch_AIA_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxSearch_AIA != null)
            {
                string currentText = textBoxSearch_AIA.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_AIA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && textBoxSearch_AIA.Text != string.Empty && cell.Value.ToString().Contains(textBoxSearch_AIA.Text))
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

        private void toolStripTextBoxSearch_AIA_TextChanged(object sender, EventArgs e)
        {
            if (toolStripTextBoxSearch_AIA != null)
            {
                string currentText = toolStripTextBoxSearch_AIA.Text;
                foreach (DataGridViewRow row in dataGridViewTableOrders_AIA.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && toolStripTextBoxSearch_AIA.Text != string.Empty && cell.Value.ToString().Contains(toolStripTextBoxSearch_AIA.Text))
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

        private void labelSearch_AIA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFilter_AIA_TextChanged(object sender, EventArgs e)
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





        private void dataGridViewTable_AIA_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewTableOrders_AIA.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewTableOrders_AIA.Rows[index].HeaderCell.Value = indexStr;
        }

    }
}
