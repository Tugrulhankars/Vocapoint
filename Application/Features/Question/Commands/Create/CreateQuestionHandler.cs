using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Question.Commands.Create;

public class CreateQuestionHandler : IRequestHandler<CreateQuestionCommand, CreateQuestionResponse>
{
    public Task<CreateQuestionResponse> Handle(CreateQuestionCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
