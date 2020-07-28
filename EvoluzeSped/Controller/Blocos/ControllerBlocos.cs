using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace EvoluzeSped.Controller.Blocos
{
    class ControllerBlocos
    {
        public Object GetRegistro(string linha, object registro)
        {
            string[] array = linha.Split('|');

            Util util = new Util();
            IDictionary<int, string> listaProriedades = util.PropriedadeRegistro(registro);

            int i = 1;
            var tipo = registro.GetType();
            PropertyInfo[] properties = tipo.GetProperties();
            foreach (var objPropertyInfo in properties)
            {
                switch (objPropertyInfo.PropertyType.Name)
                {
                    case "DateTime":
                        objPropertyInfo.SetValue(registro, util.StringToDate(array[i++]));
                        break;
                    default:
                        objPropertyInfo.SetValue(registro, array[i++]);
                        break;
                }
            }
            return registro;

        }

        public XLWorkbook GetRegistroExcel(XLWorkbook workBook, object registro)
        {
            Util util = new Util();
            IDictionary<int, string> listaProriedades = util.PropriedadeRegistro(registro);

            if (listaProriedades != null)
            {
                var tipo = registro.GetType();

                var linha = 1;

                var ws = workBook.Worksheets.Add(tipo.Name.Substring(9));


                IDictionary<int, string> listaTabelaExcel = util.TabelExel();
                string tmp = "A1:" + listaTabelaExcel[listaProriedades.Count] + linha;
                var range = ws.Range(tmp);

                // Adiciona os cabeçalos com os nomes das colunas da classe
                for (int i = 1; i <= listaProriedades.Count; ++i)
                {
                    ws.Cell(listaTabelaExcel[i] + linha).Value = listaProriedades[i];
                }
                // adicionando os valores das linhas 
                ++linha;

                var coluna = 1;
                foreach (var objPropertyInfo in tipo.GetProperties())
                {

                    switch (objPropertyInfo.PropertyType.Name)
                    {
                        case "DateTime":
                            ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(util.DateToStringExcel((DateTime)objPropertyInfo.GetValue(registro)));
                            break;
                        default:
                            ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(objPropertyInfo.GetValue(registro));
                            break;

                    }   
                }


                //ws.Range("B2:F" + linha.ToString()).SetDataType(XLDataType.Text);
                // ws.Range(listaTabelaExcel[listaProriedades.Count] + "2:F" + linha.ToString()).Style.NumberFormat.Format = "#,#.#0";
                range = ws.Range("A1:" + listaTabelaExcel[listaProriedades.Count] + linha);
                range.CreateTable();
                //range = ws.Range("A" + linha + ":" + listaTabelaExcel[listaProriedades.Count] + linha.ToString());
                //range.CreateTable();

                ws.Columns("1-" + listaProriedades.Count).AdjustToContents();
                ws.Columns("1-" + listaProriedades.Count).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
            }
            return workBook;
        }


        public XLWorkbook GetRegistroExcelList(XLWorkbook workBook, List<object> listaRegistro)
        {
            if (listaRegistro.Count > 0)
            {
                var tipo = listaRegistro.First().GetType();

                var linha = 1;

                var ws = workBook.Worksheets.Add(tipo.Name.Substring(9));

                Util util = new Util();
                IDictionary<int, string> listaProriedades = util.PropriedadeRegistro(listaRegistro.First());
                IDictionary<int, string> listaTabelaExcel = util.TabelExel();
                string tmp = "A1:" + listaTabelaExcel[listaProriedades.Count] + linha;
                var range = ws.Range(tmp);

                // Adiciona os cabeçalos com os nomes das colunas da classe
                for (int i = 1; i <= listaProriedades.Count; ++i)
                {
                    ws.Cell(listaTabelaExcel[i] + linha).Value = listaProriedades[i];
                }
                // adicionando os valores das linhas 
                foreach (var registro in listaRegistro)
                {
                    ++linha;

                    var coluna = 1;
                    foreach (var objPropertyInfo in tipo.GetProperties())
                    {
                        switch (objPropertyInfo.PropertyType.Name)
                        {
                            case "DateTime":
                                ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(util.DateToStringExcel((DateTime)objPropertyInfo.GetValue(registro)));
                                break;
                            default:
                                ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(objPropertyInfo.GetValue(registro));
                                break;

                        }
                    }
                }


                //ws.Range("B2:F" + linha.ToString()).SetDataType(XLDataType.Text);
                // ws.Range(listaTabelaExcel[listaProriedades.Count] + "2:F" + linha.ToString()).Style.NumberFormat.Format = "#,#.#0";
                range = ws.Range("A1:" + listaTabelaExcel[listaProriedades.Count] + linha);
                range.CreateTable();
                //range = ws.Range("A" + linha + ":" + listaTabelaExcel[listaProriedades.Count] + linha.ToString());
                //range.CreateTable();

                ws.Columns("1-" + listaProriedades.Count).AdjustToContents();
                ws.Columns("1-" + listaProriedades.Count).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

            }
            return workBook;
        }
    }
}
