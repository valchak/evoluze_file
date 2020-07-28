using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBloco1
    {
        /// <summary>
        /// ABERTURA DO BLOCO 1 Outras Informacoes
        /// </summary>
        public class Registro_1001
        {
            private string F_REG = "";

            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }
            private string F_IND_MOV = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            public string N02_IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value; }
            }

            public string GetRegistro_1001(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (F_IND_MOV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV */
                    if (F_IND_MOV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(F_IND_MOV.Equals("0")))
                    {
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|", F_REG, F_IND_MOV);
            }
        }

        /// <summary>
        /// DADOS COMPLEMENTARES DA ENTIDADE
        /// </summary>
        public class Registro_1010
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_IND_DOC = "";
            public string N02_IND_DOC
            {
                get { return F_IND_DOC; }
                set { F_IND_DOC = value; }
            }

            private string F_NRO_DE = "";
            public string N03_NRO_DE
            {
                get { return F_NRO_DE; }
                set { F_NRO_DE = value; }
            }

            private string F_DT_DE = "";
            public string N04_DT_DE
            {
                get { return F_DT_DE; }
                set { F_DT_DE = value; }
            }

            private string F_NAT_EXP = "";
            public string N05_NAT_EXP
            {
                get { return F_NAT_EXP; }
                set { F_NAT_EXP = value; }
            }

            private string F_NRO_RE = "";
            public string N06_NRO_RE
            {
                get { return F_NRO_RE; }
                set { F_NRO_RE = value; }
            }

            private string F_DT_RE = "";
            public string N07_DT_RE
            {
                get { return F_DT_RE; }
                set { F_DT_RE = value; }
            }

            private string F_CHC_EMB = "";
            public string N08_CHC_EMB
            {
                get { return F_CHC_EMB; }
                set { F_CHC_EMB = value; }
            }

            private string F_DT_CHC = "";
            public string N09_DT_CHC
            {
                get { return F_DT_CHC; }
                set { F_DT_CHC = value; }
            }

            private string F_DT_AVB = "";
            public string N10_DT_AVB
            {
                get { return F_DT_AVB; }
                set { F_DT_AVB = value; }
            }

            private string F_TP_CHC = "";
            public string N11_TP_CHC
            {
                get { return F_TP_CHC; }
                set { F_TP_CHC = value; }
            }

            private string F_PAIS = "";
            public string N12_PAIS
            {
                get { return F_PAIS; }
                set { F_PAIS = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, F_IND_DOC, F_NRO_DE, F_DT_DE, F_NAT_EXP, F_NRO_RE, F_DT_RE, F_CHC_EMB, F_DT_CHC, F_DT_AVB, F_TP_CHC, F_PAIS);
            }
        }


        /// <summary>
        /// REGISTRO DE INFORMAÇÕES SOBRE EXPORTAÇÃO
        /// </summary>
        public class Registro_1100
        {
            private string F_REG = "";
            /// <summary>
            /// Texto fixo contendo “1010”
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_IND_EXP = "";
            /// <summary>
            /// Reg. 1100 - Ocorreu averbação (conclusão) de exportação no período:
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N02_IND_EXP
            {
                get { return F_IND_EXP; }
                set { F_IND_EXP = value; }
            }

            private string F_IND_CCRF = "";
            /// <summary>
            /// Reg 1200 - Existem informações acerca de créditos de ICMS a serem controlados, definidos pela Sefaz: 
            /// S - Sim 
            /// N - Não
            /// </summary>
            public string N03_IND_CCRF
            {
                get { return F_IND_CCRF; }
                set { F_IND_CCRF = value; }
            }

            private string F_IND_COMB = "";
            /// <summary>
            /// Reg. 1300 - É comércio varejista de combustíveis com movimentação e/ou estoque no período: 
            /// S - Sim 
            /// N - Não
            /// </summary>
            public string N04_IND_COMB
            {
                get { return F_IND_COMB; }
                set { F_IND_COMB = value; }
            }

            private string F_IND_USINA = "";
            /// <summary>
            /// Reg. 1390 - Usinas de açúcar e/álcool - O estabelecimento é produtor de açúcar e/ou álcool carburante com movimentação e/ou estoque no período:
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N05_IND_USINA
            {
                get { return F_IND_USINA; }
                set { F_IND_USINA = value; }
            }

            private string F_IND_VA = "";
            /// <summary>
            /// Reg 1400 - Sendo o registro obrigatório em sua Unidade de Federação, existem informações a serem prestadas neste registro:
            /// S - Sim 
            /// N - Não
            /// </summary>
            public string N06_IND_VA
            {
                get { return F_IND_VA; }
                set { F_IND_VA = value; }
            }

            private string F_IND_EE = "";
            /// <summary>
            /// Reg 1500 - A empresa é distribuidora de energia e ocorreu fornecimento de energia elétrica para consumidores de outra UF:
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N07_IND_EE
            {
                get { return F_IND_EE; }
                set { F_IND_EE = value; }
            }

            private string F_IND_CART = "";
            /// <summary>
            /// Reg 1600 - Realizou vendas com Cartão de Crédito ou de débito:
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N08_IND_CART
            {
                get { return F_IND_CART; }
                set { F_IND_CART = value; }
            }

            private string F_IND_FORM = "";
            /// <summary>
            /// Reg. 1700 - Foram emitidos documentos fiscais em papel no período em unidade da federação que exija o controle de utilização de documentos fiscais: 
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N09_IND_FORM
            {
                get { return F_IND_FORM; }
                set { F_IND_FORM = value; }
            }

            private string F_IND_AER = "";
            /// <summary>
            /// Reg 1800 – A empresa prestou serviços de transporte aéreo de cargas e de passageiros: 
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N10_IND_AER
            {
                get { return F_IND_AER; }
                set { F_IND_AER = value; }
            }



            private string F_IND_GIAF1 = "";
            /// <summary>
            /// Reg. 1960 - Possui informações GIAF1?
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N11_IND_GIAF1
            {
                get { return F_IND_GIAF1; }
                set { F_IND_GIAF1 = value; }
            }

            private string F_IND_GIAF3 = "";
            /// <summary>
            /// Reg. 1970 - Possui informações GIAF3?
            /// S - Sim
            /// N - Não
            /// </summary>
            /// 
            public string N12_IND_GIAF3
            {
                get { return F_IND_GIAF3; }
                set { F_IND_GIAF3 = value; }
            }

            private string F_IND_GIAF4 = "";
            /// <summary>
            /// Reg. 1980 - Possui informações GIAF4?
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N13_IND_GIAF4
            {
                get { return F_IND_GIAF4; }
                set { F_IND_GIAF4 = value; }
            }

            private string F_IND_REST_RESSARC_COMPL_ICMS
 = "";
            /// <summary>
            /// Reg. 1980 - Possui informações GIAF4?
            /// S - Sim
            /// N - Não
            /// </summary>
            public string N14_IND_REST_RESSARC_COMPL_ICMS
            {
                get { return F_IND_REST_RESSARC_COMPL_ICMS; }
                set { F_IND_REST_RESSARC_COMPL_ICMS = value; }
            }


            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    if (F_IND_EXP.Trim().Trim().Equals("S") || F_IND_EXP.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_EXP incorreto(a)";
                    }
                    if (F_IND_CCRF.Trim().Trim().Equals("S") || F_IND_CCRF.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_CCRF incorreto(a)";
                    }

                    if (F_IND_COMB.Trim().Trim().Equals("S") || F_IND_COMB.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_COMB incorreto(a)";
                    }
                    if (F_IND_USINA.Trim().Trim().Equals("S") || F_IND_USINA.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_USINA incorreto(a)";
                    }
                    if (F_IND_VA.Trim().Trim().Equals("S") || F_IND_VA.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_VA incorreto(a)";
                    }
                    if (F_IND_EE.Trim().Trim().Equals("S") || F_IND_EE.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_EE incorreto(a)";
                    }
                    if (F_IND_CART.Trim().Trim().Equals("S") || F_IND_CART.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_CART incorreto(a)";
                    }
                    if (F_IND_FORM.Trim().Trim().Equals("S") || F_IND_FORM.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_FORM incorreto(a)";
                    }
                    if (F_IND_AER.Trim().Trim().Equals("S") || F_IND_AER.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_AER incorreto(a)";
                    }
                    if (F_IND_GIAF1.Trim().Trim().Equals("S") || F_IND_GIAF1.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_GIAF1 incorreto(a)";
                    }
                    if (F_IND_GIAF3.Trim().Trim().Equals("S") || F_IND_GIAF3.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_GIAF3 incorreto(a)";
                    }
                    if (F_IND_GIAF4.Trim().Trim().Equals("S") || F_IND_GIAF4.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_GIAF4 incorreto(a)";
                    }
                    if (F_IND_REST_RESSARC_COMPL_ICMS.Trim().Trim().Equals("S") || F_IND_REST_RESSARC_COMPL_ICMS.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_REST_RESSARC_COMPL_ICMS incorreto(a)";
                    }


                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_IND_EXP, F_IND_CCRF, F_IND_COMB, F_IND_USINA, F_IND_VA, F_IND_EE, F_IND_CART, F_IND_FORM, F_IND_AER, F_IND_GIAF1, F_IND_GIAF3, F_IND_GIAF4, F_IND_REST_RESSARC_COMPL_ICMS);
            }
        }


        /// <summary>
        ///  DOCUMENTOS FISCAIS DE EXPORTAÇÃO
        /// </summary>
        public class Registro_1105
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_MOD = "";
            public string N02_COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            private string F_SERIE = "";
        
            public string N03_SERIE
            {
                get { return F_SERIE; }
                set { F_SERIE = value; }
            }

            private string F_NUM_DOC = "";
            public string N04_NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value; }
            }

            private string F_CHV_NFE = "";
            public string N05_CHV_NFE
            {
                get { return F_CHV_NFE; }
                set { F_CHV_NFE = value; }
            }

            private DateTime F_DT_DOC;
            public DateTime N06_DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value; }
            }

            private string F_COD_ITEM = "";
            public string N07_COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value; }
            }

         
            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    if (F_COD_MOD.Trim().Trim().Equals("S") || F_COD_MOD.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_EXP incorreto(a)";
                    }
                    if (F_SERIE.Trim().Trim().Equals("S") || F_SERIE.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_CCRF incorreto(a)";
                    }

                    if (F_NUM_DOC.Trim().Trim().Equals("S") || F_NUM_DOC.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_COMB incorreto(a)";
                    }
                    if (F_CHV_NFE.Trim().Trim().Equals("S") || F_CHV_NFE.Trim().Trim().Equals("N"))
                    {
                        return "Erro -> Campo IND_USINA incorreto(a)";
                    }
                   
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_MOD, F_SERIE, F_NUM_DOC, F_CHV_NFE, F_DT_DOC.ToString("ddMMyyyy"), F_COD_ITEM);
            }
        }



        /// <summary>
        ///  OPERAÇÕES DE EXPORTAÇÃO INDIRETA - MERCADORIAS DE TERCEIROS
        /// </summary>
        public class Registro_1110
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_PART = "";
            public string N02_COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value; }
            }

            private string F_COD_MOD = "";
            public string N03_COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            private string F_SER = "";
            public string N04_SER
            {
                get { return F_SER; }
                set { F_SER = value; }
            }

            private string F_NUM_DOC = "";
            public string N05_NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value; }
            }

            private string F_DT_DOC = "";
            public string N06_DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value; }
            }

            private string F_CHV_NFE = "";
            public string N07_CHV_NFE
            {
                get { return F_CHV_NFE; }
                set { F_CHV_NFE = value; }
            }

            private string F_NR_MEMO = "";
            /// <summary>
            /// Estoque escritural (06 - 07), litros
            /// </summary>
            public string N08_NR_MEMO 
            {
                get { return F_NR_MEMO; }
                set { F_NR_MEMO = value; }
            }

            private double F_QTD;
            [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###,##0.000}")]
            public double N09_QTD
            {
                get { return F_QTD; }
                set { F_QTD = value; }
            }

            private string F_UNID;
            public string N10_UNID
            {
                get { return F_UNID; }
                set { F_UNID = value; }
            }


            public string GetRegistro()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_COD_PART, F_COD_MOD, F_SER, F_NUM_DOC, F_DT_DOC, F_CHV_NFE, F_NR_MEMO, F_QTD, F_UNID);
            }
        }

        /// <summary>
        ///   CONTROLE DE CRÉDITOS FISCAIS – ICMS
        /// </summary>
        public class Registro_1200
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_AJ_APUR = "";
            public string N02_COD_AJ_APUR
            {
                get { return F_COD_AJ_APUR; }
                set { F_COD_AJ_APUR = value; }
            }

            private string F_SLD_CRED = "";
            public string N03_SLD_CRED
            {
                get { return F_SLD_CRED; }
                set { F_SLD_CRED = value; }
            }

            private string F_CRED_APR = "";
            public string N04_CRED_APR
            {
                get { return F_CRED_APR; }
                set { F_CRED_APR = value; }
            }

            private string F_CRED_RECEB = "";
            public string N05_CRED_RECEB
            {
                get { return F_CRED_RECEB; }
                set { F_CRED_RECEB = value; }
            }

            private string F_CRED_UTIL = "";
            public string N06_CRED_UTIL
            {
                get { return F_CRED_UTIL; }
                set { F_CRED_UTIL = value; }
            }

            private string F_SLD_CRED_FIM = "";
            public string N07_SLD_CRED_FIM
            {
                get { return F_SLD_CRED_FIM; }
                set { F_SLD_CRED_FIM = value; }
            }
            public string GetRegistro()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_AJ_APUR, F_SLD_CRED, F_CRED_APR, F_CRED_RECEB, F_CRED_UTIL, F_SLD_CRED_FIM);
            }
        }

        /// <summary>
        ///   UTILIZAÇÃO DE CRÉDITOS FISCAIS – ICMS
        /// </summary>
        public class Registro_1210
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_TIPO_UTIL = "";
            public string N02_TIPO_UTIL
            {
                get { return F_TIPO_UTIL; }
                set { F_TIPO_UTIL = value; }
            }

            private string F_NR_DOC = "";
            public string N03_NR_DOC
            {
                get { return F_NR_DOC; }
                set { F_NR_DOC = value; }
            }

            private string F_VL_CRED_UTIL = "";
            public string N04_VL_CRED_UTIL
            {
                get { return F_VL_CRED_UTIL; }
                set { F_VL_CRED_UTIL = value; }
            }

            private string F_CHV_DOCe = "";
            public string N05_CHV_DOCe
            {
                get { return F_CHV_DOCe; }
                set { F_CHV_DOCe = value; }
            }
            public string GetRegistro()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_TIPO_UTIL, F_NR_DOC, F_VL_CRED_UTIL, F_CHV_DOCe);
            }
        }


        /// <summary>
        ///    INFORMAÇÕES CONSOLIDADAS DE SALDOS DE RESTITUIÇÃO, RESSARCIMENTO E COMPLEMENTAÇÃO DO ICMS
        /// </summary>
        public class Registro_1250
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_VL_CREDITO_ICMS_OP = "";
            public string N02_VL_CREDITO_ICMS_OP
            {
                get { return F_VL_CREDITO_ICMS_OP; }
                set { F_VL_CREDITO_ICMS_OP = value; }
            }

            private string F_VL_ICMS_ST_REST = "";
            public string N03_VL_ICMS_ST_REST
            {
                get { return F_VL_ICMS_ST_REST; }
                set { F_VL_ICMS_ST_REST = value; }
            }

            private string F_VL_FCP_ST_REST = "";
            public string N04_VL_FCP_ST_REST
            {
                get { return F_VL_FCP_ST_REST; }
                set { F_VL_FCP_ST_REST = value; }
            }

            private string F_VL_ICMS_ST_COMPL = "";
            public string N05_VL_ICMS_ST_COMPL
            {
                get { return F_VL_ICMS_ST_COMPL; }
                set { F_VL_ICMS_ST_COMPL = value; }
            }

            private string F_VL_FCP_ST_COMPL = "";
            public string N06_VL_FCP_ST_COMPL
            {
                get { return F_VL_FCP_ST_COMPL; }
                set { F_VL_FCP_ST_COMPL = value; }
            }

            public string GetRegistro()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, F_VL_CREDITO_ICMS_OP, F_VL_ICMS_ST_REST, F_VL_FCP_ST_REST, F_VL_ICMS_ST_COMPL, F_VL_FCP_ST_COMPL);
            }
        }

        /// <summary>
        ///     INFORMAÇÕES CONSOLIDADAS DE SALDOS DE RESTITUIÇÃO, RESSARCIMENTO E COMPLEMENTAÇÃO DO ICMS POR MOTIVO
        /// </summary>
        public class Registro_1255
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_MOT_REST_COMPL = "";
            public string N02_COD_MOT_REST_COMPL
            {
                get { return F_COD_MOT_REST_COMPL; }
                set { F_COD_MOT_REST_COMPL = value; }
            }

            private string F_VL_CREDITO_ICMS_OP_MOT = "";
            public string N03_VL_CREDITO_ICMS_OP_MOT
            {
                get { return F_VL_CREDITO_ICMS_OP_MOT; }
                set { F_VL_CREDITO_ICMS_OP_MOT = value; }
            }

            private string F_VL_ICMS_ST_REST_MOT = "";
            public string N04_VL_ICMS_ST_REST_MOT
            {
                get { return F_VL_ICMS_ST_REST_MOT; }
                set { F_VL_ICMS_ST_REST_MOT = value; }
            }

            private string F_VL_FCP_ST_REST_MOT = "";
            public string N05_VL_FCP_ST_REST_MOT
            {
                get { return F_VL_FCP_ST_REST_MOT; }
                set { F_VL_FCP_ST_REST_MOT = value; }
            }

            private string F_VL_ICMS_ST_COMPL_MOT = "";
            public string N06_VL_ICMS_ST_COMPL_MOT
            {
                get { return F_VL_ICMS_ST_COMPL_MOT; }
                set { F_VL_ICMS_ST_COMPL_MOT = value; }
            }

            private string F_VL_FCP_ST_COMPL_MOT = "";
            public string N07_VL_FCP_ST_COMPL_MOT
            {
                get { return F_VL_FCP_ST_COMPL_MOT; }
                set { F_VL_FCP_ST_COMPL_MOT = value; }
            }
            public string GetRegistro()
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_MOT_REST_COMPL, F_VL_CREDITO_ICMS_OP_MOT, F_VL_ICMS_ST_REST_MOT, F_VL_FCP_ST_REST_MOT, F_VL_ICMS_ST_COMPL_MOT, F_VL_FCP_ST_COMPL_MOT);
            }
        }



        /// <summary>
        ///  MOVIMENTAÇÃO DIÁRIA DE COMBUSTÍVEIS
        /// </summary>
        public class Registro_1300
        {
            private string F_REG = "1300";
            /// <summary>
            /// Texto fixo contendo "1300"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do produto, constante do registro 0200
            /// </summary>
            public string N02_COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value; }
            }

            private string F_DT_FECH = "";
            /// <summary>
            /// Data do fechamento da movimentação
            /// </summary>
            public string N03_DT_FECH
            {
                get { return F_DT_FECH; }
                set { F_DT_FECH = value; }
            }

            private string F_ESTQ_ABERT = "";
            /// <summary>
            /// Estoque no inicio do dia, em litros
            /// </summary>
            public string N04_ESTQ_ABERT
            {
                get { return F_ESTQ_ABERT; }
                set { F_ESTQ_ABERT = value; }
            }

            private string F_VOL_ENTR = "";
            /// <summary>
            /// Volume recebido no dia (em litros) 
            /// </summary>
            public string N05_VOL_ENTR
            {
                get { return F_VOL_ENTR; }
                set { F_VOL_ENTR = value; }
            }

            private string F_VOL_DISP = "";
            /// <summary>
            /// Volume disponível (04 + 05), em litros
            /// </summary>
            public string N06_VOL_DISP
            {
                get { return F_VOL_DISP; }
                set { F_VOL_DISP = value; }
            }

            private string F_VOL_SAIDAS = "";
            /// <summary>
            /// Volume total das saídas, em litros
            /// </summary>
            public string N07_VOL_SAIDAS
            {
                get { return F_VOL_SAIDAS; }
                set { F_VOL_SAIDAS = value; }
            }

            private string F_ESTQ_ESCR = "";
            /// <summary>
            /// Estoque escritural (06 - 07), litros
            /// </summary>
            public string N08_ESTQ_ESCR
            {
                get { return F_ESTQ_ESCR; }
                set { F_ESTQ_ESCR = value; }
            }

            private string F_VAL_AJ_PERDA = "";
            /// <summary>
            /// Valor da perda, em litros 
            /// </summary>
            public string N09_VAL_AJ_PERDA
            {
                get { return F_VAL_AJ_PERDA; }
                set { F_VAL_AJ_PERDA = value; }
            }

            private string F_VAL_AJ_GANHO = "";
            /// <summary>
            /// Valor do ganho, em litros
            /// </summary>
            public string N10_VAL_AJ_GANHO
            {
                get { return F_VAL_AJ_GANHO; }
                set { F_VAL_AJ_GANHO = value; }
            }



            private string F_FECH_FISICO = "";
            /// <summary>
            /// Estoque de fechamento, em litros 
            /// </summary>
            public string N11_FECH_FISICO
            {
                get { return F_FECH_FISICO; }
                set { F_FECH_FISICO = value; }
            }


            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_COD_ITEM, F_DT_FECH, F_ESTQ_ABERT, F_VOL_ENTR, F_VOL_DISP, F_VOL_SAIDAS, F_ESTQ_ESCR, F_VAL_AJ_PERDA, F_VAL_AJ_GANHO, F_FECH_FISICO);
            }
        }

        /// <summary>
        ///  MOVIMENTAÇÃO DIÁRIA DE COMBUSTÍVEIS POR TANQUE
        /// </summary>
        public class Registro_1310
        {
            private string F_REG = "1310";
            /// <summary>
            /// Texto fixo contendo "1310"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_NUM_TANQUE = "";
            /// <summary>
            /// Tanque que armazena o combustível 
            /// </summary>
            public string N02_NUM_TANQUE
            {
                get { return F_NUM_TANQUE; }
                set { F_NUM_TANQUE = value; }
            }

            private string F_ESTQ_ABERT = "";
            /// <summary>
            /// Estoque no início do dia, em litros
            /// </summary>
            public string N03_ESTQ_ABERT
            {
                get { return F_ESTQ_ABERT; }
                set { F_ESTQ_ABERT = value; }
            }

            private string F_VOL_ENTR = "";
            /// <summary>
            /// Volume recebido no dia (em litros) 
            /// </summary>
            public string N04_VOL_ENTR
            {
                get { return F_VOL_ENTR; }
                set { F_VOL_ENTR = value; }
            }

            private string F_VOL_DISP = "";
            /// <summary>
            /// Volume disponível (03 + 04), em litros
            /// </summary>
            public string N05_VOL_DISP
            {
                get { return F_VOL_DISP; }
                set { F_VOL_DISP = value; }
            }

            private string F_VOL_SAIDAS = "";
            /// <summary>
            /// Volume total das saídas, em litros
            /// </summary>
            public string N06_VOL_SAIDAS
            {
                get { return F_VOL_SAIDAS; }
                set { F_VOL_SAIDAS = value; }
            }

            private string F_ESTQ_ESCR = "";
            /// <summary>
            /// Estoque escritural (05 - 06), litros
            /// </summary>
            public string N07_ESTQ_ESCR
            {
                get { return F_ESTQ_ESCR; }
                set { F_ESTQ_ESCR = value; }
            }

            private string F_VAL_AJ_PERDA = "";
            /// <summary>
            /// Valor da perda, em litros 
            /// </summary>
            public string N08_VAL_AJ_PERDA
            {
                get { return F_VAL_AJ_PERDA; }
                set { F_VAL_AJ_PERDA = value; }
            }

            private string F_VAL_AJ_GANHO = "";
            /// <summary>
            /// Valor do ganho, em litros
            /// </summary>
            public string N09_VAL_AJ_GANHO
            {
                get { return F_VAL_AJ_GANHO; }
                set { F_VAL_AJ_GANHO = value; }
            }



            private string F_FECH_FISICO = "";
            /// <summary>
            /// Estoque de fechamento, em litros 
            /// </summary>
            public string N10_FECH_FISICO
            {
                get { return F_FECH_FISICO; }
                set { F_FECH_FISICO = value; }
            }


            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_NUM_TANQUE, F_ESTQ_ABERT, F_VOL_ENTR, F_VOL_DISP, F_VOL_SAIDAS, F_ESTQ_ESCR, F_VAL_AJ_PERDA, F_VAL_AJ_GANHO, F_FECH_FISICO);
            }
        }

        /// <summary>
        ///  VOLUME DE VENDAS
        /// </summary>
        public class Registro_1320
        {
            private string F_REG = "1320";
            /// <summary>
            /// Texto fixo contendo "1320"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_NUM_BICO = "";
            /// <summary>
            /// Bico ligado à bomba
            /// </summary>
            public string N02_NUM_BICO
            {
                get { return F_NUM_BICO; }
                set { F_NUM_BICO = value; }
            }

            private string F_NR_INTERV = "";
            /// <summary>
            /// Número da intervenção
            /// </summary>
            public string N03_NR_INTERV
            {
                get { return F_NR_INTERV; }
                set { F_NR_INTERV = value; }
            }

            private string F_MOT_INTERV = "";
            /// <summary>
            /// Motivo da intervenção
            /// </summary>
            public string N04_MOT_INTERV
            {
                get { return F_MOT_INTERV; }
                set { F_MOT_INTERV = value; }
            }

            private string F_NOM_INTERV = "";
            /// <summary>
            /// Nome do interventor
            /// </summary>
            public string N05_NOM_INTERV
            {
                get { return F_NOM_INTERV; }
                set { F_NOM_INTERV = value; }
            }

            private string F_CNPJ_INTERV = "";
            /// <summary>
            /// CNPJ da empresa responsável pela intervenção
            /// </summary>
            public string N06_CNPJ_INTERV
            {
                get { return F_CNPJ_INTERV; }
                set { F_CNPJ_INTERV = value; }
            }

            private string F_CPF_INTERV = "";
            /// <summary>
            /// CPF do técnico responsável pela intervenção
            /// </summary>
            public string N07_CPF_INTERV
            {
                get { return F_CPF_INTERV; }
                set { F_CPF_INTERV = value; }
            }

            private string F_VAL_FECHA = "";
            /// <summary>
            /// Valor da leitura final do contador, no fechamento do bico.
            /// </summary>
            public string N08_VAL_FECHA
            {
                get { return F_VAL_FECHA; }
                set { F_VAL_FECHA = value; }
            }

            private string F_VAL_ABERT = "";
            /// <summary>
            /// Valor da leitura inicial do contador, na abertura do bico
            /// </summary>
            public string N09_VAL_ABERT
            {
                get { return F_VAL_ABERT; }
                set { F_VAL_ABERT = value; }
            }

            private string F_VOL_AFERI = "";
            /// <summary>
            /// Aferições da bomba, em litros
            /// </summary>
            public string N10_VOL_AFERI
            {
                get { return F_VOL_AFERI; }
                set { F_VOL_AFERI = value; }
            }

            private string F_VOL_VENDAS = "";
            /// <summary>
            /// Vendas (08 - 09 - 10 ) do bico, em litros
            /// </summary>
            public string N11_VOL_VENDAS
            {
                get { return F_VOL_VENDAS; }
                set { F_VOL_VENDAS = value; }
            }

            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|", F_REG, F_NUM_BICO, F_NR_INTERV, F_MOT_INTERV, F_NOM_INTERV, F_CNPJ_INTERV, F_CPF_INTERV, F_VAL_FECHA, F_VAL_ABERT, F_VOL_AFERI, F_VOL_VENDAS);
            }
        }

        /// <summary>
        ///  BOMBAS
        /// </summary>
        public class Registro_1350
        {
            private string F_REG = "1350";
            /// <summary>
            /// Texto fixo contendo "1350"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_SERIE = "";
            /// <summary>
            /// Número de série da bomba 
            /// </summary>
            public string N02_SERIE
            {
                get { return F_SERIE; }
                set { F_SERIE = value; }
            }

            private string F_FABRICANTE = "";
            /// <summary>
            /// Nome do fabricante da bomba
            /// </summary>
            public string N03_FABRICANTE
            {
                get { return F_FABRICANTE; }
                set { F_FABRICANTE = value; }
            }

            private string F_MODELO = "";
            /// <summary>
            /// Modelo da bomba
            /// </summary>
            public string N04_MODELO
            {
                get { return F_MODELO; }
                set { F_MODELO = value; }
            }

            private string F_TIPO_MEDICAO = "";
            /// <summary>
            /// Identificador de medição: 
			// 0 - analógico 1 - digital
            /// </summary>
            public string N05_TIPO_MEDICAO
            {
                get { return F_TIPO_MEDICAO; }
                set { F_TIPO_MEDICAO = value; }
            }

            public string GetRegistro_1350(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", F_REG, F_SERIE, F_FABRICANTE, F_MODELO, F_TIPO_MEDICAO);
            }
        }


        /// <summary>
        ///   LACRES DA BOMBA
        /// </summary>
        public class Registro_1360
        {
            private string F_REG = "";
            /// <summary>
            /// Texto fixo contendo "1360"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_NUM_LACRE = "";
            /// <summary>
            /// Número do lacre associado na bomba
            /// </summary>
            public string N02_NUM_LACRE
            {
                get { return F_NUM_LACRE; }
                set { F_NUM_LACRE = value; }
            }

            private string F_DT_APLICACAO = "";
            /// <summary>
            /// Data de aplicação do lacre
            /// </summary>
            public string N03_DT_APLICACAO
            {
                get { return F_DT_APLICACAO; }
                set { F_DT_APLICACAO = value; }
            }


            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_NUM_LACRE, F_DT_APLICACAO);
            }
        }

        /// <summary>
        ///  BICOS DA BOMBA
        /// </summary>
        public class Registro_1370
        {
            private string F_REG = "";
            /// <summary>
            /// Texto fixo contendo "1370"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_NUM_BICO = "";
            /// <summary>
            /// Número sequencial do bico ligado à bomba
            /// </summary>
            public string N02_NUM_BICO
            {
                get { return F_NUM_BICO; }
                set { F_NUM_BICO = value; }
            }

            private string F_COD_ITEM = "";
            /// <summary>
            /// Código do produto, constante do registro 0200
            /// </summary>
            public string N03_COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value; }
            }

            private string F_NUM_TANQUE = "";
            /// <summary>
            /// Tanque que armazena o combustível
            /// </summary>
            public string N04_NUM_TANQUE
            {
                get { return F_NUM_TANQUE; }
                set { F_NUM_TANQUE = value; }
            }


            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (F_REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }

                }
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_NUM_BICO, F_COD_ITEM, F_NUM_TANQUE);
            }
        }

        /// <summary>
        /// CONTROLE DE PRODUÇÃO DE USINA
        /// </summary>
        public class Registro_1390
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_PROD = "";
            public string N02_COD_PROD
            {
                get { return F_COD_PROD; }
                set { F_COD_PROD = value; }
            }
            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|", F_REG, F_COD_PROD);
            }
        }

        /// <summary>
        /// PRODUÇÃO DIÁRIA DA USINA
        /// </summary>
        public class Registro_1391
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private DateTime F_DT_REGISTROC;
            public DateTime N02_DT_REGISTRO
            {
                get { return F_DT_REGISTROC; }
                set { F_DT_REGISTROC = value; }
            }

            private string F_QTD_MOID = "";
            public string N03_QTD_MOID
            {
                get { return F_QTD_MOID; }
                set { F_QTD_MOID = value; }
            }

            private string F_ESTQ_INI = "";
            public string N04_ESTQ_INI
            {
                get { return F_ESTQ_INI; }
                set { F_ESTQ_INI = value; }
            }

            private string F_QTD_PRODUZ = "";
            public string N05_QTD_PRODUZ
            {
                get { return F_QTD_PRODUZ; }
                set { F_QTD_PRODUZ = value; }
            }

            private string F_ENT_ANID_HID = "";
            public string N06_ENT_ANID_HID
            {
                get { return F_ENT_ANID_HID; }
                set { F_ENT_ANID_HID = value; }
            }

            private string F_OUTR_ENTR = "";
            public string N07_OUTR_ENTR
            {
                get { return F_OUTR_ENTR; }
                set { F_OUTR_ENTR = value; }
            }

            private string F_PERDA = "";
            public string N08_PERDA
            {
                get { return F_PERDA; }
                set { F_PERDA = value; }
            }

            private string F_CONS = "";
            public string N09_CONS
            {
                get { return F_CONS; }
                set { F_CONS = value; }
            }

            private string F_SAI_ANI_HID = "";
            public string N10_SAI_ANI_HID
            {
                get { return F_SAI_ANI_HID; }
                set { F_SAI_ANI_HID = value; }
            }

            private string F_SAIDAS = "";
            public string N11_SAIDAS
            {
                get { return F_SAIDAS; }
                set { F_SAIDAS = value; }
            }

            private string F_ESTQ_FIN = "";
            public string N12_ESTQ_FIN
            {
                get { return F_ESTQ_FIN; }
                set { F_ESTQ_FIN = value; }
            }

            private string F_ESTQ_INI_MEL = "";
            public string N13_ESTQ_INI_MEL
            {
                get { return F_ESTQ_INI_MEL; }
                set { F_ESTQ_INI_MEL = value; }
            }

            private string F_PROD_DIA_MEL = "";
            public string N14_PROD_DIA_MEL
            {
                get { return F_PROD_DIA_MEL; }
                set { F_PROD_DIA_MEL = value; }
            }

            private string F_UTIL_MEL = "";
            public string N15_UTIL_MEL
            {
                get { return F_UTIL_MEL; }
                set { F_UTIL_MEL = value; }
            }

            private string F_PROD_ALC_MEL = "";
            public string N16_PROD_ALC_MEL
            {
                get { return F_PROD_ALC_MEL; }
                set { F_PROD_ALC_MEL = value; }
            }

            private string F_OBS = "";
            public string N17_OBS
            {
                get { return F_OBS; }
                set { F_OBS = value; }
            }

            private string F_COD_ITEM = "";
            public string N18_COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value; }
            }

            private string F_TP_RESIDUO = "";
            public string N19_TP_RESIDUO
            {
                get { return F_TP_RESIDUO; }
                set { F_TP_RESIDUO = value; }
            }
            private string F_QTD_RESIDUO = "";
            public string N20_QTD_RESIDUO
            {
                get { return F_QTD_RESIDUO; }
                set { F_QTD_RESIDUO = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return "" ;
           //     return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|", F_REG, F_DT_REGISTROC, F_QTD_MOID, F_ESTQ_INI, F_QTD_PRODUZ, F_ENT_ANID_HID, F_OUTR_ENTR, F_PERDA, F_CONS, F_SAI_ANI_HID, F_SAIDAS, F_ESTQ_FIN, F_ESTQ_INI_MEL, F_PROD_DIA_MEL, F_UTIL_MEL, F_PROD_ALC_MEL, F_OBS, F_COD_ITEM, F_QTD_RESIDUO);
            }
        }


        /// <summary>
        /// INFORMAÇÃO SOBRE VALORES AGREGADOS
        /// </summary>
        public class Registro_1400
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private DateTime F_COD_ITEM_IPM;
            public DateTime N02_COD_ITEM_IPM
            {
                get { return F_COD_ITEM_IPM; }
                set { F_COD_ITEM_IPM = value; }
            }

            private string F_MUN = "";
            public string N03_MUN
            {
                get { return F_MUN; }
                set { F_MUN = value; }
            }

            private string F_VALOR = "";
            public string N04_VALOR
            {
                get { return F_VALOR; }
                set { F_VALOR = value; }
            }


            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_ITEM_IPM, F_MUN, F_VALOR);
            }
        }



        /// <summary>
        /// NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06) - OPERAÇÕES INTERESTADUAIS
        /// </summary>
        public class Registro_1500
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private DateTime F_IND_OPER;
            public DateTime N02_IND_OPER
            {
                get { return F_IND_OPER; }
                set { F_IND_OPER = value; }
            }

            private string F_IND_EMIT = "";
            public string N03_IND_EMIT
            {
                get { return F_IND_EMIT; }
                set { F_IND_EMIT = value; }
            }

            private string F_COD_PART = "";
            public string N04_COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value; }
            }

            private string F_COD_MOD = "";
            public string N05_COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            private string F_COD_SIT = "";
            public string N06_COD_SIT
            {
                get { return F_COD_SIT; }
                set { F_COD_SIT = value; }
            }

            private string F_SER = "";
            public string N07_SER
            {
                get { return F_SER; }
                set { F_SER = value; }
            }

            private string F_SUB = "";
            public string N08_SUB
            {
                get { return F_SUB; }
                set { F_SUB = value; }
            }

            private string F_COD_CONS = "";
            public string N09_COD_CONS
            {
                get { return F_COD_CONS; }
                set { F_COD_CONS = value; }
            }

            private string F_NUM_DOC = "";
            public string N10_NUM_DOC
            {
                get { return F_NUM_DOC; }
                set { F_NUM_DOC = value; }
            }

            private string F_DT_DOC = "";
            public string N11_DT_DOC
            {
                get { return F_DT_DOC; }
                set { F_DT_DOC = value; }
            }

            private string F_DT_E_S = "";
            public string N12_DT_E_S
            {
                get { return F_DT_E_S; }
                set { F_DT_E_S = value; }
            }

            private string F_VL_DOC = "";
            public string N13_VL_DOC
            {
                get { return F_VL_DOC; }
                set { F_VL_DOC = value; }
            }

            private string F_VL_DESC = "";
            public string N14_VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value; }
            }

            private string VL_FORNUTIL_MEL = "";
            public string N15_VL_FORN
            {
                get { return VL_FORNUTIL_MEL; }
                set { VL_FORNUTIL_MEL = value; }
            }

            private string F_VL_SERV_NT = "";
            public string N16_VL_SERV_NT
            {
                get { return F_VL_SERV_NT; }
                set { F_VL_SERV_NT = value; }
            }

            private string F_VL_TERC = "";
            public string N17_VL_TERC
            {
                get { return F_VL_TERC; }
                set { F_VL_TERC = value; }
            }

            private string F_VL_DA = "";
            public string N18_VL_DA
            {
                get { return F_VL_DA; }
                set { F_VL_DA = value; }
            }

            private string F_VL_BC_ICMS = "";
            public string N19_VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value; }
            }
            private string F_VL_ICMS = "";
            public string N20_VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value; }
            }
            private string F_VL_BC_ICMS_ST = "";
            public string N21_VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value; }
            }

            private string F_VL_ICMS_ST = "";
            public string N22_VL_BC_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value; }
            }

            private string F_COD_INF = "";
            public string N23_COD_INF
            {
                get { return F_COD_INF; }
                set { F_COD_INF = value; }
            }
            private string F_VL_PIS = "";
            public string N24_VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value; }
            }
            private string F_VL_COFINS = "";
            public string N25_VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value; }
            }
            private string F_TP_LIGACAO = "";
            public string N26_TP_LIGACAO
            {
                get { return F_TP_LIGACAO; }
                set { F_TP_LIGACAO = value; }
            }
            private string F_COD_GRUPO_TENSAO = "";
            public string N27_COD_GRUPO_TENSAO
            {
                get { return F_COD_GRUPO_TENSAO; }
                set { F_COD_GRUPO_TENSAO = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return "";//  String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|{15}|{16}|{17}|{18}|{19}|{20}|{21}|{22}|{23}|{24}|{25}|{26}|", F_REG, F_IND_OPER, F_IND_EMIT, F_COD_PART, F_COD_MOD, F_COD_SIT, F_SER, F_SUB, F_COD_CONS, F_NUM_DOC, F_DT_DOC, F_DT_E_S, F_VL_DOC, F_VL_DESC, VL_FORNUTIL_MEL, F_VL_SERV_NT, F_VL_TERC, F_VL_DA, F_VL_ICMS, F_VL_BC_ICMS_ST, F_VL_ICMS_ST, F_COD_INF, F_VL_PIS, F_TP_LIGACAO, F_COD_GRUPO_TENSAO);
            }
        }

        /// <summary>
        /// ITENS DO DOCUMENTO NOTA FISCAL/CONTA ENERGIA ELÉTRICA (CÓDIGO 06)
        /// </summary>
        public class Registro_1510
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private DateTime F_NUM_ITEM;
            public DateTime N02_NUM_ITEM
            {
                get { return F_NUM_ITEM; }
                set { F_NUM_ITEM = value; }
            }

            private string F_COD_ITEM = "";
            public string N03_COD_ITEM
            {
                get { return F_COD_ITEM; }
                set { F_COD_ITEM = value; }
            }

            private string F_COD_CLASS = "";
            public string N04_COD_CLASS
            {
                get { return F_COD_CLASS; }
                set { F_COD_CLASS = value; }
            }

            private string F_QTD = "";
            public string N05_QTD
            {
                get { return F_QTD; }
                set { F_QTD = value; }
            }

            private string F_UNID = "";
            public string N06_UNID
            {
                get { return F_UNID; }
                set { F_UNID = value; }
            }

            private string F_VL_ITEM = "";
            public string N07_VL_ITEM
            {
                get { return F_VL_ITEM; }
                set { F_VL_ITEM = value; }
            }

            private string F_VL_DESC = "";
            public string N08_VL_DESC
            {
                get { return F_VL_DESC; }
                set { F_VL_DESC = value; }
            }

            private string F_CST_ICMS = "";
            public string N09_CST_ICMS
            {
                get { return F_CST_ICMS; }
                set { F_CST_ICMS = value; }
            }

            private string F_CFOP = "";
            public string N10_CFOP
            {
                get { return F_CFOP; }
                set { F_CFOP = value; }
            }

            private string F_VL_BC_ICMS = "";
            public string N11_VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value; }
            }

            private string F_ALIQ_ICMS = "";
            public string N12_ALIQ_ICMS
            {
                get { return F_ALIQ_ICMS; }
                set { F_ALIQ_ICMS = value; }
            }

            private string F_VL_ICMS = "";
            public string N13_VL_ICMS
            {
                get { return F_VL_ICMS; }
                set { F_VL_ICMS = value; }
            }

            private string F_VL_BC_ICMS_ST = "";
            public string N14_VL_BC_ICMS_ST
            {
                get { return F_VL_BC_ICMS_ST; }
                set { F_VL_BC_ICMS_ST = value; }
            }

            private string VL_ALIQ_ST = "";
            public string N15_ALIQ_ST
            {
                get { return VL_ALIQ_ST; }
                set { VL_ALIQ_ST = value; }
            }

            private string F_VL_ICMS_ST = "";
            public string N16_VL_ICMS_ST
            {
                get { return F_VL_ICMS_ST; }
                set { F_VL_ICMS_ST = value; }
            }

            private string F_IND_REC = "";
            public string N17_IND_REC
            {
                get { return F_IND_REC; }
                set { F_IND_REC = value; }
            }

            private string F_COD_PART = "";
            public string N18_COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value; }
            }

            private string F_VL_PIS = "";
            public string N19_VL_PIS
            {
                get { return F_VL_PIS; }
                set { F_VL_PIS = value; }
            }

            private string F_VL_COFINS = "";
            public string N20_VL_COFINS
            {
                get { return F_VL_COFINS; }
                set { F_VL_COFINS = value; }
            }

            private string F_COD_CTA = "";
            public string N21_COD_CTA
            {
                get { return F_COD_CTA; }
                set { F_COD_CTA = value; }
            }
        }

        /// <summary>
        /// TOTAL DAS OPERAÇÕES COM CARTÃO DE CRÉDITO E/OU DÉBITO, LOJA (PRIVATE LABEL) E DEMAIS INSTRUMENTOS DE PAGAMENTOS ELETRÔNICOS
        /// </summary>
        public class Registro_1600
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_PART;
            public string N02_COD_PART
            {
                get { return F_COD_PART; }
                set { F_COD_PART = value; }
            }

            private string F_TOT_CREDITO = "";
            public string N03_TOT_CREDITO
            {
                get { return F_TOT_CREDITO; }
                set { F_TOT_CREDITO = value; }
            }

           
            private string F_TOT_DEBITO = "";
            public string N04_TOT_DEBITO
            {
                get { return F_TOT_DEBITO; }
                set { F_TOT_DEBITO = value; }
            }
            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, F_COD_PART, F_TOT_CREDITO, F_TOT_DEBITO);
            }
        }

        /// <summary>
        /// DOCUMENTOS FISCAIS UTILIZADOS
        /// </summary>
        public class Registro_1700
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_COD_DISP;
            public string N02_COD_DISP
            {
                get { return F_COD_DISP; }
                set { F_COD_DISP = value; }
            }

            private string F_COD_MOD = "";
            public string N03_COD_MOD
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            private string F_SER = "";
            public string N04_SER
            {
                get { return F_SER; }
                set { F_SER = value; }
            }

            private string F_SUB = "";
            public string N05_SUB
            {
                get { return F_COD_MOD; }
                set { F_COD_MOD = value; }
            }

            private string F_NUM_DOC_INI = "";
            public string N06_NUM_DOC_INI
            {
                get { return F_NUM_DOC_INI; }
                set { F_NUM_DOC_INI = value; }
            }

            private string F_NUM_DOC_FIN = "";
            public string N07_NUM_DOC_FIN
            {
                get { return F_NUM_DOC_FIN; }
                set { F_NUM_DOC_FIN = value; }
            }

            private string F_NUM_AUT = "";
            public string N08_NUM_AUT
            {
                get { return F_NUM_AUT; }
                set { F_NUM_AUT = value; }
            }


            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|", F_REG, F_COD_DISP, F_COD_MOD, F_SER, F_SUB, F_NUM_DOC_INI, F_NUM_DOC_FIN, F_NUM_AUT);
            }
        }

        /// <summary>
        /// DOCUMENTOS FISCAIS CANCELADOS/INUTILIZADOS
        /// </summary>
        public class Registro_1710
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_NUM_DOC_INI = "";
            public string N02_NUM_DOC_INI
            {
                get { return F_NUM_DOC_INI; }
                set { F_NUM_DOC_INI = value; }
            }

            private string F_NUM_DOC_FIN = "";
            public string N03_NUM_DOC_FIN
            {
                get { return F_NUM_DOC_FIN; }
                set { F_NUM_DOC_FIN = value; }
            }


            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|", F_REG, F_NUM_DOC_INI, F_NUM_DOC_FIN);
            }
        }

        /// <summary>
        /// NOTA FISCAL/CONTA DE ENERGIA ELÉTRICA (CÓDIGO 06) - OPERAÇÕES INTERESTADUAIS
        /// </summary>
        public class Registro_1800
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_VL_CARGA;
            public string N02_VL_CARGA
            {
                get { return F_VL_CARGA; }
                set { F_VL_CARGA = value; }
            }

            private string F_VL_PASS = "";
            public string N03_VL_PASS
            {
                get { return F_VL_PASS; }
                set { F_VL_PASS = value; }
            }

            private string F_VL_FAT = "";
            public string N04_VL_FAT
            {
                get { return F_VL_FAT; }
                set { F_VL_FAT = value; }
            }

            private string F_IND_RAT = "";
            public string N05_IND_RAT
            {
                get { return F_IND_RAT; }
                set { F_IND_RAT = value; }
            }

            private string F_VL_ICMS_ANT = "";
            public string N06_VL_ICMS_ANT
            {
                get { return F_VL_ICMS_ANT; }
                set { F_VL_ICMS_ANT = value; }
            }

            private string F_VL_BC_ICMS = "";
            public string N07_VL_BC_ICMS
            {
                get { return F_VL_BC_ICMS; }
                set { F_VL_BC_ICMS = value; }
            }

            private string F_VL_ICMS_APUR = "";
            public string N08_VL_ICMS_APUR
            {
                get { return F_VL_ICMS_APUR; }
                set { F_VL_ICMS_APUR = value; }
            }

            private string F_VL_BC_ICMS_APUR = "";
            public string N09_VL_BC_ICMS_APUR
            {
                get { return F_VL_BC_ICMS_APUR; }
                set { F_VL_BC_ICMS_APUR = value; }
            }

            private string F_VL_DIF = "";
            public string N10_VL_DIF
            {
                get { return F_VL_DIF; }
                set { F_VL_DIF = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_VL_CARGA, F_VL_PASS, F_VL_FAT, F_IND_RAT, F_VL_ICMS_ANT, F_VL_BC_ICMS, F_VL_ICMS_APUR, F_VL_BC_ICMS_APUR, F_VL_DIF);
            }
        }


        /// <summary>
        ///  INDICADOR DE SUB-APURAÇÃO DO ICMS
        /// </summary>
        public class Registro_1900
        {
            private string REG = "";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value; }
            }

            private string IND_APUR_ICMS = "";
            public string N02_IND_APUR_ICMS
            {
                get { return IND_APUR_ICMS; }
                set { IND_APUR_ICMS = value; }

            }
            private string DESCR_COMPL_OUT_APUR = "";
            public string N03_DESCR_COMPL_OUT_APUR
            {
                get { return DESCR_COMPL_OUT_APUR; }
                set { DESCR_COMPL_OUT_APUR = value; }
            }

            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_LIN_0 */
                    if (IND_APUR_ICMS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_0 não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Validação: o número de linhas (registros) existentes no bloco 0 é igual ao valor informado neste campo.
                     * */
                }
                return String.Format("|{0}|{1}|{2}|", REG, IND_APUR_ICMS, DESCR_COMPL_OUT_APUR);
            }
        }

        /// <summary>
        ///  PERÍODO DA SUB-APURAÇÃO DO ICMS
        /// </summary>
        public class Registro_1910
        {
            private string REG = "";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value; }
            }

            private DateTime DT_INI;
            public DateTime N02_DT_INI
            {
                get { return DT_INI; }
                set { DT_INI = value; }

            }
            private DateTime DT_FIN;
            public DateTime N03_DT_FIN
            {
                get { return DT_FIN; }
                set { DT_FIN = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|", REG, DT_INI, DT_FIN);
            }
        }

        /// <summary>
        /// SUB-APURAÇÃO DO ICMS
        /// </summary>
        public class Registro_1920
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string F_VL_TOT_TRANSF_DEBITOS_OA;
            public string N02_VL_TOT_TRANSF_DEBITOS_OA
            {
                get { return F_VL_TOT_TRANSF_DEBITOS_OA; }
                set { F_VL_TOT_TRANSF_DEBITOS_OA = value; }
            }

            private string F_VL_TOT_AJ_DEBITOS_OA = "";
            public string N03_VL_TOT_AJ_DEBITOS_OA
            {
                get { return F_VL_TOT_AJ_DEBITOS_OA; }
                set { F_VL_TOT_AJ_DEBITOS_OA = value; }
            }

            private string F_VL_ESTORNOS_CRED_OA = "";
            public string N04_VL_ESTORNOS_CRED_OA
            {
                get { return F_VL_ESTORNOS_CRED_OA; }
                set { F_VL_ESTORNOS_CRED_OA = value; }
            }

            private string F_VL_TOT_TRANSF_CREDITOS_OA = "";
            public string N05_VL_TOT_TRANSF_CREDITOS_OA
            {
                get { return F_VL_TOT_TRANSF_CREDITOS_OA; }
                set { F_VL_TOT_TRANSF_CREDITOS_OA = value; }
            }

            private string F_VL_TOT_AJ_CREDITOS_OA = "";
            public string N06_VL_TOT_AJ_CREDITOS_OA
            {
                get { return F_VL_TOT_AJ_CREDITOS_OA; }
                set { F_VL_TOT_AJ_CREDITOS_OA = value; }
            }

            private string F_VL_ESTORNOS_DEB_OA = "";
            public string N07_VL_ESTORNOS_DEB_OA
            {
                get { return F_VL_ESTORNOS_DEB_OA; }
                set { F_VL_ESTORNOS_DEB_OA = value; }
            }

            private string F_VL_SLD_CREDOR_ANT_OA = "";
            public string N08_VL_SLD_CREDOR_ANT_OA
            {
                get { return F_VL_SLD_CREDOR_ANT_OA; }
                set { F_VL_SLD_CREDOR_ANT_OA = value; }
            }

            private string F_VL_SLD_APURADO_OA = "";
            public string N09_VL_SLD_APURADO_OA
            {
                get { return F_VL_SLD_APURADO_OA; }
                set { F_VL_SLD_APURADO_OA = value; }
            }

            private string F_VL_TOT_DED = "";
            public string N10_VL_TOT_DED
            {
                get { return F_VL_TOT_DED; }
                set { F_VL_TOT_DED = value; }
            }

            private string F_VL_ICMS_RECOLHER_OA = "";
            public string N11_VL_ICMS_RECOLHER_OA
            {
                get { return F_VL_ICMS_RECOLHER_OA; }
                set { F_VL_ICMS_RECOLHER_OA = value; }
            }
            private string F_VL_SLD_CREDOR_TRANSP_OA = "";
            public string N12_VL_SLD_CREDOR_TRANSP_OA
            {
                get { return F_VL_SLD_CREDOR_TRANSP_OA; }
                set { F_VL_SLD_CREDOR_TRANSP_OA = value; }
            }
            private string F_DEB_ESP_OA = "";
            public string N13_DEB_ESP_OA
            {
                get { return F_DEB_ESP_OA; }
                set { F_DEB_ESP_OA = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", F_REG, F_VL_TOT_TRANSF_DEBITOS_OA, F_VL_TOT_AJ_DEBITOS_OA, F_VL_ESTORNOS_CRED_OA, F_VL_TOT_TRANSF_CREDITOS_OA, F_VL_TOT_AJ_CREDITOS_OA, F_VL_ESTORNOS_DEB_OA, F_VL_SLD_CREDOR_ANT_OA, F_VL_SLD_APURADO_OA, F_VL_TOT_DED, F_VL_ICMS_RECOLHER_OA, F_VL_SLD_CREDOR_TRANSP_OA, F_DEB_ESP_OA);
            }
        }

        /// <summary>
        /// AJUSTE/BENEFÍCIO/INCENTIVO DA SUB-APURAÇÃO DO ICMS
        /// </summary>
        public class Registro_1921
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string COD_AJ_APUR;
            public string N02_COD_AJ_APUR
            {
                get { return COD_AJ_APUR; }
                set { COD_AJ_APUR = value; }
            }

            private string DESCR_COMPL_AJ = "";
            public string N03_DESCR_COMPL_AJ
            {
                get { return DESCR_COMPL_AJ; }
                set { DESCR_COMPL_AJ = value; }
            }

            private string F_VL_AJ_APUR = "";
            public string N04_VL_AJ_APUR
            {
                get { return F_VL_AJ_APUR; }
                set { F_VL_AJ_APUR = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, COD_AJ_APUR, DESCR_COMPL_AJ, F_VL_AJ_APUR);
            }
        }

        /// <summary>
        ///  INFORMAÇÕES ADICIONAIS DOS AJUSTES DA SUB-APURAÇÃO DO ICMS
        /// </summary>
        public class Registro_1922
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string NUM_DA;
            public string N02_NUM_DA
            {
                get { return NUM_DA; }
                set { NUM_DA = value; }
            }

            private string NUM_PROC = "";
            public string N03_NUM_PROC
            {
                get { return NUM_PROC; }
                set { NUM_PROC = value; }
            }

            private string IND_PROC = "";
            public string N04_IND_PROC
            {
                get { return IND_PROC; }
                set { IND_PROC = value; }
            }

            private string F_PROC = "";
            public string N05_PROC
            {
                get { return F_PROC; }
                set { F_PROC = value; }
            }

            private string F_TXT_COMPL = "";
            public string N06_TXT_COMPL
            {
                get { return F_TXT_COMPL; }
                set { F_TXT_COMPL = value; }
            }


            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|", F_REG, NUM_DA, NUM_PROC, IND_PROC, F_PROC, F_TXT_COMPL);
            }
        }


        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DOS AJUSTES DA SUB-APURAÇÃO DO ICMS - IDENTIFICAÇÃO DOS DOCUMENTOS FISCAIS
        /// </summary>
        public class Registro_1923
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string COD_PART;
            public string N02_COD_PART
            {
                get { return COD_PART; }
                set { COD_PART = value; }
            }

            private string COD_MOD = "";
            public string N03_COD_MOD
            {
                get { return COD_MOD; }
                set { COD_MOD = value; }
            }

            private string SER = "";
            public string N04_SER
            {
                get { return SER; }
                set { SER = value; }
            }

            private string SUB = "";
            public string N05_SUB
            {
                get { return SUB; }
                set { SUB = value; }
            }

            private string NUM_DOC = "";
            public string N06_NUM_DOC
            {
                get { return NUM_DOC; }
                set { NUM_DOC = value; }
            }

            private DateTime DT_DOC;
            public DateTime N07_DT_DOC
            {
                get { return DT_DOC; }
                set { DT_DOC = value; }
            }

            private string COD_ITEM = "";
            public string N08_COD_ITEM
            {
                get { return COD_ITEM; }
                set { COD_ITEM = value; }
            }

            private string VL_AJ_ITEM = "";
            public string N09_VL_AJ_ITEM
            {
                get { return VL_AJ_ITEM; }
                set { VL_AJ_ITEM = value; }
            }

            private string CHV_DOCe = "";
            public string N10_CHV_DOCe
            {
                get { return CHV_DOCe; }
                set { CHV_DOCe = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, COD_PART, COD_MOD, SER, SUB, NUM_DOC, DT_DOC, COD_ITEM, VL_AJ_ITEM, CHV_DOCe);
            }
        }


        /// <summary>
        /// INFORMAÇÕES ADICIONAIS DA SUB-APURAÇÃO - VALORES DECLARATÓRIOS
        /// </summary>
        public class Registro_1925
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string COD_INF_ADIC;
            public string N02_COD_INF_ADIC
            {
                get { return COD_INF_ADIC; }
                set { COD_INF_ADIC = value; }
            }

            private string VL_INF_ADIC = "";
            public string N03_VL_INF_ADIC
            {
                get { return VL_INF_ADIC; }
                set { VL_INF_ADIC = value; }
            }

            private string DESCR_COMPL_AJ = "";
            public string N04_DESCR_COMPL_AJ
            {
                get { return DESCR_COMPL_AJ; }
                set { DESCR_COMPL_AJ = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|", F_REG, COD_INF_ADIC, VL_INF_ADIC, DESCR_COMPL_AJ);
            }
        }

        /// <summary>
        /// OBRIGAÇÕES DO ICMS A RECOLHER - OPERAÇÕES REFERENTES À SUB-APURAÇÃO
        /// </summary>
        public class Registro_1926
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string COD_OR;
            public string N02_COD_OR
            {
                get { return COD_OR; }
                set { COD_OR = value; }
            }

            private string VL_OR = "";
            public string N03_VL_OR
            {
                get { return VL_OR; }
                set { VL_OR = value; }
            }

            private DateTime DT_VCTO;
            public DateTime N04_DT_VCTO
            {
                get { return DT_VCTO; }
                set { DT_VCTO = value; }
            }

            private string COD_REC = "";
            public string N05_COD_REC
            {
                get { return COD_REC; }
                set { COD_REC = value; }
            }

            private string NUM_PROC = "";
            public string N06_NUM_PROC
            {
                get { return NUM_PROC; }
                set { NUM_PROC = value; }
            }

            private string IND_PROC = "";
            public string N07_IND_PROC
            {
                get { return IND_PROC; }
                set { IND_PROC = value; }
            }

            private string PROC = "";
            public string N08_PROC
            {
                get { return PROC; }
                set { PROC = value; }
            }

            private string TXT_COMPL = "";
            public string N09_TXT_COMPL
            {
                get { return TXT_COMPL; }
                set { TXT_COMPL = value; }
            }

            private string MES_REF = "";
            public string N10_MES_REF
            {
                get { return MES_REF; }
                set { MES_REF = value; }
            }
            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, COD_OR, VL_OR, DT_VCTO, COD_REC, NUM_PROC, IND_PROC, PROC, TXT_COMPL, MES_REF);
            }
        }


        /// <summary>
        /// GIAF 1 - GUIA DE INFORMAÇÃO E APURAÇÃO DE INCENTIVOS FISCAIS E FINANCEIROS: INDÚSTRIA(CRÉDITO PRESUMIDO)
        /// </summary>
        public class Registro_1960
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string IND_AP;
            public string N02_IND_AP
            {
                get { return IND_AP; }
                set { IND_AP = value; }
            }

            private string G1_01 = "";
            public string N03_G1_01
            {
                get { return G1_01; }
                set { G1_01 = value; }
            }

            private string G1_02 = "";
            public string N04_G1_02
            {
                get { return G1_02; }
                set { G1_02 = value; }
            }

            private string G1_03 = "";
            public string N05_G1_03
            {
                get { return G1_03; }
                set { G1_03 = value; }
            }

            private string G1_04 = "";
            public string N06_G1_04
            {
                get { return G1_04; }
                set { G1_04 = value; }
            }

            private string G1_05 = "";
            public string N07_G1_05
            {
                get { return G1_05; }
                set { G1_05 = value; }
            }

            private string G1_06 = "";
            public string N08_G1_06
            {
                get { return G1_06; }
                set { G1_06 = value; }
            }

            private string G1_07 = "";
            public string N09_G1_07
            {
                get { return G1_07; }
                set { G1_07 = value; }
            }

            private string G1_08 = "";
            public string N10_G1_08
            {
                get { return G1_08; }
                set { G1_08 = value; }
            }

            private string G1_09 = "";
            public string N11_G1_09
            {
                get { return G1_09; }
                set { G1_09 = value; }
            }
            private string G1_10 = "";
            public string N12_G1_10
            {
                get { return G1_10; }
                set { G1_10 = value; }
            }
            private string G1_11 = "";
            public string N13_G1_11
            {
                get { return G1_11; }
                set { G1_11 = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", F_REG, IND_AP, G1_01, G1_02, G1_03, G1_04, G1_05, G1_06, G1_07, G1_08, G1_09, G1_10, G1_11);
            }
        }


        /// <summary>
        /// GIAF 3 - GUIA DE INFORMAÇÃO E APURAÇÃO DE INCENTIVOS FISCAIS E FINANCEIROS: IMPORTAÇÃO(DIFERIMENTO NA ENTRADA E CRÉDITO PRESUMIDO NA SAÍDA SUBSEQUENTE)
        /// </summary>
        public class Registro_1970
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string IND_AP;
            public string N02_IND_AP
            {
                get { return IND_AP; }
                set { IND_AP = value; }
            }

            private string G3_01 = "";
            public string N03_G3_01
            {
                get { return G3_01; }
                set { G3_01 = value; }
            }

            private string G3_02 = "";
            public string N04_G3_02
            {
                get { return G3_02; }
                set { G3_02 = value; }
            }

            private string G3_03 = "";
            public string N05_G3_03
            {
                get { return G3_03; }
                set { G3_03 = value; }
            }

            private string G3_04 = "";
            public string N06_G3_04
            {
                get { return G3_04; }
                set { G3_04 = value; }
            }

            private string G3_05 = "";
            public string N07_G3_05
            {
                get { return G3_05; }
                set { G3_05 = value; }
            }

            private string G3_06 = "";
            public string N08_G3_06
            {
                get { return G3_06; }
                set { G3_06 = value; }
            }

            private string G3_07 = "";
            public string N09_G3_07
            {
                get { return G3_07; }
                set { G3_07 = value; }
            }

            private string G3_T = "";
            public string N12_G3_T
            {
                get { return G3_T; }
                set { G3_T = value; }
            }
            private string G3_08 = "";
            public string N10_G3_08
            {
                get { return G3_08; }
                set { G3_08 = value; }
            }

            private string G3_09 = "";
            public string N11_G3_09
            {
                get { return G3_09; }
                set { G3_09 = value; }
            }
           
           

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, IND_AP, G3_01, G3_02, G3_03, G3_04, G3_05, G3_06, G3_07, G3_T, G3_08, G3_09);
            }
        }

        /// <summary>
        /// GIAF 3 - GUIA DE INFORMAÇÃO E APURAÇÃO DE INCENTIVOS FISCAIS E FINANCEIROS: IMPORTAÇÃO(SAÍDAS INTERNAS POR FAIXA DE ALÍQUOTA)
        /// </summary>
        public class Registro_1975
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string ALIQ_IMP_BASE;
            public string N02_ALIQ_IMP_BASE
            {
                get { return ALIQ_IMP_BASE; }
                set { ALIQ_IMP_BASE = value; }
            }

            private string G3_10 = "";
            public string N03_G3_10
            {
                get { return G3_10; }
                set { G3_10 = value; }
            }

            private string G3_11 = "";
            public string N04_G3_11
            {
                get { return G3_11; }
                set { G3_11 = value; }
            }

            private string G3_12 = "";
            public string N05_G3_12
            {
                get { return G3_12; }
                set { G3_12 = value; }
            }
            
            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|", F_REG, ALIQ_IMP_BASE, G3_10, G3_11, G3_12);
            }
        }


        /// <summary>
        /// GIAF 4 GUIA DE INFORMAÇÃO E APURAÇÃO DE INCENTIVOS FISCAIS E FINANCEIROS: CENTRAL DE DISTRIBUIÇÃO(ENTRADAS/SAÍDAS)
        /// </summary>
        public class Registro_1980
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string IND_AP;
            public string N02_IND_AP
            {
                get { return IND_AP; }
                set { IND_AP = value; }
            }

            private string G4_01 = "";
            public string N03_G4_01
            {
                get { return G4_01; }
                set { G4_01 = value; }
            }

            private string G4_02 = "";
            public string N04_G4_02
            {
                get { return G4_02; }
                set { G4_02 = value; }
            }

            private string G4_03 = "";
            public string N05_G4_03
            {
                get { return G4_03; }
                set { G4_03 = value; }
            }

            private string G4_04 = "";
            public string N06_G4_04
            {
                get { return G4_04; }
                set { G4_04 = value; }
            }

            private string G4_05 = "";
            public string N07_G4_05
            {
                get { return G4_05; }
                set { G4_05 = value; }
            }

            private string G4_06 = "";
            public string N08_G4_06
            {
                get { return G4_06; }
                set { G4_06 = value; }
            }

            private string G4_07 = "";
            public string N09_G7_07
            {
                get { return G4_07; }
                set { G4_07 = value; }
            }

            private string G4_08 = "";
            public string N10_G4_08
            {
                get { return G4_08; }
                set { G4_08 = value; }
            }

            private string G4_09 = "";
            public string N11_G4_09
            {
                get { return G4_09; }
                set { G4_09 = value; }
            }
            private string G4_10 = "";
            public string N12_G4_10
            {
                get { return G4_10; }
                set { G4_10 = value; }
            }
            private string G4_11 = "";
            public string N13_G4_11
            {
                get { return G4_11; }
                set { G4_11 = value; }

            }
            private string G4_12 = "";
            public string N14_G4_12
            {
                get { return G4_12; }
                set { G4_12 = value; }
            }

            public string GetRegistro(bool Validate)
            {
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, IND_AP, G4_01, G4_02, G4_03, G4_04, G4_05, G4_06, G4_07, G4_08, G4_09, G4_10, G4_11, G4_12);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO 1
        /// </summary>
        public class Registro_1990
        {
            private string REG = "";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value; }
            }

            private string QTD_LIN_1 = "";
            /// <summary>
            /// Quantidade total de linhas do Bloco 0
            /// </summary>
            public string N02_QTD_LIN_1
            {
                get { return QTD_LIN_1; }
                set { QTD_LIN_1 = value; }
            }

            public string GetRegistro(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (REG.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo QTD_LIN_0 */
                    if (QTD_LIN_1.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_0 não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Validação: o número de linhas (registros) existentes no bloco 0 é igual ao valor informado neste campo.
                     * */
                }
                return String.Format("|{0}|{1}|", REG, QTD_LIN_1);
            }
        }

    }
}
