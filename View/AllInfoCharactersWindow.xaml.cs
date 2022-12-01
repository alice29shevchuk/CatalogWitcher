using CatalogWitcher.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CatalogWitcher.View
{
    /// <summary>
    /// Логика взаимодействия для AllInfoCharactersWindow.xaml
    /// </summary>
    public partial class AllInfoCharactersWindow : Window
    {
        public AllInfoCharactersWindow()
        {
            InitializeComponent();
            DataContext = new AllInfoCharactersViewModel();
        }
        public AllInfoCharactersWindow(string name)
        {
            InitializeComponent();
            DataContext = new AllInfoCharactersViewModel(name);
        }
    }
}
