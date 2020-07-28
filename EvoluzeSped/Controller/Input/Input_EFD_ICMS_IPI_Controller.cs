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
//                    processaBloco9(array[1], linha);
                    break;
                case "B":
//                    processaBlocoB(array[1], linha);
                    break;
                case "C":
//                    processaBlocoC(array[1], linha);
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
                case "0500":
                    sped.Bloco0.Registro0500List.Add((Registro_0500) controller.GetRegistro(linha, new Registro_0500()));
                    break;
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
                    break;
                case "1200":
                    break;
                case "1210":
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
                    break;
                case "1391":
                    break;
                case "1400":
                    break;
                case "1500":
                    break;
                case "1510":
                    break;
                case "1600":
                    break;
                case "1700":
                    break;
                case "1710":
                    break;
                case "1800":
                    break;
                case "1900":
                    break;
                case "1910":
                    break;
                case "1920":
                    break;
                case "1921":
                    break;
                case "1922":
                    break;
                case "1923":
                    break;
                case "1925":
                    break;
                case "1926":
                    break;
                case "1960":
                    break;
                case "1970":
                    break;
                case "1975":
                    break;
                case "1980":
                    break;
                case "1990":
                    sped.Bloco1.Registro1990 = (Registro_1990)controller.GetRegistro(linha, new Registro_1990());
                    break;
            }
        }


        /* 
                     private void processaBloco9(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "9001":
                                 sped.Bloco9.Registro9001 = controller.Bloco9.GetRegistro9001(linha);
                                 break;
                             case "9900":
                                 sped.Bloco9.Registro9900.Add(controller.Bloco9.GetRegistro9900(linha));
                                 break;
                             case "9990":
                                 sped.Bloco9.Registro9990 = controller.Bloco9.GetRegistro9990(linha);
                                 break;
                             case "9999":
                                 sped.Bloco9.Registro9999 = controller.Bloco9.GetRegistro9999(linha);
                                 break;
                         }
                     }


                     private void processaBloco1(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "1001":
                                 sped.Bloco1.Registro1001 = controller.Bloco1.GetRegistro1001(linha);
                                 break;
                             case "1010":
                                 sped.Bloco1.Registro1010.Add(controller.Bloco1.GetRegistro1010(linha));
                                 break;
                             case "1300":
                                 sped.Bloco1.Registro1300.Add(controller.Bloco1.GetRegistro1300(linha));
                                 break;
                             case "1310":
                                 sped.Bloco1.Registro1310.Add(controller.Bloco1.GetRegistro1310(linha));
                                 break;
                             case "1320":
                                 sped.Bloco1.Registro1320.Add(controller.Bloco1.GetRegistro1320(linha));
                                 break;
                             case "1350":
                                 sped.Bloco1.Registro1350.Add(controller.Bloco1.GetRegistro1350(linha));
                                 break;
                             case "1360":
                                 sped.Bloco1.Registro1360.Add(controller.Bloco1.GetRegistro1360(linha));
                                 break;
                             case "1370":
                                 sped.Bloco1.Registro1370.Add(controller.Bloco1.GetRegistro1370(linha));
                                 break;
                             case "1990":
                                 sped.Bloco1.Registro1990 = controller.Bloco1.GetRegistro1990(linha);
                                 break;
                         }
                     }

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

                     private void processaBlocoC(string registro, string linha)
                     {
                         switch (registro)
                         {
                             case "C001":
                                 sped.BlocoC.RegistroC001 = controller.BlocoC.GetRegistroC001(linha);
                                 break;
                             case "C100":
                                 sped.BlocoC.RegistroC100List.Add(controller.BlocoC.GetRegistroC100(linha));
                                 break;
                             case "C110":
                                 sped.BlocoC.RegistroC110List.Add(controller.BlocoC.GetRegistroC110(linha));
                                 break;
                             case "C114":
                                 sped.BlocoC.RegistroC114List.Add(controller.BlocoC.GetRegistroC114(linha));
                                 break;
                             case "C170":
                                 sped.BlocoC.RegistroC170List.Add(controller.BlocoC.GetRegistroC170(linha));
                                 break;
                             case "C171":
                                 sped.BlocoC.RegistroC171List.Add(controller.BlocoC.GetRegistroC171(linha));
                                 break;
                             case "C190":
                                 sped.BlocoC.RegistroC190List.Add(controller.BlocoC.GetRegistroC190(linha));
                                 break;
                             case "C195":
                                 sped.BlocoC.RegistroC195List.Add(controller.BlocoC.GetRegistroC195(linha));
                                 break;
                             case "C197":
                                 sped.BlocoC.RegistroC197List.Add(controller.BlocoC.GetRegistroC197(linha));
                                 break;
                             case "C400":
                                 sped.BlocoC.RegistroC400List.Add(controller.BlocoC.GetRegistroC400(linha));
                                 break;
                             case "C405":
                                 sped.BlocoC.RegistroC405List.Add(controller.BlocoC.GetRegistroC405(linha));
                                 break;
                             case "C410":
                                 sped.BlocoC.RegistroC410List.Add(controller.BlocoC.GetRegistroC410(linha));
                                 break;
                             case "C420":
                                 sped.BlocoC.RegistroC420List.Add(controller.BlocoC.GetRegistroC420(linha));
                                 break;
                             case "C425":
                                 sped.BlocoC.RegistroC425List.Add(controller.BlocoC.GetRegistroC425(linha));
                                 break;
                             case "C490":
                                 sped.BlocoC.RegistroC490List.Add(controller.BlocoC.GetRegistroC490(linha));
                                 break;
                             case "C500":
                                 sped.BlocoC.RegistroC500List.Add(controller.BlocoC.GetRegistroC500(linha));
                                 break;
                             case "C590":
                                 sped.BlocoC.RegistroC590List.Add(controller.BlocoC.GetRegistroC590(linha));
                                 break;
                             case "C990":
                                 sped.BlocoC.RegistroC990 = controller.BlocoC.GetRegistroC990(linha);
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
