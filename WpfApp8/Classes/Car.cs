using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp8.Classes
{
    public class Car : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

		private string make;
		public string Make
		{
			get { return make; }
			set { make = value; OnPropertyChanged(); }
		}

		private string vendor;

		public string Vendor
		{
			get { return vendor; }
			set { vendor = value; OnPropertyChanged(); }
		}

		private int year;

		public int Year
		{
			get { return year; }
			set { year = value; OnPropertyChanged(); }
		}

        public Car()
        {
            Make = null;
            Vendor = null;
            Year = 0;
        }
        public Car(string make, string vendor, int year)
        {
            Make = make;
            Vendor = vendor;
            Year = year;
        }

        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
