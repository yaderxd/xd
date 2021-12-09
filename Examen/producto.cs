using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
   public class producto
    {
        public int Id { get; set; }
        public string  Nombre { get ; set ; }
        public string  Descripcion { get ; set ; }
        public int existencia { get; set; }
        public decimal  Precio { get ; set ; }
        public DateTime Vencimiento { get; set; }
        public enum categoria { get }
    }
}

