using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WpfApp8.Classes;

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private ObservableCollection<Car> cars;

        public ObservableCollection<Car> Cars { get => cars; set { cars = value; OnPropertyChanged(); } }

        public MainWindow()
        {
            Cars = new ObservableCollection<Car>()
            {
                new Car("qwerty","asdfghj",2112),
                new Car("qwerty","asdfghj",2112),
                new Car("qwerty","asdfghj",2112)
            };
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
            Upgrade_Window NewWindow = new Upgrade_Window();
            NewWindow.Car = new Car();
            NewWindow.CNT = "Add";
            NewWindow.Show();
            Cars.Add(NewWindow.Car);
            
        }

        public void MyList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Upgrade_Window upgrade_Window = new Upgrade_Window();
            upgrade_Window.Car = (sender as ListView).SelectedItem as Car;
            upgrade_Window.CNT = "Upgrade";
            upgrade_Window.Show();
            
            (sender as ListView).SelectedItem = upgrade_Window.Car;
        }

        
    }
}