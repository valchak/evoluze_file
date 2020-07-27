using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using EvoluzeSped.Controller.Aquivos;
using EvoluzeSped.Model.Arquivos;
using EvoluzeSped.Model.Blocos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Controller.Output
{
    class Output_EFD_ICMS_IPI_Controller
    {
        Sped_EFD_ICMS_IPI_Controller controller;
        //Sped_EFD_ICMS_IPI sped;
        XLWorkbook wb;
        public Output_EFD_ICMS_IPI_Controller()
        {
            //sped = new Sped_EFD_ICMS_IPI();
            controller = new Sped_EFD_ICMS_IPI_Controller();
            wb = new XLWorkbook();
        }





        public string Excel_Sped_EFD_ICMS_IPI(Sped_EFD_ICMS_IPI sped, string arquivo)
        {
            string retorno = "Arquivos salvo com sucesso:\n" + arquivo;

            ProcessaBlocosParaExcel(sped);

            try
            {
                wb.SaveAs(arquivo);
            }
            catch (Exception e)
            {
                retorno = "Erro ao salvar Arquivo:\n" + e.Message;
            }

            wb.Dispose();

            return retorno;

        }

        


        private void ProcessaBlocosParaExcel(Sped_EFD_ICMS_IPI sped)
        {
            processaBloco0(sped.Bloco0);

            switch (" 0 " )
            {
                case "0":
                    
                    break;
                case "1":
                    //                   processaBloco1(array[1], linha);
                    break;
                case "9":
                    //                   processaBloco9(array[1], linha);
                    break;
                case "B":
                    //                    processaBlocoB(array[1], linha);
                    break;
                case "C":
                    //                    processaBlocoC(array[1], linha);
                    break;
                case "D":
                    //                    processaBlocoD(array[1], linha);
                    break;
                case "E":
                    //                    processaBlocoE(array[1], linha);
                    break;
                case "G":
                    //                    processaBlocoG(array[1], linha);
                    break;
                case "H":
                    //                    processaBlocoH(array[1], linha);
                    break;
                case "K":
                    //                    processaBlocoK(array[1], linha);
                    break;
            }

        }

        private void processaBloco0(Bloco0 bloco)
        {
            controller.Bloco0.GetRegistro0000Excel(wb, bloco.Registro0000);
            controller.Bloco0.GetRegistro0001Excel(wb, bloco.Registro0001);
            controller.Bloco0.GetRegistro0002Excel(wb, bloco.Registro0002);
            controller.Bloco0.GetRegistro0005Excel(wb, bloco.Registro0005);
            if(bloco.Registro0100List.Count > 0)
                controller.Bloco0.GetRegistro0100Excel(wb, bloco.Registro0100List);
            if (bloco.Registro0150List.Count > 0)
                controller.Bloco0.GetRegistro0150Excel(wb, bloco.Registro0150List);

            switch ("")
            {
                case "0000":
                    
                    break;
                case "0001":
                    //                    sped.Bloco0.Registro0001 = controller.Bloco0.GetRegistro0001(linha);
                    break;
                case "0005":
                    //                    sped.Bloco0.Registro0005 = controller.Bloco0.GetRegistro0005(linha);
                    break;
                case "0100":
                    //                    sped.Bloco0.Registro0100 = controller.Bloco0.GetRegistro0100(linha);
                    break;
                case "0150":
                    //                    sped.Bloco0.Registro0150.Add(controller.Bloco0.GetRegistro0150(linha));
                    break;
                case "0190":
                    //                    sped.Bloco0.Registro0190.Add(controller.Bloco0.GetRegistro0190(linha));
                    break;
                case "0200":
                    //                    sped.Bloco0.Registro0200.Add(controller.Bloco0.GetRegistro0200(linha));
                    break;
                case "0205":
                    //                    sped.Bloco0.Registro0205.Add(controller.Bloco0.GetRegistro0205(linha));
                    break;
                case "0206":
                    //                    sped.Bloco0.Registro0206.Add(controller.Bloco0.GetRegistro0206(linha));
                    break;
                case "0220":
                    //                    sped.Bloco0.Registro0220.Add(controller.Bloco0.GetRegistro0220(linha));
                    break;
                case "0300":
                    //                    sped.Bloco0.Registro0300.Add(controller.Bloco0.GetRegistro0300(linha));
                    break;
                case "0305":
                    //                    sped.Bloco0.Registro0305.Add(controller.Bloco0.GetRegistro0305(linha));
                    break;
                case "0450":
                    //                    sped.Bloco0.Registro0450.Add(controller.Bloco0.GetRegistro0450(linha));
                    break;
                case "0460":
                    //                    sped.Bloco0.Registro0460.Add(controller.Bloco0.GetRegistro0460(linha));
                    break;
                case "0500":
                    //                    sped.Bloco0.Registro0500.Add(controller.Bloco0.GetRegistro0500(linha));
                    break;
                case "0600":
                    //                    sped.Bloco0.Registro0600.Add(controller.Bloco0.GetRegistro0600(linha));
                    break;
                case "0990":
                    //                    sped.Bloco0.Registro0990 = controller.Bloco0.GetRegistro0990(linha);
                    break;

            }
        }


    }
}
