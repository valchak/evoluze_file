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
            Registro0001 = new Registro_0001();
            Registro0002 = new Registro_0002();
            Registro0005 = new Registro_0005();
            Registro0015List = new List<Registro_0015>();
            Registro0100List = new List<Registro_0100>();
            Registro0150List = new List<Registro_0150>();
            Registro0175List = new List<Registro_0175>();
            Registro0190List = new List<Registro_0190>();
            Registro0200List = new List<Registro_0200>();
            Registro0205List = new List<Registro_0205>();
            Registro0206List = new List<Registro_0206>();
            Registro0210List = new List<Registro_0210>();
            Registro0220List = new List<Registro_0220>();
            Registro0300List = new List<Registro_0300>();
            Registro0305List = new List<Registro_0305>();
            Registro0400List = new List<Registro_0400>();
            Registro0450List = new List<Registro_0450>();
            Registro0460List = new List<Registro_0460>();
            Registro0500List = new List<Registro_0500>();
            Registro0600List = new List<Registro_0600>();
            Registro0990 = new Registro_0990();
        }
        public Registro_0000 Registro0000 { get; set; }
        public Registro_0001 Registro0001 { get; set; }
        public Registro_0002 Registro0002 { get; set; }
        public Registro_0005 Registro0005 { get; set; }
        public List<Registro_0015> Registro0015List { get; set; }
        public List<Registro_0100> Registro0100List { get; set; }
        public List<Registro_0150> Registro0150List { get; set; }
        public List<Registro_0175> Registro0175List { get; set; }
        public List<Registro_0190> Registro0190List { get; set; }
        public List<Registro_0200> Registro0200List { get; set; }
        public List<Registro_0205> Registro0205List { get; set; }
        public List<Registro_0206> Registro0206List { get; set; }
        public List<Registro_0210> Registro0210List { get; set; }
        public List<Registro_0220> Registro0220List { get; set; }
        public List<Registro_0300> Registro0300List { get; set; }
        public List<Registro_0305> Registro0305List { get; set; }
        public List<Registro_0400> Registro0400List { get; set; }
        public List<Registro_0450> Registro0450List { get; set; }
        public List<Registro_0460> Registro0460List { get; set; }
        public List<Registro_0500> Registro0500List { get; set; }
        public List<Registro_0600> Registro0600List { get; set; }
        public Registro_0990 Registro0990 { get; set; }
    }
   
}
