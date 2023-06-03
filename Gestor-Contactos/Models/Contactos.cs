namespace Gestor_Contactos.Models
{
    // Modelo con clase para los contactos a crear.
    public class Contactos
    {
        public int Id { get; set; }
        public string Id_usuario { get; set; }
        public bool Favorito { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NumTel { get; set; }
        public string Trabajo { get; set; }
        public string Correo { get; set; }
        public string Grupo { get; set; }
        public string Direccion { get; set; }
        public string Relacion { get; set; }
        public string Notas { get; set; }
        public string FechaCreacion { get; set; }

        public Contactos() { }
    }
}
