using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingSystem
{
    class Test
    {
        public string name;
        private int Id;
        private List<Question> questions;

        // Конструктор по умолчанию
        //
        public Test()
        {
            name = "";
            questions = new List<Question>();
        }

        // Конструктор 
        //
        public Test(string _name, List<Question> _ListQuestions)
        {
            name = _name;
            questions = _ListQuestions;
        }

        //Функция в тест добавляет новый вопрос и возвращает ссылку на него
        //
        public Question AddQuestion()
        {
            Question newQuestion = new Question();
            questions.Add(newQuestion);

            return newQuestion;
        }

        //Функция удаляет вопрос в тесте
        //
        // Параметры
        //  delQuestion  - Question - ссылка на вопрос подлежащий удалению
        //
        // Возвращаемое значение:
        //   bool - true если вопрос успешно удален, false - вопрос не был удален
        //
        public bool DeleteQuestion(Question delQuestion)
        {
            return questions.Remove(delQuestion);
        }

         

    }
}
