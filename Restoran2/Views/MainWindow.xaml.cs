using Restoran2.Commands;
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

namespace Restoran2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public ICommand ShowCommand { get; set; }

        public Button button { get; set; }

        public void Click(object sender, RoutedEventArgs e)
        {
            if (btn1 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn1);
            }
            else if (btn2 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn2);
            }
            else if (btn3 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn3);
            }
            else if (btn4 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn4);
            }
            else if (btn5 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn5);
            }
            else if (btn6 == sender)
            {
                ShowCommand = new RelayCommand(ExecuteShowCommand, CanExecuteShowCommand, btn6);
            }
        }

        void ExecuteShowCommand(object? parametr)
        {

        }
        bool CanExecuteShowCommand(object? parametr)
            => true;
    }
}
