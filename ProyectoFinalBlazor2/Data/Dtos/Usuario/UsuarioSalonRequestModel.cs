namespace ProyectoFinalBlazor2.Data.Dtos.Usuario
{
    public class UsuarioSalonRequestModel
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        public int RoleId { get; set; }
    }
}
