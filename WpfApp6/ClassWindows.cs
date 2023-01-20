using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp6
{
    public static class ClassWindows
    {
        // блок с данными
        static int count = 0;
        static int count1 = 0;
        public static List<string> datalist = new List<string> { "Сложение", "Вычитание", "Деление", "Умножение" };

        // блок для обращения к текстовым полям
        public static TextBox tb1;
        public static TextBox tb2;
        public static TextBlock tbCombo;

        // блок с бизнес-логикой
        public static int Count_1 
        {
            get
            {
                return count;
            }
            set
            {
                count = value;
                tb1.Text = count.ToString();
            }
        }

        public static int Count_2 // свойство для отображения числа в TextBlock
        {
            get
            {
                return count1;
            }
            set
            {
                count1 = value;
                tb2.Text = count1.ToString();
            }
        }


        public static int Combo
        {
            set
            {
                if (datalist[value] == "Сложение")
                {
                    tbCombo.Text = "+";
                }
                else if (datalist[value] == "Вычитание")
                {
                    tbCombo.Text = "-";
                }
                else if (datalist[value] == "Деление")
                {
                    tbCombo.Text = "/";
                }
                else if (datalist[value] == "Умножение")
                {
                    tbCombo.Text = "*";
                }
                //tbCombo.Text = datalist[value];
            }
        }
    }
}
