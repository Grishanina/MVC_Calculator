using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ClassWindows.tb1 = First;
            //First = ClassWindows.tb1;
            ClassWindows.tbCombo = Znach;
            //Second = ClassWindows.tb2;
            ClassWindows.tb2 = Second;
            Box.ItemsSource = ClassWindows.datalist;
        }

        private void BtnCount_Click(object sender, RoutedEventArgs e)
        {
            ClassWindows.Count_1 = Convert.ToInt32(First.Text);
            ClassWindows.Count_2 = Convert.ToInt32(Second.Text);

            if(Znach.Text == "+")
            {
                double Result_0 = (double)ClassWindows.Count_1 + (double)ClassWindows.Count_2;
                Result.Text = Result_0.ToString();
            }
            else if(Znach.Text == "-")
            {
                double Result_0 = (double)ClassWindows.Count_1 - (double)ClassWindows.Count_2;
                Result.Text = Result_0.ToString();
            }
            else if (Znach.Text == "*")
            {
                double Result_0 = (double)ClassWindows.Count_1 * (double)ClassWindows.Count_2;
                Result.Text = Result_0.ToString();
            }
            else if (Znach.Text == "/")
            {
                double Result_0 = (double)ClassWindows.Count_1 / (double)ClassWindows.Count_2;
                Result.Text = Result_0.ToString();
            }
        }

        private void Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClassWindows.Combo = Box.SelectedIndex;
        }
    }
}
