using Models.Enumeration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiBlog.Dtos
{
    public class PostsResponseDto
    {
        public Guid Id { get; set; }
        public string Tittle { get; set; }
        public string Post { get; set; }
        public EstadoPost Status { get; set; }
        public DateTime SubmitedDate { get; set; }
        public UsersResponseDto SubmitedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public UsersResponseDto UpdatedBy { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool Activo { get; set; }
        public ICollection<CommentsResponseDto> Comments { get; set; }
    }
}
