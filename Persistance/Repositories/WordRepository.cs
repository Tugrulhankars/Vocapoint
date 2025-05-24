using Core.Repositories;
using Domain.Entities;
using Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories;

public class WordRepository : EfRepositoryBase<Word, long, DatabaseContext>
{
    public WordRepository(DatabaseContext context) : base(context)
    {
    }
}
