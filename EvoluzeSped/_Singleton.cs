using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped
{
    public class _Singleton
    {
        private static _Singleton instance;
        private _Singleton()
        {
        }

        public static _Singleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new _Singleton();
                }
                return instance;
            }
        }

        /* ProgressBar */
        public bool processandoArquivo = true;
        public int linhaAtualArquivo = 0;
        public int linhaTotalArquivo = 0;
        
    }
}
