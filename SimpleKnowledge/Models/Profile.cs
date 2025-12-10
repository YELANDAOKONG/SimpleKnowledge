using System.Collections.Generic;

namespace SimpleKnowledge.Models;

public class Profile
{
    public string Title { get; set; } = string.Empty;
    public List<QuestionBank> Banks { get; set; } = new();
}