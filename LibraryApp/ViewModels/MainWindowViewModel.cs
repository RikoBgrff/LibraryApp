using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace LibraryApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {

        public MainWindowViewModel()
        {
            //List<User> items = new List<User>();
            //items.Add(new User() { Name = "John Doe", Age = 42, Mail = "john@doe-family.com" });
            //items.Add(new User() { Name = "Jane Doe", Age = 39, Mail = "jane@doe-family.com" });
            //items.Add(new User() { Name = "Sammy Doe", Age = 7, Mail = "sammy.doe@gmail.com" });
            //BookListView.ItemsSource = items;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
