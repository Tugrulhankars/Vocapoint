using Core.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories;

public class QuestionOptionRepository : EfRepositoryBase<QuestionOption, long, DatabaseContext>
{
    public QuestionOptionRepository(DatabaseContext context) : base(context)
    {
    }
}
