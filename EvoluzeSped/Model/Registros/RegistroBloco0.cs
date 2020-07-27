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
        }
    }
}
