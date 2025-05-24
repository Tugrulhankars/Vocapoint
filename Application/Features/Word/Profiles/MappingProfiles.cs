using Application.Features.Word.Commands.Create;
using Application.Features.Word.Queries.GetAll;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Profiles;
public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateWordCommand, Domain.Entities.Word>().ReverseMap();
        CreateMap<Domain.Entities.Word,GetAllWordResponse>().ReverseMap();
    }
}
