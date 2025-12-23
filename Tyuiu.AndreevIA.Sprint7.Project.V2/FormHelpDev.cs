using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tyuiu.AndreevIA.Sprint7.Project.V2
{
    public partial class FormHelpDev : Form
    {
        public FormHelpDev()
        {
            InitializeComponent();
        }

        private void FormHelpDevWin_Load(object sender, EventArgs e)
        {

        }
        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            // Внешний источник URL для открытия в браузере
            string externalSourceUrl = "https://support.apple.com/ru-ru";

            try
            {
                // Открываем внешний источник в браузере по умолчанию на компьютере пользователя
                Process.Start(externalSourceUrl);
            }
            catch (Exception ex)
            {
                // Обработка ошибки, если не удалось открыть внешний источник
                MessageBox.Show($"Ошибка при открытии внешнего источника: {ex.Message}");
            }

        }

        private void buttonCloseBackUnion_SAD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}