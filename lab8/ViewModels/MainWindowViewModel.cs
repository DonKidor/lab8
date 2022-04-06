using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using lab8.Models;

namespace lab8.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public ObservableCollection<Note> Items
        {
            get;
            set;
        }

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Note> { new Note(), new Note(), new Note(), new Note()};
        }

        public void DeleteClk(Note note)
        {
            Items.Remove(note);
        }
    }
}
