using EvoluzeSped.Controller.Blocos;
using EvoluzeSped.Controller.Output;
using EvoluzeSped.Model.Arquivos;
using EvoluzeSped.Model.Registros;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EvoluzeSped.Model.Registros.RegistroBloco0;
using static EvoluzeSped.Model.Registros.RegistroBloco1;
using static EvoluzeSped.Model.Registros.RegistroBloco9;
using static EvoluzeSped.Model.Registros.RegistroBlocoB;
using static EvoluzeSped.Model.Registros.RegistroBlocoC;

namespace EvoluzeSped.Controller.Input
{
    class Input_EFD_ICMS_IPI_Controller
    {
        ControllerBlocos controller;
        Sped_EFD_ICMS_IPI sped;
        
        public Sped_EFD_ICMS_IPI GetObjetoSped(string localOrigemArquivo)
        {
            sped = new Sped_EFD_ICMS_IPI();
            controller = new ControllerBlocos();

            Queue<string> linhas = new Queue<string>();
            string linha = null;
            StreamReader reader = new StreamReader(localOrigemArquivo, Encoding.Default);
            while ((linha = reader.ReadLine()) != null)
            {
                linhas.Enqueue(linha);
                validaRegistro(linha);
            }
            reader.Close();


            return sped;

        }


        private void validaRegistro(string linha)
        {
            string[] array = linha.Split('|');
            string bloco = array[1].Substring(0, 1);

            switch (bloco)
            {
                case "0":
                    processaBloco0(array[1], linha);
                    break;
                case "1":
                    processaBloco1(array[1], linha);
                    break;
                case "9":
                    processaBloco9(array[1], linha);
                    break;
                case "B":
                    processaBlocoB(array[1], linha);
                    break;
                case "C":
                    processaBlocoC(array[1], linha);
                    break;
                case "D":
//                    processaBlocoD(array[1], linha);
                    break;
                case "E":
//                    processaBlocoE(array[1], linha);
                    break;
                case "G":
//                    processaBlocoG(array[1], linha);
                    break;
                case "H":
//                    processaBlocoH(array[1], linha);
                    break;
                case "K":
//                    processaBlocoK(array[1], linha);
                    break;
            }

        }

        private void processaBloco0(string registro, string linha)
        {
            switch (registro)
            {
                case "0000":
                    sped.Bloco0.Registro0000 = (Registro_0000) controller.GetRegistro(linha, new Registro_0000());
                    break;
                case "0001":
                    sped.Bloco0.Registro0001 = (Registro_0001)controller.GetRegistro(linha, new Registro_0001());
                    break;
                case "0002":
                    sped.Bloco0.Registro0002 = (Registro_0002)controller.GetRegistro(linha, new Registro_0002());
                    break;
                case "0005":
                    sped.Bloco0.Registro0005 = (Registro_0005)controller.GetRegistro(linha, new Registro_0005());
                    break;
                case "0015":
                    sped.Bloco0.Registro0015List.Add((Registro_0015) controller.GetRegistro(linha, new Registro_0015()));
                    break;
                case "0100":
                    sped.Bloco0.Registro0100List.Add((Registro_0100) controller.GetRegistro(linha, new Registro_0100()));
                    break;
                case "0150":
                    sped.Bloco0.Registro0150List.Add((Registro_0150) controller.GetRegistro(linha, new Registro_0150()));
                    break;
                case "0175":
                    sped.Bloco0.Registro0175List.Add((Registro_0175) controller.GetRegistro(linha, new Registro_0175()));
                    break;                                           
                case "0190":                                         
                    sped.Bloco0.Registro0190List.Add((Registro_0190) controller.GetRegistro(linha, new Registro_0190()));
                    break;                                           
                case "0200":                                         
                    sped.Bloco0.Registro0200List.Add((Registro_0200) controller.GetRegistro(linha, new Registro_0200()));
                    break;                                           
                case "0205":                                         
                    sped.Bloco0.Registro0205List.Add((Registro_0205) controller.GetRegistro(linha, new Registro_0205()));
                    break;                                           
                case "0206":                                         
                    sped.Bloco0.Registro0206List.Add((Registro_0206) controller.GetRegistro(linha, new Registro_0206()));
                    break;                                           
                case "0210":                                         
                    sped.Bloco0.Registro0210List.Add((Registro_0210) controller.GetRegistro(linha, new Registro_0210()));
                    break;
                case "0220":
                    sped.Bloco0.Registro0220List.Add((Registro_0220) controller.GetRegistro(linha, new Registro_0220()));
                    break;                                           
                case "0300":                                         
                    sped.Bloco0.Registro0300List.Add((Registro_0300) controller.GetRegistro(linha, new Registro_0300()));
                    break;                                           
                case "0305":                                         
                    sped.Bloco0.Registro0305List.Add((Registro_0305) controller.GetRegistro(linha, new Registro_0305()));
                    break;                                           
                case "0450":                                         
                    sped.Bloco0.Registro0450List.Add((Registro_0450) controller.GetRegistro(linha, new Registro_0450()));
                    break;                                           
                case "0460":                                         
                    sped.Bloco0.Registro0460List.Add((Registro_0460) controller.GetRegistro(linha, new Registro_0460()));
                    break;
                case "0500": sped.Bloco0.Registro0500List.Add((Registro_0500) controller.GetRegistro(linha, new Registro_0500())); break;
                case "0600":
                    sped.Bloco0.Registro0600List.Add((Registro_0600) controller.GetRegistro(linha, new Registro_0600()));
                    break;
                case "0990":
                    sped.Bloco0.Registro0990 = (Registro_0990) controller.GetRegistro(linha, new Registro_0990());
                    break;
            }
        }

        private void processaBloco1(string registro, string linha)
        {
            switch (registro)
            {
                case "1001":
                    sped.Bloco1.Registro1001 = (Registro_1001) controller.GetRegistro(linha, new Registro_1001());
                    break;
                case "1010":
                    sped.Bloco1.Registro1010 = (Registro_1010) controller.GetRegistro(linha, new Registro_1010());
                    break;
                case "1100":
                    sped.Bloco1.Registro1100List.Add((Registro_1100) controller.GetRegistro(linha, new Registro_1100()));
                    break;
                case "1105":
                    sped.Bloco1.Registro1105List.Add((Registro_1105) controller.GetRegistro(linha, new Registro_1105()));
                    break;
                case "1110":
                    sped.Bloco1.Registro1110List.Add((Registro_1110)controller.GetRegistro(linha, new Registro_1110()));
                    break;
                case "1200":
                    sped.Bloco1.Registro1200List.Add((Registro_1200)controller.GetRegistro(linha, new Registro_1200()));
                    break;
                case "1210":
                    sped.Bloco1.Registro1210List.Add((Registro_1210)controller.GetRegistro(linha, new Registro_1210()));
                    break;
                case "1250":
                    sped.Bloco1.Registro1250List.Add((Registro_1250)controller.GetRegistro(linha, new Registro_1250()));
                    break;
                case "1255":
                    sped.Bloco1.Registro1255List.Add((Registro_1255)controller.GetRegistro(linha, new Registro_1255()));
                    break;
                case "1300":
                    sped.Bloco1.Registro1300List.Add((Registro_1300) controller.GetRegistro(linha, new Registro_1300()));
                    break;
                case "1310":
                    sped.Bloco1.Registro1310List.Add((Registro_1310) controller.GetRegistro(linha, new Registro_1310()));
                    break;
                case "1320":
                    sped.Bloco1.Registro1320List.Add((Registro_1320) controller.GetRegistro(linha, new Registro_1320()));
                    break;
                case "1350":
                    sped.Bloco1.Registro1350List.Add((Registro_1350) controller.GetRegistro(linha, new Registro_1350()));
                    break;
                case "1360":
                    sped.Bloco1.Registro1360List.Add((Registro_1360) controller.GetRegistro(linha, new Registro_1360()));
                    break;
                case "1370":
                    sped.Bloco1.Registro1370List.Add((Registro_1370) controller.GetRegistro(linha, new Registro_1370()));
                    break;
                case "1390":
                    sped.Bloco1.Registro1390List.Add((Registro_1390) controller.GetRegistro(linha, new Registro_1390()));
                    break;                                           
                case "1391":                                         
                    sped.Bloco1.Registro1391List.Add((Registro_1391) controller.GetRegistro(linha, new Registro_1391()));
                    break;                                           
                case "1400":                                         
                    sped.Bloco1.Registro1400List.Add((Registro_1400) controller.GetRegistro(linha, new Registro_1400()));
                    break;                                           
                case "1500":                                         
                    sped.Bloco1.Registro1500List.Add((Registro_1500) controller.GetRegistro(linha, new Registro_1500()));
                    break;                                           
                case "1510":                                         
                    sped.Bloco1.Registro1510List.Add((Registro_1510) controller.GetRegistro(linha, new Registro_1510()));
                    break;                                           
                case "1600":                                         
                    sped.Bloco1.Registro1600List.Add((Registro_1600) controller.GetRegistro(linha, new Registro_1600()));
                    break;                                           
                case "1700":                                         
                    sped.Bloco1.Registro1700List.Add((Registro_1700) controller.GetRegistro(linha, new Registro_1700()));
                    break;                                           
                case "1710":                                         
                    sped.Bloco1.Registro1710List.Add((Registro_1710) controller.GetRegistro(linha, new Registro_1710()));
                    break;                                           
                case "1800":                                         
                    sped.Bloco1.Registro1800List.Add((Registro_1800) controller.GetRegistro(linha, new Registro_1800()));
                    break;                                           
                case "1900":                                         
                    sped.Bloco1.Registro1900List.Add((Registro_1900) controller.GetRegistro(linha, new Registro_1900()));
                    break;                                           
                case "1910":                                         
                    sped.Bloco1.Registro1910List.Add((Registro_1910) controller.GetRegistro(linha, new Registro_1910()));
                    break;                                           
                case "1920":                                         
                    sped.Bloco1.Registro1920List.Add((Registro_1920) controller.GetRegistro(linha, new Registro_1920()));
                    break;                                           
                case "1921":                                         
                    sped.Bloco1.Registro1921List.Add((Registro_1921) controller.GetRegistro(linha, new Registro_1921()));
                    break;                                           
                case "1922":                                         
                    sped.Bloco1.Registro1922List.Add((Registro_1922) controller.GetRegistro(linha, new Registro_1922()));
                    break;                                           
                case "1923":                                         
                    sped.Bloco1.Registro1923List.Add((Registro_1923) controller.GetRegistro(linha, new Registro_1923()));
                    break;                                           
                case "1925":                                         
                    sped.Bloco1.Registro1925List.Add((Registro_1925) controller.GetRegistro(linha, new Registro_1925()));
                    break;                                           
                case "1926":                                         
                    sped.Bloco1.Registro1926List.Add((Registro_1926) controller.GetRegistro(linha, new Registro_1926()));
                    break;                                           
                case "1960":                                         
                    sped.Bloco1.Registro1960List.Add((Registro_1960) controller.GetRegistro(linha, new Registro_1960()));
                    break;                                           
                case "1970":                                         
                    sped.Bloco1.Registro1970List.Add((Registro_1970) controller.GetRegistro(linha, new Registro_1970()));
                    break;                                           
                case "1975":                                         
                    sped.Bloco1.Registro1975List.Add((Registro_1975) controller.GetRegistro(linha, new Registro_1975()));
                    break;                                           
                case "1980":                                         
                    sped.Bloco1.Registro1980List.Add((Registro_1980) controller.GetRegistro(linha, new Registro_1980()));
                    break;
                case "1990":
                    sped.Bloco1.Registro1990 = (Registro_1990) controller.GetRegistro(linha, new Registro_1990());
                    break;
            }
        }

        private void processaBlocoB(string registro, string linha)
        {
            switch (registro)
            {
                case "B001":
                    sped.BlocoB.RegistroB001 = (Registro_B001) controller.GetRegistro(linha, new Registro_B001());
                    break;
                case "B020":
                    sped.BlocoB.RegistroB020List.Add((Registro_B020) controller.GetRegistro(linha, new Registro_B020()));
                    break;
                case "B025":
                    sped.BlocoB.RegistroB025List.Add((Registro_B025) controller.GetRegistro(linha, new Registro_B025()));
                    break;
                case "B030":
                    sped.BlocoB.RegistroB030List.Add((Registro_B030) controller.GetRegistro(linha, new Registro_B030()));
                    break;
                case "B035":
                    sped.BlocoB.RegistroB035List.Add((Registro_B035) controller.GetRegistro(linha, new Registro_B035()));
                    break;
                case "B350":
                    sped.BlocoB.RegistroB350List.Add((Registro_B350) controller.GetRegistro(linha, new Registro_B350()));
                    break;
                case "B420":
                    sped.BlocoB.RegistroB420List.Add((Registro_B420) controller.GetRegistro(linha, new Registro_B420()));
                    break;
                case "B440":
                    sped.BlocoB.RegistroB440List.Add((Registro_B440) controller.GetRegistro(linha, new Registro_B440()));
                    break;
                case "B460":
                    sped.BlocoB.RegistroB460List.Add((Registro_B460) controller.GetRegistro(linha, new Registro_B460()));
                    break;
                case "B470":
                    sped.BlocoB.RegistroB470 = (Registro_B470) controller.GetRegistro(linha, new Registro_B470());
                    break;
                case "B500":
                    sped.BlocoB.RegistroB500 = (Registro_B500) controller.GetRegistro(linha, new Registro_B500());
                    break;
                case "B510":
                    sped.BlocoB.RegistroB510List.Add((Registro_B510) controller.GetRegistro(linha, new Registro_B510()));
                    break;
                case "B990":
                    sped.BlocoB.RegistroB990 = (Registro_B990) controller.GetRegistro(linha, new Registro_B990());
                    break;
            }
        }

        private void processaBlocoC(string registro, string linha)
        {
            switch (registro)
            {
                case "C001": 
                    sped.BlocoC.RegistroC001 = (Registro_C001)controller.GetRegistro(linha, new Registro_C001()); 
                    break;
                case "C100": 
                    sped.BlocoC.RegistroC100List.Add((Registro_C100)controller.GetRegistro(linha, new Registro_C100())); 
                    break;
                case "C101": 
                    sped.BlocoC.RegistroC101List.Add((Registro_C101)controller.GetRegistro(linha, new Registro_C101())); 
                    break;
                case "C105": 
                    sped.BlocoC.RegistroC105List.Add((Registro_C105)controller.GetRegistro(linha, new Registro_C105())); 
                    break;
                case "C110": 
                    sped.BlocoC.RegistroC110List.Add((Registro_C110)controller.GetRegistro(linha, new Registro_C110())); 
                    break;
                case "C111": 
                    sped.BlocoC.RegistroC111List.Add((Registro_C111)controller.GetRegistro(linha, new Registro_C111())); 
                    break;
                case "C112": 
                    sped.BlocoC.RegistroC112List.Add((Registro_C112)controller.GetRegistro(linha, new Registro_C112())); 
                    break;
                case "C113": 
                    sped.BlocoC.RegistroC113List.Add((Registro_C113)controller.GetRegistro(linha, new Registro_C113())); 
                    break;
                case "C114": 
                    sped.BlocoC.RegistroC114List.Add((Registro_C114)controller.GetRegistro(linha, new Registro_C114())); 
                    break;
                case "C115": 
                    sped.BlocoC.RegistroC115List.Add((Registro_C115)controller.GetRegistro(linha, new Registro_C115())); 
                    break;
                case "C116": 
                    sped.BlocoC.RegistroC116List.Add((Registro_C116)controller.GetRegistro(linha, new Registro_C116())); 
                    break;
                case "C120": 
                    sped.BlocoC.RegistroC120List.Add((Registro_C120)controller.GetRegistro(linha, new Registro_C120())); 
                    break;
                case "C130": 
                    sped.BlocoC.RegistroC130List.Add((Registro_C130)controller.GetRegistro(linha, new Registro_C130())); 
                    break;
                case "C140": 
                    sped.BlocoC.RegistroC140List.Add((Registro_C140)controller.GetRegistro(linha, new Registro_C140())); 
                    break;
                case "C141": 
                    sped.BlocoC.RegistroC141List.Add((Registro_C141)controller.GetRegistro(linha, new Registro_C141())); 
                    break;
                case "C160": 
                    sped.BlocoC.RegistroC160List.Add((Registro_C160)controller.GetRegistro(linha, new Registro_C160()));
                    break;
                case "C165": 
                    sped.BlocoC.RegistroC165List.Add((Registro_C165)controller.GetRegistro(linha, new Registro_C165())); 
                    break;
                case "C170": 
                    sped.BlocoC.RegistroC170List.Add((Registro_C170)controller.GetRegistro(linha, new Registro_C170())); 
                    break;
                case "C171": 
                    sped.BlocoC.RegistroC171List.Add((Registro_C171)controller.GetRegistro(linha, new Registro_C171())); 
                    break;
                case "C172": 
                    sped.BlocoC.RegistroC172List.Add((Registro_C172)controller.GetRegistro(linha, new Registro_C172())); 
                    break;
                case "C173": 
                    sped.BlocoC.RegistroC173List.Add((Registro_C173)controller.GetRegistro(linha, new Registro_C173())); 
                    break;
                case "C174": 
                    sped.BlocoC.RegistroC174List.Add((Registro_C174)controller.GetRegistro(linha, new Registro_C174())); 
                    break;
                case "C175": 
                    sped.BlocoC.RegistroC175List.Add((Registro_C175)controller.GetRegistro(linha, new Registro_C175())); 
                    break;
                case "C176": 
                    sped.BlocoC.RegistroC176List.Add((Registro_C176)controller.GetRegistro(linha, new Registro_C176())); 
                    break;
                case "C177": 
                    sped.BlocoC.RegistroC177List.Add((Registro_C177)controller.GetRegistro(linha, new Registro_C177())); 
                    break;
                case "C178": 
                    sped.BlocoC.RegistroC178List.Add((Registro_C178)controller.GetRegistro(linha, new Registro_C178())); 
                    break;
                case "C179": 
                    sped.BlocoC.RegistroC179List.Add((Registro_C179)controller.GetRegistro(linha, new Registro_C179())); 
                    break;
                case "C180": 
                    sped.BlocoC.RegistroC180List.Add((Registro_C180)controller.GetRegistro(linha, new Registro_C180())); 
                    break;
                case "C185": 
                    sped.BlocoC.RegistroC185List.Add((Registro_C185)controller.GetRegistro(linha, new Registro_C185())); 
                    break;
                case "C190": 
                    sped.BlocoC.RegistroC190List.Add((Registro_C190)controller.GetRegistro(linha, new Registro_C190())); 
                    break;
                case "C191": 
                    sped.BlocoC.RegistroC191List.Add((Registro_C191)controller.GetRegistro(linha, new Registro_C191())); 
                    break;
                case "C195": 
                    sped.BlocoC.RegistroC195List.Add((Registro_C195)controller.GetRegistro(linha, new Registro_C195())); 
                    break;
                case "C197": 
                    sped.BlocoC.RegistroC197List.Add((Registro_C197)controller.GetRegistro(linha, new Registro_C197())); 
                    break;
                case "C300": 
                    sped.BlocoC.RegistroC300List.Add((Registro_C300)controller.GetRegistro(linha, new Registro_C300())); 
                    break;
                case "C310": 
                    sped.BlocoC.RegistroC310List.Add((Registro_C310)controller.GetRegistro(linha, new Registro_C310())); 
                    break;
                case "C320": 
                    sped.BlocoC.RegistroC320List.Add((Registro_C320)controller.GetRegistro(linha, new Registro_C320())); 
                    break;
                case "C321": 
                    sped.BlocoC.RegistroC321List.Add((Registro_C321)controller.GetRegistro(linha, new Registro_C321())); 
                    break;
                case "C330": 
                    sped.BlocoC.RegistroC330List.Add((Registro_C330)controller.GetRegistro(linha, new Registro_C330())); 
                    break;
                case "C350": 
                    sped.BlocoC.RegistroC350List.Add((Registro_C350)controller.GetRegistro(linha, new Registro_C350())); 
                    break;
                case "C370": 
                    sped.BlocoC.RegistroC370List.Add((Registro_C370)controller.GetRegistro(linha, new Registro_C370())); 
                    break;
                case "C380": 
                    sped.BlocoC.RegistroC380List.Add((Registro_C380)controller.GetRegistro(linha, new Registro_C380())); 
                    break;
                case "C390": 
                    sped.BlocoC.RegistroC390List.Add((Registro_C390)controller.GetRegistro(linha, new Registro_C390())); 
                    break;
                case "C400": 
                    sped.BlocoC.RegistroC400List.Add((Registro_C400)controller.GetRegistro(linha, new Registro_C400()));
                    break;
                case "C405": 
                    sped.BlocoC.RegistroC405List.Add((Registro_C405)controller.GetRegistro(linha, new Registro_C405()));
                    break;
                case "C410": 
                    sped.BlocoC.RegistroC410List.Add((Registro_C410)controller.GetRegistro(linha, new Registro_C410()));
                    break;
                case "C420": 
                    sped.BlocoC.RegistroC420List.Add((Registro_C420)controller.GetRegistro(linha, new Registro_C420()));
                    break;
                case "C425": 
                    sped.BlocoC.RegistroC425List.Add((Registro_C425)controller.GetRegistro(linha, new Registro_C425()));
                    break;
                case "C430": 
                    sped.BlocoC.RegistroC430List.Add((Registro_C430)controller.GetRegistro(linha, new Registro_C430()));
                    break;
                case "C460": 
                    sped.BlocoC.RegistroC460List.Add((Registro_C460)controller.GetRegistro(linha, new Registro_C460()));
                    break;
                case "C465": 
                    sped.BlocoC.RegistroC465List.Add((Registro_C465)controller.GetRegistro(linha, new Registro_C465())); 
                    break;
                case "C470": 
                    sped.BlocoC.RegistroC470List.Add((Registro_C470)controller.GetRegistro(linha, new Registro_C470())); 
                    break;
                case "C480": 
                    sped.BlocoC.RegistroC480List.Add((Registro_C480)controller.GetRegistro(linha, new Registro_C480())); 
                    break;
                case "C490": 
                    sped.BlocoC.RegistroC490List.Add((Registro_C490)controller.GetRegistro(linha, new Registro_C490()));
                    break;
                case "C495": 
                    sped.BlocoC.RegistroC495List.Add((Registro_C495)controller.GetRegistro(linha, new Registro_C495())); 
                    break;
                case "C500": 
                    sped.BlocoC.RegistroC500List.Add((Registro_C500)controller.GetRegistro(linha, new Registro_C500()));
                    break;
                case "C510": 
                    sped.BlocoC.RegistroC510List.Add((Registro_C510)controller.GetRegistro(linha, new Registro_C510()));
                    break;
                case "C590": 
                    sped.BlocoC.RegistroC590List.Add((Registro_C590)controller.GetRegistro(linha, new Registro_C590())); 
                    break;
                case "C591": 
                    sped.BlocoC.RegistroC591List.Add((Registro_C591)controller.GetRegistro(linha, new Registro_C591())); 
                    break;
                case "C595": 
                    sped.BlocoC.RegistroC595List.Add((Registro_C595)controller.GetRegistro(linha, new Registro_C595())); 
                    break;
                case "C597": 
                    sped.BlocoC.RegistroC597List.Add((Registro_C597)controller.GetRegistro(linha, new Registro_C597())); 
                    break;
                case "C600": 
                    sped.BlocoC.RegistroC600List.Add((Registro_C600)controller.GetRegistro(linha, new Registro_C600())); 
                    break;
                case "C601": 
                    sped.BlocoC.RegistroC601List.Add((Registro_C601)controller.GetRegistro(linha, new Registro_C601())); 
                    break;
                case "C610": 
                    sped.BlocoC.RegistroC610List.Add((Registro_C610)controller.GetRegistro(linha, new Registro_C610())); 
                    break;
                case "C690": 
                    sped.BlocoC.RegistroC690List.Add((Registro_C690)controller.GetRegistro(linha, new Registro_C690())); 
                    break;
                case "C700": 
                    sped.BlocoC.RegistroC700List.Add((Registro_C700)controller.GetRegistro(linha, new Registro_C700()));
                    break;
                case "C790": 
                    sped.BlocoC.RegistroC790List.Add((Registro_C790)controller.GetRegistro(linha, new Registro_C790())); 
                    break;
                case "C791": 
                    sped.BlocoC.RegistroC791List.Add((Registro_C791)controller.GetRegistro(linha, new Registro_C791())); 
                    break;
                case "C800": 
                    sped.BlocoC.RegistroC800List.Add((Registro_C800)controller.GetRegistro(linha, new Registro_C800())); 
                    break;
                case "C810": 
                    sped.BlocoC.RegistroC810List.Add((Registro_C810)controller.GetRegistro(linha, new Registro_C810())); 
                    break;
                case "C815": 
                    sped.BlocoC.RegistroC815List.Add((Registro_C815)controller.GetRegistro(linha, new Registro_C815())); 
                    break;
                case "C850": 
                    sped.BlocoC.RegistroC850List.Add((Registro_C850)controller.GetRegistro(linha, new Registro_C850())); 
                    break;
                case "C860": 
                    sped.BlocoC.RegistroC860List.Add((Registro_C860)controller.GetRegistro(linha, new Registro_C860())); 
                    break;
                case "C870": 
                    sped.BlocoC.RegistroC870List.Add((Registro_C870)controller.GetRegistro(linha, new Registro_C870())); 
                    break;
                case "C880": 
                    sped.BlocoC.RegistroC880List.Add((Registro_C880)controller.GetRegistro(linha, new Registro_C880())); 
                    break;
                case "C890": 
                    sped.BlocoC.RegistroC890List.Add((Registro_C890)controller.GetRegistro(linha, new Registro_C890())); 
                    break;
                case "C990": 
                    sped.BlocoC.RegistroC990 = (Registro_C990)controller.GetRegistro(linha, new Registro_C990()); 
                    break;
            }
        }
        private void processaBloco9(string registro, string linha)
        {
            switch (registro)
            {
                case "9001":
                    sped.Bloco9.Registro9001 = (Registro_9001)controller.GetRegistro(linha, new Registro_9001());
                    break;
                case "9900":
                    sped.Bloco9.Registro9900List.Add((Registro_9900)controller.GetRegistro(linha, new Registro_9900()));
                    break;
                case "9990":
                    sped.Bloco9.Registro9990 = (Registro_9990)controller.GetRegistro(linha, new Registro_9990());
                    break;
                case "9999":
                    sped.Bloco9.Registro9999 = (Registro_9999)controller.GetRegistro(linha, new Registro_9999());
                    break;
            }
        }


        /* 
                    


                    

                     private void processaBlocoK(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "K001":
                                 sped.BlocoK.RegistroK001 = controller.BlocoK.GetRegistroK001(linha);
                                 break;
                             case "K990":
                                 sped.BlocoK.RegistroK990 = controller.BlocoK.GetRegistroK990(linha);
                                 break;
                         }
                     }
                     private void processaBlocoH(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "H001":
                                 sped.BlocoH.RegistroH001 = controller.BlocoH.GetRegistroH001(linha);
                                 break;
                             case "H990":
                                 sped.BlocoH.RegistroH990 = controller.BlocoH.GetRegistroH990(linha);
                                 break;
                         }
                     }

                     private void processaBlocoG(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "G001":
                                 sped.BlocoG.RegistroG001 = controller.BlocoG.GetRegistroG001(linha);
                                 break;
                             case "G110":
                                 sped.BlocoG.RegistroG110List.Add(controller.BlocoG.GetRegistroG110(linha));
                                 break;
                             case "G125":
                                 sped.BlocoG.RegistroG125List.Add(controller.BlocoG.GetRegistroG125(linha));
                                 break;
                             case "G990":
                                 sped.BlocoG.RegistroG990 = controller.BlocoG.GetRegistroG990(linha);
                                 break;
                         }
                     }

                     private void processaBlocoE(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "E001":
                                 sped.BlocoE.RegistroE001 = controller.BlocoE.GetRegistroE001(linha);
                                 break;
                             case "E100":
                                 sped.BlocoE.RegistroE100List.Add(controller.BlocoE.GetRegistroE100(linha));
                                 break;
                             case "E110":
                                 sped.BlocoE.RegistroE110List.Add(controller.BlocoE.GetRegistroE110(linha));
                                 break;
                             case "E111":
                                 sped.BlocoE.RegistroE111List.Add(controller.BlocoE.GetRegistroE111(linha));
                                 break;
                             case "E990":
                                 sped.BlocoE.RegistroE990 = controller.BlocoE.GetRegistroE990(linha);
                                 break;
                         }
                     }

                     private void processaBlocoD(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "D001":
                                 sped.BlocoD.RegistroD001 = controller.BlocoD.GetRegistroD001(linha);
                                 break;
                             case "D500":
                                 sped.BlocoD.RegistroD500List.Add(controller.BlocoD.GetRegistroD500(linha));
                                 break;
                             case "D590":
                                 sped.BlocoD.RegistroD590List.Add(controller.BlocoD.GetRegistroD590(linha));
                                 break;
                             case "D990":
                                 sped.BlocoD.RegistroD990 = controller.BlocoD.GetRegistroD990(linha);
                                 break;
                         }
                     }

                     

                     private void processaBlocoB(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "B001":
                                 sped.BlocoB.RegistroB001 = controller.BlocoB.GetRegistroB001(linha);
                                 break;
                             case "B990":
                                 sped.BlocoB.RegistroB990 = controller.BlocoB.GetRegistroB990(linha);
                                 break;
                         }
                     }

                     public void addListaRegistro(string key, int value)
                     {
                         //listRegistros.Remove(key);
                         //listRegistros.Add(key, value);
                     }
             */

    }
}
