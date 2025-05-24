using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string PasswordHash { get; set; }

    public int Score { get; set; } // Kullanıcının kazandığı toplam puan

    public int CorrectAnswers { get; set; }

    public int TotalQuestions { get; set; }

    // Hesap oluşturma zamanı vs. de eklenebilir
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
