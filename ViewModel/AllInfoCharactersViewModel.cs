using CatalogWitcher.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CatalogWitcher.ViewModel
{
    public class AllInfoCharactersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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
        public AllInfoCharactersViewModel(string name)
        {
            Characters = new ObservableCollection<Character>(new ModelContext().Characters.Where(x=>x.Name == name));
        }
        public AllInfoCharactersViewModel()
        {
            Characters = new ObservableCollection<Character>(new ModelContext().Characters);
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
