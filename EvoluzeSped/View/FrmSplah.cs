using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoluzeSped.View
{
    public partial class FrmSplah : Form
    {
        public FrmSplah()
        {
            InitializeComponent();
            backgroundWorker.RunWorkerAsync();
        }
/*
        public void progressBarRun()
        {
            progressBar = new ProgressBar();
            while (_Singleton.GetInstance.processandoArquivo)
            {
                   if (_Singleton.GetInstance.linhaAtualArquivo > 0 && _Singleton.GetInstance.linhaTotalArquivo > 0)
                   {
                       _Singleton.GetInstance.progressCompleted = _Singleton.GetInstance.linhaAtualArquivo * 100 / _Singleton.GetInstance.linhaTotalArquivo;
                        
                        progressBar.Value = _Singleton.GetInstance.progressCompleted;
                        //lbProcessando.Text = "Gerando Arquivo: " + _Singleton.GetInstance.progressCompleted+ " %" ;
                   }
            }
            backgroundWorker.CancelAsync();
        }
*/
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            _Singleton.GetInstance.processandoArquivo = true;

            while (_Singleton.GetInstance.processandoArquivo)
            {
            }
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar.Value = e.ProgressPercentage;
            //lbProcessando.Text = "Gerando arquivo ... "+ e.ProgressPercentage.ToString() + " % ";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            backgroundWorker.CancelAsync();
            this.Dispose();
        }
    }
}
