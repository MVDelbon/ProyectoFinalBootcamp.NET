using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Entities
{
    public class UsuarioSalonEntity : BaseEntity
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public required string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
        public RoleEntity? Role { get; set; }

        public List<FichaClienteEntity> Fichas { get; set; }
    }
}
