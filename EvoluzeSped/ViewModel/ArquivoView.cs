﻿using ClosedXML.Excel;
using EvoluzeSped.Database;
using EvoluzeSpedFile.Controller.Arquivos;
using EvoluzeSpedFile.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvoluzeSped.ViewModel
{
    class ArquivoView
    {
        public string origem = "" ;
        public string destino = "";
        public void GeraArquivoExcel(string localOrigemArquivSped)
        {
            Sped_EFD_ICMS_IPI_Controller controller = new Sped_EFD_ICMS_IPI_Controller();

            string arquivoInvertido = controller.InvertString(localOrigemArquivSped);
            string arquivoSped = controller.InvertString(arquivoInvertido.Substring(0, arquivoInvertido.IndexOf("\\")));
            string diretorio = localOrigemArquivSped.Replace(arquivoSped, "");


            SaveFileDialog salvarArquivoExcel = new SaveFileDialog();
            salvarArquivoExcel.InitialDirectory = (diretorio);
            salvarArquivoExcel.Title = "SPED_EXCEL";
            salvarArquivoExcel.FileName = arquivoSped.Replace(".txt", "_" + DateTime.Now.ToString("yy_MM_dd_HH_mm_ss") + ".xlsx");
            salvarArquivoExcel.ShowDialog();

            _Singleton.GetInstance.linhaAtualArquivo = 0;
            origem = localOrigemArquivSped;
            destino = salvarArquivoExcel.FileName;

            new Thread(new ThreadStart(Gera)).Start();

            //new Thread(new ThreadStart (abreTela)).Start();
            abreTela();

            //MessageBox.Show(controller.GeraExcel(localOrigemArquivSped, salvarArquivoExcel.FileName), "Aquivo Sped!", MessageBoxButtons.OK);

           
        }

        private void Gera()
        {
            
            Parametro_Sped_EFD_ICMS_IPI parametro = new BancoLiteDB().getParametros("").Parametro_Sped_EFD_ICMS_IPI;
            Sped_EFD_ICMS_IPI_Controller controller = new Sped_EFD_ICMS_IPI_Controller();
            string msg = controller.GeraExcel(origem, destino, parametro);
            _Singleton.GetInstance.processandoArquivo = false;
            MessageBox.Show(msg, "Aquivo Sped!", MessageBoxButtons.OK);
        }

        private void abreTela( )
        {
            Spleh tela = new Spleh();
            tela.ShowDialog();
            tela.Dispose();
        }
    }
}
