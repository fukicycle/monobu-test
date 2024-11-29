namespace monobu_test.Models;

public sealed class QuestionCondition
{
    public QuestionCondition(string property, string value)
    {
        Property = property;
        Value = value;
    }
    public string Property { get; }
    public string Value { get; }
}

