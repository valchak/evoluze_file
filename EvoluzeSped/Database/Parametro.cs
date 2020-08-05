using EvoluzeSpedFile.Model;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvoluzeSped.Database
{
    public class Parametro: Parametros
    {
        public Parametro()
        {
            Id = "parametro";
        }
        public string Id { get; set; }
    }
}
