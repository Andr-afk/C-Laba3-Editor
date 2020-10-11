using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditorDevelopment
{
    class Editor
    {
        string number;
        

        public Editor(string number)
        {
            if (number is null) this.number = "0";
            else this.number = number;

        }

        public string Number
        {
            get { return this.number; }
            set { this.number = value; }
        }


        //tested!
        public string ChangeSign()
        {
            if (number.Contains('-')) this.number = number.Remove(0, 1);
            else this.number = '-' + this.number;

            return this.number;
        }


        //tested!
        public string AddDigit(byte digit)
        {
            //функция заменяет число на A, B, C, D, E, F, если оно больше 9
            string replacer()
            {
                if (digit == 0) return this.number;
                else
                {
                    string symbol = Convert.ToString(digit);

                    if (digit > 9)
                    {
                        switch (symbol)
                        {
                            case "10": symbol = "A"; break;
                            case "11": symbol = "B"; break;
                            case "12": symbol = "C"; break;
                            case "13": symbol = "D"; break;
                            case "14": symbol = "E"; break;
                            case "15": symbol = "F"; break;
                        }
                    }

                    return symbol;
                }
            }


            if (this.number == "0") this.number = replacer();
            else this.number = this.number + replacer();

            return this.number;    
        }


        //tested!
        public string BS()
        {
            if (this.number == "0") return this.number;

            else
            {
                return this.number.Remove(number.Length - 1, 1);
            }
        }


        //tested!
        public string Clear()
        {
            this.number = "0";
            return this.number;
        }


        //tested!
        public string SetDot()
        {
            if (number.Contains(".")) return this.number;
            else
            {
                this.number = this.number + '.';
                return this.number;
            }
        }

        public string DoEdit(byte i)
        {
            if (i >= 0 && i <= 15)  return this.AddDigit(i);

            if (i == 16) return this.SetDot();

            if (i == 17) return this.ChangeSign();

            if (i == 18) return this.BS();

            if (i == 19) return this.Clear();

            return this.number;
        }
    }
}
