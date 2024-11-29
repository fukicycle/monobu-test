using System.ComponentModel.DataAnnotations;

namespace monobu_test.Models;

public sealed class QuestionModel
{
    public QuestionModel(string question, IReadOnlyCollection<QuestionCondition> questionConditions)
    {
        Question = question;
        Conditions = questionConditions;
    }
    [Required]
    public string Id { get; } = Guid.NewGuid().ToString();
    public string Question { get; }
    public IReadOnlyCollection<QuestionCondition> Conditions { get; }
    [Required(ErrorMessage = "回答を入力してください。")]
    public string Answer { get; set; } = string.Empty;
    public bool IsConfirm { get; set; } = false;
}