using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBlocoC;

namespace EvoluzeSped.Model.Blocos
{
    class BlocoC
    {
        public BlocoC()
        {
            RegistroC001 = new Registro_C001();
            RegistroC100List = new List<Registro_C100>();
            RegistroC101List = new List<Registro_C101>();
            RegistroC105List = new List<Registro_C105>();
            RegistroC110List = new List<Registro_C110>();
            RegistroC111List = new List<Registro_C111>();
            RegistroC112List = new List<Registro_C112>();
            RegistroC113List = new List<Registro_C113>();
            RegistroC114List = new List<Registro_C114>();
            RegistroC115List = new List<Registro_C115>();
            RegistroC116List = new List<Registro_C116>();
            RegistroC120List = new List<Registro_C120>();
            RegistroC130List = new List<Registro_C130>();
            RegistroC140List = new List<Registro_C140>();
            RegistroC141List = new List<Registro_C141>();
            RegistroC160List = new List<Registro_C160>();
            RegistroC165List = new List<Registro_C165>();
            RegistroC170List = new List<Registro_C170>();
            RegistroC171List = new List<Registro_C171>();
            RegistroC172List = new List<Registro_C172>();
            RegistroC173List = new List<Registro_C173>();
            RegistroC174List = new List<Registro_C174>();
            RegistroC175List = new List<Registro_C175>();
            RegistroC176List = new List<Registro_C176>();
            RegistroC177List = new List<Registro_C177>();
            RegistroC178List = new List<Registro_C178>();
            RegistroC179List = new List<Registro_C179>();
            RegistroC180List = new List<Registro_C180>();
            RegistroC185List = new List<Registro_C185>();
            RegistroC190List = new List<Registro_C190>();
            RegistroC191List = new List<Registro_C191>();
            RegistroC195List = new List<Registro_C195>();
            RegistroC197List = new List<Registro_C197>();
            RegistroC300List = new List<Registro_C300>();
            RegistroC310List = new List<Registro_C310>();
            RegistroC320List = new List<Registro_C320>();
            RegistroC321List = new List<Registro_C321>();
            RegistroC330List = new List<Registro_C330>();
            RegistroC350List = new List<Registro_C350>();
            RegistroC370List = new List<Registro_C370>();
            RegistroC380List = new List<Registro_C380>();
            RegistroC390List = new List<Registro_C390>();
            RegistroC400List = new List<Registro_C400>();
            RegistroC405List = new List<Registro_C405>();
            RegistroC410List = new List<Registro_C410>();
            RegistroC420List = new List<Registro_C420>();
            RegistroC425List = new List<Registro_C425>();
            RegistroC430List = new List<Registro_C430>();
            RegistroC460List = new List<Registro_C460>();
            RegistroC465List = new List<Registro_C465>();
            RegistroC470List = new List<Registro_C470>();
            RegistroC480List = new List<Registro_C480>();
            RegistroC490List = new List<Registro_C490>();
            RegistroC495List = new List<Registro_C495>();
            RegistroC500List = new List<Registro_C500>();
            RegistroC510List = new List<Registro_C510>();
            RegistroC590List = new List<Registro_C590>();
            RegistroC591List = new List<Registro_C591>();
            RegistroC595List = new List<Registro_C595>();
            RegistroC597List = new List<Registro_C597>();
            RegistroC600List = new List<Registro_C600>();
            RegistroC601List = new List<Registro_C601>();
            RegistroC610List = new List<Registro_C610>();
            RegistroC690List = new List<Registro_C690>();
            RegistroC700List = new List<Registro_C700>();
            RegistroC790List = new List<Registro_C790>();
            RegistroC791List = new List<Registro_C791>();
            RegistroC800List = new List<Registro_C800>();
            RegistroC810List = new List<Registro_C810>();
            RegistroC815List = new List<Registro_C815>();
            RegistroC850List = new List<Registro_C850>();
            RegistroC860List = new List<Registro_C860>();
            RegistroC870List = new List<Registro_C870>();
            RegistroC880List = new List<Registro_C880>();
            RegistroC890List = new List<Registro_C890>();
            RegistroC990 = new Registro_C990();
        }

        public Registro_C001 RegistroC001 { get; set; }
        public List<Registro_C100> RegistroC100List { get; set; }
        public List<Registro_C101> RegistroC101List { get; set; }
        public List<Registro_C105> RegistroC105List { get; set; }
        public List<Registro_C110> RegistroC110List { get; set; }
        public List<Registro_C111> RegistroC111List { get; set; }
        public List<Registro_C112> RegistroC112List { get; set; }
        public List<Registro_C113> RegistroC113List { get; set; }
        public List<Registro_C114> RegistroC114List { get; set; }
        public List<Registro_C115> RegistroC115List { get; set; }
        public List<Registro_C116> RegistroC116List { get; set; }
        public List<Registro_C120> RegistroC120List { get; set; }
        public List<Registro_C130> RegistroC130List { get; set; }
        public List<Registro_C140> RegistroC140List { get; set; }
        public List<Registro_C141> RegistroC141List { get; set; }
        public List<Registro_C160> RegistroC160List { get; set; }
        public List<Registro_C165> RegistroC165List { get; set; }
        public List<Registro_C170> RegistroC170List { get; set; }
        public List<Registro_C171> RegistroC171List { get; set; }
        public List<Registro_C172> RegistroC172List { get; set; }
        public List<Registro_C173> RegistroC173List { get; set; }
        public List<Registro_C174> RegistroC174List { get; set; }
        public List<Registro_C175> RegistroC175List { get; set; }
        public List<Registro_C176> RegistroC176List { get; set; }
        public List<Registro_C177> RegistroC177List { get; set; }
        public List<Registro_C178> RegistroC178List { get; set; }
        public List<Registro_C179> RegistroC179List { get; set; }
        public List<Registro_C180> RegistroC180List { get; set; }
        public List<Registro_C185> RegistroC185List { get; set; }
        public List<Registro_C190> RegistroC190List { get; set; }
        public List<Registro_C191> RegistroC191List { get; set; }
        public List<Registro_C195> RegistroC195List { get; set; }
        public List<Registro_C197> RegistroC197List { get; set; }
        public List<Registro_C300> RegistroC300List { get; set; }
        public List<Registro_C310> RegistroC310List { get; set; }
        public List<Registro_C320> RegistroC320List { get; set; }
        public List<Registro_C321> RegistroC321List { get; set; }
        public List<Registro_C330> RegistroC330List { get; set; }
        public List<Registro_C350> RegistroC350List { get; set; }
        public List<Registro_C370> RegistroC370List { get; set; }
        public List<Registro_C380> RegistroC380List { get; set; }
        public List<Registro_C390> RegistroC390List { get; set; }
        public List<Registro_C400> RegistroC400List { get; set; }
        public List<Registro_C405> RegistroC405List { get; set; }
        public List<Registro_C410> RegistroC410List { get; set; }
        public List<Registro_C420> RegistroC420List { get; set; }
        public List<Registro_C425> RegistroC425List { get; set; }
        public List<Registro_C430> RegistroC430List { get; set; }
        public List<Registro_C460> RegistroC460List { get; set; }
        public List<Registro_C465> RegistroC465List { get; set; }
        public List<Registro_C470> RegistroC470List { get; set; }
        public List<Registro_C480> RegistroC480List { get; set; }
        public List<Registro_C490> RegistroC490List { get; set; }
        public List<Registro_C495> RegistroC495List { get; set; }
        public List<Registro_C500> RegistroC500List { get; set; }
        public List<Registro_C510> RegistroC510List { get; set; }
        public List<Registro_C590> RegistroC590List { get; set; }
        public List<Registro_C591> RegistroC591List { get; set; }
        public List<Registro_C595> RegistroC595List { get; set; }
        public List<Registro_C597> RegistroC597List { get; set; }
        public List<Registro_C600> RegistroC600List { get; set; }
        public List<Registro_C601> RegistroC601List { get; set; }
        public List<Registro_C610> RegistroC610List { get; set; }
        public List<Registro_C690> RegistroC690List { get; set; }
        public List<Registro_C700> RegistroC700List { get; set; }
        public List<Registro_C790> RegistroC790List { get; set; }
        public List<Registro_C791> RegistroC791List { get; set; }
        public List<Registro_C800> RegistroC800List { get; set; }
        public List<Registro_C810> RegistroC810List { get; set; }
        public List<Registro_C815> RegistroC815List { get; set; }
        public List<Registro_C850> RegistroC850List { get; set; }
        public List<Registro_C860> RegistroC860List { get; set; }
        public List<Registro_C870> RegistroC870List { get; set; }
        public List<Registro_C880> RegistroC880List { get; set; }
        public List<Registro_C890> RegistroC890List { get; set; }
        public Registro_C990 RegistroC990 { get; set; }
    }
}
