namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{
    partial class FormInstruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInstruction));
            InstructionLabel_AIA = new Label();
            SuspendLayout();
            // 
            // InstructionLabel_AIA
            // 
            InstructionLabel_AIA.AutoSize = true;
            InstructionLabel_AIA.BackColor = SystemColors.Window;
            InstructionLabel_AIA.ForeColor = SystemColors.ActiveCaptionText;
            InstructionLabel_AIA.Location = new Point(14, 10);
            InstructionLabel_AIA.Margin = new Padding(4, 0, 4, 0);
            InstructionLabel_AIA.Name = "InstructionLabel_AIA";
            InstructionLabel_AIA.Size = new Size(402, 150);
            InstructionLabel_AIA.TabIndex = 0;
            InstructionLabel_AIA.Text = resources.GetString("InstructionLabel_AIA.Text");
            InstructionLabel_AIA.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormInstruction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(434, 171);
            Controls.Add(InstructionLabel_AIA);
            Margin = new Padding(4);
            Name = "FormInstruction";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Краткое руководство пользователя";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InstructionLabel_AIA;
    }
}