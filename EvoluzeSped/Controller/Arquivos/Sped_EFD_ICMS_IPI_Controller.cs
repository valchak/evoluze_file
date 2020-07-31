using EvoluzeSped.Controller.Input;
using EvoluzeSped.Controller.Output;
using EvoluzeSpedFile.Model.Arquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoluzeSped.Controller.Arquivos
{
    class Sped_EFD_ICMS_IPI_Controller
    {
        Output_EFD_ICMS_IPI_Controller outputController;
        Input_EFD_ICMS_IPI_Controller inputController;


        public string GeraExcel(string localOrigemArquivoSped, SaveFileDialog salvarArquivoExcel)
        {
            inputController = new Input_EFD_ICMS_IPI_Controller();
            Sped_EFD_ICMS_IPI sped = inputController.GetObjetoSped(localOrigemArquivoSped);
            outputController = new Output_EFD_ICMS_IPI_Controller();
            return outputController.Excel_Sped_EFD_ICMS_IPI(sped, salvarArquivoExcel.FileName);
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
