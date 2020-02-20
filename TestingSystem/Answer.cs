using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestingSystem
{
    class Answer
    {
        // порядковый номер ответа в вопросе
        public int serialNumber;

        // Строка ответа
        public string name;

        // Картинка ответа
        public Image image;

        // Признак правильного ответа
        bool correct;

    }
}
