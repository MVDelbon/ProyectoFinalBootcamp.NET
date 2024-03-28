namespace ProyectoFinalBlazor2.Data.Dtos.Cliente
{
    public class ClienteDto
    {
        public int fichaClienteEntityId { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public int UsuarioSalonEntityId { get; set; }
        public bool IsDeleted { get; set; } = false;
    }

}