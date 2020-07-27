using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBloco0
    {
        public class Registro_0000
        {
            private string REG = "0000";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            // Código da versão do leiaute conforme a tabela indicada no Ato COTEPE.
            private string COD_VER = "";
            public string N02_COD_VER
            {
                get { return COD_VER; }
                set { COD_VER = value.ToUpper(); }
            }

            private string COD_FIN = "";
            /// <summary>
            /// Código da finalidade do arquivo: 0 - Remessa do arquivo original; 1 - Remessa do arquivo substituto.
            /// </summary>
            public string N03_COD_FIN
            {
                get { return COD_FIN; }
                set { COD_FIN = value.ToUpper(); }
            }

            private string DT_INI = "";
            /// <summary>
            /// Data inicial das informações contidas no arquivo.
            /// </summary>
            public string N04_DT_INI
            {
                get { return DT_INI; }
                set { DT_INI = value.ToUpper(); }
            }

            private string DT_FIN = "";
            /// <summary>
            /// Data final das informações contidas no arquivo.
            /// </summary>
            public string N05_DT_FIN
            {
                get { return DT_FIN; }
                set { DT_FIN = value.ToUpper(); }
            }

            private string NOME = "";
            /// <summary>
            /// Nome empresarial da entidade.
            /// </summary>
            public string N06_NOME
            {
                get { return NOME; }
                set { NOME = value.ToUpper(); }
            }

            private string CNPJ = "";
            /// <summary>
            /// Número de inscrição da entidade no CNPJ.
            /// </summary>
            public string N07_CNPJ
            {
                get { return CNPJ; }
                set { CNPJ = value.ToUpper(); }
            }

            private string CPF = "";
            /// <summary>
            /// Número de inscrição da entidade no CPF.
            /// </summary>
            public string N08_CPF
            {
                get { return CPF; }
                set { CPF = value.ToUpper(); }
            }

            private string UF = "";
            /// <summary>
            /// Sigla da unidade da federação da entidade.
            /// </summary>
            public string N09_UF
            {
                get { return UF; }
                set { UF = value.ToUpper(); }
            }

            private string IE = "";
            /// <summary>
            /// Inscrição Estadual da entidade.
            /// </summary>
            public string N10_IE
            {
                get { return IE; }
                set { IE = value.ToUpper(); }
            }

            private string COD_MUN = "";
            /// <summary>
            /// Código do município do domicílio fiscal da entidade, conforme a tabela IBGE
            /// </summary>
            public string N11_COD_MUN
            {
                get { return COD_MUN; }
                set { COD_MUN = value.ToUpper(); }
            }

            private string IM = "";
            /// <summary>
            /// Inscrição Municipal da entidade.
            /// </summary>
            public string N12_IM
            {
                get { return IM; }
                set { IM = value.ToUpper(); }
            }

            private string SUFRAMA = "";
            /// <summary>
            /// Inscrição da entidade na SUFRAMA
            /// </summary>
            public string N13_SUFRAMA
            {
                get { return SUFRAMA; }
                set { SUFRAMA = value.ToUpper(); }
            }

            private string IND_PERFIL = "";
            /// <summary>
            /// Perfil de apresentação do arquivo fiscal; A – Perfil A; B – Perfil B.; c – Perfil C.
            /// </summary>
            public string N14_IND_PERFIL
            {
                get { return IND_PERFIL; }
                set { IND_PERFIL = value.ToUpper(); }
            }

            private string IND_ATIV = "";
            /// <summary>
            /// Indicador de tipo de atividade: 0 – Industrial ou equiparado a industrial; 1 – Outros.
            /// </summary>
            public string N15_IND_ATIV
            {
                get { return IND_ATIV; }
                set { IND_ATIV = value.ToUpper(); }
            }

            public string GetRegistro_0000(bool Validate)
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
                    /* validacao para o tamanho do campo COD_VER */
                    if (COD_VER.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de COD_VER incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_VER */
                    if (COD_VER.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_VER não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_FIN */
                    if (COD_FIN.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de COD_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_FIN */
                    if (COD_FIN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_FIN não informado(a)";
                    }
                    /* Validacao para os dados informados a COD_FIN */
                    if (!(COD_FIN.Equals("0") || COD_FIN.Equals("1")))
                    {
                        return "Erro -> O campo COD_FIN possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (DT_INI.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIN */
                    if (DT_FIN.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIN */
                    if (DT_FIN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIN não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME */
                    if (NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UF */
                    if (UF.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de UF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UF */
                    if (UF.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UF não informado(a)";
                    }
                    /* validacao para o tamanho do campo IE */
                    if (IE.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de IE incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IE */
                    if (IE.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IE não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_MUN */
                    if (COD_MUN.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_MUN não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo SUFRAMA */
                    if (SUFRAMA.Length > 9)
                    {
                        return "Erro -> Tamanho do campo de SUFRAMA incorreto(a)";
                    }
                    /* validacao para o tamanho do campo IND_PERFIL */
                    if (IND_PERFIL.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_PERFIL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_PERFIL */
                    if (IND_PERFIL.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_PERFIL não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_PERFIL */
                    if (!(IND_PERFIL.Equals("A") || IND_PERFIL.Equals("B") || IND_PERFIL.Equals("C")))
                    {
                        return "Erro -> O campo IND_PERFIL possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_ATIV */
                    if (IND_ATIV.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_ATIV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_ATIV */
                    if (IND_ATIV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_ATIV não informado(a)";
                    }
                    /* Validacao dos dados passados a IND_ATIV */
                    if (!(IND_ATIV.Equals("0") || IND_ATIV.Equals("1")))
                    {
                        return "Erro -> O campo IND_ATIV possui valores pré-definidos";
                    }
                    /* validacoes manuais */

                    /* validacao da data de fim no mesmo mes/ano da data inicio */
                    DateTime dataInicio;
                    DateTime dataFim;
                    try
                    {
                        dataInicio = DateTime.ParseExact(N04_DT_INI, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        return "Erro -> Data inválida no campo DT_INI";
                    }
                    try
                    {
                        dataFim = DateTime.ParseExact(N05_DT_FIN, "ddMMyyyy", System.Globalization.CultureInfo.CurrentCulture);
                    }
                    catch (Exception)
                    {
                        return "Erro -> Data inválida no campo DT_FIM";
                    }
                    if ((dataInicio.Month != dataFim.Month) || (dataInicio.Year != dataFim.Year))
                    {
                        return "Erro -> Mês e Ano não conferem para Data_Final";
                    }
                    /* validar CPF / CNPJ 
                    if (!F_CNPJ.Trim().Trim().Equals(""))
                        if (!Util.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    if (!F_CPF.Trim().Trim().Equals(""))
                        if (!Util.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|{14}|", REG, COD_VER, COD_FIN, DT_INI, DT_FIN, NOME, CNPJ, CPF, UF, IE, COD_MUN, IM, SUFRAMA, IND_PERFIL, IND_ATIV);
            }
        }

        public class Registro_0001
        {
            private string F_REG = "0001";

            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }
            private string F_IND_MOV = "";
            /// <summary>
            /// Indicador de movimento: 0- Bloco com dados informados; 1- Bloco sem dados informados.
            /// </summary>
            public string N02_IND_MOV
            {
                get { return F_IND_MOV; }
                set { F_IND_MOV = value.ToUpper(); }
            }

            public string GetRegistro_0001(bool Validate)
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
        public class Registro_0005
        {
            private string F_REG = "0005";
            /// <summary>
            /// Texto fixo contendo “0005”
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_FANTASIA = "";
            /// <summary>
            /// Nome de fantasia associado ao nome empresarial.
            /// </summary>
            public string N02_FANTASIA
            {
                get { return F_FANTASIA; }
                set { F_FANTASIA = value.ToUpper(); }
            }

            private string F_CEP = "";
            /// <summary>
            /// Código de Endereçamento Postal.
            /// </summary>
            public string N03_CEP
            {
                get { return F_CEP; }
                set { F_CEP = value.ToUpper(); }
            }

            private string F_END = "";
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            public string N04_END
            {
                get { return F_END; }
                set { F_END = value.ToUpper(); }
            }

            private string F_NUM = "";
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            public string N05_NUM
            {
                get { return F_NUM; }
                set { F_NUM = value.ToUpper(); }
            }

            private string F_COMPL = "";
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string N06_COMPL
            {
                get { return F_COMPL; }
                set { F_COMPL = value.ToUpper(); }
            }

            private string F_BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string N07_BAIRRO
            {
                get { return F_BAIRRO; }
                set { F_BAIRRO = value.ToUpper(); }
            }

            private string F_FONE = "";
            /// <summary>
            /// Número do telefone (DDD+FONE).
            /// </summary>
            public string N08_FONE
            {
                get { return F_FONE; }
                set { F_FONE = value.ToUpper(); }
            }

            private string F_FAX = "";
            /// <summary>
            /// Número do fax.
            /// </summary>
            public string N09_FAX
            {
                get { return F_FAX; }
                set { F_FAX = value.ToUpper(); }
            }

            private string F_EMAIL = "";
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            public string N10_EMAIL
            {
                get { return F_EMAIL; }
                set { F_EMAIL = value.ToUpper(); }
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
                    /* validacao para a obrigatoriedade do campo REG */
                    if (F_REG.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório REG não informado(a)";
                    }
                    /* validacao para o tamanho do campo FANTASIA */
                    if (F_FANTASIA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de FANTASIA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo FANTASIA */
                    if (F_FANTASIA.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório FANTASIA não informado(a)";
                    }
                    /* validacao para o tamanho do campo CEP */
                    if (F_CEP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de CEP incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CEP */
                    if (F_CEP.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CEP não informado(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (F_END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo END */
                    if (F_END.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório END não informado(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (F_NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (F_COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (F_BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo BAIRRO */
                    if (F_BAIRRO.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório BAIRRO não informado(a)";
                    }
                    /* validacao para o tamanho do campo FONE */
                    if (F_FONE.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FONE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|", F_REG, F_FANTASIA, F_CEP, F_END, F_NUM, F_COMPL, F_BAIRRO, F_FONE, F_FAX, F_EMAIL);
            }
        }

        /// <summary>
        /// DADOS DO CONTABILISTA
        /// </summary>
        public class Registro_0100
        {
            private string F_REG = "0100";
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_NOME = "";
            /// <summary>
            /// Nome do contabilista.
            /// </summary>
            public string N02_NOME
            {
                get { return F_NOME; }
                set { F_NOME = value.ToUpper(); }
            }

            private string F_CPF = "";
            /// <summary>
            /// Número de inscrição do contabilista no CPF.
            /// </summary>
            public string N03_CPF
            {
                get { return F_CPF; }
                set { F_CPF = value.ToUpper(); }
            }

            private string F_CRC = "";
            /// <summary>
            /// Número de inscrição do contabilista no Conselho Regional de Contabilidade.
            /// </summary>
            public string N04_CRC
            {
                get { return F_CRC; }
                set { F_CRC = value.ToUpper(); }
            }

            private string F_CNPJ = "";
            /// <summary>
            /// Número de inscrição do escritório de contabilidade no CNPJ, se houver.
            /// </summary>
            public string N05_CNPJ
            {
                get { return F_CNPJ; }
                set { F_CNPJ = value.ToUpper(); }
            }

            private string F_CEP = "";
            /// <summary>
            /// Código de Endereçamento Postal.
            /// </summary>
            public string N06_CEP
            {
                get { return F_CEP; }
                set { F_CEP = value.ToUpper(); }
            }

            private string F_END = "";
            /// <summary>
            /// Logradouro e endereço do imóvel.
            /// </summary>
            public string N07_END
            {
                get { return F_END; }
                set { F_END = value.ToUpper(); }
            }

            private string F_NUM = "";
            /// <summary>
            /// Número do imóvel.
            /// </summary>
            public string N08_NUM
            {
                get { return F_NUM; }
                set { F_NUM = value.ToUpper(); }
            }

            private string F_COMPL = "";
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string N09_COMPL
            {
                get { return F_COMPL; }
                set { F_COMPL = value.ToUpper(); }
            }

            private string F_BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string N10_BAIRRO
            {
                get { return F_BAIRRO; }
                set { F_BAIRRO = value.ToUpper(); }
            }

            private string F_FONE = "";
            /// <summary>
            /// Número do telefone (DDD+FONE).
            /// </summary>
            public string N11_FONE
            {
                get { return F_FONE; }
                set { F_FONE = value.ToUpper(); }
            }

            private string F_FAX = "";
            /// <summary>
            /// Número do fax.
            /// </summary>
            public string N12_FAX
            {
                get { return F_FAX; }
                set { F_FAX = value.ToUpper(); }
            }

            private string F_EMAIL = "";
            /// <summary>
            /// Endereço do correio eletrônico.
            /// </summary>
            public string N13_EMAIL
            {
                get { return F_EMAIL; }
                set { F_EMAIL = value.ToUpper(); }
            }

            private string F_COD_MUN = "";
            /// <summary>
            /// Código do município, conforme tabela IBGE.
            /// </summary>
            public string N14_COD_MUN
            {
                get { return F_COD_MUN; }
                set { F_COD_MUN = value.ToUpper(); }
            }

            public string GetRegistro_0100(bool Validate)
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
                    /* validacao para o tamanho do campo NOME */
                    if (F_NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (F_NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (F_CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CPF */
                    if (F_CPF.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CPF não informado(a)";
                    }
                    /* validacao para o tamanho do campo CRC */
                    if (F_CRC.Length > 15)
                    {
                        return "Erro -> Tamanho do campo de CRC incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CRC */
                    if (F_CRC.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CRC não informado(a)";
                    }
                    /* validacao para o tamanho do campo CNPJ */
                    if (F_CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo CEP */
                    if (F_CEP.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de CEP incorreto(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (F_END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (F_NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (F_COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (F_BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FONE */
                    if (F_FONE.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FONE incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para o tamanho do campo FAX */
                    if (F_FAX.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de FAX incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo EMAIL */
                    if (F_EMAIL.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório EMAIL não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (F_COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacoes manuais */
                    /* validar CPF / CNPJ */
                    /*
                    if (!F_CNPJ.Trim().Trim().Equals(""))
                        if (!Util.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    if (!F_CPF.Trim().Trim().Equals(""))
                        if (!Util.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|{13}|", F_REG, F_NOME, F_CPF, F_CRC, F_CNPJ, F_CEP, F_END, F_NUM, F_COMPL, F_BAIRRO, F_FONE, F_FAX, F_EMAIL, F_COD_MUN);
            }
        }

        /// <summary>
        /// TABELA DE CADASTRO DO PARTICIPANTE
        /// </summary>
        public class Registro_0150
        {
            private string REG = "0150";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            // Código de identificação do participante no arquivo 
            private string COD_PART = "";
            public string N02_COD_PART
            {
                get { return COD_PART; }
                set { COD_PART = value.ToUpper(); }
            }

            // Nome pessoal ou empresarial do participante 
            private string NOME = "";

            public string N03_NOME
            {
                get { return NOME; }
                set { NOME = value.ToUpper(); }
            }

            // Código do país do participante, conforme a tabela indicada no item 3.2.1 
            private string COD_PAIS = "";

            public string N04_COD_PAIS
            {
                get { return COD_PAIS; }
                set { COD_PAIS = value.ToUpper(); }
            }

            private string CNPJ = "";
            public string N05_CNPJ
            {
                get { return CNPJ; }
                set { CNPJ = value.ToUpper(); }
            }

            private string CPF = "";
            public string N06_CPF
            {
                get { return CPF; }
                set { CPF = value.ToUpper(); }
            }

            private string IE = "";
            public string N07_IE
            {
                get { return IE; }
                set { IE = value.ToUpper(); }
            }

            private string COD_MUN = "";
            public string N08_COD_MUN
            {
                get { return COD_MUN; }
                set { COD_MUN = value.ToUpper(); }
            }

            private string SUFRAMA = "";
            public string N09_SUFRAMA
            {
                get { return SUFRAMA; }
                set { SUFRAMA = value.ToUpper(); }
            }

            private string END = "";
            public string N10_END
            {
                get { return END; }
                set { END = value.ToUpper(); }
            }

            private string NUM = "";
            public string N11_NUM
            {
                get { return NUM; }
                set { NUM = value.ToUpper(); }
            }

            private string COMPL = "";
            /// <summary>
            /// Dados complementares do endereço.
            /// </summary>
            public string N12_COMPL
            {
                get { return COMPL; }
                set { COMPL = value.ToUpper(); }
            }

            private string BAIRRO = "";
            /// <summary>
            /// Bairro em que o imóvel está situado.
            /// </summary>
            public string N13_BAIRRO
            {
                get { return BAIRRO; }
                set { BAIRRO = value.ToUpper(); }
            }

            public string GetRegistro_150(bool Validate)
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
                    /* validacao para o tamanho do campo NOME */
                    if (NOME.Length > 100)
                    {
                        return "Erro -> Tamanho do campo de NOME incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME */
                    if (NOME.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME não informado(a)";
                    }
                    /* validacao para o tamanho do campo CPF */
                    if (CPF.Length > 11)
                    {
                        return "Erro -> Tamanho do campo de CPF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CPF */
                    if (CPF.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CPF não informado(a)";
                    }

                    if (CNPJ.Length > 14)
                    {
                        return "Erro -> Tamanho do campo de CNPJ incorreto(a)";
                    }
                    /* validacao para o tamanho do campo END */
                    if (END.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de END incorreto(a)";
                    }
                    /* validacao para o tamanho do campo NUM */
                    if (NUM.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de NUM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COMPL */
                    if (COMPL.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COMPL incorreto(a)";
                    }
                    /* validacao para o tamanho do campo BAIRRO */
                    if (BAIRRO.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de BAIRRO incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_MUN */
                    if (COD_MUN.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de COD_MUN incorreto(a)";
                    }
                    /* validacoes manuais */
                    /* validar CPF / CNPJ */
                    /*
                    if (!F_CNPJ.Trim().Trim().Equals(""))
                        if (!Util.ValidaCNPJ(F_CNPJ))
                            return "Erro -> CNPJ Inválido";
                    if (!F_CPF.Trim().Trim().Equals(""))
                        if (!Util.ValidaCPF(F_CPF))
                            return "Erro -> CPF Inválido";
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", REG, COD_PART, NOME, COD_PAIS, CNPJ, CPF, IE, COD_MUN, SUFRAMA, END, NUM, COMPL, BAIRRO);
            }
        }

        /// <summary>
        /// IDENTIFICAÇÃO DAS UNIDADES DE MEDIDA
        /// </summary>
        public class Registro_0190
        {
            private string REG = "0190";
            /// <summary>
            /// Texto fixo contendo "0190"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string UNID = "";
            /// <summary>
            /// Código da unidade de medida
            /// </summary>
            public string N02_UNID
            {
                get { return UNID; }
                set { UNID = value.ToUpper(); }
            }

            private string DESCR = "";
            /// <summary>
            /// Descrição da unidade de medida
            /// </summary>
            public string N03_DESCR
            {
                get { return DESCR; }
                set { DESCR = value.ToUpper(); }
            }

            public string GetRegistro_0190(bool Validate)
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
                    /* validacao para o tamanho do campo UNID */
                    if (UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID */
                    if (UNID.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID */
                    if (UNID.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR */
                    if (DESCR.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR não informado(a)";
                    }
                    /* validacoes manuais */
                    if (UNID.Equals(DESCR))
                    {
                        return "Erro -> Campo UNID e DESCR não podem ser iguais";
                    }
                }
                return String.Format("|{0}|{1}|{2}|", REG, UNID, DESCR);
            }
        }

        /// <summary>
        /// TABELA DE IDENTIFICAÇÃO DO ITEM (PRODUTO E SERVIÇOS)
        /// </summary>
        public class Registro_0200
        {
            private string REG = "0200";
            /// <summary>
            /// Texto fixo contendo "0200"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string COD_ITEM = "";
            /// <summary>
            /// Código do item
            /// </summary>
            public string N02_COD_ITEM
            {
                get { return COD_ITEM; }
                set { COD_ITEM = value.ToUpper(); }
            }

            private string DESCR_ITEM = "";
            /// <summary>
            /// Descrição do item
            /// </summary>
            public string N03_DESCR_ITEM
            {
                get { return DESCR_ITEM; }
                set { DESCR_ITEM = value.ToUpper(); }
            }

            private string COD_BARRA = "";
            /// <summary>
            /// Representação alfanumérico do código de barra do produto, se houver
            /// </summary>
            public string N04_COD_BARRA
            {
                get { return COD_BARRA; }
                set { COD_BARRA = value.ToUpper(); }
            }

            private string COD_ANT_ITEM = "";
            /// <summary>
            /// Código anterior do item com relação à última informação apresentada.
            /// </summary>
            public string N05_COD_ANT_ITEM
            {
                get { return COD_ANT_ITEM; }
                set { COD_ANT_ITEM = value.ToUpper(); }
            }

            private string UNID_INV = "";
            /// <summary>
            /// Unidade de medida utilizada na quantificação de estoques.
            /// </summary>
            public string N06_UNID_INV
            {
                get { return UNID_INV; }
                set { UNID_INV = value.ToUpper(); }
            }

            private string TIPO_ITEM = "";
            /// <summary>
            /// Tipo do item / Atividades Industriais, Comerciais e Serviços: 00 – Mercadoria para Revenda; 01 – Matéria-Prima; 02 – Embalagem; 03 – Produto em Processo; 04 – Produto Acabado; 05 – Subproduto; 06 – Produto Intermediário; 07 – Material de Uso e Consumo; 08 – Ativo Imobilizado; 09 – Serviços; 10 – Outros insumos; 99 – Outras
            /// </summary>
            public string N07_TIPO_ITEM
            {
                get { return TIPO_ITEM; }
                set { TIPO_ITEM = value.ToUpper(); }
            }

            private string COD_NCM = "";
            /// <summary>
            /// Código da Nomenclatura Comum do Mercosul
            /// </summary>
            public string N08_COD_NCM
            {
                get { return COD_NCM; }
                set { COD_NCM = value.ToUpper(); }
            }

            private string EX_IPI = "";
            /// <summary>
            /// Código EX, conforme a TIPI
            /// </summary>
            public string N09_EX_IPI
            {
                get { return EX_IPI; }
                set { EX_IPI = value.ToUpper(); }
            }

            private string COD_GEN = "";
            /// <summary>
            /// Código do gênero do item, conforme a Tabela 4.2.1
            /// </summary>
            public string N10_COD_GEN
            {
                get { return COD_GEN; }
                set { COD_GEN = value.ToUpper(); }
            }

            private string COD_LST = "";
            /// <summary>
            /// Código do serviço conforme lista do Anexo I da Lei Complementar Federal nº 116/03.
            /// </summary>
            public string N11_COD_LST
            {
                get { return COD_LST; }
                set { COD_LST = value.ToUpper(); }
            }

            private string ALIQ_ICMS = "";
            /// <summary>
            /// Alíquota de ICMS aplicável ao item nas operações internas
            /// </summary>
            public string N12_ALIQ_ICMS
            {
                get { return ALIQ_ICMS; }
                set { ALIQ_ICMS = value.ToUpper(); }
            }

            private string CEST = "";
            public string N13_CEST
            {
                get { return CEST; }
                set { CEST = value.ToUpper(); }
            }

            public string GetRegistro_0200(bool Validate)
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
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ITEM */
                    if (COD_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_ITEM */
                    if (DESCR_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ITEM */
                    if (COD_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_ANT_ITEM */
                    if (COD_ANT_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ANT_ITEM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo UNID_INV */
                    if (UNID_INV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_INV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID_INV */
                    if (UNID_INV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID_INV não informado(a)";
                    }
                    /* validacao para o tamanho do campo TIPO_ITEM */
                    if (TIPO_ITEM.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de TIPO_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TIPO_ITEM */
                    if (TIPO_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TIPO_ITEM não informado(a)";
                    }
                    /* Validacao dos dados passados a TIPO_ITEM */
                    if (!(TIPO_ITEM.Equals("00") || TIPO_ITEM.Equals("01") || TIPO_ITEM.Equals("02") || TIPO_ITEM.Equals("03") || TIPO_ITEM.Equals("04") || TIPO_ITEM.Equals("05") || TIPO_ITEM.Equals("06") || TIPO_ITEM.Equals("07") || TIPO_ITEM.Equals("08") || TIPO_ITEM.Equals("09") || TIPO_ITEM.Equals("10") || TIPO_ITEM.Equals("99")))
                    {
                        return "Erro -> O campo TIPO_ITEM possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo COD_NCM */
                    if (COD_NCM.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de COD_NCM incorreto(a)";
                    }
                    /* validacao para o tamanho do campo EX_IPI */
                    if (EX_IPI.Length > 3)
                    {
                        return "Erro -> Tamanho do campo de EX_IPI incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_GEN */
                    if (COD_GEN.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_GEN incorreto(a)";
                    }
                    /* validacao para o tamanho do campo COD_LST */
                    if (COD_LST.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de COD_LST incorreto(a)";
                    }
                    /* validacao para o tamanho do campo ALIQ_ICMS */
                    if (ALIQ_ICMS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de ALIQ_ICMS incorreto(a)";
                    }
                    if (CEST.Length > 7)
                    {
                        return "Erro -> Tamanho do campo de CEST incorreto(a)";
                    }

                    if (ALIQ_ICMS.Contains("0"))
                    {
                        ALIQ_ICMS = "12";
                    }

                    if (CEST.Equals(""))
                    {
                        CEST = "0000000";
                    }
                    /* validacoes manuais */


                    /* validacoes manuais */


                    /*
                    Validação: o valor informado neste campo deve existir em pelo menos um registro dos demais blocos ou no registro 0220.
                     * 
                    Campo 06 - Validação: existindo informação neste campo, esta deve existir no registro 0190, campo UNID, respectivo.
                     * 
                    Campo 10 - Preenchimento: obrigatório para todos os contribuintes na aquisição de produtos primários. A Tabela
                    "Gênero do Item de Mercadoria/Serviço", referenciada no Item 4.2.1 do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008,
                    corresponde à tabela de "Capítulos da NCM", acrescida do código "00 - Serviço".
                    Validação: o valor informado no campo deve existir na Tabela “Gênero do Item de Mercadoria/Serviço”, item 4.2.1 do
                    Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.
                     * 
                    */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|{9}|{10}|{11}|{12}|", REG, COD_ITEM, DESCR_ITEM, COD_BARRA, COD_ANT_ITEM, UNID_INV, TIPO_ITEM, COD_NCM, EX_IPI, COD_GEN, COD_LST, ALIQ_ICMS, CEST);
            }
        }

        // <summary>
        /// ALTERAÇÃO DO ITEM
        /// </summary>
        public class Registro_0205
        {
            private string REG = "0205";
            /// <summary>
            /// Texto fixo contendo "0205"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string DESCR_ANT_ITEM = "";
            /// <summary>
            /// Descrição anterior do item
            /// </summary>
            public string N02_DESCR_ANT_ITEM
            {
                get { return DESCR_ANT_ITEM; }
                set { DESCR_ANT_ITEM = value.ToUpper(); }
            }

            private string DT_INI = "";
            /// <summary>
            /// Data inicial de utilização da descrição do item
            /// </summary>
            public string N03_DT_INI
            {
                get { return DT_INI; }
                set { DT_INI = value.ToUpper(); }
            }

            private string DT_FIM = "";
            /// <summary>
            /// Data final de utilização da descrição do item
            /// </summary>
            public string N04_DT_FIM
            {
                get { return DT_FIM; }
                set { DT_FIM = value.ToUpper(); }
            }

            private string F_COD_ANT_ITEM = "";
            /// <summary>
            /// Código anterior do item com relação à última informação apresentada.
            /// </summary>
            public string N05_COD_ANT_ITEM
            {
                get { return F_COD_ANT_ITEM; }
                set { F_COD_ANT_ITEM = value.ToUpper(); }
            }

            public string GetRegistro_0205(bool Validate)
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
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_ANT_ITEM */
                    if (DESCR_ANT_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_ANT_ITEM não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_INI */
                    if (DT_INI.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_INI incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_INI */
                    if (DT_INI.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_INI não informado(a)";
                    }
                    /* validacao para o tamanho do campo DT_FIM */
                    if (DT_FIM.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_FIM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_FIM */
                    if (DT_FIM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_FIM não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ANT_ITEM */
                    if (F_COD_ANT_ITEM.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_ANT_ITEM incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ANT_ITEM */
                    if (F_COD_ANT_ITEM.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ANT_ITEM não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 04 - Preenchimento: informar o período final de utilização da descrição anterior do item.
                    Validação: o valor informado no campo deve ser uma data válida, obedecido o formato “ddmmaaaa”. O valor informado
                    no campo deve ser menor que o valor no campo DT_FIN do registro 0000.
                     * 
                     */

                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|", REG, DESCR_ANT_ITEM, DT_INI, DT_FIM, F_COD_ANT_ITEM);
            }
        }


        /// <summary>
        /// CÓDIGO DE PRODUTO CONFORME TABELA PUBLICADA PELA ANP (COMBUSTÍVEIS)
        /// </summary>
        public class Registro_0206
        {
            private string REG = "0206";
            /// <summary>
            /// Texto fixo contendo "0206"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string F_COD_COMB = "";
            /// <summary>
            /// Código do combustível, conforme tabela publicada pela ANP
            /// </summary>
            public string N02_COD_COMB
            {
                get { return F_COD_COMB; }
                set { F_COD_COMB = value.ToUpper(); }
            }

            public string GetRegistro_0206(bool Validate)
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
                    /* validacao para o tamanho do campo REG */
                    if (REG.Length > 4)
                    {
                        return "Erro -> Tamanho do campo de REG incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_COMB */
                    if (F_COD_COMB.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_COMB não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 02 - Preenchimento: utilizar o código do combustível, conforme Tabela de Produtos para Combustíveis / Solvente
                    (Tabela 12 de códigos de produtos para o Sistema de Informações de Movimentação de Produtos (SIMP), conforme item
                    3.2.1 do Ato COTEPE/ICMS nº 09, de 18 de abril de 2008.
                    Validação: o valor informado no campo deve existir na tabela da ANP.
                     * 
                    */
                }
                return String.Format("|{0}|{1}|", REG, F_COD_COMB);
            }
        }

        /// <summary>
        /// FATORES DE CONVERSÃO DE UNIDADES
        /// </summary>
        public class Registro_0220
        {
            private string REG = "0220";
            /// <summary>
            /// Texto fixo contendo "0220"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string UNID_CONV = "";
            /// <summary>
            /// Unidade comercial a ser convertida na unidade de estoque, referida no registro 0200.
            /// </summary>
            public string N02_UNID_CONV
            {
                get { return UNID_CONV; }
                set { UNID_CONV = value.ToUpper(); }
            }

            private string FAT_CONV = "";
            /// <summary>
            /// Fator de conversão: fator utilizado para converter (multiplicar) a unidade a ser convertida na unidade adotada no inventário.
            /// </summary>
            public string N03_FAT_CONV
            {
                get { return FAT_CONV; }
                set { FAT_CONV = value.ToUpper(); }
            }

            public string GetRegistro_0220(bool Validate)
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
                    /* validacao para o tamanho do campo UNID_CONV */
                    if (UNID_CONV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_CONV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo UNID_CONV */
                    if (UNID_CONV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório UNID_CONV não informado(a)";
                    }
                    /* validacao para o tamanho do campo UNID_CONV */
                    if (UNID_CONV.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de UNID_CONV incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo FAT_CONV */
                    if (FAT_CONV.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório FAT_CONV não informado(a)";
                    }
                    /* validacoes manuais */
                    if (!(Convert.ToInt32(FAT_CONV) > 0))
                    {
                        return "Erro -> FAT_CONV deve ser maior que '0'";
                    }

                    /*
                     * Campo 02 - Validação: o valor informado no campo deve existir no campo UNID do registro 0190.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", REG, UNID_CONV, FAT_CONV);
            }
        }

        /// <summary>
        /// CADASTRO DE BENS OU COMPONENTES DO ATIVO IMOBILIZADO
        /// </summary>
        public class Registro_0300
        {
            private string REG = "0300";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string COD_IND_BEM = "";
            public string N02_COD_IND_BEM
            {
                get { return COD_IND_BEM; }
                set { COD_IND_BEM = value.ToUpper(); }
            }

            private string IDENT_MERC = "";
            public string N03_IDENT_MERC
            {
                get { return IDENT_MERC; }
                set { IDENT_MERC = value.ToUpper(); }
            }

            private string DESCR_ITEM = "";
            public string N04_DESCR_ITEM
            {
                get { return DESCR_ITEM; }
                set { DESCR_ITEM = value.ToUpper(); }
            }

            private string COD_PRNC = "";
            public string N05_COD_PRNC
            {
                get { return COD_PRNC; }
                set { COD_PRNC = value.ToUpper(); }
            }

            private string COD_CTA = "";
            public string N06_COD_CTA
            {
                get { return COD_CTA; }
                set { COD_CTA = value.ToUpper(); }
            }

            private string NR_PARC = "";
            public string N07_NR_PARC
            {
                get { return NR_PARC; }
                set { NR_PARC = value.ToUpper(); }
            }

            public string GetRegistro_0300(bool Validate)
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
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", REG, COD_IND_BEM, IDENT_MERC, DESCR_ITEM, COD_PRNC, COD_CTA, NR_PARC);
            }
        }

        /// <summary>
        /// INFORMAÇÃO SOBRE A UTILIZAÇÃO DO BEM
        /// </summary>
        public class Registro_0305
        {
            private string REG = "0305";
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string COD_CCUS = "";
            public string N02_COD_CCUS
            {
                get { return COD_CCUS; }
                set { COD_CCUS = value.ToUpper(); }
            }

            private string FUNC = "";
            public string N03_FUNC
            {
                get { return FUNC; }
                set { FUNC = value.ToUpper(); }
            }

            private string VIDA_UTIL = "";
            public string N04_VIDA_UTIL
            {
                get { return VIDA_UTIL; }
                set { VIDA_UTIL = value.ToUpper(); }
            }


            public string GetRegistro_0305(bool Validate)
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

                }
                return String.Format("|{0}|{1}|{2}|{3}|", REG, COD_CCUS, FUNC, VIDA_UTIL);
            }
        }

        /// <summary>
        /// TABELA DE NATUREZA DA OPERAÇÃO/PRESTAÇÃO
        /// </summary>
        public class Registro_0400
        {
            private string F_REG = "0400";
            /// <summary>
            /// Texto fixo contendo "0400"
            /// </summary>
            public string N01_REG
            {
                get { return F_REG; }
                set { F_REG = value.ToUpper(); }
            }

            private string F_COD_NAT = "";
            /// <summary>
            /// Código da natureza da operação/prestação
            /// </summary>
            public string N02_COD_NAT
            {
                get { return F_COD_NAT; }
                set { F_COD_NAT = value.ToUpper(); }
            }

            private string F_DESCR_NAT = "";
            /// <summary>
            /// Descrição da natureza da operação/prestação
            /// </summary>
            public string N03_DESCR_NAT
            {
                get { return F_DESCR_NAT; }
                set { F_DESCR_NAT = value.ToUpper(); }
            }

            public string GetRegistro_0400(bool Validate)
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
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_NAT */
                    if (F_COD_NAT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_NAT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_NAT */
                    if (F_COD_NAT.Length > 10)
                    {
                        return "Erro -> Tamanho do campo de COD_NAT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DESCR_NAT */
                    if (F_DESCR_NAT.Trim().Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DESCR_NAT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                    Campo 02 - Validação: o valor informado no campo COD_NAT deve existir em pelo menos um registro dos demais blocos.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", F_REG, F_COD_NAT, F_DESCR_NAT);
            }
        }

        /// <summary>
        /// TABELA DE INFORMAÇÃO COMPLEMENTAR DO DOCUMENTO FISCAL
        /// </summary>
        public class Registro_0450
        {
            private string REG = "0450";
            /// <summary>
            /// Texto fixo contendo "0450"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string COD_INF = "";
            /// <summary>
            /// Código da informação complementar do documento fiscal.
            /// </summary>
            public string N02_COD_INF
            {
                get { return COD_INF; }
                set { COD_INF = value.ToUpper(); }
            }

            private string TXT = "";
            /// <summary>
            /// Texto livre da informação complementar existente no documento fiscal, inclusive espécie de normas legais, poder normativo, número, capitulação, data e demais referências pertinentes com indicação referentes ao tributo.
            /// </summary>
            public string N03_TXT
            {
                get { return TXT; }
                set { TXT = value.ToUpper(); }
            }

            public string GetRegistro_0450(bool Validate)
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
                    /* validacao para o tamanho do campo COD_INF */
                    if (COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_INF */
                    if (COD_INF.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_INF não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_INF */
                    if (COD_INF.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_INF incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TXT */
                    if (TXT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TXT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Campo 02 - Validação: o valor informado deve existir em pelo menos um registro dos demais blocos.
                    */
                }
                return String.Format("|{0}|{1}|{2}|", REG, COD_INF, TXT);
            }
        }

        /// <summary>
        /// TABELA DE OBSERVAÇÕES DO LANÇAMENTO FISCAL
        /// </summary>
        public class Registro_0460
        {
            private string REG = "0460";
            /// <summary>
            /// Texto fixo contendo "0460"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string COD_OBS = "";
            /// <summary>
            /// Código da Observação do lançamento fiscal.
            /// </summary>
            public string N02_COD_OBS
            {
                get { return COD_OBS; }
                set { COD_OBS = value.ToUpper(); }
            }

            private string TXT = "";
            /// <summary>
            /// Descrição da observação vinculada ao lançamento fiscal
            /// </summary>
            public string N03_TXT
            {
                get { return TXT; }
                set { TXT = value.ToUpper(); }
            }

            public string GetRegistro_0460(bool Validate)
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
                    /* validacao para o tamanho do campo COD_OBS */
                    if (COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_OBS */
                    if (COD_OBS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_OBS não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_OBS */
                    if (COD_OBS.Length > 6)
                    {
                        return "Erro -> Tamanho do campo de COD_OBS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo TXT */
                    if (TXT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório TXT não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     *  Campo 02 -Validação: o valor informado neste campo deve existir em pelo menos um registro dos demais blocos.
                     *  Campo 03 - Preenchimento: este campo corresponde às informações lançadas na coluna “Observação” dos Livros Fiscais
                     *  de Entradas, Saídas e de Apuração, de acordo com o estabelecido na legislação de cada unidade federada.
                     */
                }
                return String.Format("|{0}|{1}|{2}|", REG, COD_OBS, TXT);
            }
        }

        /// <summary>
        /// PLANO DE CONTAS CONTÁBEIS
        /// </summary>
        public class Registro_0500
        {
            private string REG = "0500";
            /// <summary>
            /// Texto fixo contendo “0500”
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string DT_ALT = "";
            /// <summary>
            /// Data da inclusão/alteração
            /// </summary>
            public string N02_DT_ALT
            {
                get { return DT_ALT; }
                set { DT_ALT = value.ToUpper(); }
            }

            private string COD_NAT_CC = "";
            /// <summary>
            /// NAT_CC Código da natureza da conta/grupo de contas: 01 - Contas de ativo; 02 - Contas de passivo; 03 - Patrimônio líquido; 04 - Contas de resultado; 05 - Contas de compensação; 09 - Outras.
            /// </summary>
            public string N03_COD_NAT_CC
            {
                get { return COD_NAT_CC; }
                set { COD_NAT_CC = value.ToUpper(); }
            }

            private string IND_CTA = "";
            /// <summary>
            /// Indicador do tipo de conta: S - Sintética (grupo de contas); A - Analítica (conta).
            /// </summary>
            public string N04_IND_CTA
            {
                get { return IND_CTA; }
                set { IND_CTA = value.ToUpper(); }
            }

            private string NIVEL = "";
            /// <summary>
            /// Nível da conta analítica/grupo de contas.
            /// </summary>
            public string N05_NIVEL
            {
                get { return NIVEL; }
                set { NIVEL = value.ToUpper(); }
            }

            private string COD_CTA = "";
            /// <summary>
            /// Código da conta analítica/grupo de contas.
            /// </summary>
            public string N06_COD_CTA
            {
                get { return COD_CTA; }
                set { COD_CTA = value.ToUpper(); }
            }

            private string NOME_CTA = "";
            /// <summary>
            /// Nome da conta analítica/grupo de contas.
            /// </summary>
            public string N07_NOME_CTA
            {
                get { return NOME_CTA; }
                set { NOME_CTA = value.ToUpper(); }
            }

            public string GetRegistro_0500(bool Validate)
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
                    /* validacao para o tamanho do campo DT_ALT */
                    if (DT_ALT.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ALT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ALT */
                    if (DT_ALT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ALT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_ */
                    if (COD_NAT_CC.Length > 2)
                    {
                        return "Erro -> Tamanho do campo de COD_ incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_ */
                    if (COD_NAT_CC.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_ não informado(a)";
                    }
                    /* Validacao para os dados informados a COD_ */
                    if (!(COD_NAT_CC.Equals("01") || COD_NAT_CC.Equals("02") || COD_NAT_CC.Equals("03") || COD_NAT_CC.Equals("04") || COD_NAT_CC.Equals("05") || COD_NAT_CC.Equals("09")))
                    {
                        return "Erro -> O campo COD_ possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo IND_CTA */
                    if (IND_CTA.Length > 1)
                    {
                        return "Erro -> Tamanho do campo de IND_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo IND_CTA */
                    if (IND_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório IND_CTA não informado(a)";
                    }
                    /* Validacao para os dados informados a IND_CTA */
                    if (!(IND_CTA.Equals("S") || IND_CTA.Equals("A")))
                    {
                        return "Erro -> O campo IND_CTA possui valores pré-definidos";
                    }
                    /* validacao para o tamanho do campo NÍVEL */
                    if (NIVEL.Length > 5)
                    {
                        return "Erro -> Tamanho do campo de NÍVEL incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NÍVEL */
                    if (NIVEL.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NÍVEL não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CTA */
                    if (COD_CTA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CTA */
                    if (COD_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CTA não informado(a)";
                    }
                    /* validacao para o tamanho do campo NOME_CTA */
                    if (NOME_CTA.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de NOME_CTA incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo NOME_CTA */
                    if (NOME_CTA.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório NOME_CTA não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     Validação: a data não pode ser maior que a constante no campo DT_FIN.
                     * */
                }
                return String.Format("|{0}|{1}|{2}|{3}|{4}|{5}|{6}|", REG, DT_ALT, COD_NAT_CC, IND_CTA, NIVEL, COD_CTA, NOME_CTA);
            }
        }

        /// <summary>
        /// CENTRO DE CUSTOS
        /// </summary>
        public class Registro_0600
        {
            private string REG = "0600";
            /// <summary>
            /// Texto fixo contendo “0600”.
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string DT_ALT = "";
            /// <summary>
            /// Data da inclusão/alteração.
            /// </summary>
            public string N02_DT_ALT
            {
                get { return DT_ALT; }
                set { DT_ALT = value.ToUpper(); }
            }

            private string COD_CCUS = "";
            /// <summary>
            /// Código do centro de custos.
            /// </summary>
            public string N03_COD_CCUS
            {
                get { return COD_CCUS; }
                set { COD_CCUS = value.ToUpper(); }
            }

            private string CCUS = "";
            /// <summary>
            /// Nome do centro de custos.
            /// </summary>
            public string N04_CCUS
            {
                get { return CCUS; }
                set { CCUS = value.ToUpper(); }
            }

            public string GetRegistro_0600(bool Validate)
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
                    /* validacao para o tamanho do campo DT_ALT */
                    if (DT_ALT.Length > 8)
                    {
                        return "Erro -> Tamanho do campo de DT_ALT incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo DT_ALT */
                    if (DT_ALT.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório DT_ALT não informado(a)";
                    }
                    /* validacao para o tamanho do campo COD_CCUS */
                    if (COD_CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de COD_CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo COD_CCUS */
                    if (COD_CCUS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório COD_CCUS não informado(a)";
                    }
                    /* validacao para o tamanho do campo CCUS */
                    if (CCUS.Length > 60)
                    {
                        return "Erro -> Tamanho do campo de CCUS incorreto(a)";
                    }
                    /* validacao para a obrigatoriedade do campo CCUS */
                    if (CCUS.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório CCUS não informado(a)";
                    }
                    /* validacoes manuais */
                }
                return String.Format("|{0}|{1}|{2}|{3}|", REG, DT_ALT, COD_CCUS, CCUS);
            }
        }

        /// <summary>
        /// ENCERRAMENTO DO BLOCO 0
        /// </summary>
        public class Registro_0990
        {
            private string REG = "0990";
            /// <summary>
            /// Texto fixo contendo "0990"
            /// </summary>
            public string N01_REG
            {
                get { return REG; }
                set { REG = value.ToUpper(); }
            }

            private string QTD_LIN_0 = "";
            /// <summary>
            /// Quantidade total de linhas do Bloco 0
            /// </summary>
            public string N02_QTD_LIN_0
            {
                get { return QTD_LIN_0; }
                set { QTD_LIN_0 = value.ToUpper(); }
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
                    if (QTD_LIN_0.Trim().Equals(""))
                    {
                        return "Erro -> Campo Obrigatório QTD_LIN_0 não informado(a)";
                    }
                    /* validacoes manuais */

                    /*
                     * Validação: o número de linhas (registros) existentes no bloco 0 é igual ao valor informado neste campo.
                     * */
                }
                return String.Format("|{0}|{1}|", REG, QTD_LIN_0);
            }
        }

    }
}
