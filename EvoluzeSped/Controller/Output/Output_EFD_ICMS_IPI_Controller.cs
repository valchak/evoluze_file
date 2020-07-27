using ClosedXML.Excel;
using EvoluzeSped.Model.Arquivos;
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
        public Output_EFD_ICMS_IPI_Controller()
        {

        }





        public string Excel_Sped_EFD_ICMS_IPI(Sped_EFD_ICMS_IPI sped, string arquivo)
        {
            string retorno = "Arquivos salvo com sucesso:\n" + arquivo;

            
            var wb = new XLWorkbook();

            GeraPlainhaRegistro0000(wb, sped);

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

        public XLWorkbook GeraPlainhaRegistro0000(XLWorkbook workBook, Sped_EFD_ICMS_IPI sped) {
            
            var ws = workBook.Worksheets.Add(sped.Bloco0.Registro0000.N01_REG);
            Util util = new Util();
            IDictionary<int, string> listaProriedades = util.PropriedadeRegistro0000(sped.Bloco0.Registro0000);
            IDictionary<int, string> listaTabelaExcel = util.TabelExel();
            string tmp = "A" + linha + ":" + listaTabelaExcel[listaProriedades.Count] + linha;
            var range = ws.Range(tmp);

            var linha = 1;
            for (int i = 1; i <= listaProriedades.Count; ++i )
            {
                ws.Cell(listaTabelaExcel[i] + linha).Value = listaProriedades[i];
            }
            linha++;
            ws.Cell(listaTabelaExcel[1] + linha).SetDataType(XLDataType.Text);
            ws.Cell(listaTabelaExcel[1] + linha).Value = " "+sped.Bloco0.Registro0000.N01_REG;
            ws.Cell(listaTabelaExcel[2] + linha).SetDataType(XLDataType.Text);
            

            // ws.Range(listaTabelaExcel[listaProriedades.Count] + "2:F" + linha.ToString()).Style.NumberFormat.Format = "#,#.#0";
            ws.Cell(listaTabelaExcel[2] + linha).Value = sped.Bloco0.Registro0000.N02_COD_VER.ToString();
           

            

            

           

            //range = ws.Range("A1:C" + linha.ToString());
            range.CreateTable();

            ws.Columns("2-9").AdjustToContents();

            return workBook;

        }


        private void validaRegistro(string linha)
        {
            string[] array = linha.Split('|');
            string bloco = array[1].Substring(0, 1);

            switch (bloco)
            {
                case "0":
                    processaBloco0(array[1], linha);
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

        private void processaBloco0(string registro, string linha)
        {
            switch (registro)
            {
                case "0000":
                    //sped.Bloco0.Registro0000 = controller.Bloco0.GetRegistro0000(linha);
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
