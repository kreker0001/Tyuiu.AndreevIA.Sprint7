using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{
    partial class FormAbout
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_AIA = new Button();
            labelInfo_AIA = new Label();
            labelInfo = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pictureBoxAvatar_AIA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AIA).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_AIA
            // 
            buttonOK_AIA.BackColor = SystemColors.Menu;
            buttonOK_AIA.FlatStyle = FlatStyle.Flat;
            buttonOK_AIA.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_AIA.ForeColor = Color.Black;
            buttonOK_AIA.Location = new Point(426, 161);
            buttonOK_AIA.Margin = new Padding(4);
            buttonOK_AIA.Name = "buttonOK_AIA";
            buttonOK_AIA.Size = new Size(69, 25);
            buttonOK_AIA.TabIndex = 1;
            buttonOK_AIA.Text = "ОК";
            buttonOK_AIA.UseVisualStyleBackColor = false;
            buttonOK_AIA.Click += buttonOK_AIA_Click;
            // 
            // labelInfo_AIA
            // 
            labelInfo_AIA.AutoSize = true;
            labelInfo_AIA.Location = new Point(158, 10);
            labelInfo_AIA.Margin = new Padding(4, 0, 4, 0);
            labelInfo_AIA.Name = "labelInfo_AIA";
            labelInfo_AIA.Size = new Size(0, 15);
            labelInfo_AIA.TabIndex = 3;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = SystemColors.Window;
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(151, 14);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(302, 135);
            labelInfo.TabIndex = 4;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // pictureBoxAvatar_AIA
            // 
            pictureBoxAvatar_AIA.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBoxAvatar_AIA.BackgroundImage");
            pictureBoxAvatar_AIA.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxAvatar_AIA.ErrorImage = null;
            pictureBoxAvatar_AIA.Location = new Point(8, 10);
            pictureBoxAvatar_AIA.Margin = new Padding(4);
            pictureBoxAvatar_AIA.Name = "pictureBoxAvatar_AIA";
            pictureBoxAvatar_AIA.Size = new Size(116, 135);
            pictureBoxAvatar_AIA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAvatar_AIA.TabIndex = 5;
            pictureBoxAvatar_AIA.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(503, 188);
            Controls.Add(pictureBoxAvatar_AIA);
            Controls.Add(labelInfo);
            Controls.Add(labelInfo_AIA);
            Controls.Add(buttonOK_AIA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(519, 227);
            MinimizeBox = false;
            MinimumSize = new Size(519, 227);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button buttonOK_AIA;
        private System.Windows.Forms.Label labelInfo_AIA;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_AIA;
    }
}