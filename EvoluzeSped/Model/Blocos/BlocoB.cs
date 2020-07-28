using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBlocoB;

namespace EvoluzeSped.Model.Blocos
{
    class BlocoB
    {
        public BlocoB()
        {
            RegistroB001 = new Registro_B001();
            RegistroB020List = new List<Registro_B020>();
            RegistroB025List = new List<Registro_B025>();
            //RegistroB030List = new List<Registro_B030>();
            //RegistroB035List = new List<Registro_B035>();
            //RegistroB350List = new List<Registro_B350>();
            //RegistroB420List = new List<Registro_B420>();
            //RegistroB440List = new List<Registro_B440>();
            //RegistroB460List = new List<Registro_B460>();
            //RegistroB470 = new Registro_B470();
            //RegistroB500 = new Registro_B500();
            //RegistroB510List = new List<Registro_B510>();
            RegistroB990 = new Registro_B990();

        }


        public Registro_B001 RegistroB001 { get; set; }
        public List<Registro_B020> RegistroB020List { get; set; }
        public List<Registro_B025> RegistroB025List { get; set; }
        //public List<Registro_B030> RegistroB030List { get; set; }
        //public List<Registro_B035> RegistroB035List { get; set; }
        //public List<Registro_B350> RegistroB350List { get; set; }
        //public List<Registro_B420> RegistroB420List { get; set; }
        //public List<Registro_B440> RegistroB440List { get; set; }
        //public List<Registro_B460> RegistroB460List { get; set; }
        //public Registro_B470 RegistroB470 { get; set; }
        //public Registro_B500 RegistroB500 { get; set; }
        //public List<Registro_B510> RegistroB510List { get; set; }
        public Registro_B990 RegistroB990 { get; set; }
    }
}
