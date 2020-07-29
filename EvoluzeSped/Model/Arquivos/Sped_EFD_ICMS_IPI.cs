using EvoluzeSped.Model.Blocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Model.Arquivos
{
    class Sped_EFD_ICMS_IPI
    {
        public Sped_EFD_ICMS_IPI()
        {
            Bloco0 = new Bloco0();
            Bloco1 = new Bloco1();
            Bloco9 = new Bloco9();
            BlocoB = new BlocoB();
            BlocoC = new BlocoC();
        }
        public Bloco0 Bloco0 { get; set; }
        public Bloco1 Bloco1 { get; set; }
        public BlocoB BlocoB { get; set; }
        public BlocoC BlocoC { get; set; }
        public Bloco9 Bloco9 { get; set; }

    }
}
