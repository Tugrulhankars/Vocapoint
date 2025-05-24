using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Queries.GetAllQuestionByLevel;

public class QuestionOptionResponse
{
    public long Id { get; set; }
    public string English { get; set; }
    public string Turkish { get; set; }
} 