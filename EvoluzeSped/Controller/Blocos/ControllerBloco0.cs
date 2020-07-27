using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBloco0;

namespace EvoluzeSped.Controller.Blocos
{
    class ControllerBloco0
    {
        public Registro_0000 GetRegistro0000(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0000 registro = new Registro_0000();

            registro.N01_REG = array[1];
            registro.N02_COD_VER = array[2];
            //registro.N03_COD_FIN = array[3];
            //registro.N04_DT_INI = array[4];
            //registro.N05_DT_FIN = array[5];
            //registro.N06_NOME = array[6];
            //registro.N07_CNPJ = array[7];
            //registro.N08_CPF = array[8];
            //registro.N09_UF = array[9];
            //registro.N10_IE = array[10];
            //registro.N11_COD_MUN = array[11];
            //registro.N12_IM = array[12];
            //registro.N13_SUFRAMA = array[13];
            //registro.N14_IND_PERFIL = array[14];
            //registro.N15_IND_ATIV = array[15];

            return registro;

        }
        /*
        public Registro_0001 GetRegistro0001(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0001 registro = new Registro_0001();

            registro.N01_REG = array[1];
            registro.N02_IND_MOV = array[2];

            return registro;

        }

        public Registro_0005 GetRegistro0005(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0005 registro = new Registro_0005();

            registro.N01_REG = array[1];
            registro.N02_FANTASIA = array[2];
            registro.N03_CEP = array[3];
            registro.N04_END = array[4];
            registro.N05_NUM = array[5];
            registro.N06_COMPL = array[6];
            registro.N07_BAIRRO = array[7];
            registro.N08_FONE = array[8];
            registro.N09_FAX = array[9];
            registro.N10_EMAIL = array[10];

            return registro;

        }

        public Registro_0100 GetRegistro0100(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0100 registro = new Registro_0100();

            registro.N01_REG = array[1];
            registro.N02_NOME = array[2];
            registro.N03_CPF = array[3];
            registro.N04_CRC = array[4];
            registro.N05_CNPJ = array[5];
            registro.N06_CEP = array[6];
            registro.N07_END = array[7];
            registro.N08_NUM = array[8];
            registro.N09_COMPL = array[9];
            registro.N10_BAIRRO = array[10];
            registro.N11_FONE = array[11];
            registro.N12_FAX = array[12];
            registro.N13_EMAIL = array[13];
            registro.N14_COD_MUN = array[14];

            return registro;

        }

        public Registro_0150 GetRegistro0150(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0150 registro = new Registro_0150();

            registro.N01_REG = array[1];
            registro.N02_COD_PART = array[2];
            registro.N03_NOME = array[3];
            registro.N04_COD_PAIS = array[4];
            registro.N05_CNPJ = array[5];
            registro.N06_CPF = array[6];
            registro.N07_IE = array[7];
            registro.N08_COD_MUN = array[8];
            registro.N09_SUFRAMA = array[9];
            registro.N10_END = array[10];
            registro.N11_NUM = array[11];
            registro.N12_COMPL = array[12];
            registro.N13_BAIRRO = array[13];

            return registro;
        }

        public Registro_0190 GetRegistro0190(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0190 registro = new Registro_0190();

            registro.N01_REG = array[1];
            registro.N02_UNID = array[2];
            registro.N03_DESCR = array[3];

            return registro;

        }

        public Registro_0200 GetRegistro0200(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0200 registro = new Registro_0200();

            registro.N01_REG = array[1];
            registro.N02_COD_ITEM = array[2];
            registro.N03_DESCR_ITEM = array[3];
            registro.N04_COD_BARRA = array[4];
            registro.N05_COD_ANT_ITEM = array[5];
            registro.N06_UNID_INV = array[6];
            registro.N07_TIPO_ITEM = array[7];
            registro.N08_COD_NCM = array[8];
            registro.N09_EX_IPI = array[9];
            registro.N10_COD_GEN = array[10];
            registro.N11_COD_LST = array[11];
            registro.N12_ALIQ_ICMS = array[12];
            registro.N13_CEST = array[13];

            return registro;
        }

        public Registro_0205 GetRegistro0205(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0205 registro = new Registro_0205();

            registro.N01_REG = array[1];
            registro.N02_DESCR_ANT_ITEM = array[2];
            registro.N03_DT_INI = array[3];
            registro.N04_DT_FIM = array[4];
            registro.N05_COD_ANT_ITEM = array[5];

            return registro;
        }

        public Registro_0206 GetRegistro0206(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0206 registro = new Registro_0206();

            registro.N01_REG = array[1];
            registro.N02_COD_COMB = array[2];
            return registro;
        }

        public Registro_0220 GetRegistro0220(string linha)
        {
            string[] array = linha.Split('|');
            Registro_0220 registro = new Registro_0220();
            registro.N01_REG = array[1];
            registro.N02_UNID_CONV = array[2];
            registro.N03_FAT_CONV = array[3];
            return registro;
        }

        public Registro_0300 GetRegistro0300(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0300 registro = new Registro_0300();
            registro.N01_REG = array[1];
            registro.N02_COD_IND_BEM = array[2];
            registro.N03_IDENT_MERC = array[3];
            registro.N04_DESCR_ITEM = array[4];
            registro.N05_COD_PRNC = array[5];
            registro.N06_COD_CTA = array[6];
            registro.N07_NR_PARC = array[7];
            return registro;
        }

        public Registro_0305 GetRegistro0305(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0305 registro = new Registro_0305();
            registro.N01_REG = array[1];
            registro.N02_COD_CCUS = array[2];
            registro.N03_FUNC = array[3];
            registro.N04_VIDA_UTIL = array[4];

            return registro;
        }

        public Registro_0450 GetRegistro0450(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0450 registro = new Registro_0450();
            registro.N01_REG = array[1];
            registro.N02_COD_INF = array[2];
            registro.N03_TXT = array[3];
            return registro;
        }

        public Registro_0460 GetRegistro0460(string linha)
        {
            string[] array = linha.Split('|');

            Registro_0460 registro = new Registro_0460();
            registro.N01_REG = array[1];
            registro.N02_COD_OBS = array[2];
            registro.N03_TXT = array[3];
            return registro;
        }

        public Registro_0500 GetRegistro0500(string linha)
        {
            string[] array = linha.Split('|');
            Registro_0500 registro = new Registro_0500();
            registro.N01_REG = array[1];
            registro.N02_DT_ALT = array[2];
            registro.N03_COD_NAT_CC = array[3];
            registro.N04_IND_CTA = array[4];
            registro.N05_NIVEL = array[5];
            registro.N06_COD_CTA = array[6];
            registro.N07_NOME_CTA = array[7];
            return registro;
        }

        public Registro_0600 GetRegistro0600(string linha)
        {
            string[] array = linha.Split('|');
            Registro_0600 registro = new Registro_0600();
            registro.N01_REG = array[1];
            registro.N02_DT_ALT = array[2];
            registro.N03_COD_CCUS = array[3];
            registro.N04_CCUS = array[4];
            return registro;
        }
        public Registro_0990 GetRegistro0990(string linha)
        {
            string[] array = linha.Split('|');
            Registro_0990 registro = new Registro_0990();
            registro.N01_REG = array[1];
            registro.N02_QTD_LIN_0 = array[2];
            return registro;
        }
        */
    }
}
