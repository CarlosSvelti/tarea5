using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginTarea5.Data
{
    public class SecretosModel
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string descripcion { get; set; }
        public double valor { get; set; }
        public DateTime fecha { get; set; }
        public string lugar { get; set; }
        public double latitud { get; set; }
        public double logitud { get; set; }
    }
}
