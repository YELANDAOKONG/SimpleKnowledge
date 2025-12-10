using System;
using System.Collections.Generic;

namespace SimpleKnowledge.Models;

public class Question
{
    public Guid Id { get; set; } = Guid.Empty;
    public string Content { get; set; } = string.Empty;
    public Dictionary<string, string> Options { get; set; } = new();
    public string CorrectAnswer { get; set; } = string.Empty;
    public string? Explanation { get; set; }
}