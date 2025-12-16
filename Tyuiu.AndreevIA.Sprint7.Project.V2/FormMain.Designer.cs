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
            menuStrip_SAD = new MenuStrip();
            toolStripMenuItemInfo_SAD = new ToolStripMenuItem();
            toolStripMenuItemInstruction_SAD = new ToolStripMenuItem();
            toolStripMenuItemAbout_SAD = new ToolStripMenuItem();
            ToolStripMenuItemHelpBaton = new ToolStripMenuItem();
            toolStripMenuItemExit_SAD = new ToolStripMenuItem();
            labelMain_SAD = new Label();
            buttonEnterWorker_SAD = new Button();
            textBox1_SADlog = new TextBox();
            textBox2_SADpass = new TextBox();
            groupBoxAuth = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            groupBox1Auth = new GroupBox();
            menuStrip_SAD.SuspendLayout();
            groupBoxAuth.SuspendLayout();
            groupBox1Auth.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip_SAD
            // 
            menuStrip_SAD.ImageScalingSize = new Size(20, 20);
            menuStrip_SAD.Items.AddRange(new ToolStripItem[] { toolStripMenuItemInfo_SAD, toolStripMenuItemExit_SAD });
            menuStrip_SAD.Location = new Point(0, 0);
            menuStrip_SAD.Name = "menuStrip_SAD";
            menuStrip_SAD.Padding = new Padding(8, 3, 0, 3);
            menuStrip_SAD.Size = new Size(691, 34);
            menuStrip_SAD.TabIndex = 5;
            menuStrip_SAD.Text = "menuStrip1";
            // 
            // toolStripMenuItemInfo_SAD
            // 
            toolStripMenuItemInfo_SAD.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInstruction_SAD, toolStripMenuItemAbout_SAD, ToolStripMenuItemHelpBaton });
            toolStripMenuItemInfo_SAD.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemInfo_SAD.Name = "toolStripMenuItemInfo_SAD";
            toolStripMenuItemInfo_SAD.Size = new Size(82, 28);
            toolStripMenuItemInfo_SAD.Text = "Помощь";
            toolStripMenuItemInfo_SAD.Click += toolStripMenuItemInfo_SAD_Click;
            // 
            // toolStripMenuItemInstruction_SAD
            // 
            toolStripMenuItemInstruction_SAD.Name = "toolStripMenuItemInstruction_SAD";
            toolStripMenuItemInstruction_SAD.Size = new Size(348, 28);
            toolStripMenuItemInstruction_SAD.Text = "Краткое руководство пользователя";
            toolStripMenuItemInstruction_SAD.Click += toolStripMenuItemInstruction_SAD_Click;
            // 
            // toolStripMenuItemAbout_SAD
            // 
            toolStripMenuItemAbout_SAD.Name = "toolStripMenuItemAbout_SAD";
            toolStripMenuItemAbout_SAD.Size = new Size(348, 28);
            toolStripMenuItemAbout_SAD.Text = "О программе ";
            toolStripMenuItemAbout_SAD.Click += toolStripMenuItemAbout_SAD_Click;
            // 
            // ToolStripMenuItemHelpBaton
            // 
            ToolStripMenuItemHelpBaton.Name = "ToolStripMenuItemHelpBaton";
            ToolStripMenuItemHelpBaton.Size = new Size(348, 28);
            ToolStripMenuItemHelpBaton.Text = "Тех. поддержка";
            ToolStripMenuItemHelpBaton.Click += техПоддержкаToolStripMenuItem_Click;
            // 
            // toolStripMenuItemExit_SAD
            // 
            toolStripMenuItemExit_SAD.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 204);
            toolStripMenuItemExit_SAD.Name = "toolStripMenuItemExit_SAD";
            toolStripMenuItemExit_SAD.Size = new Size(67, 28);
            toolStripMenuItemExit_SAD.Text = "Выход";
            toolStripMenuItemExit_SAD.Click += toolStripMenuItemExit_SAD_Click;
            // 
            // labelMain_SAD
            // 
            labelMain_SAD.AutoSize = true;
            labelMain_SAD.Font = new System.Drawing.Font("Sitka Banner", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelMain_SAD.Location = new Point(60, 9);
            labelMain_SAD.Margin = new Padding(4, 0, 4, 0);
            labelMain_SAD.Name = "labelMain_SAD";
            labelMain_SAD.Size = new Size(215, 49);
            labelMain_SAD.TabIndex = 6;
            labelMain_SAD.Text = "Авторизация:";
            labelMain_SAD.TextAlign = ContentAlignment.MiddleCenter;
            labelMain_SAD.Click += labelMain_SAD_Click;
            // 
            // buttonEnterWorker_SAD
            // 
            buttonEnterWorker_SAD.BackColor = SystemColors.GradientActiveCaption;
            buttonEnterWorker_SAD.FlatStyle = FlatStyle.Flat;
            buttonEnterWorker_SAD.Font = new System.Drawing.Font("Sitka Banner", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            buttonEnterWorker_SAD.ForeColor = SystemColors.ActiveCaptionText;
            buttonEnterWorker_SAD.Location = new Point(61, 235);
            buttonEnterWorker_SAD.Margin = new Padding(4, 5, 4, 5);
            buttonEnterWorker_SAD.MaximumSize = new Size(240, 62);
            buttonEnterWorker_SAD.MinimumSize = new Size(240, 62);
            buttonEnterWorker_SAD.Name = "buttonEnterWorker_SAD";
            buttonEnterWorker_SAD.Size = new Size(240, 62);
            buttonEnterWorker_SAD.TabIndex = 7;
            buttonEnterWorker_SAD.Text = "ВОЙТИ";
            buttonEnterWorker_SAD.UseVisualStyleBackColor = false;
            buttonEnterWorker_SAD.Click += button1_Click;
            // 
            // textBox1_SADlog
            // 
            textBox1_SADlog.Location = new Point(61, 126);
            textBox1_SADlog.Margin = new Padding(4, 5, 4, 5);
            textBox1_SADlog.Name = "textBox1_SADlog";
            textBox1_SADlog.Size = new Size(239, 27);
            textBox1_SADlog.TabIndex = 8;
            // 
            // textBox2_SADpass
            // 
            textBox2_SADpass.Location = new Point(61, 195);
            textBox2_SADpass.Margin = new Padding(4, 5, 4, 5);
            textBox2_SADpass.Name = "textBox2_SADpass";
            textBox2_SADpass.Size = new Size(239, 27);
            textBox2_SADpass.TabIndex = 9;
            textBox2_SADpass.UseSystemPasswordChar = true;
            // 
            // groupBoxAuth
            // 
            groupBoxAuth.BackColor = SystemColors.ActiveCaption;
            groupBoxAuth.Controls.Add(button1);
            groupBoxAuth.Controls.Add(label2);
            groupBoxAuth.Controls.Add(label1);
            groupBoxAuth.Controls.Add(groupBox1Auth);
            groupBoxAuth.Controls.Add(buttonEnterWorker_SAD);
            groupBoxAuth.Controls.Add(textBox2_SADpass);
            groupBoxAuth.Controls.Add(textBox1_SADlog);
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
            groupBox1Auth.Controls.Add(labelMain_SAD);
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
            Controls.Add(menuStrip_SAD);
            Margin = new Padding(4, 5, 4, 5);
            MaximumSize = new Size(709, 445);
            MinimumSize = new Size(709, 445);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            Load += FormMain_Load;
            menuStrip_SAD.ResumeLayout(false);
            menuStrip_SAD.PerformLayout();
            groupBoxAuth.ResumeLayout(false);
            groupBoxAuth.PerformLayout();
            groupBox1Auth.ResumeLayout(false);
            groupBox1Auth.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInfo_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemInstruction_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout_SAD;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit_SAD;
        private System.Windows.Forms.Label labelMain_SAD;
        private System.Windows.Forms.Button buttonEnterWorker_SAD;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelpBaton;
        private System.Windows.Forms.TextBox textBox1_SADlog;
        private System.Windows.Forms.TextBox textBox2_SADpass;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1Auth;
        private System.Windows.Forms.Button button1;
    }
}