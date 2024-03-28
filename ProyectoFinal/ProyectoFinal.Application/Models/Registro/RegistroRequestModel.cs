using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Models.Registro
{
    public class RegistroRequestModel
    {
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public int FichaClienteEntityId { get; set; }
    }
}
