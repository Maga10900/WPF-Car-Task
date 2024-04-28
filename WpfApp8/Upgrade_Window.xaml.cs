using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

using WpfApp8.Classes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for Upgrade_Window.xaml
    /// </summary>
    public partial class Upgrade_Window : Window, INotifyPropertyChanged
    {
        private Car car;

        public Car Car
        {
            get { return car; }
            set { car = value; OnPropertyChanged(); }
        }

        private string cnt;

        public string CNT
        {
            get { return cnt; }
            set { cnt = value; }
        }

        public Upgrade_Window()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            if(btn.Content == "Add")
            {
                
                Close();
            }
            else if(btn.Content == "Upgrade")
            {
                Close();
            }
        }
    }
}
