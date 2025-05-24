using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Queries.GetAll;

public class GetAllWordQueryHandler : IRequestHandler<GetAllWordQuery, List<GetAllWordResponse>>
{
    private readonly IWordRepository _wordRepository;
    private readonly IMapper _mapper;

    public GetAllWordQueryHandler(IWordRepository wordRepository, IMapper mapper)
    {
        _wordRepository = wordRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllWordResponse>> Handle(GetAllWordQuery request, CancellationToken cancellationToken)
    {
        var words = await _wordRepository.GetListAsync();
        var response = _mapper.Map<List<GetAllWordResponse>>(words);
        return response;
    }
}
