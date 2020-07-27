using DocumentFormat.OpenXml.Math;
using EvoluzeSped.Model.Arquivos;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using static EvoluzeSped.Model.Registros.RegistroBloco0;

namespace EvoluzeSped
{
    class Util
    {

        public Dictionary<int, string> PropriedadeRegistro(Object registro)
        {
            Dictionary<int, string> propriedades = new Dictionary<int, string>();
            Type tipo = registro.GetType();

            int numeroPropriedade = 0;

            PropertyInfo[] properties = tipo.GetProperties();
            foreach (var propertyInfo in properties)
            {
                propriedades.Add(++numeroPropriedade, propertyInfo.Name.Substring(4));
            }
            return propriedades;
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
                    tabelas.Add(++numero, tabelas[i]+tabelas[x]);
                }
            }
            
            return tabelas;
        }
    }
}
