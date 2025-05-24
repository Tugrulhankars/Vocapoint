using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Question
{
    public long Id { get; set; }

    // Sorulan kelimenin İngilizcesi
    public long WordId { get; set; }
    public Word Word { get; set; }

    // Dört şıkkın kelime Id'leri
    public List<QuestionOption> Options { get; set; }

    // Doğru cevap hangi Word Id
    public int CorrectAnswerId { get; set; }
}

