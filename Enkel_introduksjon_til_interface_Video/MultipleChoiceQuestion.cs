﻿namespace Enkel_introduksjon_til_interface_Video
{
    internal class MultipleChoiceQuestion : IQuestion
    {
        private readonly string _question;
        private readonly string[] _answers;
        private readonly int _correctAnswerNo;

        public MultipleChoiceQuestion(string question, int correctAnswerNo, params string[] answers)
        {
            _question = question;
            _correctAnswerNo = correctAnswerNo;
            _answers = answers;
        }

        public bool Run()
        {
            Console.WriteLine(_question);
            Console.WriteLine("Svaralternativer:");
            for (int index = 0; index < _answers.Length; index++)
            {
                var answerNo = index + 1;
                var answer = _answers[index];
                Console.WriteLine(answerNo + ": " + answer);
            }

            Console.WriteLine("Velg svaralternativ: ");
            var selectedAnswerNoStr = Console.ReadLine();
            var selectedAnswerNo = Convert.ToInt32(selectedAnswerNoStr);
            return selectedAnswerNo == _correctAnswerNo;

        }
    }
}