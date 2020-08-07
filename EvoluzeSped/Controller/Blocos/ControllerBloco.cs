using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace EvoluzeSped.Controller.Blocos
{
        class ControllerBlocos
        {
            IDictionary<int, string> listaTabelaExcel;
            public ControllerBlocos()
            {
                listaTabelaExcel = TabelExel();
            }
            public Object GetRegistro(string linha, object registro)
            {
                string[] array = linha.Split('|');

                IDictionary<int, string> listaProriedades = PropriedadeRegistro(registro);

                int i = 0;
                var tipo = registro.GetType();
                PropertyInfo[] properties = tipo.GetProperties();
                foreach (var objPropertyInfo in properties)
                {
                    string valor = array[++i];
                    string tmp = objPropertyInfo.PropertyType.Name + " = " + objPropertyInfo.Name + " Valor: " + valor;
                    switch (objPropertyInfo.PropertyType.Name)
                    {
                        case "DateTime":
                            if (!valor.Equals("") || valor.Count() == 8)
                                objPropertyInfo.SetValue(registro, StringToDate(valor));
                            else
                                objPropertyInfo.SetValue(registro, null);
                            break;
                        case "Double":
                            try
                            {
                                objPropertyInfo.SetValue(registro, StringToDouble(valor));
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message + "\nNome: " + tipo.Name + "\nProriedade: " + objPropertyInfo.PropertyType.Name + "\nLinha: " + linha + "\nValor: " + valor);
                            }
                            break;
                        case "Int32":
                            try
                            {
                                objPropertyInfo.SetValue(registro, StringToInt(valor));
                            }
                            catch (Exception ex)
                            {
                                System.Windows.Forms.MessageBox.Show(ex.Message + "\nNome: " + tipo.Name + "\nProriedade: " + objPropertyInfo.PropertyType.Name + "\nLinha: " + linha + "\nValor: " + valor);
                            }
                            break;
                        default:
                            if (objPropertyInfo.Name.Substring(4, 2).Equals("DT") && !valor.Equals(""))
                                objPropertyInfo.SetValue(registro, StringToStringDateFormatExcel(valor));
                            else
                                objPropertyInfo.SetValue(registro, valor);
                            break;
                    }
                }
                return registro;
            }

            public XLWorkbook GetRegistroExcel(XLWorkbook workBook, object registro)
            {

                IDictionary<int, string> listaProriedades = PropriedadeRegistro(registro);

                if (listaProriedades != null)
                {
                    var tipo = registro.GetType();

                    var linha = 1;

                    var ws = workBook.Worksheets.Add(tipo.Name.Substring(9));

                    string tmp = "A1:" + listaTabelaExcel[listaProriedades.Count] + linha;
                    var range = ws.Range(tmp);

                    // Adiciona os cabeçalos com os nomes das colunas da classe
                    for (int i = 1; i <= listaProriedades.Count; ++i)
                    {
                        ws.Cell(listaTabelaExcel[i] + linha).SetValue(listaProriedades[i]).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                    }
                    // adicionando os valores das linhas 
                    ++linha;
                    GeraLinhasExel(linha, tipo, ws, registro);
                    
                   //ws.Range("B2:F" + linha.ToString()).SetDataType(XLDataType.Text);
                    // ws.Range(listaTabelaExcel[listaProriedades.Count] + "2:F" + linha.ToString()).Style.NumberFormat.Format = "#,#.#0";
                    range = ws.Range("A1:" + listaTabelaExcel[listaProriedades.Count] + linha);
                    range.CreateTable();
                    //range = ws.Range("A" + linha + ":" + listaTabelaExcel[listaProriedades.Count] + linha.ToString());
                    //range.CreateTable();

                    ws.Columns("1-" + listaProriedades.Count).AdjustToContents();
                    //ws.Columns("1-" + listaProriedades.Count).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
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

                    IDictionary<int, string> listaProriedades = PropriedadeRegistro(listaRegistro.First());
                    string tmp = "A1:" + listaTabelaExcel[listaProriedades.Count] + linha;
                    var range = ws.Range(tmp);

                    // Adiciona os cabeçalos com os nomes das colunas da classe
                    for (int i = 1; i <= listaProriedades.Count; ++i)
                    {
                    ws.Cell(listaTabelaExcel[i] + linha).SetValue(listaProriedades[i]).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                }
                    // adicionando os valores das linhas 
                    foreach (var registro in listaRegistro)
                    {
                        ++linha;
                        GeraLinhasExel(linha, tipo, ws, registro);
                        
                    }


                    //ws.Range("B2:F" + linha.ToString()).SetDataType(XLDataType.Text);
                    // ws.Range(listaTabelaExcel[listaProriedades.Count] + "2:F" + linha.ToString()).Style.NumberFormat.Format = "#,#.#0";
                    range = ws.Range("A1:" + listaTabelaExcel[listaProriedades.Count] + linha);
                    range.CreateTable();
                    //range = ws.Range("A" + linha + ":" + listaTabelaExcel[listaProriedades.Count] + linha.ToString());
                    //range.CreateTable();

                    ws.Columns("1-" + listaProriedades.Count).AdjustToContents();
                    //ws.Columns("1-" + listaProriedades.Count).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                }
                return workBook;
            }

            private void GeraLinhasExel(int linha, Type tipo, IXLWorksheet ws, object registro)
            {
                var coluna = 1;
                foreach (var objPropertyInfo in tipo.GetProperties())
                {
                    string formatacaoExcel = GetFormatoExcel(objPropertyInfo);

                    switch (objPropertyInfo.PropertyType.Name)
                    {
                        case "DateTime":
                            if (objPropertyInfo.GetValue(registro) != null)
                                ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(DateToStringExcel((DateTime)objPropertyInfo.GetValue(registro))).SetDataType(XLDataType.DateTime).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                            else
                                ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue("").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                            break;
                        case "Double":
                            ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(objPropertyInfo.GetValue(registro)).SetDataType(XLDataType.Number).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right).NumberFormat.Format = formatacaoExcel.Equals("") ? "#,##0.00" : formatacaoExcel;
                            break;
                        case "Int32":
                            ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(objPropertyInfo.GetValue(registro)).SetDataType(XLDataType.Number).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Right).NumberFormat.Format = formatacaoExcel.Equals("") ? "#,##0" : formatacaoExcel; ;
                            break;
                        default:
                            ws.Cell(listaTabelaExcel[coluna++] + linha).SetValue(objPropertyInfo.GetValue(registro)).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                            break;
                    }
                }
            }

            private string GetFormatoExcel(PropertyInfo objPropertyInfo)
            {
                string valor = "";

                foreach (var obj in objPropertyInfo.CustomAttributes.ToList())
                {
                    if (obj.AttributeType.Name.Equals("FormatoField"))
                    {
                        valor = obj.ConstructorArguments[0].Value.ToString();
                        break;
                    }
                }
                return valor;
            }

            public Dictionary<int, string> PropriedadeRegistro(object registro)
            {
                Dictionary<int, string> propriedades = new Dictionary<int, string>();
                Type tipo = registro.GetType();

                int numeroPropriedade = 0;

                if (!tipo.GetProperties().First().GetValue(registro).Equals(""))
                {
                    PropertyInfo[] properties = tipo.GetProperties();
                    foreach (var propertyInfo in properties)
                    {
                        propriedades.Add(++numeroPropriedade, propertyInfo.Name.Substring(4));
                    }
                    return propriedades;
                }
                else
                {
                    return null;
                }
            }

            public DateTime StringToDate(string dataString = "")
            {
                if (!dataString.Equals(""))
                    return DateTime.ParseExact(dataString, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                else
                    return new DateTime(1899, 12, 30);
            }

            public static double StringToDouble(string valor = "")
            {
                if (!valor.Equals(""))
                {
                    valor = valor.Replace(".", "").Replace(",", ".");
                    return double.Parse(valor);
                }
                else
                {
                    return 0.00;
                }
            }

            public static int StringToInt(string valor = "")
            {
                if (!valor.Equals(""))
                {
                    valor = valor.Replace(".", "").Replace(",", ".");
                    return int.Parse(valor);
            }
                else
                {
                    return 0;
                }
            }

            public static string IntToString(int valor = 0)
            {
                return String.Format(CultureInfo.InvariantCulture, "{0:0}", valor);
            }

            public static string DoubleToString(double valor = 0)
            {

                return String.Format(CultureInfo.InvariantCulture, "{0:0.0,0}", valor);

            }

            public string DateToStringExcel(DateTime objData)
            {
                if (!objData.Equals("") || objData.Year != 1899)
                    return objData.ToString("dd/MM/yyyy");
                else
                    return "";
            }

            public string StringToStringDateFormatExcel(string dataString)
            {
                string dia = dataString.Substring(0, 2);
                string mes = dataString.Substring(2, 2);
                string ano = dataString.Substring(4, 4);
                return dia + "/" + mes + "/" + ano; ;
            }

            public Dictionary<int, string> TabelExel()
            {
                int numero = 0;
                Dictionary<int, string> tabelas = new Dictionary<int, string>();

                tabelas.Add(++numero, "A");
                tabelas.Add(++numero, "B");
                tabelas.Add(++numero, "C");
                tabelas.Add(++numero, "D");
                tabelas.Add(++numero, "E");
                tabelas.Add(++numero, "F");
                tabelas.Add(++numero, "G");
                tabelas.Add(++numero, "H");
                tabelas.Add(++numero, "I");
                tabelas.Add(++numero, "J");
                tabelas.Add(++numero, "K");
                tabelas.Add(++numero, "L");
                tabelas.Add(++numero, "M");
                tabelas.Add(++numero, "N");
                tabelas.Add(++numero, "O");
                tabelas.Add(++numero, "Q");
                tabelas.Add(++numero, "R");
                tabelas.Add(++numero, "S");
                tabelas.Add(++numero, "T");
                tabelas.Add(++numero, "U");
                tabelas.Add(++numero, "V");
                tabelas.Add(++numero, "W");
                tabelas.Add(++numero, "Y");
                tabelas.Add(++numero, "X");
                tabelas.Add(++numero, "Z");
                tabelas.Add(++numero, "P");

                int registros = tabelas.Count;

                for (int i = 1; i < registros; ++i)
                {
                    for (int x = 1; x < registros; ++x)
                    {
                        tabelas.Add(++numero, tabelas[i] + tabelas[x]);
                    }
                }

                return tabelas;
            }

        }
    }
