using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Word
{
    public long Id { get; set; }

    // İngilizce kelime
    public string English { get; set; }

    // Türkçe karşılığı
    public string Turkish { get; set; }

    // Seviye (örn. A1, B2 vb.)
    public string Level { get; set; } // Alternatif: Enum da kullanılabilir

    // Örn: "noun", "verb" gibi tür bilgisi eklersen daha iyi olabilir
    public string PartOfSpeech { get; set; }
}

