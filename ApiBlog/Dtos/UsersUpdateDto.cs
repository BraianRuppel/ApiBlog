using System;

namespace ApiBlog.Dtos
{
    public class UsersUpdateDto
    {
        public Guid Id { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public bool Activo { get; set; }
        public Guid RolId  { get; set; }
    }
}
