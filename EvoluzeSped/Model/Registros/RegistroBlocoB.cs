using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoB
    {
        public class Registro_B001
        {
            private string REG = "B001";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string IND_MOV = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            public string N02_IND_MOV
            {
                get { return IND_MOV; }
                set { IND_MOV = value.ToUpper(); }
            }

            public string GetRegistroB001(bool Validate)
            {
                if (Validate)
                {
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo REG */
                    if (REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (IND_MOV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV */
                    if (IND_MOV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(IND_MOV.Equals("0")))
                    {
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|", REG, IND_MOV);
            }
        }


        /// <summary>
        /// NOTA FISCAL (CÓDIGO 01), NOTA FISCAL DE SERVIÇOS (CÓDIGO 03), 
        /// NOTA FISCAL DE SERVIÇOS AVULSA(CÓDIGO 3B), 
        /// NOTA FISCAL DE PRODUTOR(CÓDIGO 04), CONHECIMENTO DE 
        /// TRANSPORTE RODOVIÁRIO DE CARGAS(CÓDIGO 08), NF-e(CÓDIGO 55) e NFC-e(CÓDIGO 65)
        /// </summary>
        public class Registro_B020
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string IND_OPER = "";
            public string N02_IND_OPER
            {
                get { return IND_OPER; }
                set { IND_OPER = value; }
            }

            private string IND_EMIT = "";
            public string N03_IND_EMIT
            {
                get { return IND_EMIT; }
                set { IND_EMIT = value; }
            }

            private string COD_PART = "";
            public string N04_COD_PART
            {
                get { return COD_PART; }
                set { COD_PART = value; }
            }

            private string COD_MOD = "";
            public string N05_COD_MOD
            {
                get { return COD_MOD; }
                set { COD_MOD = value; }
            }

            private string COD_SIT = "";
            public string N06_COD_SIT
            {
                get { return COD_SIT; }
                set { COD_SIT = value; }
            }

            private string SER = "";
            public string N07_SER
            {
                get { return SER; }
                set { SER = value; }
            }

            private string NUM_DOC = "";
            public string N08_NUM_DOC
            {
                get { return NUM_DOC; }
                set { NUM_DOC = value; }
            }

            private string CHV_NFE = "";
            public string N09_CHV_NFE
            {
                get { return CHV_NFE; }
                set { CHV_NFE = value; }
            }

            private DateTime DT_DOC;
            public DateTime N10_DT_DOC
            {
                get { return DT_DOC; }
                set { DT_DOC = value; }
            }

            private string COD_MUN_SERV = "";
            public string N11_COD_MUN_SERV
            {
                get { return COD_MUN_SERV; }
                set { COD_MUN_SERV = value; }
            }

            private string VL_CONT = "";
            public string N12_VL_CONT
            {
                get { return VL_CONT; }
                set { VL_CONT = value; }
            }

            private string VL_MAT_TERC = "";
            public string N13_VL_MAT_TERC
            {
                get { return VL_MAT_TERC; }
                set { VL_MAT_TERC = value; }
            }

            private string VL_SUB = "";
            public string N14_VL_SUB
            {
                get { return VL_SUB; }
                set { VL_SUB = value; }
            }

            private string VL_ISNT_ISS = "";
            public string N15_VL_ISNT_ISS
            {
                get { return VL_ISNT_ISS; }
                set { VL_ISNT_ISS = value; }
            }

            private string VL_DED_BC = "";
            public string N16_VL_DED_BC
            {
                get { return VL_DED_BC; }
                set { VL_DED_BC = value; }
            }

            private string VL_BC_ISS = "";
            public string N17_VL_BC_ISS
            {
                get { return VL_BC_ISS; }
                set { VL_BC_ISS = value; }
            }

            private string VL_BC_ISS_RT = "";
            public string N18_VL_BC_ISS_RT
            {
                get { return VL_BC_ISS_RT; }
                set { VL_BC_ISS_RT = value; }
            }

            private string VL_ISS_RT = "";
            public string N19_VL_ISS_RT
            {
                get { return VL_ISS_RT; }
                set { VL_ISS_RT = value; }
            }
            private string F_VL_ISS = "";
            public string N20_VL_ISS
            {
                get { return F_VL_ISS; }
                set { F_VL_ISS = value; }
            }
            private string COD_INF_OBS = "";
            public string N21_COD_INF_OBS
            {
                get { return COD_INF_OBS; }
                set { COD_INF_OBS = value; }
            }

        }


        /// <summary>
        /// DETALHAMENTO POR COMBINAÇÃO DE ALÍQUOTA E ITEM DA LISTA DE SERVIÇOS DA LC 116/2003)
        /// </summary>
        public class Registro_B025
        {
            private string F_REG = "";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value; }
            }

            private string VL_CONT_P = "" ;
            public string N02_VL_CONT_P
            {
                get { return VL_CONT_P; }
                set { VL_CONT_P = value; }
            }

            private string VL_BC_ISS_P = "";
            public string N03_VL_BC_ISS_P
            {
                get { return VL_BC_ISS_P; }
                set { VL_BC_ISS_P = value; }
            }

            private string ALIQ_ISS = "";
            public string N04_ALIQ_ISS
            {
                get { return ALIQ_ISS; }
                set { ALIQ_ISS = value; }
            }

            private string VL_ISS_P = "";
            public string N05_VL_ISS_P
            {
                get { return VL_ISS_P; }
                set { VL_ISS_P = value; }
            }

            private string VL_ISNT_ISS_P = "";
            public string N06_VL_ISNT_ISS_P
            {
                get { return VL_ISNT_ISS_P; }
                set { VL_ISNT_ISS_P = value; }
            }

            private string COD_SERV = "";
            public string N07_COD_SERV
            {
                get { return COD_SERV; }
                set { COD_SERV = value; }
            }

        }

        public class Registro_B990
        {
            private string REG = "B990";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string QTD_LIN_B = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            public string N02_QTD_LIN_B
            {
                get { return QTD_LIN_B; }
                set { QTD_LIN_B = value.ToUpper(); }
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
                    if (REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo IND_MOV */
                    if (QTD_LIN_B.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_MOV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_MOV */
                    if (QTD_LIN_B.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_MOV não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_MOV */
                    if (!(QTD_LIN_B.Equals("0")))
                    {
                        return "Erro -> O campo IND_MOV possui valores pré-definidos";
                    }
                }
                return String.Format("|{0}|{1}|", REG, QTD_LIN_B);
            }
        }
    }
}

