using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Word.Queries.GetAll;

public class GetAllWordQuery:IRequest<List<GetAllWordResponse>>
{
}
