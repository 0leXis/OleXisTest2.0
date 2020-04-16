using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OleXisTest
{
    public struct AnswerListVariant : IAnswerListVariant
    {
        public AnswerVariations Type { get; }
        public string VariantText { get; }

        public AnswerListVariant(AnswerVariations Type, string VariantText)
        {
            this.Type = Type;
            this.VariantText = VariantText;
        }
    }

    public class AnswerListItem : IAnswerListItem
    {
        public string QuestionDescription { get; set; }
        public List<IAnswerListVariant> Variants { get; } = new List<IAnswerListVariant>();
        public int Question_score { get; set; }
        public bool IsRight { get; set; }
    }
}
