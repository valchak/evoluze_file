using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBolocD
    {
        // REGISTRO D001: ABERTURA DO BLOCO D
        public class Registro_D001
        {
            public Registro_D001()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }

        /// <summary>
        /// REGISTRO D100: NOTA FISCAL DE SERVIÇO DE TRANSPORTE (CÓDIGO 07) E CONHECIMENTOS DETRANSPORTE RODOVIÁRIO DE CARGAS(CÓDIGO 08), CONHECIMENTOS DE TRANSPORTE DE CARGAS
        /// AVULSO(CÓDIGO 8B), AQUAVIÁRIO DE CARGAS(CÓDIGO 09), AÉREO(CÓDIGO 10), FERROVIÁRIO DE CARGAS(CÓDIGO 11), MULTIMODAL DE CARGAS(CÓDIGO 26), NOTA FISCAL DE TRANSPORTE
        /// FERROVIÁRIO DE CARGA(CÓDIGO 27), CONHECIMENTO DE TRANSPORTE ELETRÔNICO – CT-e(CÓDIGO57), CONHECIMENTO DE TRANSPORTE ELETRÔNICO PARA OUTROS SERVIÇOS - CT-e OS(CÓDIGO 67) e
        /// BILHETE DE PASSAGEM ELETRÔNICO(CÓDIGO 63)
        /// </summary>
        public class Registro_D100
        {
            public Registro_D100()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_OPER { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_COD_PART { get; set; }
            public string N05_COD_MOD { get; set; }
            public string N06_COD_SIT { get; set; }
            public string N07_SER { get; set; }
            public string N08_SUB { get; set; }
            public string N09_NUM_DOC { get; set; }
            public string N10_CHV_CTE { get; set; }
            public DateTime N11_DT_DOC { get; set; }
            public DateTime N12_DT_A_P { get; set; }
            public string N13_TP_CTe { get; set; }
            public string N14_CHV_CTE_REF { get; set; }
            public string N15_VL_DOC { get; set; }
            public string N16_VL_DESC { get; set; }
            public string N17_IND_FRT { get; set; }
            public string N18_VL_SERV { get; set; }
            public string N19_VL_BC_ICMS { get; set; }
            public string N20_VL_ICMS { get; set; }
            public string N21_VL_NT { get; set; }
            public string N22_COD_INF { get; set; }
            public string N23_COD_CTA { get; set; }
            public string N24_COD_MUN_ORIG { get; set; }
            public string N25_COD_MUN_DEST { get; set; }


        }

        //REGISTRO D101: INFORMAÇÃO COMPLEMENTAR DOS DOCUMENTOS FISCAIS QUANDO DAS PRESTAÇÕES INTERESTADUAIS DESTINADAS 
        //A CONSUMIDOR FINAL NÃO CONTRIBUINTE EC 87/ public string N15_(CÓDIGOS 57, 63 e 67)
        public class Registro_D101
        {
            public Registro_D101()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_FCP_UF_DEST { get; set; }
            public string N03_VL_ICMS_UF_DEST { get; set; }
            public string N04_VL_ICMS_UF_REM { get; set; }

        }

        //REGISTRO D110: ITENS do documento - NOTA FISCAL DE SERVIÇOS DE TRANSPORTE (CÓDIGO 07
        public class Registro_D110
        {
            public Registro_D110()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_ITEM { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_VL_SERV { get; set; }
            public string N05_VL_OUT { get; set; }
        }

        //REGISTRO D120: COMPLEMENTO DA NOTA FISCAL DE SERVIÇOS DE TRANSPORTE (CÓDIGO 07)
        public class Registro_D120
        {
            public Registro_D120()
            {
                N01_REG = "";

            }
            public string N01_REG { get; set; }
            public string N02_COD_MUN_ORIG { get; set; }
            public string N03_COD_MUN_DEST { get; set; }
            public string N04_VEIC_ID { get; set; }
            public string N05_UF_ID { get; set; }

        }

        //REGISTRO D130: COMPLEMENTO DO CONHECIMENTO RODOVIÁRIO DE CARGAS(CÓDIGO 08) E CONHECIMENTO DE TRANSPORTES DE CARGAS AVULSO(CÓDIGO 8B)
        public class Registro_D130
        {
            public Registro_D130()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART_CONSG { get; set; }
            public string N03_COD_PART_RED { get; set; }
            public string N04_IND_FRT_RED { get; set; }
            public string N05_COD_MUN_ORIG { get; set; }
            public string N06_COD_MUN_DEST { get; set; }
            public string N07_VEIC_ID { get; set; }
            public string N08_VL_LIQ_FRT { get; set; }
            public string N09_VL_SEC_CAT { get; set; }
            public string N10_VL_DESP { get; set; }
            public string N11_VL_PEDG { get; set; }
            public string N12_VL_OUT { get; set; }
            public string N13_VL_FRT { get; set; }
            public string N14_UF_ID { get; set; }

        }

        //REGISTRO D140: COMPLEMENTO DO CONHECIMENTO AQUAVIÁRIO DE CARGAS (CÓDIGO 09)
        public class Registro_D140
        {
            public Registro_D140()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART_CONSG { get; set; }
            public string N03_COD_MUN_ORIG { get; set; }
            public string N04_COD_MUN_DEST { get; set; }
            public string N05_IND_VEIC { get; set; }
            public string N06_VEIC_ID { get; set; }
            public string N07_IND_NAV { get; set; }
            public string N08_VIAGEM { get; set; }
            public string N09_VL_FRT_LIQ { get; set; }
            public string N10_VL_DESP_PORT { get; set; }
            public string N11_VL_DESP_CAR_DESC { get; set; }
            public string N12_VL_OUT { get; set; }
            public string N13_VL_FRT_BRT { get; set; }
            public string N14_VL_FRT_MM { get; set; }

        }

        //REGISTRO D150: COMPLEMENTO DO CONHECIMENTO AÉREO (CÓDIGO 10)
        public class Registro_D150
        {
            public Registro_D150()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MUN_ORIG { get; set; }
            public string N03_COD_MUN_DEST { get; set; }
            public string N04_VEIC_ID { get; set; }
            public string N05_VIAGEM { get; set; }
            public string N06_IND_TFA { get; set; }
            public string N07_VL_PESO_TX { get; set; }
            public string N08_VL_TX_TERR { get; set; }
            public string N09_VL_TX_RED { get; set; }
            public string N10_VL_OUT { get; set; }
            public string N11_VL_TX_ADV { get; set; }

        }

        //REGISTRO D160: CARGA TRANSPORTADA (CÓDIGO 08, 8B, 09, 10, 11, public string N26_E 27)
        public class Registro_D160
        {
            public Registro_D160()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DESPACHO { get; set; }
            public string N03_CNPJ_CPF_REM { get; set; }
            public string N04_IE_REM { get; set; }
            public string N05_COD_MUN_ORI { get; set; }
            public string N06_CNPJ_CPF_DEST { get; set; }
            public string N07_IE_DEST { get; set; }
            public string N08_COD_MUN_DEST { get; set; }

        }

        //REGISTRO D161: LOCAL DA COLETA E ENTREGA (CÓDIGO 08, 8B, 09, 10, 11, N26_E 27)
        public class Registro_D161
        {
            public Registro_D161()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_CARGA { get; set; }
            public string N03_CNPJ_CPF_COL { get; set; }
            public string N04_IE_COL { get; set; }
            public string N05_COD_MUN_COL { get; set; }
            public string N06_CNPJ_CPF_ENTG { get; set; }
            public string N07_IE_ENTG { get; set; }
            public string N08_COD_MUN_ENTG { get; set; }

        }

        //REGISTRO D162: IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS(CÓDIGOS 08, 8B, 09, 10, 11, public string N26_E 27)
        public class Registro_D162
        {
            public Registro_D162()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_SER { get; set; }
            public string N04_NUM_DOC { get; set; }
            public DateTime N05_DT_DOC { get; set; }
            public string N06_VL_DOC { get; set; }
            public string N07_VL_MERC { get; set; }
            public string N08_QTD_VOL { get; set; }
            public string N09_PESO_BRT { get; set; }
            public string N10_PESO_LIQ { get; set; }

        }

        //REGISTRO D170: COMPLEMENTO DO CONHECIMENTO MULTIMODAL DE CARGAS (CÓDIGO 26)
        public class Registro_D170
        {
            public Registro_D170()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART_CONSG { get; set; }
            public string N03_COD_PART_RED { get; set; }
            public string N04_COD_MUN_ORIG { get; set; }
            public string N05_COD_MUN_DEST { get; set; }
            public string N06_OTM { get; set; }
            public string N07_IND_NAT_FRT { get; set; }
            public string N08_VL_LIQ_FRT { get; set; }
            public string N09_VL_GRIS { get; set; }
            public string N10_VL_PDG { get; set; }
            public string N11_VL_OUT { get; set; }
            public string N12_VL_FRT { get; set; }
            public string N13_VEIC_ID { get; set; }
            public string N14_UF_ID { get; set; }

        }

        //REGISTRO D180: MODAIS (CÓDIGO 26)
        public class Registro_D180
        {
            public Registro_D180()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_SEQ { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_CNPJ_CPF_EMIT { get; set; }
            public string N05_UF_EMIT { get; set; }
            public string N06_IE_EMIT { get; set; }
            public string N07_COD_MUN_ORIG { get; set; }
            public string N08_CNPJ_CPF_TOM { get; set; }
            public string N09_UF_TOM { get; set; }
            public string N10_IE_TOM { get; set; }
            public string N11_COD_MUN_DEST { get; set; }
            public string N12_COD_MOD { get; set; }
            public string N13_SER { get; set; }
            public string N14_SUB { get; set; }
            public string N15_NUM_DOC { get; set; }
            public DateTime N16_DT_DOC { get; set; }
            public string N17_VL_DOC { get; set; }
        }

        //REGISTRO D190: REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGO 07, 08, 8B, 09, 10, 11, 26, 27, 57 e 67);
        public class Registro_D190
        {
            public Registro_D190()
            {
                N01_REG = "";
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


        //REGISTRO D195: OBSERVAÇÕES DO LANÇAMENTO FISCAL (CÓDIGO 07, 08, 8B, 09, 10, 11, 26, 27, 57, 63 E67)
        public class Registro_D195
        {
            public Registro_D195()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OBS { get; set; }
            public string N03_TXT_COMPL { get; set; }
        }

        //REGISTRO D197: OUTRAS OBRIGAÇÕES TRIBUTÁRIAS, AJUSTES E INFORMAÇÕES DE VALORES PROVENIENTES DE DOCUMENTO FISCAL
        public class Registro_D197
        {
            public Registro_D197()
            {
                N01_REG = "";
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

        //REGISTRO D300: REGISTRO ANALÍTICO DOS BILHETES CONSOLIDADOS DE PASSAGEM RODOVIÁRIO (CÓDIGO 13), DE PASSAGEM AQUAVIÁRIO (CÓDIGO 14), DE PASSAGEM E NOTA DE BAGAGEM (CÓDIGO 15) E DE PASSAGEM FERROVIÁRIO (CÓDIGO 16) 
        public class Registro_D300
        {
            public Registro_D300()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_SER { get; set; }
            public string N04_SUB { get; set; }
            public string N05_NUM_DOC_INI { get; set; }
            public string N06_NUM_DOC_FIN { get; set; }
            public string N07_CST_ICMS { get; set; }
            public string N08_CFOP { get; set; }
            public string N09_ALIQ_ICMS { get; set; }
            public DateTime N10_DT_DOC { get; set; }
            public string N11_VL_OPR { get; set; }
            public string N12_VL_DESC { get; set; }
            public string N13_VL_SERV { get; set; }
            public string N14_VL_SEG { get; set; }
            public string N15_VL_OUT_DESP { get; set; }
            public string N16_VL_BC_ICMS { get; set; }
            public string N17_VL_ICMS { get; set; }
            public string N18_VL_RED_BC { get; set; }
            public string N19_COD_OBS { get; set; }
            public string N20_COD_CTA { get; set; }
        }

        //REGISTRO D301: DOCUMENTOS CANCELADOS DOS BILHETES DE PASSAGEM RODOVIÁRIO(CÓDIGO 13), DE PASSAGEM AQUAVIÁRIO(CÓDIGO 14), DE PASSAGEM E NOTA DE BAGAGEM(CÓDIGO 15) E DE PASSAGEM FERROVIÁRIO(CÓDIGO 16)
        public class Registro_D301
        {
            public Registro_D301()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DOC_CANC { get; set; }
        }

        //REGISTRO D310: COMPLEMENTO DOS BILHETES (CÓDIGO 13, 14, public string N15_E 16)
        public class Registro_D310
        {
            public Registro_D310()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MUN_ORIG { get; set; }
            public string N03_VL_SERV { get; set; }
            public string N04_VL_BC_ICMS { get; set; }
            public string N05_VL_ICMS { get; set; }

        }

        //REGISTRO D350: EQUIPAMENTO ECF(CÓDIGOS 2E, 13, 14, public string N15_e 16)
        public class Registro_D350
        {
            public Registro_D350()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_ECF_MOD { get; set; }
            public string N04_ECF_FAB { get; set; }
            public string N05_ECF_CX { get; set; }

        }

        //REGISTRO D355: REDUÇÃO Z (CÓDIGOS 2E, 13, 14, public string N15_e 16)
        public class Registro_D355
        {
            public Registro_D355()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_DOC { get; set; }
            public string N03_CRO { get; set; }
            public string N04_CRZ { get; set; }
            public string N05_NUM_COO_FIN { get; set; }
            public string N06_GT_FIN { get; set; }
            public string N07_VL_BRT { get; set; }

        }

        //REGISTRO D360: PIS E COFINS TOTALIZADOS NO DIA (CÓDIGOS 2E, 13, 14, public string N15_e 16)
        public class Registro_D360
        {
            public Registro_D360()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_VL_PIS { get; set; }
            public string N03_VL_COFINS { get; set; }

        }

        //REGISTRO D365: REGISTRO DOS TOTALIZADORES PARCIAIS DA REDUÇÃO Z (CÓDIGOS 2E, 13, 14, public string N15_e16)
        public class Registro_D365
        {
            public Registro_D365()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_TOT_PAR { get; set; }
            public string N03_VLR_ACUM_TOT { get; set; }
            public string N04_NR_TOT { get; set; }
            public string N05_DESCR_NR_TOT { get; set; }

        }

        //REGISTRO D370: COMPLEMENTO DOS DOCUMENTOS INFORMADOS (CÓDIGO 13, 14, 15, public string N16_E 2E)
        public class Registro_D370
        {
            public Registro_D370()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MUN_ORIG { get; set; }
            public string N03_VL_SERV { get; set; }
            public string N04_QTD_BILH { get; set; }
            public string N05_VL_BC_ICMS { get; set; }
            public string N06_VL_ICMS { get; set; }

        }

        // REGISTRO D390: REGISTRO ANALÍTICO DO MOVIMENTO DIÁRIO(CÓDIGOS 13, 14, 15, public string N16_E 2E)
        public class Registro_D390
        {
            public Registro_D390()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ISSQN { get; set; }
            public string N07_ALIQ_ISSQN { get; set; }
            public string N08_VL_ISSQN { get; set; }
            public string N09_VL_BC_ICMS { get; set; }
            public string N10_VL_ICMS { get; set; }
            public string N11_COD_OBS { get; set; }


        }

        // REGISTRO D400: RESUMO DE MOVIMENTO DIÁRIO (CÓDIGO 18)
        public class Registro_D400
        {
            public Registro_D400()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_PART { get; set; }
            public string N03_COD_MOD { get; set; }
            public string N04_COD_SIT { get; set; }
            public string N05_SER { get; set; }
            public string N06_SUB { get; set; }
            public string N07_NUM_DOC { get; set; }
            public DateTime N08_DT_DOC { get; set; }
            public string N09_VL_DOC { get; set; }
            public string N10_VL_DESC { get; set; }
            public string N11_VL_SERV { get; set; }
            public string N12_VL_BC_ICMS { get; set; }
            public string N13_VL_ICMS { get; set; }
            public string N14_VL_PIS { get; set; }
            public string N15_VL_COFINS { get; set; }
            public string N16_COD_CTA { get; set; }

        }

        // REGISTRO D410: DOCUMENTOS INFORMADOS (CÓDIGOS 13, 14, public string N15_E 16)
        public class Registro_D410
        {
            public Registro_D410()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_SER { get; set; }
            public string N04_SUB { get; set; }
            public string N05_NUM_DOC_INI { get; set; }
            public string N06_NUM_DOC_FIN { get; set; }
            public DateTime N07_DT_DOC { get; set; }
            public string N08_CST_ICMS { get; set; }
            public string N09_CFOP { get; set; }
            public string N10_ALIQ_ICMS { get; set; }
            public string N11_VL_OPR { get; set; }
            public string N12_VL_DESC { get; set; }
            public string N13_VL_SERV { get; set; }
            public string N14_VL_BC_ICMS { get; set; }
            public string N15_VL_ICMS { get; set; }

        }

        // REGISTRO D411: DOCUMENTOS CANCELADOS DOS DOCUMENTOS INFORMADOS (CÓDIGOS 13, 14, public string N15_E 16)
        public class Registro_D411
        {
            public Registro_D411()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_NUM_DOC_CANC { get; set; }

        }

        //REGISTRO D420: COMPLEMENTO DOS DOCUMENTOS INFORMADOS(CÓDIGOS 13, 14, public string N15_E 16)
        public class Registro_D420
        {
            public Registro_D420()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MUN_ORIG { get; set; }
            public string N03_VL_SERV { get; set; }
            public string N04_VL_BC_ICMS { get; set; }
            public string N05_VL_ICMS { get; set; }

        }

        //REGISTRO D500: NOTA FISCAL DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E NOTA FISCAL DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22)
        public class Registro_D500
        {
            public Registro_D500()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_OPER { get; set; }
            public string N03_IND_EMIT { get; set; }
            public string N04_COD_PART { get; set; }
            public string N05_COD_MOD { get; set; }
            public string N06_COD_SIT { get; set; }
            public string N07_SER { get; set; }
            public string N08_SUB { get; set; }
            public string N09_NUM_DOC { get; set; }
            public DateTime N10_DT_DOC { get; set; }
            public DateTime N11_DT_A_P { get; set; }
            public string N12_VL_DOC { get; set; }
            public string N13_VL_DESC { get; set; }
            public string N14_VL_SERV { get; set; }
            public string N15_VL_SERV_NT { get; set; }
            public string N16_VL_TERC { get; set; }
            public string N17_VL_DA { get; set; }
            public string N18_VL_BC_ICMS { get; set; }
            public string N19_VL_ICMS { get; set; }
            public string N20_COD_INF { get; set; }
            public string N21_VL_PIS { get; set; }
            public string N22_VL_COFINS { get; set; }
            public string N23_COD_CTA { get; set; }
            public string N24_TP_ASSINANTE { get; set; }
        }

        //REGISTRO D510: ITENS DO DOCUMENTO - NOTA FISCAL DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22)
        public class Registro_D510
        {
            public Registro_D510()
            {
                N01_REG = "";
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
            public string N14_VL_BC_ICMS_UF { get; set; }
            public string N15_VL_ICMS_UF { get; set; }
            public string N16_IND_REC { get; set; }
            public string N17_COD_PART { get; set; }
            public string N18_VL_PIS { get; set; }
            public string N19_VL_COFINS { get; set; }
            public string N20_COD_CTA { get; set; }
        }

        // REGISTRO D530: TERMINAL FATURADO
        public class Registro_D530
        {
            public Registro_D530()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_SERV { get; set; }
            public DateTime N03_DT_INI_SERV { get; set; }
            public DateTime N04_DT_FIN_SERV { get; set; }
            public string N05_PER_FISCAL { get; set; }
            public string N06_COD_AREA { get; set; }
            public string N07_TERMINAL { get; set; }
        }

        // REGISTRO D590: REGISTRO ANALÍTICO DO DOCUMENTO (CÓDIGO public string N21_E 22)
        public class Registro_D590
        {
            public Registro_D590()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_UF { get; set; }
            public string N09_VL_ICMS_UF { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        // REGISTRO D600: CONSOLIDAÇÃO DA PRESTAÇÃO DE SERVIÇOS - NOTAS DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22)
        public class Registro_D600
        {
            public Registro_D600()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_MOD { get; set; }
            public string N03_COD_MUN { get; set; }
            public string N04_SER { get; set; }
            public string N05_SUB { get; set; }
            public string N06_COD_CONS { get; set; }
            public string N07_QTD_CONS { get; set; }
            public DateTime N08_DT_DOC { get; set; }
            public string N09_VL_DOC { get; set; }
            public string N10_VL_DESC { get; set; }
            public string N11_VL_SERV { get; set; }
            public string N12_VL_SERV_NT { get; set; }
            public string N13_VL_TERC { get; set; }
            public string N14_VL_DA { get; set; }
            public string N15_VL_BC_ICMS { get; set; }
            public string N16_VL_ICMS { get; set; }
            public string N17_VL_PIS { get; set; }
            public string N18_VL_COFINS { get; set; }

        }

        // REGISTRO D610: ITENS DO DOCUMENTO CONSOLIDADO (CÓDIGO public string N21_E 22)
        public class Registro_D610
        {
            public Registro_D610()
            {
                N01_REG = "";
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
            public string N13_VL_BC_ICMS_UF { get; set; }
            public string N14_VL_ICMS_UF { get; set; }
            public string N15_VL_RED_BC { get; set; }
            public string N16_VL_PIS { get; set; }
            public string N17_VL_COFINS { get; set; }
            public string N18_COD_CTA { get; set; }
        }

        //REGISTRO D690: REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGOS public string N21_e 22)
        public class Registro_D690
        {
            public Registro_D690()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_UF { get; set; }
            public string N09_VL_ICMS_UF { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        // REGISTRO D695: CONSOLIDAÇÃO DA PRESTAÇÃO DE SERVIÇOS - NOTAS DE SERVIÇO DE COMUNICAÇÃO (CÓDIGO 21) E DE SERVIÇO DE TELECOMUNICAÇÃO (CÓDIGO 22) EMPRESAS OBRIGADAS À ENTREGA DOS ARQUIVOS PREVISTOS NO CONVÊNIO ICMS Nº 115/03
        public class Registro_D695
        {
            public Registro_D695()
            {
                N01_REG = "";
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

        //REGISTRO D696: REGISTRO ANALÍTICO DOS DOCUMENTOS (CÓDIGO public string N21_E 22)
        public class Registro_D696
        {
            public Registro_D696()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_CST_ICMS { get; set; }
            public string N03_CFOP { get; set; }
            public string N04_ALIQ_ICMS { get; set; }
            public string N05_VL_OPR { get; set; }
            public string N06_VL_BC_ICMS { get; set; }
            public string N07_VL_ICMS { get; set; }
            public string N08_VL_BC_ICMS_UF { get; set; }
            public string N09_VL_ICMS_UF { get; set; }
            public string N10_VL_RED_BC { get; set; }
            public string N11_COD_OBS { get; set; }
        }

        // REGISTRO D697: REGISTRO DE INFORMAÇÕES DE OUTRAS UFs, RELATIVAMENTE AOS SERVIÇOS “NÃO-MEDIDOS” DE TELEVISÃO POR ASSINATURA VIA SATÉLITE
        public class Registro_D697
        {
            public Registro_D697()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_UF { get; set; }
            public string N03_VL_BC_ICMS { get; set; }
            public string N04_VL_ICMS { get; set; }

        }

        //REGISTRO D990: ENCERRAMENTO DO BLOCO D
        public class Registro_D990
        {
            public Registro_D990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_D { get; set; }
        }
    }
}
