using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestingSystem
{
    class Question
    {
        // Порядковый номер вопроса в тесте
        public int serialNumber;

        // Строка вопроса
        public string name;

        // Картинка вопроса
        public Image image;

        // Список ответов
        private List<Answer> answers;

        // Количество ответов
        public int NumberAnswers { 
            get { return answers.Count; } 
        }

        // Функция добавляет в вопрос новый ответ и возвращает ссылку на него
        //
        public Answer AddAnswer()
        {
            Answer newAnswer = new Answer();
            newAnswer.serialNumber = answers.Count + 1; 
            answers.Add(newAnswer);

            return newAnswer;
        }

        //Функция удаляет ответ в вопросе
        //
        // Параметры
        //  delAnswer  - Answer - ссылка на ответ подлежащий удалению
        //
        // Возвращаемое значение:
        //   bool - true если вопрос успешно удален, false - вопрос не был удален
        //
        public bool DeleteAnswer(Answer delAnswer)
        {
            return answers.Remove(delAnswer);
        }
    
        
    }
}
