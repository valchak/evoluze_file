
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Database
{
    public class BancoLiteDB
    {
        private static string NomeBanco = "banco.db";
        private static string Tipo = "parametros";
        public string setParametros(Parametro obj)
        {
            try
            {
                using (var db = new LiteDatabase(NomeBanco))
                {
                    var data = db.GetCollection<Parametro>(Tipo);
                    data.Update(obj);
                    return "Parametro salvo com sucesso" ;
                }
            } catch(Exception ex)
            {
                return "Erro ao salvar os parametros: " + ex.Message;

            }
            
        }

        public Parametro getParametros(string id)
        {
            if(id.Equals(""))
            {
                id = new Parametro().Id;
            }
            using (var db = new LiteDatabase(NomeBanco))
            {
                var data = db.GetCollection<Parametro>(Tipo);
                try
                {
                    return data.Find(x => x.Id == id).First();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    data.Insert(new Parametro());
                    return data.Find(x => x.Id == id).First();
                }
            }
        }
    }
}
