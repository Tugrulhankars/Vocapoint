using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Commands.Create;

public class CreateWordCommand:IRequest<CreateWordResponse>
{
    public string English { get; set; }
    public string Turkish { get; set; }
    public string Level { get; set; }
    public string PartOfSpeech { get; set; }

}
