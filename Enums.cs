using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mee
{
    public class Enums
    {
        public enum Status
        {
            Случай_снят,
            Случай_не_снят
        }

        public enum EditType
        {
            Нет_дефектов,
            Есть_дефект_МЭЭ,
            Есть_дефект_ЭКМП,
            Удалить_заключение
        }
    }
}
