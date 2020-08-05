using EvoluzeSped.Database;
using EvoluzeSped.View;
using EvoluzeSped.ViewModel;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EvoluzeSped
{
    public partial class Main : Form
    {
        BancoLiteDB banco;
        public Main()
        {
            InitializeComponent();
            banco = new BancoLiteDB();
            banco.getParametros("");
            //txtFileOpen.Text = "C:\\Users\\Valchak\\Desktop\\SpedPosto\\EFD-Emp000244-Fil000001-03_2020.txt";
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
                //foreach (char file in openFile.FileNames.ToString())
                //{

                //}
                txtFileOpen.Text = openFile.FileName.ToString();
                StreamReader redearFile = new StreamReader(txtFileOpen.Text, Encoding.Default);
                Regex rx = new Regex("\r\n");
                _Singleton.GetInstance.linhaTotalArquivo = (rx.Matches(redearFile.ReadToEnd()).Count+1)*2;
                redearFile.Close();
            }



        }



        private void btn_EFD_ICMS_IPI_Click(object sender, EventArgs e)
        {
            if (!txtFileOpen.Text.Trim().Equals(""))
            {
                this.Visible = false;
                ArquivoView arquivo = new ArquivoView();
                arquivo.GeraArquivoExcel(txtFileOpen.Text);
                this.Visible = true;
            } else
            {
                MessageBox.Show("Favor selecionar o arquivo sped");
            }
            
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametro tela = new FrmParametro();
            tela.ShowDialog();
            tela.Dispose();
        }
        /*
private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
{
   _Singleton.GetInstance.processandoArquivo = true;

   while (_Singleton.GetInstance.processandoArquivo)
   {
       if (backgroundWorker.CancellationPending)
       {
           //CANCEL
           e.Cancel = true;
       }
       else
       {
           if (_Singleton.GetInstance.linhaAtualArquivo > 0)
               _Singleton.GetInstance.progressCompleted = _Singleton.GetInstance.linhaAtualArquivo * 100 / _Singleton.GetInstance.linhaTotalArquivo;
           backgroundWorker.ReportProgress(_Singleton.GetInstance.progressCompleted);
       }
   }

}

private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
{
   progressBar.Value = e.ProgressPercentage;
   lbPercentual.Text = e.ProgressPercentage.ToString() + " %";
}

private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
   if (e.Cancelled)
   {
       progressBar.Value = 0;

       lbPercentual.Text = "0";
   }
   else
   {
       if (!_Singleton.GetInstance.processandoArquivo)
       {

       }
       lbPercentual.Text = " 100 %";
   }
}
*/
    }
}
