using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Models.FichaCliente
{
    public class FichaClienteRequestModel
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int UsuarioSalonEntityId { get; set; }
    }
}
