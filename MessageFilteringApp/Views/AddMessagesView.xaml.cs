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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageFilteringApp.ViewModels;

namespace MessageFilteringApp.Views
{
    /// <summary>
    /// Interaction logic for AddMessagesView.xaml
    /// </summary>
    public partial class AddMessagesView : UserControl
    {
        public AddMessagesView()
        {
            InitializeComponent();
            this.DataContext = new AddMessagesViewModel();
        }
    }
}
