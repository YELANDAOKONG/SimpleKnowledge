using System;
using System.Collections.Generic;

namespace SimpleKnowledge.Models;

public class QuestionBank
{
    public Guid Id { get; set; } = Guid.Empty;
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Question> Questions { get; set; } = new();
    public Dictionary<Guid, QuestionStats> QuestionStats { get; set; } = new();
}