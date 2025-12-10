using System;

namespace SimpleKnowledge.Models;

public class AnswerRecord
{
    public string? UserAnswer { get; set; } = null;
    public DateTime AnsweredAt { get; set; } = DateTime.UtcNow;
}
