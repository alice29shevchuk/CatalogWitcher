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
    public class ChaptersViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Chapter> collection;

        public ObservableCollection<Chapter> Collection
        {
            get { return collection; }
            set { collection = value; }
        }
        public ChaptersViewModel()
        {
            Collection = new ObservableCollection<Chapter>(new ModelContext().Chapters);
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
