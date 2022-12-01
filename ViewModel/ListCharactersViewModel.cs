using CatalogWitcher.Model;
using CatalogWitcher.View;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWitcher.ViewModel
{
    public class ListCharactersViewModel : INotifyCollectionChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        private ObservableCollection<Character> character;

        public ObservableCollection<Character> Characters
        {
            get { return character; }
            set { character = value; }
        }

        private Character _selectedCharacters;

        public Character SelectedCharacters
        {
            get { return _selectedCharacters; }
            set { _selectedCharacters = value; }
        }
        public RelayCommand relayCommand;

        public RelayCommand BTNCommand
        {
            get { return relayCommand ?? (relayCommand = new RelayCommand(ShowMoreInfo)); }
        }
        public void ShowMoreInfo()
        {
            if (SelectedCharacters == null)
                return;
            AllInfoCharactersWindow allInfoCharactersWindow = new AllInfoCharactersWindow();
            allInfoCharactersWindow.ShowDialog();

        }
        public ListCharactersViewModel()
        {
            Characters = new ObservableCollection<Character>(new ModelContext().Characters);
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
