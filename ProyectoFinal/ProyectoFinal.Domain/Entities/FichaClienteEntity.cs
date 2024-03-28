using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Entities
{
    public class FichaClienteEntity : BaseEntity
    {
        [Key]
        public int FichaClienteEntityId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }

        public List<RegistroEntity> Registros { get; set; }

        public UsuarioSalonEntity Salon { get; set; }
        public int UsuarioSalonEntityId { get; set; }
    }
}
