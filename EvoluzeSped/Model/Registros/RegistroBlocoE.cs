using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoE
    {
        // REGISTRO E001: ABERTURA DO BLOCO E
        public class Registro_E001
        {
            public Registro_E001()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }

        // REGISTRO E100: PERÍODO DA APURAÇÃO DO ICMS
        public class Registro_E100
        {
            public Registro_E100()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI { get; set; }
            public string N03_DT_FIN { get; set; }
        }

        // REGISTRO E110: APURAÇÃO DO ICMS - OPERAÇÕES PRÓPRIAS
        public class Registro_E
        {
            public Registro_E()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_TOT_DEBITOS { get; set; }
            public string N03_VL_AJ_DEBITOS { get; set; }
            public string N04_VL_TOT_AJ_DEBITOS { get; set; }
            public string N05_VL_ESTORNOS_CRED { get; set; }
            public string N06_VL_TOT_CREDITOS { get; set; }
            public string N07_VL_AJ_CREDITOS { get; set; }
            public string N08_VL_TOT_AJ_CREDITOS { get; set; }
            public string N09_VL_ESTORNOS_DEB { get; set; }
            public string N10_VL_SLD_CREDOR_ANT { get; set; }
            public string N11_VL_SLD_APURADO { get; set; }
            public string N12_VL_TOT_DED { get; set; }
            public string N13_VL_ICMS_RECOLHER { get; set; }
            public string N14_VL_SLD_CREDOR_TRANSPORTAR { get; set; }
            public string N15_DEB_ESP { get; set; }
        }

        // REGISTRO E111: AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO ICMS
        public class Registro_E111
        {
            public Registro_E111()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_AJ_APUR { get; set; }
            public string N03_DESCR_COMPL_AJ { get; set; }
            public string N04_VL_AJ_APUR { get; set; }

        }

        // REGISTRO E112: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS
        public class Registro_E112
        {
            public Registro_E112()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DA { get; set; }
            public string N03_NUM_PROC { get; set; }
            public string N04_IND_PROC { get; set; }
            public string N05_PROC { get; set; }
            public string N06_TXT_COMPL { get; set; }
        }

        // REGISTRO E113: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS - IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS
        public class Registro_E113
        {
            public Registro_E113()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_COD_MOD { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_DT_DOC { get; set; }
            public string N08_COD_ITEM { get; set; }
            public string N09_VL_AJ_ITEM { get; set; }
            public string N10_CHV_DOCe { get; set; }
        }

        // REGISTRO E115: INFORMAÇÕES ADICIONAIS DA APURAÇÃO - VALORES DECLARATÓRIOS
        public class Registro_E115
        {
            public Registro_E115()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_INF_ADIC { get; set; }
            public string N03_VL_INF_ADIC { get; set; }
            public string N04_DESCR_COMPL_AJ { get; set; }
        }

        // REGISTRO E116: OBRIGAÇÕES DO ICMS RECOLHIDO OU A RECOLHER - OPERAÇÕES PRÓPRIAS
        public class Registro_E116
        {
            public Registro_E116()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OR { get; set; }
            public string N03_VL_OR { get; set; }
            public string N04_DT_VCTO { get; set; }
            public string N05_COD_REC { get; set; }
            public string N06_NUM_PROC { get; set; }
            public string N07_IND_PROC { get; set; }
            public string N08_PROC { get; set; }
            public string N09_TXT_COMPL { get; set; }
            public string N10_MES_REF { get; set; }
        }

        // REGISTRO E200: PERÍODO DA APURAÇÃO DO ICMS - SUBSTITUIÇÃO TRIBUTÁRIA
        public class Registro_E200
        {
            public Registro_E200()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_UF { get; set; }
            public string N03_DT_INI { get; set; }
            public string N04_DT_FIN { get; set; }
        }

        // REGISTRO E210: APURAÇÃO DO ICMS - SUBSTITUIÇÃO TRIBUTÁRIA
        public class Registro_E210
        {
            public Registro_E210()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV_ST { get; set; }
            public string N03_VL_SLD_CRED_ANT_ST { get; set; }
            public string N04_VL_DEVOL_ST { get; set; }
            public string N05_VL_RESSARC_ST { get; set; }
            public string N06_VL_OUT_CRED_ST { get; set; }
            public string N07_VL_AJ_CREDITOS_ST { get; set; }
            public string N08_VL_RETENÇAO_ST { get; set; }
            public string N09_VL_OUT_DEB_ST { get; set; }
            public string N10_VL_AJ_DEBITOS_ST { get; set; }
            public string N11_VL_SLD_DEV_ANT_ST { get; set; }
            public string N12_VL_DEDUÇÕES_ST { get; set; }
            public string N13_VL_ICMS_RECOL_ST { get; set; }
            public string N14_VL_SLD_CRED_ST_TRANSPORTAR { get; set; }
        }

        // REGISTRO E220: AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA
        public class Registro_E220
        {
            public Registro_E220()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_AJ_APUR { get; set; }
            public string N03_DESCR_COMPL_AJ { get; set; }
            public string N04_VL_AJ_APUR { get; set; }
        }


        // REGISTRO E230: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA
        public class Registro_E230
        {
            public Registro_E230()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DA { get; set; }
            public string N03_NUM_PROC { get; set; }
            public string N04_IND_PROC { get; set; }
            public string N05_PROC { get; set; }
            public string N06_TXT_COMPL { get; set; }
        }

        // REGISTRO E240: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO ICMS SUBSTITUIÇÃO TRIBUTÁRIA - IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS
        public class Registro_E240
        {
            public Registro_E240()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_COD_MOD { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_DT_DOC { get; set; }
            public string N08_COD_ITEM { get; set; }
            public string N09_VL_AJ_ITEM { get; set; }
            public string N10_CHV_DOCe { get; set; }
        }

        // REGISTRO E250: OBRIGAÇÕES DO ICMS RECOLHIDO OU A RECOLHER - SUBSTITUIÇÃO TRIBUTÁRIA
        public class Registro_E250
        {
            public Registro_E250()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OR { get; set; }
            public string N03_VL_OR { get; set; }
            public string N04_DT_VCTO { get; set; }
            public string N05_COD_REC { get; set; }
            public string N06_NUM_PROC { get; set; }
            public string N07_IND_PROC { get; set; }
            public string N08_PROC { get; set; }
            public string N09_TXT_COMPL { get; set; }
            public string N10_MES_REF { get; set; }
        }


        // REGISTRO E300: PERÍODO DE APURAÇÃO DO FUNDO DE COMBATE À POBREZA E DO ICMS DIFERENCIAL DE ALÍQUOTAS - UF ORIGEM/DESTINO EC 87/15
        public class Registro_E300
        {
            public Registro_E300()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_UF { get; set; }
            public string N03_DT_INI { get; set; }
            public string N04_DT_FIN { get; set; }
        }


        // REGISTRO E310: APURAÇÃO DO FUNDO DE COMBATE À POBREZA E DO ICMS DIFERENCIAL DE ALÍQUOTAS – UF ORIGEM/DESTINO EC 87/15
        public class Registro_E310
        {
            public Registro_E310()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV_FCP_DIFAL { get; set; }
            public string N03_VL_SLD_CRED_ANT_DIFAL { get; set; }
            public string N04_VL_TOT_DEBITOS_DIFAL { get; set; }
            public string N05_VL_OUT_DEB_DIFAL { get; set; }
            public string N06_VL_TOT_CREDITOS_DIFAL { get; set; }
            public string N07_VL_OUT_CRED_DIFAL { get; set; }
            public string N08_VL_SLD_DEV_ANT_DIFAL { get; set; }
            public string N09_VL_DEDUÇÕES_DIFAL { get; set; }
            public string N10_VL_RECOL_DIFAL { get; set; }
            public string N11_VL_SLD_CRED_TRANSPORTAR_DIFAL { get; set; }
            public string N12_DEB_ESP_DIFAL { get; set; }
            public string N13_VL_SLD_CRED_ANT_FCP { get; set; }
            public string N14_VL_TOT_DEB_FCP { get; set; }
            public string N15_VL_OUT_DEB_FCP { get; set; }
            public string N16_VL_TOT_CRED_FCP { get; set; }
            public string N17_VL_OUT_CRED_FCP { get; set; }
            public string N18_VL_SLD_DEV_ANT_FCP { get; set; }
            public string N19_VL_DEDUÇÕES_FCP { get; set; }
            public string N20_VL_RECOL_FCP { get; set; }
            public string N21_VL_SLD_CRED_TRANSPORTAR_FCP { get; set; }
            public string N22_DEB_ESP_FCP { get; set; }
        }

        // REGISTRO E311: AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO FUNDO DE COMBATE À POBREZA E DO ICMS DIFERENCIAL DE ALÍQUOTAS UF ORIGEM/DESTINO EC 87/15
        public class Registro_E311
        {
            public Registro_E311()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_AJ_APUR { get; set; }
            public string N03_DESCR_COMPL_AJ { get; set; }
            public string N04_VL_AJ_APUR { get; set; }
        }

        // REGISTRO E312: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO FUNDO DE COMBATE À POBREZA E DO ICMS DIFERENCIAL DE ALÍQUOTAS UF ORIGEM/DESTINO EC 87/15
        public class Registro_E312
        {
            public Registro_E312()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DA { get; set; }
            public string N03_NUM_PROC { get; set; }
            public string N04_IND_PROC { get; set; }
            public string N05_PROC { get; set; }
            public string N06_TXT_COMPL { get; set; }
        }

        // REGISTRO E313: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO FUNDO DE COMBATE À POBREZA E DO ICMS DIFERENCIAL DE ALÍQUOTAS UF ORIGEM/DESTINO EC 87/public string N15_- IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS
        public class Registro_E313
        {
            public Registro_E313()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_COD_MOD { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_CHV_DOCe { get; set; }
            public string N08_DT_DOC { get; set; }
            public string N09_COD_ITEM { get; set; }
            public string N10_VL_AJ_ITEM { get; set; }
        }

        // REGISTRO E316: OBRIGAÇÕES RECOLHIDAS OU A RECOLHER – FUNDO DE COMBATE À POBREZA E ICMS DIFERENCIAL DE ALÍQUOTAS UF ORIGEM/DESTINO EC 87/15
        public class Registro_E316
        {
            public Registro_E316()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OR { get; set; }
            public string N03_VL_OR { get; set; }
            public string N04_DT_VCTO { get; set; }
            public string N05_COD_REC { get; set; }
            public string N06_NUM_PROC { get; set; }
            public string N07_IND_PROC { get; set; }
            public string N08_PROC { get; set; }
            public string N09_TXT_COMPL { get; set; }
            public string N10_MES_REF { get; set; }

        }


        // REGISTRO E500: PERÍODO DE APURAÇÃO DO IPI
        public class Registro_E500
        {
            public Registro_E500()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_APUR { get; set; }
            public string N03_DT_INI { get; set; }
            public string N04_DT_FIN { get; set; }
        }

        // REGISTRO E510: CONSOLIDAÇÃO DOS VALORES DO IPI
        public class Registro_E510
        {
            public Registro_E510()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CFOP { get; set; }
            public string N03_CST_IPI { get; set; }
            public string N04_VL_CONT_IPI { get; set; }
            public string N05_VL_BC_IPI { get; set; }
            public string N06_VL_IPI { get; set; }
        }

        // REGISTRO E520: APURAÇÃO DO IPI
        public class Registro_E520
        {
            public Registro_E520()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_SD_ANT_IPI { get; set; }
            public string N03_VL_DEB_IPI { get; set; }
            public string N04_VL_CRED_IPI { get; set; }
            public string N05_VL_OD_IPI { get; set; }
            public string N06_VL_OC_IPI { get; set; }
            public string N07_VL_SC_IPI { get; set; }
            public string N08_VL_SD_IPI { get; set; }
        }

        // REGISTRO E530: AJUSTES DA APURAÇÃO DO IPI
        public class Registro_E530
        {
            public Registro_E530()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_AJ { get; set; }
            public string N03_VL_AJ { get; set; }
            public string N04_COD_AJ { get; set; }
            public string N05_IND_DOC { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_DESCR_AJ { get; set; }
        }

        // REGISTRO E531: INFORMAÇÕES ADICIONAIS DOS AJUSTES DA APURAÇÃO DO IPI – IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS (public string N01_e 55)
        public class Registro_E531
        {
            public Registro_E531()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_COD_MOD { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_NUM_DOC { get; set; }
            public string N07_DT_DOC { get; set; }
            public string N08_COD_ITEM { get; set; }
            public string N09_VL_AJ_ITEM { get; set; }
            public string N10_CHV_NFE { get; set; }
        }

        // REGISTRO E990: ENCERRAMENTO DO BLOCO E
        public class Registro_E990
        {
            public Registro_E990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_E { get; set; }
        }
    }
}
