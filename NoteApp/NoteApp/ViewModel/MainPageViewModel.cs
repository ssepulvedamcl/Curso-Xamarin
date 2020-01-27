using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace NoteApp.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            AllNotes = new ObservableCollection<string>();

            EraseNoteCommand = new Command(()=> {
                TheNote = String.Empty;
            });

            SaveNoteCommand = new Command(() =>
            {
                AllNotes.Add(theNote);
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<string> AllNotes { get; set; }

        string theNote;

        public string TheNote
        {
            get => theNote;
            set {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));

                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command SaveNoteCommand{ get;}
        public Command EraseNoteCommand { get; }

    }
}
