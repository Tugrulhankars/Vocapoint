using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Commands.Create;

public class CreateWordResponse
{
    public string Response { get; set; }

    public CreateWordResponse(string response)
    {
        Response = response;
    }
}
