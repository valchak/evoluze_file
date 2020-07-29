using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoC
    {
        // REGISTRO C001: ABERTURA DO BLOCO C
        public class Registro_C001
        {
            public Registro_C001()
            {
                N01_REG = "";
                N02_IND_MOV = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }

        //REGISTRO C100: NOTA FISCAL (CÓDIGO 01), NOTA FISCAL AVULSA (CÓDIGO 1B), NOTA FISCAL DE PRODUTOR (CÓDIGO 04), NF-e (CÓDIGO 55) e NFC-e (CÓDIGO 65)
        public class Registro_C100
        {
            public Registro_C100()
            {
                N01_REG = "";
                N02_IND_OPER = "";
                N03_IND_EMIT = "";
                N04_COD_PART = "";
                N05_COD_MOD = "";
                N06_COD_SIT = "";
                N07_SER = "";
                N08_NUM_DOC = "";
                N09_CHV_NFE = "";
                N10_DT_DOC = DateTime.Now;
                N11_DT_E_S = DateTime.Now;
                N12_VL_DOC = "";
                N13_IND_PGTO = "";
                N14_VL_DESC = "";
                N15_VL_ABAT_NT = "";
                N16_VL_MERC = "";
                N17_IND_FRT = "";
                N18_VL_FRT = "";
                N19_VL_SEG = "";
                N20_VL_OUT_DA = "";
                N21_VL_BC_ICMS = "";
                N22_VL_ICMS = "";
                N23_VL_BC_ICMS_ST = "";
                N24_VL_ICMS_ST = "";
                N25_VL_IPI = "";
                N26_VL_PIS = "";
                N27_VL_COFINS = "";
                N28_VL_PIS_ST = "";
                N29_VL_COFINS_ST = "";

            }
            public string N01_REG { get; set; }
            public string N02_IND_OPER { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_COD_PART { get; set; }
            public string N05_COD_MOD { get; set; }
            public string N06_COD_SIT { get; set; }
            public string N07_SER { get; set; }
            public string N08_NUM_DOC { get; set; }
            public string N09_CHV_NFE { get; set; }
            public DateTime N10_DT_DOC { get; set; }
            public DateTime N11_DT_E_S { get; set; }
            public string N12_VL_DOC { get; set; }
            public string N13_IND_PGTO { get; set; }
            public string N14_VL_DESC { get; set; }
            public string N15_VL_ABAT_NT { get; set; }
            public string N16_VL_MERC { get; set; }
            public string N17_IND_FRT { get; set; }
            public string N18_VL_FRT { get; set; }
            public string N19_VL_SEG { get; set; }
            public string N20_VL_OUT_DA { get; set; }
            public string N21_VL_BC_ICMS { get; set; }
            public string N22_VL_ICMS { get; set; }
            public string N23_VL_BC_ICMS_ST { get; set; }
            public string N24_VL_ICMS_ST { get; set; }
            public string N25_VL_IPI { get; set; }
            public string N26_VL_PIS { get; set; }
            public string N27_VL_COFINS { get; set; }
            public string N28_VL_PIS_ST { get; set; }
            public string N29_VL_COFINS_ST { get; set; }

        }

        //REGISTRO C101: INFORMAÇÃO COMPLEMENTAR DOS DOCUMENTOS FISCAIS QUANDO DAS OPERAÇÕES INTERESTADUAIS DESTINADAS A CONSUMIDOR FINAL NÃO CONTRIBUINTE EC 87/15
        public class Registro_C101
        {
            public Registro_C101()
            {
                N01_REG = "";
                N02_VL_FCP_UF_DEST = "";
                N03_VL_ICMS_UF_DEST = "";
                N04_VL_ICMS_UF_REM = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_FCP_UF_DEST { get; set; }
            public string N03_VL_ICMS_UF_DEST { get; set; }
            public string N04_VL_ICMS_UF_REM { get; set; }

        }

        //REGISTRO C105 - OPERAÇÕES COM ICMS ST RECOLHIDO PARA UF DIVERSA DO DESTINATÁRIO DO DOCUMENTO FISCAL (CÓDIGO 55)
        public class Registro_C105
        {
            public Registro_C105()
            {
                N01_REG = "";
                N02_OPER = "";
                N03_UF = "";
            }
            public string N01_REG { get; set; }
            public string N02_OPER { get; set; }
            public string N03_UF { get; set; }
        }

        //REGISTRO C110: INFORMAÇÃO COMPLEMENTAR DA NOTA FISCAL(CÓDIGO 01; 1B, 04 e 55)
        public class Registro_C110
        {
            public Registro_C110()
            {
                N01_REG = "";
                N02_COD_INF = "";
                N03_TXT_COMPL = "";

            }
            public string N01_REG { get; set; }
            public string N02_COD_INF { get; set; }
            public string N03_TXT_COMPL { get; set; }


        }

        //REGISTRO C111: PROCESSO REFERENCIADO
        public class Registro_C111
        {
            public Registro_C111()
            {
                N01_REG = "";
                N02_NUM_PROC = "";
                N03_IND_PROC = "";

            }
            public string N01_REG { get; set; }
            public string N02_NUM_PROC { get; set; }
            public string N03_IND_PROC { get; set; }

        }

        //REGISTRO C112: DOCUMENTO DE ARRECADAÇÃO REFERENCIADO
        public class Registro_C112
        {
            public Registro_C112()
            {
                N01_REG = "";
                N02_COD_DA = "";
                N03_UF = "";
                N04_NUM_DA = "";
                N05_COD_AUT = "";
                N06_VL_DA = "";
                N07_DT_VCTO = DateTime.Now;
                N08_DT_PGTO = DateTime.Now;
            }
            public string N01_REG { get; set; }
            public string N02_COD_DA { get; set; }
            public string N03_UF { get; set; }
            public string N04_NUM_DA { get; set; }
            public string N05_COD_AUT { get; set; }
            public string N06_VL_DA { get; set; }
            public DateTime N07_DT_VCTO { get; set; }
            public DateTime N08_DT_PGTO { get; set; }
        }

        //REGISTRO C113: DOCUMENTO FISCAL REFERENCIADO
        public class Registro_C113
        {
            public Registro_C113()
            {
                N01_REG = "";
                N02_IND_OPER = "";
                N03_IND_EMIT = "";
                N04_COD_PART = "";
                N05_COD_MOD = "";
                N06_SER = "";
                N07_SUB = "";
                N08_NUM_DOC = "";
                N09_DT_DOC = DateTime.Now;
                N10_CHV_DOCe = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_OPER { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_COD_PART { get; set; }
            public string N05_COD_MOD { get; set; }
            public string N06_SER { get; set; }
            public string N07_SUB { get; set; }
            public string N08_NUM_DOC { get; set; }
            public DateTime N09_DT_DOC { get; set; }
            public string N10_CHV_DOCe { get; set; }

        }

        //REGISTRO C114: CUPOM FISCAL REFERENCIADO
        public class Registro_C114
        {
            public Registro_C114()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_ECF_FAB = "";
                N04_ECF_CX = "";
                N05_NUM_DOC = "";
                N06_DT_DOC = DateTime.Now;
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_ECF_FAB { get; set; }
            public string N04_ECF_CX { get; set; }
            public string N05_NUM_DOC { get; set; }
            public DateTime N06_DT_DOC { get; set; }
        }

        //REGISTRO C115: LOCAL DE COLETA E/OU ENTREGA(CÓDIGOS 01, 1B e 04)
        public class Registro_C115
        {
            public Registro_C115()
            {
                N01_REG = "";
                N02_IND_CARGA = "";
                N03_CNPJ_COL = "";
                N04_IE_COL = "";
                N05_CPF_COL = "";
                N06_COD_MUN_COL = "";
                N07_CNPJ_ENTG = "";
                N08_IE_ENTG = "";
                N09_CPF_ENTG = "";
                N10_COD_MUN_ENTG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_CARGA { get; set; }
            public string N03_CNPJ_COL { get; set; }
            public string N04_IE_COL { get; set; }
            public string N05_CPF_COL { get; set; }
            public string N06_COD_MUN_COL { get; set; }
            public string N07_CNPJ_ENTG { get; set; }
            public string N08_IE_ENTG { get; set; }
            public string N09_CPF_ENTG { get; set; }
            public string N10_COD_MUN_ENTG { get; set; }
        }

        //REGISTRO C116: CUPOM FISCAL ELETRÔNICO REFERENCIADO
        public class Registro_C116
        {
            public Registro_C116()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_NR_SAT = "";
                N04_CHV_CFE = "";
                N05_NUM_CFE = "";
                N06_DT_DOC = DateTime.Now;
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_NR_SAT { get; set; }
            public string N04_CHV_CFE { get; set; }
            public string N05_NUM_CFE { get; set; }
            public DateTime N06_DT_DOC { get; set; }
        }

        //REGISTRO C120: COMPLEMENTO DE DOCUMENTO - OPERAÇÕES DE IMPORTAÇÃO (CÓDIGO public string N01_E 55)
        public class Registro_C120
        {
            public Registro_C120()
            {
                N01_REG = "";
                N02_COD_DOC_IMP = "";
                N03_NUM_DOC_IMP = "";
                N04_PIS_IMP = "";
                N05_COFINS_IMP = "";
                N06_NUM_ACDRAW = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_DOC_IMP { get; set; }
            public string N03_NUM_DOC_IMP { get; set; }
            public string N04_PIS_IMP { get; set; }
            public string N05_COFINS_IMP { get; set; }
            public string N06_NUM_ACDRAW { get; set; }
        }

        //REGISTRO C130: ISSQN, IRRF E PREVIDÊNCIA SOCIAL
        public class Registro_C130
        {
            public Registro_C130()
            {
                N01_REG = "";
                N02_VL_SERV_NT = "";
                N03_VL_BC_ISSQN = "";
                N04_VL_ISSQN = "";
                N05_VL_BC_IRRF = "";
                N06_VL_IRRF = "";
                N07_VL_BC_PREV = "";
                N08_VL_PREV = "";

            }
            public string N01_REG { get; set; }
            public string N02_VL_SERV_NT { get; set; }
            public string N03_VL_BC_ISSQN { get; set; }
            public string N04_VL_ISSQN { get; set; }
            public string N05_VL_BC_IRRF { get; set; }
            public string N06_VL_IRRF { get; set; }
            public string N07_VL_BC_PREV { get; set; }
            public string N08_VL_PREV { get; set; }
        }

        //REGISTRO C140: FATURA(CÓDIGO 01)
        public class Registro_C140
        {
            public Registro_C140()
            {
                N01_REG = "";
                N02_IND_EMIT = "";
                N03_IND_TIT = "";
                N04_DESC_TIT = "";
                N05_NUM_TIT = "";
                N06_QTD_PARC = "";
                N07_VL_TIT = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_EMIT { get; set; }
            public string N03_IND_TIT { get; set; }
            public string N04_DESC_TIT { get; set; }
            public string N05_NUM_TIT { get; set; }
            public string N06_QTD_PARC { get; set; }
            public string N07_VL_TIT { get; set; }
        }

        //REGISTRO C141: VENCIMENTO DA FATURA(CÓDIGO 01)
        public class Registro_C141
        {
            public Registro_C141()
            {
                N01_REG = "";
                N02_NUM_PARC = "";
                N03_DT_VCTO = DateTime.Now;
                N04_VL_PARC = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_PARC { get; set; }
            public DateTime N03_DT_VCTO { get; set; }
            public string N04_VL_PARC { get; set; }

        }

        //REGISTRO C160: VOLUMES TRANSPORTADOS(CÓDIGO public string N01_E 04) - EXCETO COMBUSTÍVEIS
        public class Registro_C160
        {
            public Registro_C160()
            {
                N01_REG = "";
                N02_COD_PART = "";
                N03_VEIC_ID = "";
                N04_QTD_VOL = "";
                N05_PESO_BRT = "";
                N06_PESO_LIQ = "";
                N07_UF_ID = "";

            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_VEIC_ID { get; set; }
            public string N04_QTD_VOL { get; set; }
            public string N05_PESO_BRT { get; set; }
            public string N06_PESO_LIQ { get; set; }
            public string N07_UF_ID { get; set; }
        }

        //REGISTRO C165: OPERAÇÕES COM COMBUSTÍVEIS(CÓDIGO 01; 55)
        public class Registro_C165
        {
            public Registro_C165()
            {
                N01_REG = "";
                N02_COD_PART = "";
                N03_VEIC_ID = "";
                N04_COD_AUT = "";
                N05_NR_PASSE = "";
                N06_HORA = "";
                N07_TEMPER = "";
                N08_QTD_VOL = "";
                N09_PESO_BRT = "";
                N10_PESO_LIQ = "";
                N11_NOM_MOT = "";
                N12_CPF = "";
                N13_UF_ID = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_VEIC_ID { get; set; }
            public string N04_COD_AUT { get; set; }
            public string N05_NR_PASSE { get; set; }
            public string N06_HORA { get; set; }
            public string N07_TEMPER { get; set; }
            public string N08_QTD_VOL { get; set; }
            public string N09_PESO_BRT { get; set; }
            public string N10_PESO_LIQ { get; set; }
            public string N11_NOM_MOT { get; set; }
            public string N12_CPF { get; set; }
            public string N13_UF_ID { get; set; }
        }

        ///REGISTRO C170: ITENS DO DOCUMENTO (CÓDIGO 01, 1B, public string N04_e 55)
        public class Registro_C170
        {
            public Registro_C170()
            {
                N01_REG = "";
                N02_NUM_ITEM = "";
                N03_COD_ITEM = "";
                N04_DESCR_COMPL = "";
                N05_QTD = "";
                N06_UNID = "";
                N07_VL_ITEM = "";
                N08_VL_DESC = "";
                N09_IND_MOV = "";
                N10_CST_ICMS = "";
                N11_CFOP = "";
                N12_COD_NAT = "";
                N13_VL_BC_ICMS = "";
                N14_ALIQ_ICMS = "";
                N15_VL_ICMS = "";
                N16_VL_BC_ICMS_ST = "";
                N17_ALIQ_ST = "";
                N18_VL_ICMS_ST = "";
                N19_IND_APUR = "";
                N20_CST_IPI = "";
                N21_COD_ENQ = "";
                N22_VL_BC_IPI = "";
                N23_ALIQ_IPI = "";
                N24_VL_IPI = "";
                N25_CST_PIS = "";
                N26_VL_BC_PIS = "";
                N27_ALIQ_PIS_PERCENTUAL = "";
                N28_QUANT_BC_PIS = "";
                N29_ALIQ_PIS_REAIS = "";
                N30_VL_PIS = "";
                N31_CST_COFINS = "";
                N32_VL_BC_COFINS = "";
                N33_ALIQ_COFINS = "";
                N34_QUANT_BC_COFINS = "";
                N35_ALIQ_COFINS = "";
                N36_VL_COFINS = "";
                N37_COD_CTA = "";
                N38_VL_ABAT_NT = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_DESCR_COMPL { get; set; }
            public string N05_QTD { get; set; }
            public string N06_UNID { get; set; }
            public string N07_VL_ITEM { get; set; }
            public string N08_VL_DESC { get; set; }
            public string N09_IND_MOV { get; set; }
            public string N10_CST_ICMS { get; set; }
            public string N11_CFOP { get; set; }
            public string N12_COD_NAT { get; set; }
            public string N13_VL_BC_ICMS { get; set; }
            public string N14_ALIQ_ICMS { get; set; }
            public string N15_VL_ICMS { get; set; }
            public string N16_VL_BC_ICMS_ST { get; set; }
            public string N17_ALIQ_ST { get; set; }
            public string N18_VL_ICMS_ST { get; set; }
            public string N19_IND_APUR { get; set; }
            public string N20_CST_IPI { get; set; }
            public string N21_COD_ENQ { get; set; }
            public string N22_VL_BC_IPI { get; set; }
            public string N23_ALIQ_IPI { get; set; }
            public string N24_VL_IPI { get; set; }
            public string N25_CST_PIS { get; set; }
            public string N26_VL_BC_PIS { get; set; }
            public string N27_ALIQ_PIS_PERCENTUAL { get; set; }
            public string N28_QUANT_BC_PIS { get; set; }
            public string N29_ALIQ_PIS_REAIS { get; set; }
            public string N30_VL_PIS { get; set; }
            public string N31_CST_COFINS { get; set; }
            public string N32_VL_BC_COFINS { get; set; }
            public string N33_ALIQ_COFINS { get; set; }
            public string N34_QUANT_BC_COFINS { get; set; }
            public string N35_ALIQ_COFINS { get; set; }
            public string N36_VL_COFINS { get; set; }
            public string N37_COD_CTA { get; set; }
            public string N38_VL_ABAT_NT { get; set; }
        }

        //REGISTRO C171: ARMAZENAMENTO DE COMBUSTÍVEIS (código 01, 55)
        public class Registro_C171
        {
            public Registro_C171()
            {
                N01_REG = "";
                N02_NUM_TANQUE = "";
                N03_QTDE = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_TANQUE { get; set; }
            public string N03_QTDE { get; set; }
        }

        //REGISTRO C172: OPERAÇÕES COM ISSQN(CÓDIGO 01)
        public class Registro_C172
        {
            public Registro_C172()
            {
                N01_REG = "";
                N02_VL_BC_ISSQN = "";
                N03_ALIQ_ISSQN = "";
                N04_VL_ISSQN = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_BC_ISSQN { get; set; }
            public string N03_ALIQ_ISSQN { get; set; }
            public string N04_VL_ISSQN { get; set; }

        }

        //REGISTRO C173: OPERAÇÕES COM MEDICAMENTOS (CÓDIGO 01, 55)
        public class Registro_C173
        {
            public Registro_C173()
            {
                N01_REG = "";
                N02_LOTE_MED = "";
                N03_QTD_ITEM = "";
                N04_DT_FAB = DateTime.Now;
                N05_DT_VAL = DateTime.Now;
                N06_IND_MED = "";
                N07_TP_PROD = "";
                N08_VL_TAB_MAX = "";
            }
            public string N01_REG { get; set; }
            public string N02_LOTE_MED { get; set; }
            public string N03_QTD_ITEM { get; set; }
            public DateTime N04_DT_FAB { get; set; }
            public DateTime N05_DT_VAL { get; set; }
            public string N06_IND_MED { get; set; }
            public string N07_TP_PROD { get; set; }
            public string N08_VL_TAB_MAX { get; set; }

        }

        //REGISTRO C174: OPERAÇÕES COM ARMAS DE FOGO (CÓDIGO 01)
        public class Registro_C174
        {
            public Registro_C174()
            {
                N01_REG = "";
                N02_IND_ARM = "";
                N03_NUM_ARM = "";
                N04_DESCR_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_ARM { get; set; }
            public string N03_NUM_ARM { get; set; }
            public string N04_DESCR_COMPL { get; set; }
        }

        //REGISTRO C175: OPERAÇÕES COM VEÍCULOS NOVOS (CÓDIGO 01, 55)
        public class Registro_C175
        {
            public Registro_C175()
            {
                N01_REG = "";
                N02_IND_VEIC_OPER = "";
                N03_CNPJ = "";
                N04_UF = "";
                N05_CHASSI_VEIC = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_VEIC_OPER { get; set; }
            public string N03_CNPJ { get; set; }
            public string N04_UF { get; set; }
            public string N05_CHASSI_VEIC { get; set; }
        }

        //REGISTRO C176: RESSARCIMENTO DE ICMS E FUNDO DE COMBATE À POBREZA (FCP) EM OPERAÇÕES COM SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 01, 55)
        public class Registro_C176
        {
            public Registro_C176()
            {
                N01_REG = "";
                N02_COD_MOD_ULT_E = "";
                N03_NUM_DOC_ULT_E = "";
                N04_SER_ULT_E = "";
                N05_DT_ULT_E = DateTime.Now;
                N06_COD_PART_ULT_E = "";
                N07_QUANT_ULT_E = "";
                N08_VL_UNIT_ULT_E = "";
                N09_VL_UNIT_BC_ST = "";
                N10_CHAVE_NFE_ULT_E = "";
                N11_NUM_ITEM_ULT_E = "";
                N12_VL_UNIT_BC_ICMS_ULT_E = "";
                N13_ALIQ_ICMS_ULT_E = "";
                N14_VL_UNIT_LIMITE_BC_ICMS_ULT_E = "";
                N15_VL_UNIT_ICMS_ULT_E = "";
                N16_ALIQ_ST_ULT_E = "";
                N17_VL_UNIT_RES = "";
                N18_COD_RESP_RET = "";
                N19_COD_MOT_RES = "";
                N20_CHAVE_NFE_RET = "";
                N21_COD_PART_NFE_RET = "";
                N22_SER_NFE_RET = "";
                N23_NUM_NFE_RET = "";
                N24_ITEM_NFE_RET = "";
                N25_COD_DA = "";
                N26_NUM_DA = "";
                N27_VL_UNIT_RES_FCP_ST = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD_ULT_E { get; set; }
            public string N03_NUM_DOC_ULT_E { get; set; }
            public string N04_SER_ULT_E { get; set; }
            public DateTime N05_DT_ULT_E { get; set; }
            public string N06_COD_PART_ULT_E { get; set; }
            public string N07_QUANT_ULT_E { get; set; }
            public string N08_VL_UNIT_ULT_E { get; set; }
            public string N09_VL_UNIT_BC_ST { get; set; }
            public string N10_CHAVE_NFE_ULT_E { get; set; }
            public string N11_NUM_ITEM_ULT_E { get; set; }
            public string N12_VL_UNIT_BC_ICMS_ULT_E { get; set; }
            public string N13_ALIQ_ICMS_ULT_E { get; set; }
            public string N14_VL_UNIT_LIMITE_BC_ICMS_ULT_E { get; set; }
            public string N15_VL_UNIT_ICMS_ULT_E { get; set; }
            public string N16_ALIQ_ST_ULT_E { get; set; }
            public string N17_VL_UNIT_RES { get; set; }
            public string N18_COD_RESP_RET { get; set; }
            public string N19_COD_MOT_RES { get; set; }
            public string N20_CHAVE_NFE_RET { get; set; }
            public string N21_COD_PART_NFE_RET { get; set; }
            public string N22_SER_NFE_RET { get; set; }
            public string N23_NUM_NFE_RET { get; set; }
            public string N24_ITEM_NFE_RET { get; set; }
            public string N25_COD_DA { get; set; }
            public string N26_NUM_DA { get; set; }
            public string N27_VL_UNIT_RES_FCP_ST { get; set; }
        }

        //REGISTRO C177: COMPLEMENTO DE ITEM - OUTRAS INFORMAÇÕES (código 01, 55) - (VÁLIDO A PARTIR DE 01/01/2019)
        public class Registro_C177
        {
            public Registro_C177()
            {
                N01_REG = "";
                N02_COD_INF_ITEM = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_INF_ITEM { get; set; }
        }

        //REGISTRO C178: OPERAÇÕES COM PRODUTOS SUJEITOS À TRIBUTAÇÃO DE IPI POR UNIDADE OU QUANTIDADE DE PRODUTO
        public class Registro_C178
        {
            public Registro_C178()
            {
                N01_REG = "";
                N02_CL_ENQ = "";
                N03_VL_UNID = "";
                N04_QUANT_PAD = "";
            }
            public string N01_REG { get; set; }
            public string N02_CL_ENQ { get; set; }
            public string N03_VL_UNID { get; set; }
            public string N04_QUANT_PAD { get; set; }
        }

        //REGISTRO C179: INFORMAÇÕES COMPLEMENTARES ST (CÓDIGO 01)
        public class Registro_C179
        {
            public Registro_C179()
            {
                N01_REG = "";
                N02_BC_ST_ORIG_DEST = "";
                N03_ICMS_ST_REP = "";
                N04_ICMS_ST_COMPL = "";
                N05_BC_RET = "";
                N06_ICMS_RET = "";
            }
            public string N01_REG { get; set; }
            public string N02_BC_ST_ORIG_DEST { get; set; }
            public string N03_ICMS_ST_REP { get; set; }
            public string N04_ICMS_ST_COMPL { get; set; }
            public string N05_BC_RET { get; set; }
            public string N06_ICMS_RET { get; set; }

        }

        //REGISTRO C180: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE ENTRADA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA(CÓDIGO 01, 1B, N04_e 55)
        public class Registro_C180
        {
            public Registro_C180()
            {
                N01_REG = "";
                N02_COD_RESP_RET = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_OP_CONV = "";
                N07_VL_UNIT_BC_ICMS_ST_CONV = "";
                N08_VL_UNIT_ICMS_ST_CONV = "";
                N09_VL_UNIT_FCP_ST_CONV = "";
                N10_COD_DA = "";
                N11_NUM_DA = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_RESP_RET { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N07_VL_UNIT_BC_ICMS_ST_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_ST_CONV { get; set; }
            public string N09_VL_UNIT_FCP_ST_CONV { get; set; }
            public string N10_COD_DA { get; set; }
            public string N11_NUM_DA { get; set; }
        }

        //REGISTRO C185: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA(CÓDIGO 01, 1B, 04, 55 e 65)
        public class Registro_C185
        {
            public Registro_C185()
            {
                N01_REG = "";
                N02_NUM_ITEM = "";
                N03_COD_ITEM = "";
                N04_CST_ICMS = "";
                N05_CFOP = "";
                N06_COD_MOT_REST_COMPL = "";
                N07_QUANT_CONV = "";
                N08_UNID = "";
                N09_VL_UNIT_CONV = "";
                N10_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N11_VL_UNIT_ICMS_OP_CONV = "";
                N12_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N13_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N14_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N15_VL_UNIT_ICMS_ST_CONV_REST = "";
                N16_VL_UNIT_FCP_ST_CONV_REST = "";
                N17_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N18_VL_UNIT_FCP_ST_CONV_COMPL = "";

            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_CST_ICMS { get; set; }
            public string N05_CFOP { get; set; }
            public string N06_COD_MOT_REST_COMPL { get; set; }
            public string N07_QUANT_CONV { get; set; }
            public string N08_UNID { get; set; }
            public string N09_VL_UNIT_CONV { get; set; }
            public string N10_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N12_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N13_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N14_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N15_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N16_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N17_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N18_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }

        }

        //REGISTRO C190: REGISTRO ANALÍTICO DO DOCUMENTO (CÓDIGO 01, 1B, 04, 55 e 65)
        public class Registro_C190
        {
            public Registro_C190()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_BC_ICMS_ST = "";
                N09_VL_ICMS_ST = "";
                N10_VL_RED_BC = "";
                N11_VL_IPI = "";
                N12_COD_OBS = "";

            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_ST { get; set; }
            public string N09_VL_ICMS_ST { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_VL_IPI { get; set; }
            public string N12_COD_OBS { get; set; }

        }

        //REGISTRO C191: INFORMAÇÕES DO FUNDO DE COMBATE À POBREZA – FCP – NA NF-e (CÓDIGO 55) E NA NFC-E (CÓDIGO 65).
        public class Registro_C191
        {
            public Registro_C191()
            {
                N01_REG = "";
                N02_VL_FCP_OP = "";
                N03_VL_FCP_ST = "";
                N04_VL_FCP_RET = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_FCP_OP { get; set; }
            public string N03_VL_FCP_ST { get; set; }
            public string N04_VL_FCP_RET { get; set; }
        }

        //REGISTRO C195: OBSERVAÇÕES DO LANÇAMENTO FISCAL (CÓDIGO 01, 1B, 04, 55 e 65)
        public class Registro_C195
        {
            public Registro_C195()
            {
                N01_REG = "";
                N02_COD_OBS = "";
                N03_TXT_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OBS { get; set; }
            public string N03_TXT_COMPL { get; set; }
        }

        //REGISTRO C197: OUTRAS OBRIGAÇÕES TRIBUTÁRIAS, AJUSTES E INFORMAÇÕES DE VALORES PROVENIENTES DE DOCUMENTO FISCAL
        public class Registro_C197
        {
            public Registro_C197()
            {
                N01_REG = "";
                N02_COD_AJ = "";
                N03_DESCR_COMPL_AJ = "";
                N04_COD_ITEM = "";
                N05_VL_BC_ICMS = "";
                N06_ALIQ_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_OUTROS = "";

            }
            public string N01_REG { get; set; }
            public string N02_COD_AJ { get; set; }
            public string N03_DESCR_COMPL_AJ { get; set; }
            public string N04_COD_ITEM { get; set; }
            public string N05_VL_BC_ICMS { get; set; }
            public string N06_ALIQ_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_OUTROS { get; set; }
        }

        //REGISTRO C300: RESUMO DIÁRIO DAS NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02)
        public class Registro_C300
        {
            public Registro_C300()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_SER = "";
                N04_SUB = "";
                N05_NUM_DOC_INI = "";
                N06_NUM_DOC_FIN = "";
                N07_DT_DOC = "";
                N08_VL_DOC = "";
                N09_VL_PIS = "";
                N10_VL_COFINS = "";
                N11_COD_CTA = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_SER { get; set; }
            public string N04_SUB { get; set; }
            public string N05_NUM_DOC_INI { get; set; }
            public string N06_NUM_DOC_FIN { get; set; }
            public string N07_DT_DOC { get; set; }
            public string N08_VL_DOC { get; set; }
            public string N09_VL_PIS { get; set; }
            public string N10_VL_COFINS { get; set; }
            public string N11_COD_CTA { get; set; }
        }

        //REGISTRO C310: DOCUMENTOS CANCELADOS DE NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02)
        public class Registro_C310
        {
            public Registro_C310()
            {
                N01_REG = "";
                N02_NUM_DOC_CANC = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DOC_CANC { get; set; }
        }

        //REGISTRO C320: REGISTRO ANALÍTICO DO RESUMO DIÁRIO DAS NOTAS FISCAIS DE VENDA A CONSUMIDOR(CÓDIGO 02)
        public class Registro_C320
        {
            public Registro_C320()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_RED_BC = "";
                N09_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_RED_BC { get; set; }
            public string N09_COD_OBS { get; set; }

        }

        //REGISTRO C321: ITENS DO RESUMO DIÁRIO DOS DOCUMENTOS (CÓDIGO 02)
        public class Registro_C321
        {
            public Registro_C321()
            {
                N01_REG = "";
                N02_COD_ITEM = "";
                N03_QTD = "";
                N04_UNID = "";
                N05_VL_ITEM = "";
                N06_VL_DESC = "";
                N07_VL_BC_ICMS = "";
                N08_VL_ICMS = "";
                N09_VL_PIS = "";
                N10_VL_COFINS = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_ITEM { get; set; }
            public string N06_VL_DESC { get; set; }
            public string N07_VL_BC_ICMS { get; set; }
            public string N08_VL_ICMS { get; set; }
            public string N09_VL_PIS { get; set; }
            public string N10_VL_COFINS { get; set; }
        }

        //REGISTRO C330: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 02)
        public class Registro_C330
        {
            public Registro_C330()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
        }

        //REGISTRO C350: NOTA FISCAL DE VENDA AO CONSUMIDOR (CÓDIGO 02)
        public class Registro_C350
        {
            public Registro_C350()
            {
                N01_REG = "";
                N02_SER = "";
                N03_SUB_SER = "";
                N04_NUM_DOC = "";
                N05_DT_DOC = DateTime.Now;
                N06_CNPJ_CPF = "";
                N07_VL_MERC = "";
                N08_VL_DOC = "";
                N09_VL_DESC = "";
                N10_VL_PIS = "";
                N11_VL_COFINS = "";
                N12_COD_CTA = "";
            }
            public string N01_REG { get; set; }
            public string N02_SER { get; set; }
            public string N03_SUB_SER { get; set; }
            public string N04_NUM_DOC { get; set; }
            public DateTime N05_DT_DOC { get; set; }
            public string N06_CNPJ_CPF { get; set; }
            public string N07_VL_MERC { get; set; }
            public string N08_VL_DOC { get; set; }
            public string N09_VL_DESC { get; set; }
            public string N10_VL_PIS { get; set; }
            public string N11_VL_COFINS { get; set; }
            public string N12_COD_CTA { get; set; }
        }

        //REGISTRO C370: ITENS DO DOCUMENTO (CÓDIGO 02)
        public class Registro_C370
        {
            public Registro_C370()
            {
                N01_REG = "";
                N02_NUM_ITEM = "";
                N03_COD_ITEM = "";
                N04_QTD = "";
                N05_UNID = "";
                N06_VL_ITEM = "";
                N07_VL_DESC = "";
            }

            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_UNID { get; set; }
            public string N06_VL_ITEM { get; set; }
            public string N07_VL_DESC { get; set; }
        }

        //REGISTRO C380: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 02)
        public class Registro_C380
        {
            public Registro_C380()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
                N15_CST_ICMS = "";
                N16_CFOP = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
            public string N15_CST_ICMS { get; set; }
            public string N16_CFOP { get; set; }
        }

        //REGISTRO C390: REGISTRO ANALÍTICO DAS NOTAS FISCAIS DE VENDA A CONSUMIDOR (CÓDIGO 02)
        public class Registro_C390
        {
            public Registro_C390()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_RED_BC = "";
                N09_COD_OBS = "";

            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_RED_BC { get; set; }
            public string N09_COD_OBS { get; set; }
        }

        //REGISTRO C400: EQUIPAMENTO ECF (CÓDIGO 02, 2D e 60)
        public class Registro_C400
        {
            public Registro_C400()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_ECF_MOD = "";
                N04_ECF_FAB = "";
                N05_ECF_CX = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_ECF_MOD { get; set; }
            public string N04_ECF_FAB { get; set; }
            public string N05_ECF_CX { get; set; }
        }

        //REGISTRO C405 - REDUÇÃO Z (CÓDIGO 02, 2D e 60)
        public class Registro_C405
        {
            public Registro_C405()
            {
                N01_REG = "";
                N02_DT_DOC = DateTime.Now;
                N03_CRO = "";
                N04_CRZ = "";
                N05_NUM_COO_FIN = "";
                N06_GT_FIN = "";
                N07_VL_BRT = "";
            }
            public string N01_REG { get; set; }
            public DateTime N02_DT_DOC { get; set; }
            public string N03_CRO { get; set; }
            public string N04_CRZ { get; set; }
            public string N05_NUM_COO_FIN { get; set; }
            public string N06_GT_FIN { get; set; }
            public string N07_VL_BRT { get; set; }
        }

        //REGISTRO C410: PIS E COFINS TOTALIZADOS NO DIA (CÓDIGO N02_E 2D)
        public class Registro_C410
        {
            public Registro_C410()
            {
                N01_REG = "";
                N02_VL_PIS = "";
                N03_VL_COFINS = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_PIS { get; set; }
            public string N03_VL_COFINS { get; set; }

        }

        //REGISTRO C420: REGISTRO DOS TOTALIZADORES PARCIAIS DA REDUÇÃO Z (COD 02, 2D e 60)
        public class Registro_C420
        {
            public Registro_C420()
            {
                N01_REG = "";
                N02_COD_TOT_PAR = "";
                N03_VLR_ACUM_TOT = "";
                N04_NR_TOT = "";
                N05_DESCR_NR_TOT = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_TOT_PAR { get; set; }
            public string N03_VLR_ACUM_TOT { get; set; }
            public string N04_NR_TOT { get; set; }
            public string N05_DESCR_NR_TOT { get; set; }
        }

        //REGISTRO C425: RESUMO DE ITENS DO MOVIMENTO DIÁRIO (CÓDIGO N02_E 2D)
        public class Registro_C425
        {
            public Registro_C425()
            {
                N01_REG = "";
                N02_COD_ITEM = "";
                N03_QTD = "";
                N04_UNID = "";
                N05_VL_ITEM = "";
                N06_VL_PIS = "";
                N07_VL_COFINS = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_ITEM { get; set; }
            public string N06_VL_PIS { get; set; }
            public string N07_VL_COFINS { get; set; }
        }

        //REGISTRO C430: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 02, 2D e 60)
        public class Registro_C430
        {
            public Registro_C430()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_O = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
                N15_CST_ICMS = "";
                N16_CFOP = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_O { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
            public string N15_CST_ICMS { get; set; }
            public string N16_CFOP { get; set; }
        }

        //REGISTRO C460: DOCUMENTO FISCAL EMITIDO POR ECF (CÓDIGO 02, 2D e 60)
        public class Registro_C460
        {
            public Registro_C460()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_COD_SIT = "";
                N04_NUM_DOC = "";
                N05_DT_DOC = DateTime.Now;
                N06_VL_DOC = "";
                N07_VL_PIS = "";
                N08_VL_COFINS = "";
                N09_CPF_CNPJ = "";
                N10_NOM_ADQ = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_COD_SIT { get; set; }
            public string N04_NUM_DOC { get; set; }
            public DateTime N05_DT_DOC { get; set; }
            public string N06_VL_DOC { get; set; }
            public string N07_VL_PIS { get; set; }
            public string N08_VL_COFINS { get; set; }
            public string N09_CPF_CNPJ { get; set; }
            public string N10_NOM_ADQ { get; set; }
        }

        //REGISTRO C465: COMPLEMENTO DO CUPOM FISCAL ELETRÔNICO EMITIDO POR ECF - CF-e-ECF(CÓDIGO 60)
        public class Registro_C465
        {
            public Registro_C465()
            {
                N01_REG = "";
                N02_CHV_CFE = "";
                N03_NUM_CCF = "";
            }
            public string N01_REG { get; set; }
            public string N02_CHV_CFE { get; set; }
            public string N03_NUM_CCF { get; set; }
        }

        //REGISTRO C470: ITENS DO DOCUMENTO FISCAL EMITIDO POR ECF (CÓDIGO N02_E 2D)
        public class Registro_C470
        {
            public Registro_C470()
            {
                N01_REG = "";
                N02_COD_ITEM = "";
                N03_QTD = "";
                N04_QTD_CANC = "";
                N05_UNID = "";
                N06_VL_ITEM = "";
                N07_CST_ICMS = "";
                N08_CFOP = "";
                N09_ALIQ_ICMS = "";
                N10_VL_PIS = "";
                N11_VL_COFINS = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
            public string N04_QTD_CANC { get; set; }
            public string N05_UNID { get; set; }
            public string N06_VL_ITEM { get; set; }
            public string N07_CST_ICMS { get; set; }
            public string N08_CFOP { get; set; }
            public string N09_ALIQ_ICMS { get; set; }
            public string N10_VL_PIS { get; set; }
            public string N11_VL_COFINS { get; set; }
        }

        //REGISTRO C480: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CÓDIGO 02, 2D e 60)
        public class Registro_C480
        {
            public Registro_C480()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
                N15_CST_ICMS = "";
                N16_CFOP = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
            public string N15_CST_ICMS { get; set; }
            public string N16_CFOP { get; set; }
        }

        //REGISTRO C490: REGISTRO ANALÍTICO DO MOVIMENTO DIÁRIO (CÓDIGO 02, 2D e 60)
        public class Registro_C490
        {
            public Registro_C490()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_COD_OBS { get; set; }
        }

        //REGISTRO C495: RESUMO MENSAL DE ITENS DO ECF POR ESTABELECIMENTO (CÓDIGO 02, 2D)
        public class Registro_C495
        {
            public Registro_C495()
            {
                N01_REG = "";
                N02_ALIQ_ICMS = "";
                N03_COD_ITEM = "";
                N04_QTD = "";
                N05_QTD_CANC = "";
                N06_UNID = "";
                N07_VL_ITEM = "";
                N08_VL_DESC = "";
                N09_VL_CANC = "";
                N10_VL_ACMO = "";
                N11_VL_BC_ICMS = "";
                N12_VL_ICMS = "";
                N13_VL_ISEN = "";
                N14_VL_NT = "";
                N15_VL_ICMS_ST = "";
            }
            public string N01_REG { get; set; }
            public string N02_ALIQ_ICMS { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_QTD_CANC { get; set; }
            public string N06_UNID { get; set; }
            public string N07_VL_ITEM { get; set; }
            public string N08_VL_DESC { get; set; }
            public string N09_VL_CANC { get; set; }
            public string N10_VL_ACMO { get; set; }
            public string N11_VL_BC_ICMS { get; set; }
            public string N12_VL_ICMS { get; set; }
            public string N13_VL_ISEN { get; set; }
            public string N14_VL_NT { get; set; }
            public string N15_VL_ICMS_ST { get; set; }
        }
        /// <summary>
        /// REGISTRO C500: NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL DE ENERGIA ELÉTRICA ELETRÔNICA – NF3e (CÓDIGO 66), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO D'ÁGUA CANALIZADA (CÓDIGO 29) E 
        /// NOTA FISCAL CONSUMO FORNECIMENTO DE GÁS (CÓDIGO 28).
        /// </summary>
        public class Registro_C500
        {
            public Registro_C500()
            {
                N01_REG = "";
                N02_IND_OPER = "";
                N03_IND_EMIT = "";
                N04_COD_PART = "";
                N05_COD_MOD = "";
                N06_COD_SIT = "";
                N07_SER = "";
                N08_SUB = "";
                N09_COD_CONS = "";
                N10_NUM_DOC = "";
                N11_DT_DOC = DateTime.Now;
                N12_DT_E_S = DateTime.Now;
                N13_VL_DOC = "";
                N14_VL_DESC = "";
                N15_VL_FORN = "";
                N16_VL_SERV_NT = "";
                N17_VL_TERC = "";
                N18_VL_DA = "";
                N19_VL_BC_ICMS = "";
                N20_VL_ICMS = "";
                N21_VL_BC_ICMS_ST = "";
                N22_VL_ICMS_ST = "";
                N23_COD_INF = "";
                N24_VL_PIS = "";
                N25_VL_COFINS = "";
                N26_TP_LIGACAO = "";
                N27_COD_GRUPO_TENSAO = "";
                N28_CHV_DOCe = "";
                N29_FIN_DOCe = "";
                N30_CHV_DOCe_REF = "";
                N31_IND_DEST = "";
                N32_COD_MUN_DEST = "";
                N33_COD_CTA = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_OPER { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_COD_PART { get; set; }
            public string N05_COD_MOD { get; set; }
            public string N06_COD_SIT { get; set; }
            public string N07_SER { get; set; }
            public string N08_SUB { get; set; }
            public string N09_COD_CONS { get; set; }
            public string N10_NUM_DOC { get; set; }
            public DateTime N11_DT_DOC { get; set; }
            public DateTime N12_DT_E_S { get; set; }
            public string N13_VL_DOC { get; set; }
            public string N14_VL_DESC { get; set; }
            public string N15_VL_FORN { get; set; }
            public string N16_VL_SERV_NT { get; set; }
            public string N17_VL_TERC { get; set; }
            public string N18_VL_DA { get; set; }
            public string N19_VL_BC_ICMS { get; set; }
            public string N20_VL_ICMS { get; set; }
            public string N21_VL_BC_ICMS_ST { get; set; }
            public string N22_VL_ICMS_ST { get; set; }
            public string N23_COD_INF { get; set; }
            public string N24_VL_PIS { get; set; }
            public string N25_VL_COFINS { get; set; }
            public string N26_TP_LIGACAO { get; set; }
            public string N27_COD_GRUPO_TENSAO { get; set; }
            public string N28_CHV_DOCe { get; set; }
            public string N29_FIN_DOCe { get; set; }
            public string N30_CHV_DOCe_REF { get; set; }
            public string N31_IND_DEST { get; set; }
            public string N32_COD_MUN_DEST { get; set; }
            public string N33_COD_CTA { get; set; }
        }

        /// <summary>
        /// REGISTRO C510: ITENS DO DOCUMENTO NOTA FISCAL/CONTA ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO DE ÁGUA CANALIZADA(CÓDIGO 29) E NOTA FISCAL/CONTA DE FORNECIMENTO DE GÁS(CÓDIGO 28)
        /// </summary>
        public class Registro_C510
        {
            public Registro_C510()
            {
                N01_REG = "";
                N02_NUM_ITEM = "";
                N03_COD_ITEM = "";
                N04_COD_CLASS = "";
                N05_QTD = "";
                N06_UNID = "";
                N07_VL_ITEM = "";
                N08_VL_DESC = "";
                N09_CST_ICMS = "";
                N10_CFOP = "";
                N11_VL_BC_ICMS = "";
                N12_ALIQ_ICMS = "";
                N13_VL_ICMS = "";
                N14_VL_BC_ICMS_ST = "";
                N15_ALIQ_ST = "";
                N16_VL_ICMS_ST = "";
                N17_IND_REC = "";
                N18_COD_PART = "";
                N19_VL_PIS = "";
                N20_VL_COFINS = "";
                N21_COD_CTA = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_COD_CLASS { get; set; }
            public string N05_QTD { get; set; }
            public string N06_UNID { get; set; }
            public string N07_VL_ITEM { get; set; }
            public string N08_VL_DESC { get; set; }
            public string N09_CST_ICMS { get; set; }
            public string N10_CFOP { get; set; }
            public string N11_VL_BC_ICMS { get; set; }
            public string N12_ALIQ_ICMS { get; set; }
            public string N13_VL_ICMS { get; set; }
            public string N14_VL_BC_ICMS_ST { get; set; }
            public string N15_ALIQ_ST { get; set; }
            public string N16_VL_ICMS_ST { get; set; }
            public string N17_IND_REC { get; set; }
            public string N18_COD_PART { get; set; }
            public string N19_VL_PIS { get; set; }
            public string N20_VL_COFINS { get; set; }
            public string N21_COD_CTA { get; set; }
        }

        /// <summary>
        /// REGISTRO C590: REGISTRO ANALÍTICO DO DOCUMENTO – NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL DE ENERGIA ELÉTRICA ELETRÔNICA – NF3e (CÓDIGO 66), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO D'ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL CONSUMO FORNECIMENTO DE GÁS (CÓDIGO 28).
        /// </summary>
        public class Registro_C590
        {
            public Registro_C590()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_BC_ICMS_ST = "";
                N09_VL_ICMS_ST = "";
                N10_VL_RED_BC = "";
                N11_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_ST { get; set; }
            public string N09_VL_ICMS_ST { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        //REGISTRO C591: INFORMAÇÕES DO FUNDO DE COMBATE À POBREZA – FCP NA NF3e (CÓDIGO 66)
        public class Registro_C591
        {
            public Registro_C591()
            {
                N01_REG = "";
                N02_VL_FCP_OP = "";
                N03_VL_FCP_ST = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_FCP_OP { get; set; }
            public string N03_VL_FCP_ST { get; set; }
        }

        //REGISTRO C595: OBSERVAÇÕES DO LANÇAMENTO FISCAL (CÓDIGOS 06, 28, 29e 66)
        public class Registro_C595
        {
            public Registro_C595()
            {
                N01_REG = "";
                N02_COD_OBS = "";
                N03_TXT_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OBS { get; set; }
            public string N03_TXT_COMPL { get; set; }
        }

        //REGISTRO C597: OUTRAS OBRIGAÇÕES TRIBUTÁRIAS, AJUSTES E INFORMAÇÕES DE VALORES PROVENIENTES DE DOCUMENTO FISCAL.
        public class Registro_C597
        {
            public Registro_C597()
            {
                N01_REG = "";
                N02_COD_AJ = "";
                N03_DESCR_COMPL_AJ = "";
                N04_COD_ITEM = "";
                N05_VL_BC_ICMS = "";
                N06_ALIQ_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_OUTROS = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_AJ { get; set; }
            public string N03_DESCR_COMPL_AJ { get; set; }
            public string N04_COD_ITEM { get; set; }
            public string N05_VL_BC_ICMS { get; set; }
            public string N06_ALIQ_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_OUTROS { get; set; }
        }

        /// <summary>
        /// REGISTRO C600: CONSOLIDAÇÃO DIÁRIA DE NOTAS FISCAIS/CONTAS DE ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO DE ÁGUA CANALIZADA (CÓDIGO 29) 
        /// E NOTA FISCAL/CONTA DE FORNECIMENTO DE GÁS (CÓDIGO 28) (EMPRESAS NÃO OBRIGADAS AO CONVÊNIO ICMS 115/03)
        /// </summary>
        public class Registro_C600
        {
            public Registro_C600()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_COD_MUN = "";
                N04_SER = "";
                N05_SUB = "";
                N06_COD_CONS = "";
                N07_QTD_CONS = "";
                N08_QTD_CANC = "";
                N09_DT_DOC = DateTime.Now;
                N10_VL_DOC = "";
                N11_VL_DESC = "";
                N12_CONS = "";
                N13_VL_FORN = "";
                N14_VL_SERV_NT = "";
                N15_VL_TERC = "";
                N16_VL_DA = "";
                N17_VL_BC_ICMS = "";
                N18_VL_ICMS = "";
                N19_VL_BC_ICMS_ST = "";
                N20_VL_ICMS_ST = "";
                N21_VL_PIS = "";
                N22_VL_COFINS = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_COD_MUN { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_COD_CONS { get; set; }
            public string N07_QTD_CONS { get; set; }
            public string N08_QTD_CANC { get; set; }
            public DateTime N09_DT_DOC { get; set; }
            public string N10_VL_DOC { get; set; }
            public string N11_VL_DESC { get; set; }
            public string N12_CONS { get; set; }
            public string N13_VL_FORN { get; set; }
            public string N14_VL_SERV_NT { get; set; }
            public string N15_VL_TERC { get; set; }
            public string N16_VL_DA { get; set; }
            public string N17_VL_BC_ICMS { get; set; }
            public string N18_VL_ICMS { get; set; }
            public string N19_VL_BC_ICMS_ST { get; set; }
            public string N20_VL_ICMS_ST { get; set; }
            public string N21_VL_PIS { get; set; }
            public string N22_VL_COFINS { get; set; }
        }

        /// <summary>
        /// REGISTRO C601: DOCUMENTOS CANCELADOS -CONSOLIDAÇÃO DIÁRIA DE NOTAS FISCAIS/ CONTAS DE ENERGIA ELÉTRICA(CÓDIGO 06),
        /// NOTA FISCAL/ CONTA DE FORNECIMENTO DE ÁGUA CANALIZADA(CÓDIGO 29) E NOTA FISCAL / CONTA DE FORNECIMENTO DE GÁS(CÓDIGO 28)
        /// </summary>
        public class Registro_C601
        {
            public Registro_C601()
            {
                N01_REG = "";
                N02_NUM_DOC_CANC = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DOC_CANC { get; set; }
        }

        /// <summary>
        /// REGISTRO C610: ITENS DO DOCUMENTO CONSOLIDADO NOTAS FISCAIS/CONTAS DE ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO DE ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL/CONTA DE FORNECIMENTO DE GÁS (CÓDIGO 28) (EMPRESAS NÃO OBRIGADAS AO CONVENIO ICMS 115/03)
        /// </summary>
        public class Registro_C610
        {
            public Registro_C610()
            {
                N01_REG = "";
                N02_COD_CLASS = "";
                N03_COD_ITEM = "";
                N04_QTD = "";
                N05_UNID = "";
                N06_VL_ITEM = "";
                N07_VL_DESC = "";
                N08_CST_ICMS = "";
                N09_CFOP = "";
                N10_ALIQ_ICMS = "";
                N11_VL_BC_ICMS = "";
                N12_VL_ICMS = "";
                N13_VL_BC_ICMS_ST = "";
                N14_VL_ICMS_ST = "";
                N15_VL_PIS = "";
                N16_VL_COFINS = "";
                N17_COD_CTA = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_CLASS { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_UNID { get; set; }
            public string N06_VL_ITEM { get; set; }
            public string N07_VL_DESC { get; set; }
            public string N08_CST_ICMS { get; set; }
            public string N09_CFOP { get; set; }
            public string N10_ALIQ_ICMS { get; set; }
            public string N11_VL_BC_ICMS { get; set; }
            public string N12_VL_ICMS { get; set; }
            public string N13_VL_BC_ICMS_ST { get; set; }
            public string N14_VL_ICMS_ST { get; set; }
            public string N15_VL_PIS { get; set; }
            public string N16_VL_COFINS { get; set; }
            public string N17_COD_CTA { get; set; }
        }

        /// <summary>
        /// REGISTRO C690: REGISTRO ANALÍTICO DOS DOCUMENTOS (NOTAS FISCAIS/CONTAS DE ENERGIA ELÉTRICA (CÓDIGO 06), 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO DE ÁGUA CANALIZADA (CÓDIGO 29) E NOTA FISCAL/CONTA DE FORNECIMENTO DE GÁS (CÓDIGO 28)
        /// </summary>
        public class Registro_C690
        {
            public Registro_C690()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_RED_BC = "";
                N09_VL_BC_ICMS_ST = "";
                N10_VL_ICMS_ST = "";
                N11_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_RED_BC { get; set; }
            public string N09_VL_BC_ICMS_ST { get; set; }
            public string N10_VL_ICMS_ST { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        /// <summary>
        /// REGISTRO C700: CONSOLIDAÇÃO DOS DOCUMENTOS NOTA FISCAL/CONTA ENERGIA ELÉTRICA (CÓDIGO 06) EMITIDAS EM VIA ÚNICA -
        /// (EMPRESAS OBRIGADAS À ENTREGA DO ARQUIVO PREVISTO NO CONVÊNIO ICMS 115/03) E 
        /// NOTA FISCAL/CONTA DE FORNECIMENTO DE GÁS CANALIZADO (CÓDIGO 28)
        /// </summary>
        public class Registro_C700
        {
            public Registro_C700()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_SER = "";
                N04_NRO_ORD_INI = "";
                N05_NRO_ORD_FIN = "";
                N06_DT_DOC_INI = DateTime.Now;
                N07_DT_DOC_FIN = DateTime.Now;
                N08_NOM_MEST = "";
                N09_CHV_COD_DIG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_SER { get; set; }
            public string N04_NRO_ORD_INI { get; set; }
            public string N05_NRO_ORD_FIN { get; set; }
            public DateTime N06_DT_DOC_INI { get; set; }
            public DateTime N07_DT_DOC_FIN { get; set; }
            public string N08_NOM_MEST { get; set; }
            public string N09_CHV_COD_DIG { get; set; }
        }

        ////REGISTRO C790: REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGOS N06_e 28)
        public class Registro_C790
        {
            public Registro_C790()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_VL_BC_ICMS_ST = "";
                N09_VL_ICMS_ST = "";
                N10_VL_RED_BC = "";
                N11_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_ST { get; set; }
            public string N09_VL_ICMS_ST { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        //REGISTRO C791: REGISTRO DE INFORMAÇÕES DE ICMS ST POR UF (COD 06)
        public class Registro_C791
        {
            public Registro_C791()
            {
                N01_REG = "";
                N02_UF = "";
                N03_VL_BC_ICMS_ST = "";
                N04_VL_ICMS_ST = "";
            }
            public string N01_REG { get; set; }
            public string N02_UF { get; set; }
            public string N03_VL_BC_ICMS_ST { get; set; }
            public string N04_VL_ICMS_ST { get; set; }
        }

        //REGISTRO C800: CUPOM FISCAL ELETRÔNICO - SAT (CF-e-SAT) (CÓDIGO 59)
        public class Registro_C800
        {
            public Registro_C800()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_COD_SIT = "";
                N04_NUM_CFE = "";
                N05_DT_DOC = DateTime.Now;
                N06_VL_CFE = "";
                N07_VL_PIS = "";
                N08_VL_COFINS = "";
                N09_CNPJ_CPF = "";
                N10_NR_SAT = "";
                N11_CHV_CFE = "";
                N12_VL_DESC = "";
                N13_VL_MERC = "";
                N14_VL_OUT_DA = "";
                N15_VL_ICMS = "";
                N16_VL_PIS_ST = "";
                N17_VL_COFINS_ST = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_COD_SIT { get; set; }
            public string N04_NUM_CFE { get; set; }
            public DateTime N05_DT_DOC { get; set; }
            public string N06_VL_CFE { get; set; }
            public string N07_VL_PIS { get; set; }
            public string N08_VL_COFINS { get; set; }
            public string N09_CNPJ_CPF { get; set; }
            public string N10_NR_SAT { get; set; }
            public string N11_CHV_CFE { get; set; }
            public string N12_VL_DESC { get; set; }
            public string N13_VL_MERC { get; set; }
            public string N14_VL_OUT_DA { get; set; }
            public string N15_VL_ICMS { get; set; }
            public string N16_VL_PIS_ST { get; set; }
            public string N17_VL_COFINS_ST { get; set; }
        }

        //REGISTRO C810: ITENS DO DOCUMENTO DO CUPOM FISCAL ELETRÔNICO – SAT (CF-E-SAT) (CÓDIGO59)
        public class Registro_C810
        {
            public Registro_C810()
            {
                N01_REG = "";
                N02_NUM_ITEM = "";
                N03_COD_ITEM = "";
                N04_QTD = "";
                N05_UNID = "";
                N06_VL_ITEM = "";
                N07_CST_ICMS = "";
                N08_CFOP = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_UNID { get; set; }
            public string N06_VL_ITEM { get; set; }
            public string N07_CST_ICMS { get; set; }
            public string N08_CFOP { get; set; }
        }

        //REGISTRO C815: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CF-E-SAT) (CÓDIGO 59)
        public class Registro_C815
        {
            public Registro_C815()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_ICMS_OP_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
        }

        //REGISTRO C850: REGISTRO ANALÍTICO DO CF-e-SAT (CODIGO 59)
        public class Registro_C850
        {
            public Registro_C850()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_COD_OBS { get; set; }
        }

        //REGISTRO C860: IDENTIFICAÇÃO DO EQUIPAMENTO SAT-CF-E
        public class Registro_C860
        {
            public Registro_C860()
            {
                N01_REG = "";
                N02_COD_MOD = "";
                N03_NR_SAT = "";
                N04_DT_DOC = DateTime.Now;
                N05_DOC_INI = DateTime.Now;
                N06_DOC_FIM = DateTime.Now;

            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_NR_SAT { get; set; }
            public DateTime N04_DT_DOC { get; set; }
            public DateTime N05_DOC_INI { get; set; }
            public DateTime N06_DOC_FIM { get; set; }
        }

        //REGISTRO C870: ITENS DO RESUMO DIÁRIO DOS DOCUMENTOS (CF-E-SAT) (CÓDIGO 59)
        public class Registro_C870
        {
            public Registro_C870()
            {
                N01_REG = "";
                N02_COD_ITEM = "";
                N03_QTD = "";
                N04_UNID = "";
                N05_CST_ICMS = "";
                N06_CFOP = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
            public string N04_UNID { get; set; }
            public string N05_CST_ICMS { get; set; }
            public string N06_CFOP { get; set; }
        }

        //REGISTRO C880: INFORMAÇÕES COMPLEMENTARES DAS OPERAÇÕES DE SAÍDA DE MERCADORIAS SUJEITAS À SUBSTITUIÇÃO TRIBUTÁRIA (CF-E-SAT) (CÓDIGO 59)
        public class Registro_C880
        {
            public Registro_C880()
            {
                N01_REG = "";
                N02_COD_MOT_REST_COMPL = "";
                N03_QUANT_CONV = "";
                N04_UNID = "";
                N05_VL_UNIT_CONV = "";
                N06_VL_UNIT_ICMS_NA_OPERACAO_CONV = "";
                N07_VL_UNIT_ICMS_OP_CONV = "";
                N08_VL_UNIT_BC_ICMS_ST_ESTOQUE_CONV = "";
                N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV = "";
                N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV = "";
                N11_VL_UNIT_ICMS_ST_CONV_REST = "";
                N12_VL_UNIT_FCP_ST_CONV_REST = "";
                N13_VL_UNIT_ICMS_ST_CONV_COMPL = "";
                N14_VL_UNIT_FCP_ST_CONV_COMPL = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOT_REST_COMPL { get; set; }
            public string N03_QUANT_CONV { get; set; }
            public string N04_UNID { get; set; }
            public string N05_VL_UNIT_CONV { get; set; }
            public string N06_VL_UNIT_ICMS_NA_OPERACAO_CONV { get; set; }
            public string N07_VL_UNIT_ICMS_OP_CONV { get; set; }
            public string N08_VL_UNIT_BC_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N09_VL_UNIT_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N10_VL_UNIT_FCP_ICMS_ST_ESTOQUE_CONV { get; set; }
            public string N11_VL_UNIT_ICMS_ST_CONV_REST { get; set; }
            public string N12_VL_UNIT_FCP_ST_CONV_REST { get; set; }
            public string N13_VL_UNIT_ICMS_ST_CONV_COMPL { get; set; }
            public string N14_VL_UNIT_FCP_ST_CONV_COMPL { get; set; }
        }

        //REGISTRO C890: RESUMO DIÁRIO DO CF-e-SAT (CÓDIGO 59) POR EQUIPAMENTO SAT-CF-e
        public class Registro_C890
        {
            public Registro_C890()
            {
                N01_REG = "";
                N02_CST_ICMS = "";
                N03_CFOP = "";
                N04_ALIQ_ICMS = "";
                N05_VL_OPR = "";
                N06_VL_BC_ICMS = "";
                N07_VL_ICMS = "";
                N08_COD_OBS = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_COD_OBS { get; set; }

        }

        //REGISTRO C990: ENCERRAMENTO DO BLOCO C
        public class Registro_C990
        {
            public Registro_C990()
            {
                N01_REG = "";
                N02_QTD_LIN_C = "";

            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_C { get; set; }
        }
    }
}

