using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Queries.GetAllQuestionByLevel;

public class GetAllQuestionByLevelHandler : IRequestHandler<GetAllQuestionByLevelQuery, List<GetAllQuestionByLevelResponse>>
{
    private readonly IQuestionRepository _questionRepository;
    private readonly IMapper _mapper;

    public GetAllQuestionByLevelHandler(IQuestionRepository questionRepository, IMapper mapper)
    {
        _questionRepository = questionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllQuestionByLevelResponse>> Handle(GetAllQuestionByLevelQuery request, CancellationToken cancellationToken)
    {
        var level = request.WordLevel.ToString();

        // Soruları ilgili seviyeye göre, Word ve Options ile birlikte çek
        var questions = await _questionRepository.GetListAsync(
            q => q.Word.Level == level,
            include: q => q.Include(x => x.Word).Include(x => x.Options).ThenInclude(o => o.Word),
            size: 1000 // Gerekirse sınır koyabilirsin
        );

        // Sadece 4 şıklı ve tüm şıkları aynı seviyede olan soruları filtrele
        var filteredQuestions = questions.Where(q => 
            q.Options != null && 
            q.Options.Count == 4 && 
            q.Options.All(o => o.Word.Level == level)
        ).ToList();

        // Mapping
        var response = filteredQuestions.Select(q => new GetAllQuestionByLevelResponse
        {
            Id = q.Id,
            English = q.Word.English,
            Turkish = q.Word.Turkish,
            Level = q.Word.Level,
            PartOfSpeech = q.Word.PartOfSpeech,
            CorrectAnswerId = q.CorrectAnswerId,
            Options = q.Options.Select(opt => new QuestionOptionResponse
            {
                Id = opt.Id,
                English = opt.Word.English,
                Turkish = opt.Word.Turkish
            }).ToList()
        }).ToList();

        return response;
    }
}
