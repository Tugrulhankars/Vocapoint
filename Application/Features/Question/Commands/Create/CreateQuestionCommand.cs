using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Commands.Create;

public class CreateQuestionCommand:IRequest<CreateQuestionResponse>
{
}
