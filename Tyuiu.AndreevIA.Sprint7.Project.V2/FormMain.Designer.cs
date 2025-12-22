
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            saveFileDialogTable_AIA = new SaveFileDialog();
            openFileDialogTable_AIA = new OpenFileDialog();
            menuStrip_AIA = new MenuStrip();
            SearchToolStripMenuItem_AIA = new ToolStripMenuItem();
            toolStripTextBoxSearch_AIA = new ToolStripTextBox();
            toolStripMenuFile_AIA = new ToolStripMenuItem();
            toolStripMenuItemAdd_AIA = new ToolStripMenuItem();
            toolStripMenuItemOpen_AIA = new ToolStripMenuItem();
            toolStripMenuItemSave_AIA = new ToolStripMenuItem();
            toolStripMenuItemInfo_AIA = new ToolStripMenuItem();
            toolStripMenuItemInstruction_AIA = new ToolStripMenuItem();
            toolStripMenuItemAbout_AIA = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            tabPageStats_AIA = new TabPage();
            buttonGetStats_AIA = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageOrderData_AIA = new TabPage();
            groupBoxMovesOrders_AIA = new GroupBox();
            groupBox5 = new GroupBox();
            textBoxFilter_AIA = new TextBox();
            groupBox4 = new GroupBox();
            textBoxSearch_AIA = new TextBox();
            groupBox3 = new GroupBox();
            comboBoxColsNames_AIA = new ComboBox();
            groupBox1 = new GroupBox();
            buttonRemoveRows_AIA = new Button();
            buttonAddOrders_AIA = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            buttonDownloadOrders_AIA = new Button();
            buttonOpenOrder_AIA = new Button();
            dataGridViewTableOrders_AIA = new DataGridView();
            NumberOrder_AIA = new DataGridViewTextBoxColumn();
            DateDone_AIA = new DataGridViewTextBoxColumn();
            PriceOrder_AIA = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            NameOrder_AIA = new DataGridViewTextBoxColumn();
            buttonFilter_AIA = new Button();
            tabControl_AIA = new TabControl();
            splitter1 = new Splitter();
            menuStrip_AIA.SuspendLayout();
            tabPageStats_AIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPageOrderData_AIA.SuspendLayout();
            groupBoxMovesOrders_AIA.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
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
            menuStrip_AIA.Items.AddRange(new ToolStripItem[] { SearchToolStripMenuItem_AIA, toolStripMenuFile_AIA, toolStripMenuItemInfo_AIA });
            menuStrip_AIA.Location = new Point(0, 0);
            menuStrip_AIA.Name = "menuStrip_AIA";
            menuStrip_AIA.Padding = new Padding(7, 2, 0, 2);
            menuStrip_AIA.Size = new Size(1315, 24);
            menuStrip_AIA.TabIndex = 4;
            menuStrip_AIA.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem_AIA
            // 
            SearchToolStripMenuItem_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxSearch_AIA });
            SearchToolStripMenuItem_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchToolStripMenuItem_AIA.Name = "SearchToolStripMenuItem_AIA";
            SearchToolStripMenuItem_AIA.Size = new Size(56, 20);
            SearchToolStripMenuItem_AIA.Text = "Найти";
            // 
            // toolStripTextBoxSearch_AIA
            // 
            toolStripTextBoxSearch_AIA.Name = "toolStripTextBoxSearch_AIA";
            toolStripTextBoxSearch_AIA.Size = new Size(100, 23);
            toolStripTextBoxSearch_AIA.TextChanged += toolStripTextBoxSearch_AIA_TextChanged;
            // 
            // toolStripMenuFile_AIA
            // 
            toolStripMenuFile_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAdd_AIA, toolStripMenuItemOpen_AIA, toolStripMenuItemSave_AIA });
            toolStripMenuFile_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuFile_AIA.Name = "toolStripMenuFile_AIA";
            toolStripMenuFile_AIA.Size = new Size(51, 20);
            toolStripMenuFile_AIA.Text = "Файл";
            // 
            // toolStripMenuItemAdd_AIA
            // 
            toolStripMenuItemAdd_AIA.Name = "toolStripMenuItemAdd_AIA";
            toolStripMenuItemAdd_AIA.Size = new Size(137, 22);
            toolStripMenuItemAdd_AIA.Text = "Добавить";
            toolStripMenuItemAdd_AIA.Click += buttonAdd_AIA_Click;
            // 
            // toolStripMenuItemOpen_AIA
            // 
            toolStripMenuItemOpen_AIA.Name = "toolStripMenuItemOpen_AIA";
            toolStripMenuItemOpen_AIA.Size = new Size(137, 22);
            toolStripMenuItemOpen_AIA.Text = "Открыть";
            toolStripMenuItemOpen_AIA.Click += buttonOpen_AIA_Click;
            // 
            // toolStripMenuItemSave_AIA
            // 
            toolStripMenuItemSave_AIA.Name = "toolStripMenuItemSave_AIA";
            toolStripMenuItemSave_AIA.Size = new Size(137, 22);
            toolStripMenuItemSave_AIA.Text = "Сохранить";
            toolStripMenuItemSave_AIA.Click += buttonDownload_AIA_Click;
            // 
            // toolStripMenuItemInfo_AIA
            // 
            toolStripMenuItemInfo_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_AIA, toolStripMenuItemAbout_AIA, поддержкаToolStripMenuItem });
            toolStripMenuItemInfo_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_AIA.Name = "toolStripMenuItemInfo_AIA";
            toolStripMenuItemInfo_AIA.Size = new Size(68, 20);
            toolStripMenuItemInfo_AIA.Text = "Справка";
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
            tabPageStats_AIA.Location = new Point(4, 30);
            tabPageStats_AIA.Margin = new Padding(4);
            tabPageStats_AIA.Name = "tabPageStats_AIA";
            tabPageStats_AIA.Size = new Size(1307, 682);
            tabPageStats_AIA.TabIndex = 2;
            tabPageStats_AIA.Text = "Статистика";
            tabPageStats_AIA.UseVisualStyleBackColor = true;
            // 
            // buttonGetStats_AIA
            // 
            buttonGetStats_AIA.Location = new Point(514, 542);
            buttonGetStats_AIA.Margin = new Padding(4);
            buttonGetStats_AIA.Name = "buttonGetStats_AIA";
            buttonGetStats_AIA.Size = new Size(199, 45);
            buttonGetStats_AIA.TabIndex = 1;
            buttonGetStats_AIA.Text = "Получить статистику по выручке из каждого филиала";
            buttonGetStats_AIA.UseVisualStyleBackColor = true;
            buttonGetStats_AIA.Click += button1_Click;
            // 
            // chart1
            // 
            chartArea1.Name = "Размер выручки";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Размер выручки";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(10, 4);
            chart1.Margin = new Padding(4);
            chart1.Name = "chart1";
            series1.ChartArea = "Размер выручки";
            series1.Legend = "Размер выручки";
            series1.MarkerSize = 1;
            series1.Name = "Размер выручки";
            series1.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series1.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            chart1.Series.Add(series1);
            chart1.Size = new Size(1247, 531);
            chart1.TabIndex = 0;
            chart1.Text = "Размер выручки";
            chart1.Click += chart1_Click;
            // 
            // tabPageOrderData_AIA
            // 
            tabPageOrderData_AIA.Controls.Add(groupBoxMovesOrders_AIA);
            tabPageOrderData_AIA.Location = new Point(4, 30);
            tabPageOrderData_AIA.Margin = new Padding(4);
            tabPageOrderData_AIA.Name = "tabPageOrderData_AIA";
            tabPageOrderData_AIA.Padding = new Padding(4);
            tabPageOrderData_AIA.Size = new Size(1307, 682);
            tabPageOrderData_AIA.TabIndex = 1;
            tabPageOrderData_AIA.Text = "База данных сети магазинов";
            tabPageOrderData_AIA.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovesOrders_AIA
            // 
            groupBoxMovesOrders_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMovesOrders_AIA.BackColor = SystemColors.Menu;
            groupBoxMovesOrders_AIA.Controls.Add(groupBox5);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox4);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox3);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox1);
            groupBoxMovesOrders_AIA.Controls.Add(label3);
            groupBoxMovesOrders_AIA.Controls.Add(groupBox2);
            groupBoxMovesOrders_AIA.Controls.Add(dataGridViewTableOrders_AIA);
            groupBoxMovesOrders_AIA.Controls.Add(buttonFilter_AIA);
            groupBoxMovesOrders_AIA.Location = new Point(4, 0);
            groupBoxMovesOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_AIA.Name = "groupBoxMovesOrders_AIA";
            groupBoxMovesOrders_AIA.Padding = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_AIA.Size = new Size(1295, 634);
            groupBoxMovesOrders_AIA.TabIndex = 4;
            groupBoxMovesOrders_AIA.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.AccessibleRole = AccessibleRole.None;
            groupBox5.BackColor = SystemColors.Menu;
            groupBox5.Controls.Add(textBoxFilter_AIA);
            groupBox5.Font = new System.Drawing.Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(759, 0);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(256, 75);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Введите ключ для фильтрации:";
            // 
            // textBoxFilter_AIA
            // 
            textBoxFilter_AIA.BackColor = SystemColors.Window;
            textBoxFilter_AIA.Enabled = false;
            textBoxFilter_AIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFilter_AIA.Location = new Point(24, 34);
            textBoxFilter_AIA.Margin = new Padding(4);
            textBoxFilter_AIA.Name = "textBoxFilter_AIA";
            textBoxFilter_AIA.Size = new Size(207, 24);
            textBoxFilter_AIA.TabIndex = 1;
            textBoxFilter_AIA.TextChanged += textBoxFilter_AIA_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Menu;
            groupBox4.Controls.Add(textBoxSearch_AIA);
            groupBox4.Font = new System.Drawing.Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(540, 0);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(252, 75);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите ключ для поиска:\n";
            // 
            // textBoxSearch_AIA
            // 
            textBoxSearch_AIA.BackColor = SystemColors.Window;
            textBoxSearch_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch_AIA.Location = new Point(7, 36);
            textBoxSearch_AIA.Margin = new Padding(4);
            textBoxSearch_AIA.Name = "textBoxSearch_AIA";
            textBoxSearch_AIA.Size = new Size(162, 24);
            textBoxSearch_AIA.TabIndex = 1;
            textBoxSearch_AIA.TextChanged += textBoxSearch_AIA_TextChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Menu;
            groupBox3.Controls.Add(comboBoxColsNames_AIA);
            groupBox3.Font = new System.Drawing.Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(358, 0);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(238, 75);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите столбец";
            // 
            // comboBoxColsNames_AIA
            // 
            comboBoxColsNames_AIA.BackColor = SystemColors.Window;
            comboBoxColsNames_AIA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColsNames_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxColsNames_AIA.ForeColor = SystemColors.WindowText;
            comboBoxColsNames_AIA.FormattingEnabled = true;
            comboBoxColsNames_AIA.Items.AddRange(new object[] { "", "Номер филиала", "Название магазина", "Адрес", "Ежемесячная выручка", "Контактный телефон" });
            comboBoxColsNames_AIA.Location = new Point(7, 36);
            comboBoxColsNames_AIA.Margin = new Padding(4);
            comboBoxColsNames_AIA.Name = "comboBoxColsNames_AIA";
            comboBoxColsNames_AIA.Size = new Size(168, 27);
            comboBoxColsNames_AIA.TabIndex = 3;
            comboBoxColsNames_AIA.SelectedIndexChanged += comboBoxColsNames_AIA_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(buttonRemoveRows_AIA);
            groupBox1.Controls.Add(buttonAddOrders_AIA);
            groupBox1.Font = new System.Drawing.Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(197, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(199, 75);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить/Удалить ";
            // 
            // buttonRemoveRows_AIA
            // 
            buttonRemoveRows_AIA.BackColor = SystemColors.Window;
            buttonRemoveRows_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonRemoveRows_AIA.BackgroundImage");
            buttonRemoveRows_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonRemoveRows_AIA.Enabled = false;
            buttonRemoveRows_AIA.FlatStyle = FlatStyle.Flat;
            buttonRemoveRows_AIA.ForeColor = Color.Black;
            buttonRemoveRows_AIA.Location = new Point(77, 28);
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
            buttonAddOrders_AIA.Location = new Point(18, 28);
            buttonAddOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonAddOrders_AIA.Name = "buttonAddOrders_AIA";
            buttonAddOrders_AIA.Size = new Size(43, 38);
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
            label3.Size = new Size(0, 21);
            label3.TabIndex = 5;
            label3.Click += label3_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Menu;
            groupBox2.Controls.Add(buttonDownloadOrders_AIA);
            groupBox2.Controls.Add(buttonOpenOrder_AIA);
            groupBox2.Font = new System.Drawing.Font("Sitka Display", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(6, 0);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(230, 75);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сохранить/Выгрузить";
            // 
            // buttonDownloadOrders_AIA
            // 
            buttonDownloadOrders_AIA.BackColor = SystemColors.Window;
            buttonDownloadOrders_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonDownloadOrders_AIA.BackgroundImage");
            buttonDownloadOrders_AIA.BackgroundImageLayout = ImageLayout.Center;
            buttonDownloadOrders_AIA.FlatStyle = FlatStyle.Flat;
            buttonDownloadOrders_AIA.Location = new Point(38, 26);
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
            buttonOpenOrder_AIA.Location = new Point(91, 26);
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
            dataGridViewTableOrders_AIA.Columns.AddRange(new DataGridViewColumn[] { NumberOrder_AIA, DateDone_AIA, PriceOrder_AIA, Column1, NameOrder_AIA });
            dataGridViewTableOrders_AIA.Location = new Point(4, 79);
            dataGridViewTableOrders_AIA.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTableOrders_AIA.Name = "dataGridViewTableOrders_AIA";
            dataGridViewTableOrders_AIA.RowHeadersVisible = false;
            dataGridViewTableOrders_AIA.RowHeadersWidth = 51;
            dataGridViewTableOrders_AIA.RowTemplate.Height = 24;
            dataGridViewTableOrders_AIA.Size = new Size(1284, 548);
            dataGridViewTableOrders_AIA.TabIndex = 1;
            dataGridViewTableOrders_AIA.RowPrePaint += dataGridViewTable_AIA_RowPrePaint;
            // 
            // NumberOrder_AIA
            // 
            NumberOrder_AIA.HeaderText = "Номер филиала";
            NumberOrder_AIA.MinimumWidth = 6;
            NumberOrder_AIA.Name = "NumberOrder_AIA";
            NumberOrder_AIA.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DateDone_AIA
            // 
            DateDone_AIA.HeaderText = "Название магазина";
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
            // Column1
            // 
            Column1.HeaderText = "Ежемесячная выручка";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NameOrder_AIA
            // 
            NameOrder_AIA.HeaderText = "Проходимость людей/ч";
            NameOrder_AIA.MinimumWidth = 6;
            NameOrder_AIA.Name = "NameOrder_AIA";
            NameOrder_AIA.Resizable = DataGridViewTriState.True;
            NameOrder_AIA.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonFilter_AIA
            // 
            buttonFilter_AIA.Enabled = false;
            buttonFilter_AIA.Font = new System.Drawing.Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonFilter_AIA.Location = new Point(1086, 16);
            buttonFilter_AIA.Margin = new Padding(3, 2, 3, 2);
            buttonFilter_AIA.Name = "buttonFilter_AIA";
            buttonFilter_AIA.Size = new Size(122, 58);
            buttonFilter_AIA.TabIndex = 0;
            buttonFilter_AIA.Text = "Отфильтровать";
            buttonFilter_AIA.UseVisualStyleBackColor = true;
            buttonFilter_AIA.Click += buttonFilter_AIA_Click;
            // 
            // tabControl_AIA
            // 
            tabControl_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_AIA.Controls.Add(tabPageOrderData_AIA);
            tabControl_AIA.Controls.Add(tabPageStats_AIA);
            tabControl_AIA.Font = new System.Drawing.Font("Sitka Banner", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 204);
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_AIA).EndInit();
            tabControl_AIA.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_AIA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_AIA;
        private System.Windows.Forms.MenuStrip menuStrip_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_AIA;
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
        private System.Windows.Forms.TextBox textBoxSearch_AIA;
        private System.Windows.Forms.TextBox textBoxFilter_AIA;
        private System.Windows.Forms.Button buttonRemoveRows_AIA;
        private System.Windows.Forms.ComboBox comboBoxColsNames_AIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGetStats_AIA;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_AIA;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_AIA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private DataGridViewTextBoxColumn NumberOrder_AIA;
        private DataGridViewTextBoxColumn DateDone_AIA;
        private DataGridViewTextBoxColumn PriceOrder_AIA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn NameOrder_AIA;
    }
}
