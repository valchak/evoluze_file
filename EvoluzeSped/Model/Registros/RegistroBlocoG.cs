using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoG
    {
        // REGISTRO G001: ABERTURA DO BLOCO G
        public class Registro_E990
        {
            public Registro_E990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }


        // REGISTRO G110: ICMS - ATIVO PERMANENTE – CIAP
        public class Registro_G110
        {
            public Registro_G110()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI { get; set; }
            public string N03_DT_FIN { get; set; }
            public string N04_SALDO_IN_ICMS { get; set; }
            public string N05_SOM_PARC { get; set; }
            public string N06_VL_TRIB_EXP { get; set; }
            public string N07_VL_TOTAL { get; set; }
            public string N08_IND_PER_SAI { get; set; }
            public string N09_ICMS_APROP { get; set; }
            public string N10_SOM_ICMS_OC { get; set; }
        }

        // REGISTRO G125: MOVIMENTAÇÃO DE BEM OU COMPONENTE DO ATIVO IMOBILIZADO
        public class Registro_G125
        {
            public Registro_G125()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_IND_BEM { get; set; }
            public string N03_DT_MOV { get; set; }
            public string N04_TIPO_MOV { get; set; }
            public string N05_VL_IMOB_ICMS_OP { get; set; }
            public string N06_VL_IMOB_ICMS_ST { get; set; }
            public string N07_VL_IMOB_ICMS_FRT { get; set; }
            public string N08_VL_IMOB_ICMS_DIF { get; set; }
            public string N09_NUM_PARC { get; set; }
            public string N10_VL_PARC_PASS { get; set; }
        }

        // REGISTRO G126: OUTROS CRÉDITOS CIAP
        public class Registro_G126
        {
            public Registro_G126()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI { get; set; }
            public string N03_DT_FIM { get; set; }
            public string N04_NUM_PARC { get; set; }
            public string N05_VL_PARC_PASS { get; set; }
            public string N06_VL_TRIB_OC { get; set; }
            public string N07_VL_TOTAL { get; set; }
            public string N08_IND_PER_SAI { get; set; }
            public string N09_VL_PARC_APROP { get; set; }
        }

        // REGISTRO G130: IDENTIFICAÇÃO DO DOCUMENTO FISCAL
        public class Registro_G130
        {
            public Registro_G130()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_EMIT { get; set; }
            public string N03_COD_PART { get; set; }
            public string N04_COD_MOD { get; set; }
            public string N05_SERIE { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_CHV_NFE_CTE { get; set; }
            public string N08_DT_DOC { get; set; }
            public string N09_NUM_DA { get; set; }
        }

        // REGISTRO G140: IDENTIFICAÇÃO DO ITEM DO DOCUMENTO FISCAL
        public class Registro_G140
        {
            public Registro_G140()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTDE { get; set; }
            public string N05_UNID { get; set; }
            public string N06_VL_ICMS_OP_APLICADO { get; set; }
            public string N07_VL_ICMS_ST_APLICADO { get; set; }
            public string N08_VL_ICMS_FRT_APLICADO { get; set; }
            public string N09_VL_ICMS_DIF_APLICADO { get; set; }
        }

        // REGISTRO G990: ENCERRAMENTO DO BLOCO G
        public class Registro_G990
        {
            public Registro_G990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_G { get; set; }
        }


    }
}
