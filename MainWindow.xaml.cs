using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HumanData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if(fio.Text == "" || adress.Text == "" || phone.Text == "")
            {
                MessageBox.Show("Вы заполнили не все поля!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                LoggerName(fio.Text);
                LoggerAddres(adress.Text);
                LoggerPhone(phone.Text);
                MessageBox.Show("Данные успешно записаны в фаил", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            string commandText = @"C:\Users\111\source\repos\HumanData\bin\Debug\netcoreapp3.1\log.txt";
            var proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = commandText;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
        }

        private void LoggerName(string msg)
        {
            string message = "Ф.И.О" + " : " + msg;
            using StreamWriter file = new StreamWriter("log.txt", true);
            file.WriteLine(message);
        }
        private void LoggerAddres(string msg)
        {
            string message = "Адрес" + " : " + msg;
            using StreamWriter file = new StreamWriter("log.txt", true);
            file.WriteLine(message);
        }
        private void LoggerPhone(string msg)
        {
            string message = "Телефон" + " : " + msg + Environment.NewLine;
            using StreamWriter file = new StreamWriter("log.txt", true);
            file.WriteLine(message);
        }
    }
}
