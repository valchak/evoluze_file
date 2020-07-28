using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBloco9;

namespace EvoluzeSped.Model.Blocos
{
    class Bloco9
    {
        public Bloco9()
        {
            Registro9001 = new Registro_9001();
            Registro9900List = new List<Registro_9900>();
            Registro9990 = new Registro_9990();
            Registro9999 = new Registro_9999();

        }

        public Registro_9001 Registro9001 { get; set; }
        public List<Registro_9900> Registro9900List { get; set; }
        public Registro_9990 Registro9990 { get; set; }
        public Registro_9999 Registro9999 { get; set; }
    }
}
