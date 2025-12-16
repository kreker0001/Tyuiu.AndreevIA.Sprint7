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
            labelMain_AIA = new Label();
            buttonEnterWorker_AIA = new Button();
            textBox1_AIAlog = new TextBox();
            textBox2_AIApass = new TextBox();
            groupBoxAuth = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1Auth = new GroupBox();
            menuStrip_AIA.SuspendLayout();
            groupBoxAuth.SuspendLayout();
            groupBox1Auth.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_AIA
            // 
            menuStrip_AIA.ImageScalingSize = new Size(20, 20);
            menuStrip_AIA.Items.AddRange(new ToolStripItem[] { toolStripMenuItemInfo_AIA, toolStripMenuItemExit_AIA });
            menuStrip_AIA.Location = new Point(0, 0);
            menuStrip_AIA.Name = "menuStrip_AIA";
            menuStrip_AIA.Padding = new Padding(8, 3, 0, 3);
            menuStrip_AIA.Size = new Size(691, 34);
            menuStrip_AIA.TabIndex = 5;
            menuStrip_AIA.Text = "menuStrip1";
            // 
            // toolStripMenuItemInfo_AIA
            // 
            toolStripMenuItemInfo_AIA.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_AIA, toolStripMenuItemAbout_AIA, ToolStripMenuItemHelpBaton });
            toolStripMenuItemInfo_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_AIA.Name = "toolStripMenuItemInfo_AIA";
            toolStripMenuItemInfo_AIA.Size = new Size(82, 28);
            toolStripMenuItemInfo_AIA.Text = "Помощь";
            toolStripMenuItemInfo_AIA.Click += toolStripMenuItemInfo_AIA_Click;
            // 
            // toolStripMenuItemInstruction_AIA
            // 
            toolStripMenuItemInstruction_AIA.Name = "toolStripMenuItemInstruction_AIA";
            toolStripMenuItemInstruction_AIA.Size = new Size(348, 28);
            toolStripMenuItemInstruction_AIA.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_AIA.Click += toolStripMenuItemInstruction_AIA_Click;
            // 
            // toolStripMenuItemAbout_AIA
            // 
            toolStripMenuItemAbout_AIA.Name = "toolStripMenuItemAbout_AIA";
            toolStripMenuItemAbout_AIA.Size = new Size(348, 28);
            toolStripMenuItemAbout_AIA.Text = "О программе ";
            toolStripMenuItemAbout_AIA.Click += toolStripMenuItemAbout_AIA_Click;
            // 
            // ToolStripMenuItemHelpBaton
            // 
            ToolStripMenuItemHelpBaton.Name = "ToolStripMenuItemHelpBaton";
            ToolStripMenuItemHelpBaton.Size = new Size(348, 28);
            ToolStripMenuItemHelpBaton.Text = "Тех. поддержка";
            ToolStripMenuItemHelpBaton.Click += техПоддержкаToolStripMenuItem_Click;
            // 
            // toolStripMenuItemExit_AIA
            // 
            toolStripMenuItemExit_AIA.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemExit_AIA.Name = "toolStripMenuItemExit_AIA";
            toolStripMenuItemExit_AIA.Size = new Size(67, 28);
            toolStripMenuItemExit_AIA.Text = "Выход";
            toolStripMenuItemExit_AIA.Click += toolStripMenuItemExit_AIA_Click;
            // 
            // labelMain_AIA
            // 
            labelMain_AIA.AutoSize = true;
            labelMain_AIA.Font = new System.Drawing.Font("Sitka Banner", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelMain_AIA.Location = new Point(60, 9);
            labelMain_AIA.Margin = new Padding(4, 0, 4, 0);
            labelMain_AIA.Name = "labelMain_AIA";
            labelMain_AIA.Size = new Size(215, 49);
            labelMain_AIA.TabIndex = 6;
            labelMain_AIA.Text = "Авторизация:";
            labelMain_AIA.TextAlign = ContentAlignment.MiddleCenter;
            labelMain_AIA.Click += labelMain_AIA_Click;
            // 
            // buttonEnterWorker_AIA
            // 
            buttonEnterWorker_AIA.BackColor = SystemColors.GradientActiveCaption;
            buttonEnterWorker_AIA.FlatStyle = FlatStyle.Flat;
            buttonEnterWorker_AIA.Font = new System.Drawing.Font("Sitka Banner", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonEnterWorker_AIA.ForeColor = SystemColors.ActiveCaptionText;
            buttonEnterWorker_AIA.Location = new Point(61, 235);
            buttonEnterWorker_AIA.Margin = new Padding(4, 5, 4, 5);
            buttonEnterWorker_AIA.MaximumSize = new Size(240, 62);
            buttonEnterWorker_AIA.MinimumSize = new Size(240, 62);
            buttonEnterWorker_AIA.Name = "buttonEnterWorker_AIA";
            buttonEnterWorker_AIA.Size = new Size(240, 62);
            buttonEnterWorker_AIA.TabIndex = 7;
            buttonEnterWorker_AIA.Text = "ВОЙТИ";
            buttonEnterWorker_AIA.UseVisualStyleBackColor = false;
            buttonEnterWorker_AIA.Click += button1_Click;
            // 
            // textBox1_AIAlog
            // 
            textBox1_AIAlog.Location = new Point(61, 126);
            textBox1_AIAlog.Margin = new Padding(4, 5, 4, 5);
            textBox1_AIAlog.Name = "textBox1_AIAlog";
            textBox1_AIAlog.Size = new Size(239, 27);
            textBox1_AIAlog.TabIndex = 8;
            // 
            // textBox2_AIApass
            // 
            textBox2_AIApass.Location = new Point(61, 195);
            textBox2_AIApass.Margin = new Padding(4, 5, 4, 5);
            textBox2_AIApass.Name = "textBox2_AIApass";
            textBox2_AIApass.Size = new Size(239, 27);
            textBox2_AIApass.TabIndex = 9;
            textBox2_AIApass.UseSystemPasswordChar = true;
            // 
            // groupBoxAuth
            // 
            groupBoxAuth.BackColor = SystemColors.ActiveCaption;
            groupBoxAuth.Controls.Add(button1);
            groupBoxAuth.Controls.Add(label2);
            groupBoxAuth.Controls.Add(label1);
            groupBoxAuth.Controls.Add(groupBox1Auth);
            groupBoxAuth.Controls.Add(buttonEnterWorker_AIA);
            groupBoxAuth.Controls.Add(textBox2_AIApass);
            groupBoxAuth.Controls.Add(textBox1_AIAlog);
            groupBoxAuth.Location = new Point(164, 42);
            groupBoxAuth.Margin = new Padding(4, 5, 4, 5);
            groupBoxAuth.Name = "groupBoxAuth";
            groupBoxAuth.Padding = new Padding(4, 5, 4, 5);
            groupBoxAuth.Size = new Size(363, 369);
            groupBoxAuth.TabIndex = 10;
            groupBoxAuth.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            button1.Location = new Point(105, 306);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(141, 43);
            button1.TabIndex = 12;
            button1.Text = "Забыли пароль?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(61, 162);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 24);
            label2.TabIndex = 11;
            label2.Text = "Пароль:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(61, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 24);
            label1.TabIndex = 10;
            label1.Text = "Логин:";
            // 
            // groupBox1Auth
            // 
            groupBox1Auth.Controls.Add(labelMain_AIA);
            groupBox1Auth.Location = new Point(8, 15);
            groupBox1Auth.Margin = new Padding(4, 5, 4, 5);
            groupBox1Auth.Name = "groupBox1Auth";
            groupBox1Auth.Padding = new Padding(4, 5, 4, 5);
            groupBox1Auth.Size = new Size(347, 72);
            groupBox1Auth.TabIndex = 7;
            groupBox1Auth.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(691, 398);
            Controls.Add(groupBoxAuth);
            Controls.Add(menuStrip_AIA);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(709, 445);
            MinimumSize = new Size(709, 445);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += FormMain_Load;
            menuStrip_AIA.ResumeLayout(false);
            menuStrip_AIA.PerformLayout();
            groupBoxAuth.ResumeLayout(false);
            groupBoxAuth.PerformLayout();
            groupBox1Auth.ResumeLayout(false);
            groupBox1Auth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_AIA;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_AIA;
        private System.Windows.Forms.Label labelMain_AIA;
        private System.Windows.Forms.Button buttonEnterWorker_AIA;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpBaton;
        private System.Windows.Forms.TextBox textBox1_AIAlog;
        private System.Windows.Forms.TextBox textBox2_AIApass;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1Auth;
        private System.Windows.Forms.Button button1;
    }
}