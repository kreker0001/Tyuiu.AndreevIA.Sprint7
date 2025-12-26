
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            saveFileDialogTable_AIA = new SaveFileDialog();
            openFileDialogTable_AIA = new OpenFileDialog();
            menuStrip_AIA = new MenuStrip();
            toolStripMenuItemInfo_AIA = new ToolStripMenuItem();
            toolStripMenuItemInstruction_AIA = new ToolStripMenuItem();
            toolStripMenuItemAbout_AIA = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            tabPageStats_AIA = new TabPage();
            buttonGetStats_AIA = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageOrderData_AIA = new TabPage();
            groupBoxMovesOrders_AIA = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxSearch = new TextBox();
            groupBox5 = new GroupBox();
            comboBoxColsNames_AIA = new ComboBox();
            textBoxFilter_AIA = new TextBox();
            buttonFilter_AIA = new Button();
            groupBox1 = new GroupBox();
            labelTextDeleteString_AIA = new Label();
            labelTextAddString_AIA = new Label();
            buttonRemoveRows_AIA = new Button();
            buttonAddOrders_AIA = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            labelTextOpenTable_AIA = new Label();
            labelTextSaveTable_AIA = new Label();
            buttonDownloadOrders_AIA = new Button();
            buttonOpenOrder_AIA = new Button();
            dataGridViewTableOrders_AIA = new DataGridView();
            tabControl_AIA = new TabControl();
            splitter1 = new Splitter();
            NumberOrder_AIA = new DataGridViewTextBoxColumn();
            DateDone_AIA = new DataGridViewTextBoxColumn();
            PriceOrder_AIA = new DataGridViewTextBoxColumn();
            CapitalOrder_AIA = new DataGridViewTextBoxColumn();
            PhoneOrder_AIA = new DataGridViewTextBoxColumn();
            menuStrip_AIA.SuspendLayout();
            tabPageStats_AIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPageOrderData_AIA.SuspendLayout();
            groupBoxMovesOrders_AIA.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_AIA).BeginInit();
            tabControl_AIA.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTable_AIA
            // 
            openFileDialogTable_AIA.FileName = "openFileDialog1";
            // 
            // menuStrip_AIA
            // 
            menuStrip_AIA.BackColor = SystemColors.Window;
            menuStrip_AIA.ImageScalingSize = new Size(20, 20);
            menuStrip_AIA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemInfo_AIA });
            menuStrip_AIA.Location = new Point(0, 0);
            menuStrip_AIA.Name = "menuStrip_AIA";
            menuStrip_AIA.Padding = new Padding(7, 2, 0, 2);
            menuStrip_AIA.Size = new Size(1315, 24);
            menuStrip_AIA.TabIndex = 4;
            menuStrip_AIA.Text = "menuStrip1";
            // 
            // toolStripMenuItemInfo_AIA
            // 
            toolStripMenuItemInfo_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_AIA, toolStripMenuItemAbout_AIA, поддержкаToolStripMenuItem });
            toolStripMenuItemInfo_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_AIA.Name = "toolStripMenuItemInfo_AIA";
            toolStripMenuItemInfo_AIA.Size = new Size(48, 20);
            toolStripMenuItemInfo_AIA.Text = "Окно";
            // 
            // toolStripMenuItemInstruction_AIA
            // 
            toolStripMenuItemInstruction_AIA.Name = "toolStripMenuItemInstruction_AIA";
            toolStripMenuItemInstruction_AIA.Size = new Size(285, 22);
            toolStripMenuItemInstruction_AIA.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_AIA.Click += toolStripMenuItemInstruction_AIA_Click;
            // 
            // toolStripMenuItemAbout_AIA
            // 
            toolStripMenuItemAbout_AIA.Name = "toolStripMenuItemAbout_AIA";
            toolStripMenuItemAbout_AIA.Size = new Size(285, 22);
            toolStripMenuItemAbout_AIA.Text = "О программе ";
            toolStripMenuItemAbout_AIA.Click += buttonInfo_AIA_Click;
            // 
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(285, 22);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // tabPageStats_AIA
            // 
            tabPageStats_AIA.Controls.Add(buttonGetStats_AIA);
            tabPageStats_AIA.Controls.Add(chart1);
            tabPageStats_AIA.Location = new Point(4, 22);
            tabPageStats_AIA.Margin = new Padding(4);
            tabPageStats_AIA.Name = "tabPageStats_AIA";
            tabPageStats_AIA.Size = new Size(1307, 690);
            tabPageStats_AIA.TabIndex = 2;
            tabPageStats_AIA.Text = "Статистика";
            tabPageStats_AIA.UseVisualStyleBackColor = true;
            // 
            // buttonGetStats_AIA
            // 
            buttonGetStats_AIA.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonGetStats_AIA.Location = new Point(431, 662);
            buttonGetStats_AIA.Margin = new Padding(4);
            buttonGetStats_AIA.Name = "buttonGetStats_AIA";
            buttonGetStats_AIA.Size = new Size(372, 24);
            buttonGetStats_AIA.TabIndex = 1;
            buttonGetStats_AIA.Text = "Получить статистику \"Капитал владельцев магазинов\"";
            buttonGetStats_AIA.UseVisualStyleBackColor = true;
            buttonGetStats_AIA.Click += button1_Click;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea3.Name = "Размер выручки";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Размер выручки";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(10, 4);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            chart1.RightToLeft = RightToLeft.No;
            series3.ChartArea = "Размер выручки";
            series3.Legend = "Размер выручки";
            series3.MarkerSize = 1;
            series3.Name = "Размер выручки";
            series3.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series3);
            chart1.Size = new Size(1293, 650);
            chart1.TabIndex = 0;
            chart1.Text = "Капитал владельцев магазинов";
            chart1.Click += chart1_Click;
            // 
            // tabPageOrderData_AIA
            // 
            tabPageOrderData_AIA.Controls.Add(groupBoxMovesOrders_AIA);
            tabPageOrderData_AIA.Location = new Point(4, 22);
            tabPageOrderData_AIA.Margin = new Padding(4);
            tabPageOrderData_AIA.Name = "tabPageOrderData_AIA";
            tabPageOrderData_AIA.Padding = new Padding(4);
            tabPageOrderData_AIA.Size = new Size(1307, 690);
            tabPageOrderData_AIA.TabIndex = 1;
            tabPageOrderData_AIA.Text = "База данных сети магазинов";
            tabPageOrderData_AIA.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovesOrders_AIA
            // 
            groupBoxMovesOrders_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMovesOrders_AIA.BackColor = SystemColors.Menu;
            groupBoxMovesOrders_AIA.Controls.Add(groupBox3);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox5);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox1);
            groupBoxMovesOrders_AIA.Controls.Add(label3);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox2);
            groupBoxMovesOrders_AIA.Controls.Add(dataGridViewTableOrders_AIA);
            groupBoxMovesOrders_AIA.Location = new Point(4, 0);
            groupBoxMovesOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_AIA.Name = "groupBoxMovesOrders_AIA";
            groupBoxMovesOrders_AIA.Padding = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_AIA.Size = new Size(1295, 642);
            groupBoxMovesOrders_AIA.TabIndex = 4;
            groupBoxMovesOrders_AIA.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.AccessibleRole = AccessibleRole.None;
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.BackColor = SystemColors.Menu;
            groupBox3.Controls.Add(textBoxSearch);
            groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox3.Location = new Point(484, 4);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(308, 75);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Найти в таблице:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = SystemColors.Window;
            textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch.Location = new Point(15, 30);
            textBoxSearch.Margin = new Padding(4);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(273, 24);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBox1_TextChanged;
            // 
            // groupBox5
            // 
            groupBox5.AccessibleRole = AccessibleRole.None;
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox5.BackColor = SystemColors.Menu;
            groupBox5.Controls.Add(comboBoxColsNames_AIA);
            groupBox5.Controls.Add(textBoxFilter_AIA);
            groupBox5.Controls.Add(buttonFilter_AIA);
            groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox5.Location = new Point(800, 4);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(483, 75);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Поиск по таблице:";
            // 
            // comboBoxColsNames_AIA
            // 
            comboBoxColsNames_AIA.BackColor = SystemColors.Window;
            comboBoxColsNames_AIA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColsNames_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxColsNames_AIA.ForeColor = SystemColors.WindowText;
            comboBoxColsNames_AIA.FormattingEnabled = true;
            comboBoxColsNames_AIA.Items.AddRange(new object[] { "", "Номер", "Название магазина", "Адрес", "Капитал владельцев магазинов", "Контактный телефон" });
            comboBoxColsNames_AIA.Location = new Point(15, 30);
            comboBoxColsNames_AIA.Margin = new Padding(4);
            comboBoxColsNames_AIA.Name = "comboBoxColsNames_AIA";
            comboBoxColsNames_AIA.Size = new Size(168, 21);
            comboBoxColsNames_AIA.TabIndex = 3;
            comboBoxColsNames_AIA.SelectedIndexChanged += comboBoxColsNames_AIA_SelectedIndexChanged;
            // 
            // textBoxFilter_AIA
            // 
            textBoxFilter_AIA.BackColor = SystemColors.Window;
            textBoxFilter_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFilter_AIA.Location = new Point(191, 30);
            textBoxFilter_AIA.Margin = new Padding(4);
            textBoxFilter_AIA.Name = "textBoxFilter_AIA";
            textBoxFilter_AIA.Size = new Size(207, 24);
            textBoxFilter_AIA.TabIndex = 1;
            textBoxFilter_AIA.TextChanged += textBoxFilter_AIA_TextChanged;
            // 
            // buttonFilter_AIA
            // 
            buttonFilter_AIA.Enabled = false;
            buttonFilter_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonFilter_AIA.Location = new Point(405, 30);
            buttonFilter_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonFilter_AIA.Name = "buttonFilter_AIA";
            buttonFilter_AIA.Size = new Size(72, 27);
            buttonFilter_AIA.TabIndex = 0;
            buttonFilter_AIA.Text = "Поиск";
            buttonFilter_AIA.UseVisualStyleBackColor = true;
            buttonFilter_AIA.Click += buttonFilter_AIA_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(labelTextDeleteString_AIA);
            groupBox1.Controls.Add(labelTextAddString_AIA);
            groupBox1.Controls.Add(buttonRemoveRows_AIA);
            groupBox1.Controls.Add(buttonAddOrders_AIA);
            groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox1.Location = new Point(241, 4);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(235, 75);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // labelTextDeleteString_AIA
            // 
            labelTextDeleteString_AIA.AutoSize = true;
            labelTextDeleteString_AIA.Location = new Point(122, 9);
            labelTextDeleteString_AIA.Name = "labelTextDeleteString_AIA";
            labelTextDeleteString_AIA.Size = new Size(87, 13);
            labelTextDeleteString_AIA.TabIndex = 2;
            labelTextDeleteString_AIA.Text = "Удалить строку";
            // 
            // labelTextAddString_AIA
            // 
            labelTextAddString_AIA.AutoSize = true;
            labelTextAddString_AIA.Location = new Point(7, 9);
            labelTextAddString_AIA.Name = "labelTextAddString_AIA";
            labelTextAddString_AIA.Size = new Size(94, 13);
            labelTextAddString_AIA.TabIndex = 1;
            labelTextAddString_AIA.Text = "Добавить строку";
            // 
            // buttonRemoveRows_AIA
            // 
            buttonRemoveRows_AIA.BackColor = SystemColors.Window;
            buttonRemoveRows_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonRemoveRows_AIA.BackgroundImage");
            buttonRemoveRows_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonRemoveRows_AIA.Enabled = false;
            buttonRemoveRows_AIA.FlatStyle = FlatStyle.Flat;
            buttonRemoveRows_AIA.ForeColor = Color.Black;
            buttonRemoveRows_AIA.Location = new Point(145, 26);
            buttonRemoveRows_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveRows_AIA.Name = "buttonRemoveRows_AIA";
            buttonRemoveRows_AIA.Size = new Size(45, 38);
            buttonRemoveRows_AIA.TabIndex = 0;
            buttonRemoveRows_AIA.UseVisualStyleBackColor = false;
            buttonRemoveRows_AIA.Click += buttonRemoveRows_AIA_Click;
            // 
            // buttonAddOrders_AIA
            // 
            buttonAddOrders_AIA.BackColor = SystemColors.Window;
            buttonAddOrders_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonAddOrders_AIA.BackgroundImage");
            buttonAddOrders_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonAddOrders_AIA.FlatStyle = FlatStyle.Flat;
            buttonAddOrders_AIA.Location = new Point(29, 26);
            buttonAddOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonAddOrders_AIA.Name = "buttonAddOrders_AIA";
            buttonAddOrders_AIA.Size = new Size(43, 39);
            buttonAddOrders_AIA.TabIndex = 0;
            buttonAddOrders_AIA.UseVisualStyleBackColor = false;
            buttonAddOrders_AIA.Click += buttonAdd_AIA_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 13);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Menu;
            groupBox2.Controls.Add(labelTextOpenTable_AIA);
            groupBox2.Controls.Add(labelTextSaveTable_AIA);
            groupBox2.Controls.Add(buttonDownloadOrders_AIA);
            groupBox2.Controls.Add(buttonOpenOrder_AIA);
            groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            groupBox2.Location = new Point(6, 4);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(227, 75);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // labelTextOpenTable_AIA
            // 
            labelTextOpenTable_AIA.AutoSize = true;
            labelTextOpenTable_AIA.Location = new Point(129, 9);
            labelTextOpenTable_AIA.Name = "labelTextOpenTable_AIA";
            labelTextOpenTable_AIA.Size = new Size(94, 13);
            labelTextOpenTable_AIA.TabIndex = 4;
            labelTextOpenTable_AIA.Text = "Открыть таблицу";
            // 
            // labelTextSaveTable_AIA
            // 
            labelTextSaveTable_AIA.AutoSize = true;
            labelTextSaveTable_AIA.Location = new Point(5, 9);
            labelTextSaveTable_AIA.Name = "labelTextSaveTable_AIA";
            labelTextSaveTable_AIA.Size = new Size(103, 13);
            labelTextSaveTable_AIA.TabIndex = 3;
            labelTextSaveTable_AIA.Text = "Сохранить таблицу";
            // 
            // buttonDownloadOrders_AIA
            // 
            buttonDownloadOrders_AIA.BackColor = SystemColors.Window;
            buttonDownloadOrders_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonDownloadOrders_AIA.BackgroundImage");
            buttonDownloadOrders_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonDownloadOrders_AIA.FlatStyle = FlatStyle.Flat;
            buttonDownloadOrders_AIA.Location = new Point(29, 26);
            buttonDownloadOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonDownloadOrders_AIA.Name = "buttonDownloadOrders_AIA";
            buttonDownloadOrders_AIA.Size = new Size(49, 40);
            buttonDownloadOrders_AIA.TabIndex = 0;
            buttonDownloadOrders_AIA.UseVisualStyleBackColor = false;
            buttonDownloadOrders_AIA.Click += buttonDownload_AIA_Click;
            // 
            // buttonOpenOrder_AIA
            // 
            buttonOpenOrder_AIA.BackColor = SystemColors.Window;
            buttonOpenOrder_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonOpenOrder_AIA.BackgroundImage");
            buttonOpenOrder_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenOrder_AIA.FlatStyle = FlatStyle.Flat;
            buttonOpenOrder_AIA.Location = new Point(149, 26);
            buttonOpenOrder_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonOpenOrder_AIA.Name = "buttonOpenOrder_AIA";
            buttonOpenOrder_AIA.Size = new Size(49, 40);
            buttonOpenOrder_AIA.TabIndex = 0;
            buttonOpenOrder_AIA.UseVisualStyleBackColor = false;
            buttonOpenOrder_AIA.Click += buttonOpen_AIA_Click;
            // 
            // dataGridViewTableOrders_AIA
            // 
            dataGridViewTableOrders_AIA.AllowUserToAddRows = false;
            dataGridViewTableOrders_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableOrders_AIA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTableOrders_AIA.BackgroundColor = SystemColors.Window;
            dataGridViewTableOrders_AIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTableOrders_AIA.Columns.AddRange(new DataGridViewColumn[] { NumberOrder_AIA, DateDone_AIA, PriceOrder_AIA, CapitalOrder_AIA, PhoneOrder_AIA });
            dataGridViewTableOrders_AIA.Location = new Point(4, 79);
            dataGridViewTableOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTableOrders_AIA.Name = "dataGridViewTableOrders_AIA";
            dataGridViewTableOrders_AIA.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewTableOrders_AIA.RowHeadersVisible = false;
            dataGridViewTableOrders_AIA.RowHeadersWidth = 51;
            dataGridViewTableOrders_AIA.RowTemplate.Height = 24;
            dataGridViewTableOrders_AIA.Size = new Size(1284, 556);
            dataGridViewTableOrders_AIA.TabIndex = 1;
            dataGridViewTableOrders_AIA.RowPrePaint += dataGridViewTable_AIA_RowPrePaint;
            // 
            // tabControl_AIA
            // 
            tabControl_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_AIA.Controls.Add(tabPageOrderData_AIA);
            tabControl_AIA.Controls.Add(tabPageStats_AIA);
            tabControl_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl_AIA.Location = new Point(0, 24);
            tabControl_AIA.Margin = new Padding(4);
            tabControl_AIA.Name = "tabControl_AIA";
            tabControl_AIA.SelectedIndex = 0;
            tabControl_AIA.Size = new Size(1315, 716);
            tabControl_AIA.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 24);
            splitter1.Margin = new Padding(4);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 716);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // NumberOrder_AIA
            // 
            NumberOrder_AIA.FillWeight = 20F;
            NumberOrder_AIA.HeaderText = "Номер";
            NumberOrder_AIA.MinimumWidth = 6;
            NumberOrder_AIA.Name = "NumberOrder_AIA";
            NumberOrder_AIA.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DateDone_AIA
            // 
            DateDone_AIA.HeaderText = "Название";
            DateDone_AIA.MinimumWidth = 6;
            DateDone_AIA.Name = "DateDone_AIA";
            DateDone_AIA.Resizable = DataGridViewTriState.True;
            DateDone_AIA.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceOrder_AIA
            // 
            PriceOrder_AIA.HeaderText = "Адрес";
            PriceOrder_AIA.MinimumWidth = 6;
            PriceOrder_AIA.Name = "PriceOrder_AIA";
            PriceOrder_AIA.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // CapitalOrder_AIA
            // 
            CapitalOrder_AIA.HeaderText = "Капитал владельцев магазинов";
            CapitalOrder_AIA.MinimumWidth = 6;
            CapitalOrder_AIA.Name = "CapitalOrder_AIA";
            CapitalOrder_AIA.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PhoneOrder_AIA
            // 
            PhoneOrder_AIA.HeaderText = "Телефон магазина";
            PhoneOrder_AIA.MinimumWidth = 6;
            PhoneOrder_AIA.Name = "PhoneOrder_AIA";
            PhoneOrder_AIA.Resizable = DataGridViewTriState.True;
            PhoneOrder_AIA.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1315, 740);
            Controls.Add(splitter1);
            Controls.Add(tabControl_AIA);
            Controls.Add(menuStrip_AIA);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рабочая среда";
            menuStrip_AIA.ResumeLayout(false);
            menuStrip_AIA.PerformLayout();
            tabPageStats_AIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPageOrderData_AIA.ResumeLayout(false);
            groupBoxMovesOrders_AIA.ResumeLayout(false);
            groupBoxMovesOrders_AIA.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_AIA).EndInit();
            tabControl_AIA.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_AIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_AIA;
        private System.Windows.Forms.MenuStrip menuStrip_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_AIA;
        private System.Windows.Forms.TabPage tabPageStats_AIA;
        private System.Windows.Forms.TabPage tabPageOrderData_AIA;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_AIA;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_AIA;
        private System.Windows.Forms.Button buttonOpenOrder_AIA;
        private System.Windows.Forms.Button buttonAddOrders_AIA;
        private System.Windows.Forms.Button buttonDownloadOrders_AIA;
        private System.Windows.Forms.TabControl tabControl_AIA;
        private System.Windows.Forms.Button buttonFilter_AIA;
        private System.Windows.Forms.TextBox textBoxFilter_AIA;
        private System.Windows.Forms.Button buttonRemoveRows_AIA;
        private System.Windows.Forms.ComboBox comboBoxColsNames_AIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGetStats_AIA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private Label labelTextDeleteString_AIA;
        private Label labelTextAddString_AIA;
        private Label labelTextOpenTable_AIA;
        private Label labelTextSaveTable_AIA;
        private GroupBox groupBox3;
        private TextBox textBoxSearch;
        private DataGridViewTextBoxColumn NumberOrder_AIA;
        private DataGridViewTextBoxColumn DateDone_AIA;
        private DataGridViewTextBoxColumn PriceOrder_AIA;
        private DataGridViewTextBoxColumn CapitalOrder_AIA;
        private DataGridViewTextBoxColumn PhoneOrder_AIA;
    }
}
