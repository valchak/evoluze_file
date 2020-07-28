using System;
using System.Collections.Generic;
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
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", F_REG, F_COD_MOD, F_SERIE, F_NUM_DOC, F_CHV_NFE, F_DT_DOC, F_COD_ITEM);
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
            private string F_REG = "1360";
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
            private string F_REG = "1370";
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
        /// ENCERRAMENTO DO BLOCO 1
        /// </summary>
        public class Registro_1990
        {
            private string REG = "1990";
            /// <summary>
            /// Texto fixo contendo "1990"
            /// </summary>
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
