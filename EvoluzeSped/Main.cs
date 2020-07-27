using EvoluzeSped.Controller.Input;
using EvoluzeSped.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoluzeSped
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            txtFileOpen.Text = "C:\\Users\\Valchak\\Desktop\\SpedPosto\\EFD-Emp000244-Fil000001-03_2020.txt";
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            this.openFile.Multiselect = false;
            this.openFile.Title = "Buscar arquivo sped";
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //openFile.Filter = "*.txt";
            openFile.RestoreDirectory = true;

            DialogResult result = this.openFile.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (char file in openFile.FileNames.ToString())
                {

                }
                txtFileOpen.Text = openFile.FileName.ToString();
            }

        }

        private void btn_EFD_ICMS_IPI_Click(object sender, EventArgs e)
        {
            ArquivoView arquivo = new ArquivoView();
            arquivo.GeraExcel(txtFileOpen.Text);
        }
    }
}
