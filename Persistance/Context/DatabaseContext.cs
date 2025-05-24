using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Context;

public class DatabaseContext:DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
    {

    }

    public DbSet<Question> Questions { get; set; }
    public DbSet<Word> Words { get; set; }
    public DbSet<QuestionOption> QuestionOptions { get; set; }
}
