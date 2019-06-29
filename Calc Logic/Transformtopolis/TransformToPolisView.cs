using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Logic.Transformtopolis
{
    public class TransformToPolisView
    {
        public string CurrentString { get; set; }
        public string ExitString { get; set; } = "";
        string[] CurrentStringToArray { get; set; }
        Stack<double> Calculator { get; set; } = new Stack<double>();
        Stack<PriorityInfo> Operator { get; set; } = new Stack<PriorityInfo>();
        public TransformToPolisView(string currentString)
        {
            CurrentString = currentString;
        }

        public void Transform()
        {
            CurrentString = SpacedString(CurrentString);
            //string Operator = "";
            for(int i = 0; i < CurrentString.Length; i++)
            {
                if ((CurrentString[i] == '.') || (CurrentString[i] == ','))
                {
                    ExitString += ',';
                }
                else
                {
                    if ((CurrentString[i] >= '0') && (CurrentString[i] <= '9'))
                    {
                        ExitString += CurrentString[i];
                    }
                    else
                    {
                        if (Operator.Count > 0)
                        {

                            while ((Operator.Count > 0) && (Operator.Peek().Priority > new PriorityInfo(CurrentString[i].ToString()).Priority))
                            {
                                ExitString += " " + Operator.Pop().Txt;
                            }
                        }
                        if (CurrentString[i] == ')')
                        {
                            Operator.Pop();
                        }
                        else
                        {
                            Operator.Push(new PriorityInfo(CurrentString[i].ToString()));
                            if (ExitString.Length > 0)
                            {
                                ExitString += " ";
                            }
                        }
                    }
                }
            }
            while (Operator.Count > 0)
            {
                ExitString += " " + Operator.Pop().Txt;
            }
        }

        public string Calculate()
        {
            CurrentStringToArray = ExitString.Split(' ');
            for(int i = 0; i < CurrentStringToArray.Length; i++)
            {
                if(double.TryParse(CurrentStringToArray[i],out double Number))
                {
                    Calculator.Push(Number);
                }
                else
                {
                    var a = Calculator.Pop();
                    var b = Calculator.Pop();
                    switch (CurrentStringToArray[i])
                    {
                        case "*":
                            Calculator.Push(a * b);
                            break;
                        case "-":
                            Calculator.Push(b - a);
                            break;
                        case "+":
                            Calculator.Push(a + b);
                            break;
                        case "/":
                            Calculator.Push(b / a);
                            break;
                    }
                }
            }
            return Calculator.Pop().ToString();
        }

        private string SpacedString(string currentString)
        {
            for (int i = currentString.Length - 1; i >= 0; i--)
            {
                if (currentString[i] == ' ')
                {
                    currentString=currentString.Remove(i, 1);
                }
            }
            return currentString;
        }
    }
}
