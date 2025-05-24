using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Application.Features.Question.Queries.GetAllQuestionByLevel;

public class GetAllQuestionByLevelQuery:IRequest<List<GetAllQuestionByLevelResponse>>
{
    public WordLevel WordLevel { get; set; }
}
