using System;

namespace SimpleKnowledge.Models;

public class QuestionStats
{
    public int CorrectCount { get; set; }
    public int WrongCount { get; set; }
    public DateTime? LastAnswered { get; set; }
    public bool IsMarked { get; set; }
}