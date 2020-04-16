using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public enum AnswerVariations 
    { 
        RightAnswerChoosed, 
        WrongAnswerChoosed, 
        RightAnswerNotChoosed, 
        WrongAnswerNotChoosed 
    }
    public interface IAnswerListVariant
    {
        AnswerVariations Type { get; }
        string VariantText { get; }
    }
    public interface IAnswerListItem
    {
        string QuestionDescription { get; set; }
        List<IAnswerListVariant> Variants { get; }
        int Question_score { get; set; }
        bool IsRight { get; set; }
    }
}
