using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace pr_11_teselko_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstStroke = "a1a a22a a333a a4444a a55555a aba aca";
        string secondStroke = "aba aea aca aza axa a-a a#a";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №11\n" +
                "Теселько Максим ИСП-34\n" +
                "Дана строка 'a1a a22a a333a a4444a a55555a aba aca'. Напишите регулярное выражение, которое найдет строки, в которых по краям стоят буквы 'a', " +
                "а между ними любое количество цифр.\n" +
                "Дана строка 'aba aea aca aza axa a-a a#a'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a', " +
                "а между ними - не 'e' и не 'x'.", "О прошрамме"
                , MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void findFirst_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a\d+a");
            MatchCollection matches = regex.Matches(firstStroke);
            object[] regexArray = new object[matches.Count];
            matches.CopyTo(regexArray, 0);
            firstListBox.ItemsSource = regexArray;
        }

        private void findSecond_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"a[^ex\s]a");
            MatchCollection matches = regex.Matches(secondStroke);
            object[] regexArray = new object[matches.Count];
            matches.CopyTo(regexArray, 0);
            secondListBox.ItemsSource = regexArray;
        }
    }
}
