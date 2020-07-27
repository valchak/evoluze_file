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
            Registro0015 = new List<Registro_0015>();
            Registro0100List = new List<Registro_0100>();
            Registro0150List = new List<Registro_0150>();
            //Registro0175 = new Registro_0175();
            Registro0190 = new Registro_0190();
            Registro0200 = new Registro_0200();
            Registro0205 = new Registro_0205();
            Registro0206 = new Registro_0206();
            //Registro0210 = new Registro_0210();
            Registro0220 = new Registro_0220();
            Registro0300 = new Registro_0300();
            Registro0305 = new Registro_0305();
            Registro0400 = new Registro_0400();
            Registro0450 = new Registro_0450();
            Registro0460 = new Registro_0460();
            Registro0500 = new Registro_0500();
            Registro0600 = new Registro_0600();
            Registro0990 = new Registro_0990();
        }
        public Registro_0000 Registro0000 { get; set; }
        public Registro_0001 Registro0001 { get; set; }
        public Registro_0002 Registro0002 { get; set; }
        public Registro_0005 Registro0005 { get; set; }
        public List<Registro_0015> Registro0015 { get; set; }
        public List<Registro_0100> Registro0100List { get; set; }
        public List<Registro_0150> Registro0150List { get; set; }
        //public Registro_0175 Registro0175 { get; set; }
        public Registro_0190 Registro0190 { get; set; }
        public Registro_0200 Registro0200 { get; set; }
        public Registro_0205 Registro0205 { get; set; }
        public Registro_0206 Registro0206 { get; set; }
        //public Registro_0210 Registro0210 { get; set; }
        public Registro_0220 Registro0220 { get; set; }
        public Registro_0300 Registro0300 { get; set; }
        public Registro_0305 Registro0305 { get; set; }
        public Registro_0400 Registro0400 { get; set; }
        public Registro_0450 Registro0450 { get; set; }
        public Registro_0460 Registro0460 { get; set; }
        public Registro_0500 Registro0500 { get; set; }
        public Registro_0600 Registro0600 { get; set; }
        public Registro_0990 Registro0990 { get; set; }
    }
   
}
