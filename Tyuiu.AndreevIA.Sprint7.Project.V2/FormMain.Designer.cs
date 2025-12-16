
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
            saveFileDialogTable_SAD = new SaveFileDialog();
            openFileDialogTable_SAD = new OpenFileDialog();
            menuStrip_SAD = new MenuStrip();
            SearchToolStripMenuItem_SAD = new ToolStripMenuItem();
            toolStripTextBoxSearch_SAD = new ToolStripTextBox();
            toolStripMenuFile_SAD = new ToolStripMenuItem();
            toolStripMenuItemAdd_SAD = new ToolStripMenuItem();
            toolStripMenuItemOpen_SAD = new ToolStripMenuItem();
            toolStripMenuItemSave_SAD = new ToolStripMenuItem();
            toolStripMenuItemInfo_SAD = new ToolStripMenuItem();
            toolStripMenuItemInstruction_SAD = new ToolStripMenuItem();
            toolStripMenuItemAbout_SAD = new ToolStripMenuItem();
            поддержкаToolStripMenuItem = new ToolStripMenuItem();
            tabPageStats_SAD = new TabPage();
            buttonGetStats_SAD = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPageOrderData_SAD = new TabPage();
            groupBoxMovesOrders_SAD = new GroupBox();
            groupBox5 = new GroupBox();
            textBoxFilter_SAD = new TextBox();
            groupBox4 = new GroupBox();
            textBoxSearch_SAD = new TextBox();
            groupBox3 = new GroupBox();
            comboBoxColsNames_SAD = new ComboBox();
            groupBox1 = new GroupBox();
            buttonRemoveRows_SAD = new Button();
            buttonAddOrders_SAD = new Button();
            label3 = new Label();
            groupBox2 = new GroupBox();
            buttonDownloadOrders_SAD = new Button();
            buttonOpenOrder_SAD = new Button();
            dataGridViewTableOrders_SAD = new DataGridView();
            NumberOrder_SAD = new DataGridViewTextBoxColumn();
            DateDone_SAD = new DataGridViewTextBoxColumn();
            PriceOrder_SAD = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            NameOrder_SAD = new DataGridViewTextBoxColumn();
            buttonFilter_SAD = new Button();
            tabControl_SAD = new TabControl();
            splitter1 = new Splitter();
            menuStrip_SAD.SuspendLayout();
            tabPageStats_SAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            tabPageOrderData_SAD.SuspendLayout();
            groupBoxMovesOrders_SAD.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_SAD).BeginInit();
            tabControl_SAD.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogTable_SAD
            // 
            openFileDialogTable_SAD.FileName = "openFileDialog1";
            // 
            // menuStrip_SAD
            // 
            menuStrip_SAD.BackColor = SystemColors.Window;
            menuStrip_SAD.ImageScalingSize = new Size(20, 20);
            menuStrip_SAD.Items.AddRange(new ToolStripItem[] { SearchToolStripMenuItem_SAD, toolStripMenuFile_SAD, toolStripMenuItemInfo_SAD });
            menuStrip_SAD.Location = new Point(0, 0);
            menuStrip_SAD.Name = "menuStrip_SAD";
            menuStrip_SAD.Padding = new Padding(7, 2, 0, 2);
            menuStrip_SAD.Size = new Size(1315, 24);
            menuStrip_SAD.TabIndex = 4;
            menuStrip_SAD.Text = "menuStrip1";
            // 
            // SearchToolStripMenuItem_SAD
            // 
            SearchToolStripMenuItem_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBoxSearch_SAD });
            SearchToolStripMenuItem_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchToolStripMenuItem_SAD.Name = "SearchToolStripMenuItem_SAD";
            SearchToolStripMenuItem_SAD.Size = new Size(56, 20);
            SearchToolStripMenuItem_SAD.Text = "Найти";
            // 
            // toolStripTextBoxSearch_SAD
            // 
            toolStripTextBoxSearch_SAD.Name = "toolStripTextBoxSearch_SAD";
            toolStripTextBoxSearch_SAD.Size = new Size(100, 23);
            toolStripTextBoxSearch_SAD.TextChanged += toolStripTextBoxSearch_SAD_TextChanged;
            // 
            // toolStripMenuFile_SAD
            // 
            toolStripMenuFile_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAdd_SAD, toolStripMenuItemOpen_SAD, toolStripMenuItemSave_SAD });
            toolStripMenuFile_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuFile_SAD.Name = "toolStripMenuFile_SAD";
            toolStripMenuFile_SAD.Size = new Size(51, 20);
            toolStripMenuFile_SAD.Text = "Файл";
            // 
            // toolStripMenuItemAdd_SAD
            // 
            toolStripMenuItemAdd_SAD.Name = "toolStripMenuItemAdd_SAD";
            toolStripMenuItemAdd_SAD.Size = new Size(180, 22);
            toolStripMenuItemAdd_SAD.Text = "Добавить";
            toolStripMenuItemAdd_SAD.Click += buttonAdd_SAD_Click;
            // 
            // toolStripMenuItemOpen_SAD
            // 
            toolStripMenuItemOpen_SAD.Name = "toolStripMenuItemOpen_SAD";
            toolStripMenuItemOpen_SAD.Size = new Size(180, 22);
            toolStripMenuItemOpen_SAD.Text = "Открыть";
            toolStripMenuItemOpen_SAD.Click += buttonOpen_SAD_Click;
            // 
            // toolStripMenuItemSave_SAD
            // 
            toolStripMenuItemSave_SAD.Name = "toolStripMenuItemSave_SAD";
            toolStripMenuItemSave_SAD.Size = new Size(180, 22);
            toolStripMenuItemSave_SAD.Text = "Сохранить";
            toolStripMenuItemSave_SAD.Click += buttonDownload_SAD_Click;
            // 
            // toolStripMenuItemInfo_SAD
            // 
            toolStripMenuItemInfo_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_SAD, toolStripMenuItemAbout_SAD, поддержкаToolStripMenuItem });
            toolStripMenuItemInfo_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_SAD.Name = "toolStripMenuItemInfo_SAD";
            toolStripMenuItemInfo_SAD.Size = new Size(68, 20);
            toolStripMenuItemInfo_SAD.Text = "Справка";
            // 
            // toolStripMenuItemInstruction_SAD
            // 
            toolStripMenuItemInstruction_SAD.Name = "toolStripMenuItemInstruction_SAD";
            toolStripMenuItemInstruction_SAD.Size = new Size(285, 22);
            toolStripMenuItemInstruction_SAD.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_SAD.Click += toolStripMenuItemInstruction_SAD_Click;
            // 
            // toolStripMenuItemAbout_SAD
            // 
            toolStripMenuItemAbout_SAD.Name = "toolStripMenuItemAbout_SAD";
            toolStripMenuItemAbout_SAD.Size = new Size(285, 22);
            toolStripMenuItemAbout_SAD.Text = "О программе ";
            toolStripMenuItemAbout_SAD.Click += buttonInfo_SAD_Click;
            // 
            // поддержкаToolStripMenuItem
            // 
            поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            поддержкаToolStripMenuItem.Size = new Size(285, 22);
            поддержкаToolStripMenuItem.Text = "Поддержка";
            поддержкаToolStripMenuItem.Click += поддержкаToolStripMenuItem_Click;
            // 
            // tabPageStats_SAD
            // 
            tabPageStats_SAD.Controls.Add(buttonGetStats_SAD);
            tabPageStats_SAD.Controls.Add(chart1);
            tabPageStats_SAD.Location = new Point(4, 30);
            tabPageStats_SAD.Margin = new Padding(4);
            tabPageStats_SAD.Name = "tabPageStats_SAD";
            tabPageStats_SAD.Size = new Size(1307, 682);
            tabPageStats_SAD.TabIndex = 2;
            tabPageStats_SAD.Text = "Статистика";
            tabPageStats_SAD.UseVisualStyleBackColor = true;
            // 
            // buttonGetStats_SAD
            // 
            buttonGetStats_SAD.Location = new Point(514, 542);
            buttonGetStats_SAD.Margin = new Padding(4);
            buttonGetStats_SAD.Name = "buttonGetStats_SAD";
            buttonGetStats_SAD.Size = new Size(199, 45);
            buttonGetStats_SAD.TabIndex = 1;
            buttonGetStats_SAD.Text = "Получить статистику по выручке из каждого филиала";
            buttonGetStats_SAD.UseVisualStyleBackColor = true;
            buttonGetStats_SAD.Click += button1_Click;
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
            // tabPageOrderData_SAD
            // 
            tabPageOrderData_SAD.Controls.Add(groupBoxMovesOrders_SAD);
            tabPageOrderData_SAD.Location = new Point(4, 30);
            tabPageOrderData_SAD.Margin = new Padding(4);
            tabPageOrderData_SAD.Name = "tabPageOrderData_SAD";
            tabPageOrderData_SAD.Padding = new Padding(4);
            tabPageOrderData_SAD.Size = new Size(1307, 682);
            tabPageOrderData_SAD.TabIndex = 1;
            tabPageOrderData_SAD.Text = "База данных сети магазинов";
            tabPageOrderData_SAD.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovesOrders_SAD
            // 
            groupBoxMovesOrders_SAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMovesOrders_SAD.BackColor = SystemColors.Menu;
            groupBoxMovesOrders_SAD.Controls.Add(groupBox5);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox4);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox3);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox1);
            groupBoxMovesOrders_SAD.Controls.Add(label3);
            groupBoxMovesOrders_SAD.Controls.Add(groupBox2);
            groupBoxMovesOrders_SAD.Controls.Add(dataGridViewTableOrders_SAD);
            groupBoxMovesOrders_SAD.Controls.Add(buttonFilter_SAD);
            groupBoxMovesOrders_SAD.Location = new Point(4, 0);
            groupBoxMovesOrders_SAD.Margin = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_SAD.Name = "groupBoxMovesOrders_SAD";
            groupBoxMovesOrders_SAD.Padding = new Padding(3, 2, 3, 2);
            groupBoxMovesOrders_SAD.Size = new Size(1295, 634);
            groupBoxMovesOrders_SAD.TabIndex = 4;
            groupBoxMovesOrders_SAD.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.AccessibleRole = AccessibleRole.None;
            groupBox5.BackColor = SystemColors.Menu;
            groupBox5.Controls.Add(textBoxFilter_SAD);
            groupBox5.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(759, 0);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(256, 75);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Введите ключ для фильтрации:";
            // 
            // textBoxFilter_SAD
            // 
            textBoxFilter_SAD.BackColor = SystemColors.Window;
            textBoxFilter_SAD.Enabled = false;
            textBoxFilter_SAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxFilter_SAD.Location = new Point(24, 34);
            textBoxFilter_SAD.Margin = new Padding(4);
            textBoxFilter_SAD.Name = "textBoxFilter_SAD";
            textBoxFilter_SAD.Size = new Size(207, 24);
            textBoxFilter_SAD.TabIndex = 1;
            textBoxFilter_SAD.TextChanged += textBoxFilter_SAD_TextChanged;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.Menu;
            groupBox4.Controls.Add(textBoxSearch_SAD);
            groupBox4.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(540, 0);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(252, 75);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Введите ключ для поиска:\n";
            // 
            // textBoxSearch_SAD
            // 
            textBoxSearch_SAD.BackColor = SystemColors.Window;
            textBoxSearch_SAD.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxSearch_SAD.Location = new Point(7, 36);
            textBoxSearch_SAD.Margin = new Padding(4);
            textBoxSearch_SAD.Name = "textBoxSearch_SAD";
            textBoxSearch_SAD.Size = new Size(162, 24);
            textBoxSearch_SAD.TabIndex = 1;
            textBoxSearch_SAD.TextChanged += textBoxSearch_SAD_TextChanged_1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Menu;
            groupBox3.Controls.Add(comboBoxColsNames_SAD);
            groupBox3.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(358, 0);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(238, 75);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выберите столбец";
            // 
            // comboBoxColsNames_SAD
            // 
            comboBoxColsNames_SAD.BackColor = SystemColors.Window;
            comboBoxColsNames_SAD.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColsNames_SAD.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxColsNames_SAD.ForeColor = SystemColors.WindowText;
            comboBoxColsNames_SAD.FormattingEnabled = true;
            comboBoxColsNames_SAD.Items.AddRange(new object[] { "", "Номер филиала", "Название магазина", "Адрес", "Ежемесячная выручка", "Контактный телефон" });
            comboBoxColsNames_SAD.Location = new Point(7, 36);
            comboBoxColsNames_SAD.Margin = new Padding(4);
            comboBoxColsNames_SAD.Name = "comboBoxColsNames_SAD";
            comboBoxColsNames_SAD.Size = new Size(168, 27);
            comboBoxColsNames_SAD.TabIndex = 3;
            comboBoxColsNames_SAD.SelectedIndexChanged += comboBoxColsNames_SAD_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Menu;
            groupBox1.Controls.Add(buttonRemoveRows_SAD);
            groupBox1.Controls.Add(buttonAddOrders_SAD);
            groupBox1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(197, 0);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(199, 75);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавить/Удалить ";
            // 
            // buttonRemoveRows_SAD
            // 
            buttonRemoveRows_SAD.BackColor = SystemColors.Window;
            buttonRemoveRows_SAD.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonRemoveRows_SAD.BackgroundImage");
            buttonRemoveRows_SAD.BackgroundImageLayout = ImageLayout.Center;
            buttonRemoveRows_SAD.Enabled = false;
            buttonRemoveRows_SAD.FlatStyle = FlatStyle.Flat;
            buttonRemoveRows_SAD.ForeColor = Color.Black;
            buttonRemoveRows_SAD.Location = new Point(77, 28);
            buttonRemoveRows_SAD.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveRows_SAD.Name = "buttonRemoveRows_SAD";
            buttonRemoveRows_SAD.Size = new Size(45, 38);
            buttonRemoveRows_SAD.TabIndex = 0;
            buttonRemoveRows_SAD.UseVisualStyleBackColor = false;
            buttonRemoveRows_SAD.Click += buttonRemoveRows_SAD_Click;
            // 
            // buttonAddOrders_SAD
            // 
            buttonAddOrders_SAD.BackColor = SystemColors.Window;
            buttonAddOrders_SAD.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonAddOrders_SAD.BackgroundImage");
            buttonAddOrders_SAD.BackgroundImageLayout = ImageLayout.Center;
            buttonAddOrders_SAD.FlatStyle = FlatStyle.Flat;
            buttonAddOrders_SAD.Location = new Point(18, 28);
            buttonAddOrders_SAD.Margin = new Padding(3, 2, 3, 2);
            buttonAddOrders_SAD.Name = "buttonAddOrders_SAD";
            buttonAddOrders_SAD.Size = new Size(43, 38);
            buttonAddOrders_SAD.TabIndex = 0;
            buttonAddOrders_SAD.UseVisualStyleBackColor = false;
            buttonAddOrders_SAD.Click += buttonAdd_SAD_Click;
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
            groupBox2.Controls.Add(buttonDownloadOrders_SAD);
            groupBox2.Controls.Add(buttonOpenOrder_SAD);
            groupBox2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(6, 0);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(230, 75);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Сохранить/Выгрузить";
            // 
            // buttonDownloadOrders_SAD
            // 
            buttonDownloadOrders_SAD.BackColor = SystemColors.Window;
            buttonDownloadOrders_SAD.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonDownloadOrders_SAD.BackgroundImage");
            buttonDownloadOrders_SAD.BackgroundImageLayout = ImageLayout.Center;
            buttonDownloadOrders_SAD.FlatStyle = FlatStyle.Flat;
            buttonDownloadOrders_SAD.Location = new Point(38, 26);
            buttonDownloadOrders_SAD.Margin = new Padding(3, 2, 3, 2);
            buttonDownloadOrders_SAD.Name = "buttonDownloadOrders_SAD";
            buttonDownloadOrders_SAD.Size = new Size(49, 40);
            buttonDownloadOrders_SAD.TabIndex = 0;
            buttonDownloadOrders_SAD.UseVisualStyleBackColor = false;
            buttonDownloadOrders_SAD.Click += buttonDownload_SAD_Click;
            // 
            // buttonOpenOrder_SAD
            // 
            buttonOpenOrder_SAD.BackColor = SystemColors.Window;
            buttonOpenOrder_SAD.BackgroundImage = (System.Drawing.Image)resources.GetObject("buttonOpenOrder_SAD.BackgroundImage");
            buttonOpenOrder_SAD.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenOrder_SAD.FlatStyle = FlatStyle.Flat;
            buttonOpenOrder_SAD.Location = new Point(91, 26);
            buttonOpenOrder_SAD.Margin = new Padding(3, 2, 3, 2);
            buttonOpenOrder_SAD.Name = "buttonOpenOrder_SAD";
            buttonOpenOrder_SAD.Size = new Size(49, 40);
            buttonOpenOrder_SAD.TabIndex = 0;
            buttonOpenOrder_SAD.UseVisualStyleBackColor = false;
            buttonOpenOrder_SAD.Click += buttonOpen_SAD_Click;
            // 
            // dataGridViewTableOrders_SAD
            // 
            dataGridViewTableOrders_SAD.AllowUserToAddRows = false;
            dataGridViewTableOrders_SAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewTableOrders_SAD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTableOrders_SAD.BackgroundColor = SystemColors.Window;
            dataGridViewTableOrders_SAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTableOrders_SAD.Columns.AddRange(new DataGridViewColumn[] { NumberOrder_SAD, DateDone_SAD, PriceOrder_SAD, Column1, NameOrder_SAD });
            dataGridViewTableOrders_SAD.Location = new Point(4, 79);
            dataGridViewTableOrders_SAD.Margin = new Padding(3, 2, 3, 2);
            dataGridViewTableOrders_SAD.Name = "dataGridViewTableOrders_SAD";
            dataGridViewTableOrders_SAD.RowHeadersVisible = false;
            dataGridViewTableOrders_SAD.RowHeadersWidth = 51;
            dataGridViewTableOrders_SAD.RowTemplate.Height = 24;
            dataGridViewTableOrders_SAD.Size = new Size(1284, 548);
            dataGridViewTableOrders_SAD.TabIndex = 1;
            dataGridViewTableOrders_SAD.RowPrePaint += dataGridViewTable_SAD_RowPrePaint;
            // 
            // NumberOrder_SAD
            // 
            NumberOrder_SAD.HeaderText = "Номер филиала";
            NumberOrder_SAD.MinimumWidth = 6;
            NumberOrder_SAD.Name = "NumberOrder_SAD";
            NumberOrder_SAD.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // DateDone_SAD
            // 
            DateDone_SAD.HeaderText = "Название магазина";
            DateDone_SAD.MinimumWidth = 6;
            DateDone_SAD.Name = "DateDone_SAD";
            DateDone_SAD.Resizable = DataGridViewTriState.True;
            DateDone_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // PriceOrder_SAD
            // 
            PriceOrder_SAD.HeaderText = "Адрес";
            PriceOrder_SAD.MinimumWidth = 6;
            PriceOrder_SAD.Name = "PriceOrder_SAD";
            PriceOrder_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ежемесячная выручка";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // NameOrder_SAD
            // 
            NameOrder_SAD.HeaderText = "Проходимость людей/ч";
            NameOrder_SAD.MinimumWidth = 6;
            NameOrder_SAD.Name = "NameOrder_SAD";
            NameOrder_SAD.Resizable = DataGridViewTriState.True;
            NameOrder_SAD.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonFilter_SAD
            // 
            buttonFilter_SAD.Enabled = false;
            buttonFilter_SAD.Font = new System.Drawing.Font("Sitka Banner", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonFilter_SAD.Location = new Point(1086, 16);
            buttonFilter_SAD.Margin = new Padding(3, 2, 3, 2);
            buttonFilter_SAD.Name = "buttonFilter_SAD";
            buttonFilter_SAD.Size = new Size(122, 58);
            buttonFilter_SAD.TabIndex = 0;
            buttonFilter_SAD.Text = "Отфильтровать";
            buttonFilter_SAD.UseVisualStyleBackColor = true;
            buttonFilter_SAD.Click += buttonFilter_SAD_Click;
            // 
            // tabControl_SAD
            // 
            tabControl_SAD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl_SAD.Controls.Add(tabPageOrderData_SAD);
            tabControl_SAD.Controls.Add(tabPageStats_SAD);
            tabControl_SAD.Font = new System.Drawing.Font("Sitka Banner", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            tabControl_SAD.Location = new Point(0, 24);
            tabControl_SAD.Margin = new Padding(4);
            tabControl_SAD.Name = "tabControl_SAD";
            tabControl_SAD.SelectedIndex = 0;
            tabControl_SAD.Size = new Size(1315, 716);
            tabControl_SAD.TabIndex = 3;
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
            Controls.Add(tabControl_SAD);
            Controls.Add(menuStrip_SAD);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Рабочая среда";
            menuStrip_SAD.ResumeLayout(false);
            menuStrip_SAD.PerformLayout();
            tabPageStats_SAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            tabPageOrderData_SAD.ResumeLayout(false);
            groupBoxMovesOrders_SAD.ResumeLayout(false);
            groupBoxMovesOrders_SAD.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTableOrders_SAD).EndInit();
            tabControl_SAD.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_SAD;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_SAD;
        private System.Windows.Forms.MenuStrip menuStrip_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAdd_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SAD;
        private System.Windows.Forms.TabPage tabPageStats_SAD;
        private System.Windows.Forms.TabPage tabPageOrderData_SAD;
        private System.Windows.Forms.DataGridView dataGridViewTableOrders_SAD;
        private System.Windows.Forms.GroupBox groupBoxMovesOrders_SAD;
        private System.Windows.Forms.Button buttonOpenOrder_SAD;
        private System.Windows.Forms.Button buttonAddOrders_SAD;
        private System.Windows.Forms.Button buttonDownloadOrders_SAD;
        private System.Windows.Forms.TabControl tabControl_SAD;
        private System.Windows.Forms.Button buttonFilter_SAD;
        private System.Windows.Forms.TextBox textBoxSearch_SAD;
        private System.Windows.Forms.TextBox textBoxFilter_SAD;
        private System.Windows.Forms.Button buttonRemoveRows_SAD;
        private System.Windows.Forms.ComboBox comboBoxColsNames_SAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button buttonGetStats_SAD;
        private System.Windows.Forms.ToolStripMenuItem SearchToolStripMenuItem_SAD;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_SAD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private DataGridViewTextBoxColumn NumberOrder_SAD;
        private DataGridViewTextBoxColumn DateDone_SAD;
        private DataGridViewTextBoxColumn PriceOrder_SAD;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn NameOrder_SAD;
    }
}
