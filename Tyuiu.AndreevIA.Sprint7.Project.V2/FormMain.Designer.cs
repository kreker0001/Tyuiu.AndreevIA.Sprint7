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
            menuStrip_AIA = new MenuStrip();
            toolStripMenuItemInfo_AIA = new ToolStripMenuItem();
            toolStripMenuItemInstruction_AIA = new ToolStripMenuItem();
            toolStripMenuItemAbout_AIA = new ToolStripMenuItem();
            ToolStripMenuItemHelpBaton = new ToolStripMenuItem();
            toolStripMenuItemExit_AIA = new ToolStripMenuItem();
            textBox1_AIAlog = new TextBox();
            textBox2_AIApass = new TextBox();
            buttonEnterWorker_AIA = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            labelMain_AIA = new Label();
            groupBoxAuth = new GroupBox();
            menuStrip_AIA.SuspendLayout();
            groupBoxAuth.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_AIA
            // 
            menuStrip_AIA.BackColor = SystemColors.Menu;
            menuStrip_AIA.ImageScalingSize = new Size(20, 20);
            menuStrip_AIA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemInfo_AIA, toolStripMenuItemExit_AIA });
            menuStrip_AIA.Location = new Point(0, 0);
            menuStrip_AIA.Name = "menuStrip_AIA";
            menuStrip_AIA.Padding = new Padding(7, 2, 0, 2);
            menuStrip_AIA.Size = new Size(606, 27);
            menuStrip_AIA.TabIndex = 5;
            menuStrip_AIA.Text = "menuStrip1";
            // 
            // toolStripMenuItemInfo_AIA
            // 
            toolStripMenuItemInfo_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_AIA, toolStripMenuItemAbout_AIA, ToolStripMenuItemHelpBaton });
            toolStripMenuItemInfo_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_AIA.Name = "toolStripMenuItemInfo_AIA";
            toolStripMenuItemInfo_AIA.Size = new Size(65, 23);
            toolStripMenuItemInfo_AIA.Text = "Помощь";
            toolStripMenuItemInfo_AIA.Click += toolStripMenuItemInfo_AIA_Click;
            // 
            // toolStripMenuItemInstruction_AIA
            // 
            toolStripMenuItemInstruction_AIA.Name = "toolStripMenuItemInstruction_AIA";
            toolStripMenuItemInstruction_AIA.Size = new Size(265, 24);
            toolStripMenuItemInstruction_AIA.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_AIA.Click += toolStripMenuItemInstruction_AIA_Click;
            // 
            // toolStripMenuItemAbout_AIA
            // 
            toolStripMenuItemAbout_AIA.Name = "toolStripMenuItemAbout_AIA";
            toolStripMenuItemAbout_AIA.Size = new Size(265, 24);
            toolStripMenuItemAbout_AIA.Text = "О программе ";
            toolStripMenuItemAbout_AIA.Click += toolStripMenuItemAbout_AIA_Click;
            // 
            // ToolStripMenuItemHelpBaton
            // 
            ToolStripMenuItemHelpBaton.Name = "ToolStripMenuItemHelpBaton";
            ToolStripMenuItemHelpBaton.Size = new Size(265, 24);
            ToolStripMenuItemHelpBaton.Text = "Тех. поддержка";
            ToolStripMenuItemHelpBaton.Click += техПоддержкаToolStripMenuItem_Click;
            // 
            // toolStripMenuItemExit_AIA
            // 
            toolStripMenuItemExit_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toolStripMenuItemExit_AIA.Name = "toolStripMenuItemExit_AIA";
            toolStripMenuItemExit_AIA.Size = new Size(55, 23);
            toolStripMenuItemExit_AIA.Text = "Выход";
            toolStripMenuItemExit_AIA.Click += toolStripMenuItemExit_AIA_Click;
            // 
            // textBox1_AIAlog
            // 
            textBox1_AIAlog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1_AIAlog.Location = new Point(210, 120);
            textBox1_AIAlog.Margin = new Padding(4);
            textBox1_AIAlog.Name = "textBox1_AIAlog";
            textBox1_AIAlog.Size = new Size(210, 23);
            textBox1_AIAlog.TabIndex = 8;
            // 
            // textBox2_AIApass
            // 
            textBox2_AIApass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2_AIApass.Location = new Point(210, 172);
            textBox2_AIApass.Margin = new Padding(4);
            textBox2_AIApass.Name = "textBox2_AIApass";
            textBox2_AIApass.Size = new Size(210, 23);
            textBox2_AIApass.TabIndex = 9;
            textBox2_AIApass.UseSystemPasswordChar = true;
            // 
            // buttonEnterWorker_AIA
            // 
            buttonEnterWorker_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonEnterWorker_AIA.BackColor = SystemColors.GradientActiveCaption;
            buttonEnterWorker_AIA.FlatStyle = FlatStyle.Flat;
            buttonEnterWorker_AIA.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonEnterWorker_AIA.ForeColor = SystemColors.ActiveCaptionText;
            buttonEnterWorker_AIA.Location = new Point(210, 202);
            buttonEnterWorker_AIA.Margin = new Padding(4);
            buttonEnterWorker_AIA.Name = "buttonEnterWorker_AIA";
            buttonEnterWorker_AIA.Size = new Size(210, 46);
            buttonEnterWorker_AIA.TabIndex = 7;
            buttonEnterWorker_AIA.Text = "ВОЙТИ";
            buttonEnterWorker_AIA.UseVisualStyleBackColor = false;
            buttonEnterWorker_AIA.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(210, 95);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 19);
            label1.TabIndex = 10;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(210, 148);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 11;
            label2.Text = "Пароль:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(245, 263);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(123, 32);
            button1.TabIndex = 12;
            button1.Text = "Забыли пароль?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // labelMain_AIA
            // 
            labelMain_AIA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelMain_AIA.AutoSize = true;
            labelMain_AIA.Font = new System.Drawing.Font("Sitka Small", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelMain_AIA.Location = new Point(210, 46);
            labelMain_AIA.Margin = new Padding(4, 0, 4, 0);
            labelMain_AIA.Name = "labelMain_AIA";
            labelMain_AIA.Size = new Size(226, 39);
            labelMain_AIA.TabIndex = 6;
            labelMain_AIA.Text = "Авторизация:";
            labelMain_AIA.TextAlign = ContentAlignment.MiddleCenter;
            labelMain_AIA.Click += labelMain_AIA_Click;
            // 
            // groupBoxAuth
            // 
            groupBoxAuth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxAuth.AutoSize = true;
            groupBoxAuth.BackColor = SystemColors.Menu;
            groupBoxAuth.Controls.Add(labelMain_AIA);
            groupBoxAuth.Controls.Add(button1);
            groupBoxAuth.Controls.Add(label2);
            groupBoxAuth.Controls.Add(label1);
            groupBoxAuth.Controls.Add(buttonEnterWorker_AIA);
            groupBoxAuth.Controls.Add(textBox2_AIApass);
            groupBoxAuth.Controls.Add(textBox1_AIAlog);
            groupBoxAuth.Location = new Point(0, 31);
            groupBoxAuth.Margin = new Padding(4);
            groupBoxAuth.Name = "groupBoxAuth";
            groupBoxAuth.Padding = new Padding(4);
            groupBoxAuth.Size = new Size(606, 343);
            groupBoxAuth.TabIndex = 10;
            groupBoxAuth.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(606, 369);
            Controls.Add(groupBoxAuth);
            Controls.Add(menuStrip_AIA);
            Margin = new Padding(4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += FormMain_Load;
            menuStrip_AIA.ResumeLayout(false);
            menuStrip_AIA.PerformLayout();
            groupBoxAuth.ResumeLayout(false);
            groupBoxAuth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_AIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpBaton;
        private TextBox textBox1_AIAlog;
        private TextBox textBox2_AIApass;
        private Button buttonEnterWorker_AIA;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label labelMain_AIA;
        private GroupBox groupBoxAuth;
    }
}