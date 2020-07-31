using ClosedXML.Excel;
using EvoluzeSped.Controller.Arquivos;
using EvoluzeSped.Controller.Input;
using EvoluzeSped.Controller.Output;
using EvoluzeSpedFile.Model.Arquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoluzeSped.ViewModel
{
    class ArquivoView
    {
        public void GeraArquivoExcel(string localOrigemArquivSped)
        {
            Sped_EFD_ICMS_IPI_Controller controller = new Sped_EFD_ICMS_IPI_Controller();

            string arquivoInvertido = controller.InvertString(localOrigemArquivSped);
            string arquivoSped = controller.InvertString(arquivoInvertido.Substring(0, arquivoInvertido.IndexOf("\\")));
            string diretorio = localOrigemArquivSped.Replace(arquivoSped, "");


            SaveFileDialog salvarArquivoExcel = new SaveFileDialog();
            salvarArquivoExcel.InitialDirectory = (diretorio);
            salvarArquivoExcel.Title = "SPED_EXCEL";
            salvarArquivoExcel.FileName = arquivoSped.Replace(".txt", "_" + DateTime.Now.ToString("yy_MM_dd_HH_mm_ss") + ".xlsx");
            salvarArquivoExcel.ShowDialog();

            MessageBox.Show(controller.GeraExcel(localOrigemArquivSped, salvarArquivoExcel),"Aquivo Sped!", MessageBoxButtons.OK);
        }

    }
}
