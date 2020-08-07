using EvoluzeSped.Controller.Input;
using EvoluzeSped.Controller.Output;
using EvoluzeSpedFile.Model;
using EvoluzeSpedFile.Model.Arquivos;
using System;
using System.Collections.Generic;
using System.Text;

namespace EvoluzeSped.Controller.Arquivos
{
    public class Sped_EFD_ICMS_IPI_Controller
    {
        Output_EFD_ICMS_IPI_Controller outputController;
        Input_EFD_ICMS_IPI_Controller inputController;


        public string GeraExcel(string localOrigemArquivoSped, string salvarArquivoExcel, Parametro_Sped_EFD_ICMS_IPI parametro)
        {
            if (parametro == null)
                parametro = new Parametro_Sped_EFD_ICMS_IPI();

            inputController = new Input_EFD_ICMS_IPI_Controller();
            Sped_EFD_ICMS_IPI sped = inputController.GetObjetoSped(localOrigemArquivoSped, parametro);
            outputController = new Output_EFD_ICMS_IPI_Controller();
            return outputController.Excel_Sped_EFD_ICMS_IPI(sped, salvarArquivoExcel);
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
