using AutoMapper;
using Education.Application.DTO;
using Education.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.Mapping
{
    public class MappingProfilecs : Profile
    {
        public MappingProfilecs()
        {
            CreateMap<Curso, CursoDTO>();
        }
    }
}
