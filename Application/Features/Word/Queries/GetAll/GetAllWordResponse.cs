using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Queries.GetAll;

public class GetAllWordResponse
{
    public string English { get; set; }
    public string Turkish { get; set; }
    public string Level { get; set; }
    public string PartOfSpeech { get; set; }
}
