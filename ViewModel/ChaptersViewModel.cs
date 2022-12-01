using CatalogWitcher.Model;
using CatalogWitcher.View;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

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
        private Chapter _selectedChapter;

        public Chapter SelectedChapter
        {
            get { return _selectedChapter; }
            set { _selectedChapter = value; }
        }
        public ChaptersViewModel(int id)
        {
           Collection = new ObservableCollection<Chapter>(new ModelContext().Chapters.Where(x=> x.Id == id));
        }
        public ChaptersViewModel()
        {
            Collection = new ObservableCollection<Chapter>(new ModelContext().Chapters);
        }
        public RelayCommand relayCommand;

        public RelayCommand BTNrelayCommand
        {
            get { return relayCommand ?? (relayCommand = new RelayCommand(BTN)); }
        }
        public void BTN()
        {
            if (SelectedChapter == null)
                return;
            //
            // Написать конструктор ID
            //
            ListCharacters listCharacters = new ListCharacters(SelectedChapter.Id);
            listCharacters.ShowDialog();
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
