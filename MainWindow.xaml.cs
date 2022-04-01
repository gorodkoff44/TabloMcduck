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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Табло_Макдак
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] a = new string[100]; //массив хранит заказы
        int i = 0; //переменная для массива
        string t; //хранит введенный текст
        public MainWindow()
        {
            InitializeComponent();
        }
        public void tablo_con() //Выводит данные в табло
        {
            Tablo.Content = ""; //Очистка табло
            for (int j = 0; j <= i; j++) //вывод заказов на экран
            {
                Tablo.Content += a[j];
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text.Length > 0) //проверка на пустое поле
            {
                i++;
                t = textBox1.Text; //хранит введенный текст
                a[i] = " " + t; //массив табло
                tablo_con(); //обновить табло
                textBox1.Text = ""; //очистка введенного текста
            }
            else //если поле пустое
            {
                MessageBox.Show("Введите текст");
                return;
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e) //удалить последний введенный заказ
        {
            if (i > 0)
            {
                i -= 1;
                tablo_con();
                textBox1.Text = "";
            }
            else if (i == 0)
            {
                a[0] = "";
                tablo_con();
                textBox1.Text = "";
                MessageBox.Show("Всё удалено");
            }
        }
        private void Button_Click3(object sender, RoutedEventArgs e) //Очистить табло
        {
            for (int j = 0; j <= i; j++) //вывод заказов на экран
            {
                Tablo.Content = "";
                a[j] = "";
                i = 0;
            }
        }

    }
}
