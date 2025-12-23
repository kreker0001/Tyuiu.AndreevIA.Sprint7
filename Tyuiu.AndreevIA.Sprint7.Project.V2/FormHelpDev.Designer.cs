
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{
    partial class FormHelpDev
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
            btnOpenBrowser = new Button();
            buttonCloseBackUnion = new Button();
            labelHelpDevWinInfo = new Label();
            groupBoxHelpDevWin = new GroupBox();
            groupBoxHelpDevWin.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenBrowser
            // 
            btnOpenBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOpenBrowser.BackColor = SystemColors.Window;
            btnOpenBrowser.FlatStyle = FlatStyle.Popup;
            btnOpenBrowser.ForeColor = SystemColors.ActiveCaptionText;
            btnOpenBrowser.Location = new Point(10, 14);
            btnOpenBrowser.Margin = new Padding(4);
            btnOpenBrowser.Name = "btnOpenBrowser";
            btnOpenBrowser.Size = new Size(140, 34);
            btnOpenBrowser.TabIndex = 0;
            btnOpenBrowser.Text = "Связаться с нами";
            btnOpenBrowser.UseVisualStyleBackColor = false;
            btnOpenBrowser.Click += btnOpenBrowser_Click;
            // 
            // buttonCloseBackUnion
            // 
            buttonCloseBackUnion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCloseBackUnion.BackColor = SystemColors.Window;
            buttonCloseBackUnion.FlatStyle = FlatStyle.Popup;
            buttonCloseBackUnion.ForeColor = SystemColors.ActiveCaptionText;
            buttonCloseBackUnion.Location = new Point(217, 14);
            buttonCloseBackUnion.Margin = new Padding(4);
            buttonCloseBackUnion.Name = "buttonCloseBackUnion";
            buttonCloseBackUnion.Size = new Size(115, 34);
            buttonCloseBackUnion.TabIndex = 1;
            buttonCloseBackUnion.Text = "Закрыть";
            buttonCloseBackUnion.UseVisualStyleBackColor = false;
            buttonCloseBackUnion.Click += buttonCloseBackUnion_SAD_Click;
            // 
            // labelHelpDevWinInfo
            // 
            labelHelpDevWinInfo.BackColor = SystemColors.Window;
            labelHelpDevWinInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelHelpDevWinInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelHelpDevWinInfo.Location = new Point(10, 10);
            labelHelpDevWinInfo.Margin = new Padding(4, 0, 4, 0);
            labelHelpDevWinInfo.Name = "labelHelpDevWinInfo";
            labelHelpDevWinInfo.Size = new Size(322, 115);
            labelHelpDevWinInfo.TabIndex = 2;
            labelHelpDevWinInfo.Text = "Если у вас возникли трудности,\r\nВы можете связаться с нашей службой поддержки\r\nНажав на кнопку \"Связаться с нами\"\r\n\r\n\r\n";
            labelHelpDevWinInfo.TextAlign = ContentAlignment.MiddleCenter;
            labelHelpDevWinInfo.Click += label1_Click;
            // 
            // groupBoxHelpDevWin
            // 
            groupBoxHelpDevWin.BackColor = SystemColors.Window;
            groupBoxHelpDevWin.Controls.Add(btnOpenBrowser);
            groupBoxHelpDevWin.Controls.Add(buttonCloseBackUnion);
            groupBoxHelpDevWin.Dock = DockStyle.Bottom;
            groupBoxHelpDevWin.Location = new Point(0, 121);
            groupBoxHelpDevWin.Margin = new Padding(4);
            groupBoxHelpDevWin.Name = "groupBoxHelpDevWin";
            groupBoxHelpDevWin.Padding = new Padding(4);
            groupBoxHelpDevWin.Size = new Size(340, 61);
            groupBoxHelpDevWin.TabIndex = 3;
            groupBoxHelpDevWin.TabStop = false;
            // 
            // FormHelpDev
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(340, 182);
            Controls.Add(groupBoxHelpDevWin);
            Controls.Add(labelHelpDevWinInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FormHelpDev";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Обратная связь и поддержка ";
            Load += FormHelpDevWin_Load;
            groupBoxHelpDevWin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnOpenBrowser;
        private System.Windows.Forms.Button buttonCloseBackUnion;
        private System.Windows.Forms.Label labelHelpDevWinInfo;
        private System.Windows.Forms.GroupBox groupBoxHelpDevWin;
    }
}