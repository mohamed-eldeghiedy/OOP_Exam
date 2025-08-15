﻿using System;
using System.Collections.Generic;


namespace OOP_Exam
{
    public class Answer :ICloneable , IComparable<Answer>
    {

        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }

        public int CompareTo(Answer other)
        {
            if (other == null) return 1; 
            return AnswerId.CompareTo(other.AnswerId);
        }

        public override string ToString()
        {
            return $"AnswerId: {AnswerId}, AnswerText: {AnswerText}";
        }

    }
}
