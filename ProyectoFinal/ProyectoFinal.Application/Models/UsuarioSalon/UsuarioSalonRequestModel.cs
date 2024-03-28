using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Application.Models.UsuarioSalon
{
    public class UsuarioSalonRequestModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public required string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
    }
}
