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
            processaBlocoB(sped.BlocoB);
            processaBlocoC(sped.BlocoC);
            processaBloco9(sped.Bloco9);
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

        private void processaBlocoB(BlocoB bloco)
        {
            controller.GetRegistroExcel(wb, bloco.RegistroB001);
            
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB020List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB025List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB030List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB035List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB350List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB420List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB440List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB460List));
            controller.GetRegistroExcel(wb, bloco.RegistroB470);
            controller.GetRegistroExcel(wb, bloco.RegistroB500);
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroB510List));
            controller.GetRegistroExcel(wb, bloco.RegistroB990);
        }

        private void processaBlocoC(BlocoC bloco)
        {
            controller.GetRegistroExcel(wb, bloco.RegistroC001);
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC100List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC101List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC105List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC110List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC111List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC112List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC113List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC114List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC115List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC116List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC120List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC130List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC140List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC141List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC160List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC165List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC170List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC171List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC172List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC173List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC174List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC175List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC176List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC177List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC178List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC179List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC180List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC185List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC190List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC191List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC195List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC197List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC300List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC310List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC320List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC321List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC330List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC350List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC370List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC380List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC390List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC400List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC405List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC410List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC420List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC425List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC430List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC460List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC465List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC470List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC480List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC490List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC495List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC500List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC510List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC590List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC591List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC595List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC597List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC600List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC601List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC610List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC690List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC700List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC790List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC791List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC800List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC810List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC815List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC850List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC860List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC870List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC880List));
            controller.GetRegistroExcelList(wb, new List<object>(bloco.RegistroC890List));
            controller.GetRegistroExcel(wb, bloco.RegistroC990);
        }

        private void processaBloco9(Bloco9 bloco)
        {   
            controller.GetRegistroExcel(wb, bloco.Registro9001);
            controller.GetRegistroExcelList(wb, new List<object>(bloco.Registro9900List));
            controller.GetRegistroExcel(wb, bloco.Registro9990);
            controller.GetRegistroExcel(wb, bloco.Registro9999);
        }
    }
}
