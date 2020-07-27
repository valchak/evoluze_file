using ClosedXML.Excel;
using EvoluzeSped.Controller.Input;
using EvoluzeSped.Controller.Output;
using EvoluzeSped.Model.Arquivos;
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

        Output_EFD_ICMS_IPI_Controller outputController;
        Input_EFD_ICMS_IPI_Controller inputController;
       

        public void GeraExcel(string localOrigemArquivoSped)
        {
            inputController = new Input_EFD_ICMS_IPI_Controller();
            Sped_EFD_ICMS_IPI sped = inputController.GetObjetoSped(localOrigemArquivoSped);
            
            GeraArquivoExcel(sped, localOrigemArquivoSped);

        }

        public void GeraArquivoExcel(Sped_EFD_ICMS_IPI sped, string localOrigemArquivSped)
        {
            outputController = new Output_EFD_ICMS_IPI_Controller();
            string arquivoInvertido = InvertString(localOrigemArquivSped);
            string arquivoSped = InvertString(arquivoInvertido.Substring(0, arquivoInvertido.IndexOf("\\")));
            string diretorio = localOrigemArquivSped.Replace(arquivoSped, "");


            SaveFileDialog salvarArquivoExcel = new SaveFileDialog();
            salvarArquivoExcel.InitialDirectory = (diretorio);
            salvarArquivoExcel.Title = "SPED_EXCEL";
            salvarArquivoExcel.FileName = arquivoSped.Replace(".txt", "_"+DateTime.Now.ToString("yy_MM_dd_HH_mm_ss")+".xlsx");
            salvarArquivoExcel.ShowDialog();

            MessageBox.Show(outputController.Excel_Sped_EFD_ICMS_IPI(sped, salvarArquivoExcel.FileName));
        }


        public string InvertString(string arquivoOrigem)
        {
            char[] arrChar = arquivoOrigem.ToCharArray();
            Array.Reverse(arrChar);
            string invertida = new String(arrChar);

            return invertida;

        }
    }
}
