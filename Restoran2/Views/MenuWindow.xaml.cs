using Restoran2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private ObservableCollection<Food> _foodItems;

        public MenuWindow()
        {
            InitializeComponent();
            Food food = new Food("fr", 12);
            _foodItems = new ObservableCollection<Food>
            {
                new Food { Name = "Hamburger", Price = 11.2 },
                new Food { Name = "Cheeseburger", Price = 12 },
                new Food { Name = "Pizza", Price = 15 },
                new Food { Name = "Hot dog", Price = 8 },
                new Food { Name = "French fries", Price = 5 }
            };

            leftListView.ItemsSource = _foodItems;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var foodName = button.Content.ToString();

            // Remove the clicked button from the left ListView.
            leftListView.Items.Remove(button);

            // Add the food name to the right ListView.
            rightListView.Items.Add(foodName);
        }


    }
}
