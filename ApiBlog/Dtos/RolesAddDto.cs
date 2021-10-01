using Models.Enumeration;

namespace ApiBlog.Dtos
{
    public class RolesAddDto
    {
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public TipoRol TipoRol { get; set; }
    }
}