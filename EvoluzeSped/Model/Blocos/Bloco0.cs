using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBloco0;

namespace EvoluzeSped.Model.Blocos
{
    class Bloco0
    {
        public Bloco0()
        {
            Registro0000 = new Registro_0000();
        }
        public Registro_0000 Registro0000 { get; set; }
    }
   
}
