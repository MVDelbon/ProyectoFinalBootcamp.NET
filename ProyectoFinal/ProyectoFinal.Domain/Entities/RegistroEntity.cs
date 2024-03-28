using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Domain.Entities
{
    public class RegistroEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

       
        public int FichaClienteEntityId { get; set; }
        //Propiedad de navegacion
        public FichaClienteEntity Ficha { get; set; }
    }
}
