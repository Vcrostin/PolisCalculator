using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Logic.Transformtopolis
{
    public class PriorityInfo
    {
        public string Txt { get; }
        public bool Unary { get; set; } = false;
        public int Priority { get; set; }
        public PriorityInfo(string txt)
        {
            Txt = txt;
            Priority = GetPrior(txt);
        }

        private int GetPrior(string txt)
        {
            switch (txt)
            {
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "sin":
                case "cos":
                case "tg":
                case "ctg":
                    Unary = true;
                    return 2;
                case "*":
                case "/":
                    return 2;
                case "^":
                case "|":
                case "&":
                    return 3;
                default:
                    throw new ArgumentException("Проверьте написание строки",nameof(txt));
            }
        }
    }
}
