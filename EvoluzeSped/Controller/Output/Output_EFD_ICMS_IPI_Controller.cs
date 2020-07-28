using ClosedXML.Excel;
using EvoluzeSped.Controller.Blocos;
using EvoluzeSped.Model.Arquivos;
using EvoluzeSped.Model.Blocos;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EvoluzeSped.Controller.Output
{
    class Output_EFD_ICMS_IPI_Controller
    {
        ControllerBlocos controller;
        //Sped_EFD_ICMS_IPI sped;
        XLWorkbook wb;
        public Output_EFD_ICMS_IPI_Controller()
        {
            //sped = new Sped_EFD_ICMS_IPI();
            controller = new ControllerBlocos();
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
            processaBloco1(sped.Bloco1);
        }

        private void processaBloco0(Bloco0 bloco)
        {
            controller.GetRegistroExcel(wb, bloco.Registro0000);
            controller.GetRegistroExcel(wb, bloco.Registro0001);
            controller.GetRegistroExcel(wb, bloco.Registro0002);
            controller.GetRegistroExcel(wb, bloco.Registro0005);
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0015List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0100List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0150List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0175List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0190List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0200List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0205List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0206List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0210List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0220List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0300List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0305List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0400List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0450List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0460List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0500List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro0600List));
            controller.GetRegistroExcel(wb, bloco.Registro0990);

        }

        private void processaBloco1(Bloco1 bloco)
        {
            controller.GetRegistroExcel(wb, bloco.Registro1001);
            controller.GetRegistroExcel(wb, bloco.Registro1010);
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1100List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1105List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1110List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1200List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1210List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1300List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1310List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1320List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1350List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1360List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1370List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1390List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1391List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1400List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1500List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1510List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1600List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1700List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1710List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1800List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1900List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1910List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1920List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1921List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1922List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1923List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1925List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1926List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1960List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1970List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1975List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro1980List));
            controller.GetRegistroExcel(wb, bloco.Registro1990);
        }
    }
}
