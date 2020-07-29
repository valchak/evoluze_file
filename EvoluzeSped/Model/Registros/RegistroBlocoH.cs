using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoH
    {
        // REGISTRO H001: ABERTURA DO BLOCO H
        public class Registro_H001
        {
            public Registro_H001()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }

        // REGISTRO H005: TOTAIS DO INVENTÁRIO
        public class Registro_H005
        {
            public Registro_H005()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INV { get; set; }
            public string N03_VL_INV { get; set; }
            public string N04_MOT_INV { get; set; }
        }


        // REGISTRO H010: INVENTÁRIO
        public class Registro_H010
        {
            public Registro_H010()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_UNID { get; set; }
            public string N04_QTD { get; set; }
            public string N05_VL_UNIT { get; set; }
            public string N06_VL_ITEM { get; set; }
            public string N07_IND_PROP { get; set; }
            public string N08_COD_PART { get; set; }
            public string N09_TXT_COMPL { get; set; }
            public string N10_COD_CTA { get; set; }
            public string N11_VL_ITEM_IR { get; set; }
        }

        //REGISTRO H020: INFORMAÇÃO COMPLEMENTAR DO INVENTÁRIO
        public class Registro_H020
        {
            public Registro_H020()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_BC_ICMS { get; set; }
            public string N04_VL_ICMS { get; set; }
        }

        // REGISTRO H030: INFORMAÇÕES COMPLEMENTARES DO INVENTÁRIO DAS MERCADORIAS SUJEITAS AO REGIME DE SUBSTITUIÇÃO TRIBUTÁRIA.
        public class Registro_H030
        {
            public Registro_H030()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_ICMS_OP { get; set; }
            public string N03_VL_BC_ICMS_ST { get; set; }
            public string N04_VL_ICMS_ST { get; set; }
            public string N05_VL_FCP { get; set; }
        }

        // REGISTRO H990: ENCERRAMENTO DO BLOCO H
        public class Registro_H990
        {
            public Registro_H990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_H { get; set; }
        }
    }
}
