using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class QuestionOption
{
    public long Id { get; set; }

    public long QuestionId { get; set; }
    public Question Question { get; set; }

    public long WordId { get; set; }
    public Word Word { get; set; }
}
