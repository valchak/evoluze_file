using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Registros
{
    public class RegistroBlocoK
    {
        //REGISTRO K001: ABERTURA DO BLOCO K
        public class Registro_K001
        {
            public Registro_K001()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_IND_MOV { get; set; }
        }

        //REGISTRO K100: PERÍODO DE APURAÇÃO DO ICMS/IPI
        public class Registro_K100
        {
            public Registro_K100()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI { get; set; }
            public string N03_DT_FIN { get; set; }
        }

        // REGISTRO K200: ESTOQUE ESCRITURADO
        public class Registro_K200
        {
            public Registro_K200()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_EST { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_IND_EST { get; set; }
            public string N06_COD_PART { get; set; }
        }

        // REGISTRO K210: DESMONTAGEM DE MERCADORIAS – ITEM DE ORIGEM
        public class Registro_K210
        {
            public Registro_K210()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI_OS { get; set; }
            public string N03_DT_FIN_OS { get; set; }
            public string N04_COD_DOC_OS { get; set; }
            public string N05_COD_ITEM_ORI { get; set; }
            public string N06_QTD_ORI { get; set; }
        }

        // REGISTRO K215: DESMONTAGEM DE MERCADORIAS – ITENS DE DESTINO
        public class Registro_K215
        {
            public Registro_K215()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM_DES { get; set; }
            public string N03_QTD_DES { get; set; }
        }

        // REGISTRO K220: OUTRAS MOVIMENTAÇÕES INTERNAS ENTRE MERCADORIAS
        public class Registro_K220
        {
            public Registro_K220()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_MOV { get; set; }
            public string N03_COD_ITEM_ORI { get; set; }
            public string N04_COD_ITEM_DEST { get; set; }
            public string N05_QTD_ORI { get; set; }
            public string N06_QTD_DEST { get; set; }

        }

        // REGISTRO K230: ITENS PRODUZIDOS
        public class Registro_K230
        {
            public Registro_K230()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI_OP { get; set; }
            public string N03_DT_FIN_OP { get; set; }
            public string N04_COD_DOC_OP { get; set; }
            public string N05_COD_ITEM { get; set; }
            public string N06_QTD_ENC { get; set; }
        }

        // REGISTRO K235: INSUMOS CONSUMIDOS
        public class Registro_K235
        {
            public Registro_K235()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_SAÍDA { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_COD_INS_SUBST { get; set; }
        }

        //REGISTRO K250: INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS – ITENS PRODUZIDOS
        public class Registro_K250
        {
            public Registro_K250()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_PROD { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }

        }

        //REGISTRO K255: INDUSTRIALIZAÇÃO EM TERCEIROS – INSUMOS CONSUMIDOS
        public class Registro_K255
        {
            public Registro_K255()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_CONS { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD { get; set; }
            public string N05_COD_INS_SUBST { get; set; }
        }

        // REGISTRO K260: REPROCESSAMENTO/REPARO DE PRODUTO/INSUMO
        public class Registro_K260
        {
            public Registro_K260()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_OP_OS { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_DT_SAÍDA { get; set; }
            public string N05_QTD_SAÍDA { get; set; }
            public string N06_DT_RET { get; set; }
            public string N07_QTD_RET { get; set; }
        }


        // REGISTRO K265: REPROCESSAMENTO/REPARO - MERCADORIAS CONSUMIDAS E/OU RETORNADAS
        public class Registro_K265
        {
            public Registro_K265()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD_CONS { get; set; }
            public string N04_QTD_RET { get; set; }
        }

        // REGISTRO K270: CORREÇÃO DE APONTAMENTO DOS REGISTROS K210, K220, K230, K250, K260, K291, K292, K3public string N01_E K302
        public class Registro_K270
        {
            public Registro_K270()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI_AP { get; set; }
            public string N03_DT_FIN_AP { get; set; }
            public string N04_COD_OP_OS { get; set; }
            public string N05_COD_ITEM { get; set; }
            public string N06_QTD_COR_POS { get; set; }
            public string N07_QTD_COR_NEG { get; set; }
            public string N08_ORIGEM { get; set; }
        }

        //REGISTRO K275: CORREÇÃO DE APONTAMENTO E RETORNO DE INSUMOS DOS REGISTROS K215, K220, K235, K255 E K265
        public class Registro_K275
        {
            public Registro_K275()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD_COR_POS { get; set; }
            public string N04_QTD_COR_NEG { get; set; }
            public string N05_COD_INS_SUBST { get; set; }
        }

        //REGISTRO K280: CORREÇÃO DE APONTAMENTO – ESTOQUE ESCRITURADO
        public class Registro_K280
        {
            public Registro_K280()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_EST { get; set; }
            public string N03_COD_ITEM { get; set; }
            public string N04_QTD_COR_POS { get; set; }
            public string N05_QTD_COR_NEG { get; set; }
            public string N06_IND_EST { get; set; }
            public string N07_COD_PART { get; set; }
        }

        //REGISTRO K290: PRODUÇÃO CONJUNTA – ORDEM DE PRODUÇÃO
        public class Registro_K290
        {
            public Registro_K290()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_INI_OP { get; set; }
            public string N03_DT_FIN_OP { get; set; }
            public string N04_COD_DOC_OP { get; set; }
        }

        // REGISTRO K291: PRODUÇÃO CONJUNTA – ITENS PRODUZIDOS
        public class Registro_K291
        {
            public Registro_K291()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
        }

        //REGISTRO K292: PRODUÇÃO CONJUNTA – INSUMOS CONSUMIDOS
        public class Registro_K292
        {
            public Registro_K292()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
        }

        //REGISTRO K300: PRODUÇÃO CONJUNTA – INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS
        public class Registro_K300
        {
            public Registro_K300()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_DT_PROD { get; set; }
        }

        //REGISTRO K301: PRODUÇÃO CONJUNTA – INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS – ITENS PRODUZIDOS
        public class Registro_K301
        {
            public Registro_K301()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }

        }

        //REGISTRO K302: PRODUÇÃO CONJUNTA – INDUSTRIALIZAÇÃO EFETUADA POR TERCEIROS – INSUMOS CONSUMIDOS
        public class Registro_K302
        {
            public Registro_K302()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_COD_ITEM { get; set; }
            public string N03_QTD { get; set; }
        }

        //REGISTRO K990: ENCERRAMENTO DO BLOCO K
        public class Registro_K990
        {
            public Registro_K990()
            {
                N01_REG = "";
            }
            public string N01_REG { get; set; }
            public string N02_QTD_LIN_K { get; set; }
        }
    }
}
