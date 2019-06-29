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
                /*case "sin":
                case "cos":
                case "tg":
                case "ctg":
                    break;*/
                case "(":
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                default:
                    throw new ArgumentException("Проверьте написание строки",nameof(txt));
            }
        }
    }
}
