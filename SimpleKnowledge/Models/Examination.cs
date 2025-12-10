using System;
using System.Collections.Generic;

namespace SimpleKnowledge.Models;

public class Examination
{
    public Guid Id { get; set; } = Guid.Empty;
    
    public List<Question> Questions { get; set; } = new();
    public Dictionary<Guid, AnswerRecord> AnswerRecords { get; set; } = new();

    public int CurrentQuestionIndex { get; set; } = -1;
    
    public DateTime StartTime { get; set; } = DateTime.UtcNow;
    public DateTime? EndTime { get; set; }
    
    public ExaminationMode Mode { get; set; }
    public bool IsCompleted { get; set; } = false;
}