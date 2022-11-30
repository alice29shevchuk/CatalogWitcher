using CatalogWitcher.Model;
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
