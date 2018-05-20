using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace LongWork
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread thread;
        public MainWindow()
        {
            InitializeComponent();
        
        }
        public void PrintHello(object i)
        {
            Thread.Sleep(5000);
            Dispatcher.Invoke(new Action(() => text.Content = "Hi!!"));

        }

        private void Stop_Clik(object sender, RoutedEventArgs e)
        {
            thread.Suspend();
            MessageBox.Show("поток остоновлен");
        }

        private void Save_Clik(object sender, RoutedEventArgs e)
        {
            thread = new Thread(new ParameterizedThreadStart(PrintHello));
            thread.Start(text);
        
        }
    }
}
