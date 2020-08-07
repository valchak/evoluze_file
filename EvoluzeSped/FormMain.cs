using AutoUpdaterDotNET;
using EvoluzeSped.Database;
using EvoluzeSped.View;
using EvoluzeSped.ViewModel;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace EvoluzeSped
{
    public partial class FormMain : Form
    {
        BancoLiteDB banco;
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {   //txtFileOpen.Text = "C:\\Users\\Valchak\\Desktop\\SpedPosto\\EFD-Emp000244-Fil000001-03_2020.txt";
            //lbVersao.Text = "Versão: " + Application.ProductVersion;
            lbVersao.Text = "Versão: " + string.Format(Application.ProductVersion, Assembly.GetEntryAssembly().GetName().Version);
            banco = new BancoLiteDB();
            banco.getParametros("");


            AutoUpdater.ApplicationExitEvent += AutoUpdater_ApplicationExitEvent;

            AutoUpdater.Mandatory = true;
            AutoUpdater.Start("http://evoluze.com.br/app/autoupdater.xml");
        }

        private void AutoUpdater_ApplicationExitEvent()
        {
            Text = @"Fechando Aplicacao ...";
            Thread.Sleep(5000);
            Application.Exit();
        }

/*
        private void AutoUpdaterOnParseUpdateInfoEvent(ParseUpdateInfoEventArgs args)
        {
            dynamic json = JsonConvert.DeserializeObject(args.RemoteData);
            args.UpdateInfo = new UpdateInfoEventArgs
            {
                CurrentVersion = json.version,
                ChangelogURL = json.changelog,
                DownloadURL = json.url,
                Mandatory = new Mandatory
                {
                    Value = json.mandatory.value,
                    UpdateMode = json.mandatory.mode,
                    MinimumVersion = json.mandatory.minVersion
                },
                CheckSum = new CheckSum
                {
                    Value = json.checksum.value,
                    HashingAlgorithm = json.checksum.hashingAlgorithm
                }
            };
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                    DialogResult dialogResult;
                    if (args.Mandatory.Value)
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. This is required update. Press Ok to begin updating the application.",
                                @"Update Available",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    }
                    else
                    {
                        dialogResult =
                            MessageBox.Show(
                                $@"There is new version {args.CurrentVersion} available. You are using version {
                                        args.InstalledVersion
                                    }. Do you want to update the application now?", @"Update Available",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                    }


                    if (dialogResult.Equals(DialogResult.Yes) || dialogResult.Equals(DialogResult.OK))
                    {
                        try
                        {
                            //You can use Download Update dialog used by AutoUpdater.NET to download the update.

                            if (AutoUpdater.DownloadUpdate(args))
                            {
                                Application.Exit();
                            }
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"There is no update available. Please try again later.", @"Update Unavailable",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    @"There is a problem reaching update server. Please check your internet connection and try again later.",
                    @"Update Check Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonCheckForUpdate_Click(object sender, EventArgs e)
        {
            //Uncomment below lines to select download path where update is saved.

            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //if (folderBrowserDialog.ShowDialog().Equals(DialogResult.OK))
            //{
            //    AutoUpdater.DownloadPath = folderBrowserDialog.SelectedPath;
            //    AutoUpdater.Mandatory = true;
            //    AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
            //}

            AutoUpdater.Mandatory = true;
            AutoUpdater.Start("https://rbsoft.org/updates/AutoUpdaterTest.xml");
        }
    
*/

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
