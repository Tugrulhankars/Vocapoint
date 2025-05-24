using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Queries.GetAllQuestionByLevel;

public class GetAllQuestionByLevelResponse
{
    public long Id { get; set; }
    public string English { get; set; }
    public string Turkish { get; set; }
    public string Level { get; set; }
    public string PartOfSpeech { get; set; }
    public List<QuestionOptionResponse> Options { get; set; }
    public long CorrectAnswerId { get; set; }
}
