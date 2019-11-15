using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Block
    {
        public bool mine = false;
        public int flag = 0; //0-нет флага 1-флаг 2-вопрос 3-клетка открыта
        public int count = 0; //кол-во бомб вокруг клетки
    }
}
