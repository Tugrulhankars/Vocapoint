using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Commands.Create;

public class CreateWordHandler : IRequestHandler<CreateWordCommand, CreateWordResponse>
{
    private readonly IWordRepository _wordRepository;
    private readonly IMapper _mapper;
    public CreateWordHandler(IWordRepository wordRepository,IMapper mapper)
    {
        _wordRepository = wordRepository;
        _mapper = mapper;
    }
    async Task<CreateWordResponse> IRequestHandler<CreateWordCommand, CreateWordResponse>.Handle(CreateWordCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Word word = _mapper.Map<Domain.Entities.Word>(request);
        await _wordRepository.AddAsync(word);
        return new CreateWordResponse("İşlem Başarılı");
    }
}
