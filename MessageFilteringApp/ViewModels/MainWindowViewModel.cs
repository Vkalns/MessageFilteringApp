using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using MessageFilteringApp.Commands;
using MessageFilteringApp.Views;

namespace MessageFilteringApp.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        public string AddMessagesButtonContent { get; private set; }
        public string ViewMessagesButtonContent { get; private set; }

        public ICommand AddMessagesButtonCommand { get; private set; }
        public ICommand ViewMessagesButtonCommand { get; private set; }

        public UserControl ContentControlBinding { get; private set; }

        public MainWindowViewModel()
        {
            AddMessagesButtonContent = "Add messages";
            ViewMessagesButtonContent = "View messages";

            AddMessagesButtonCommand = new RelayCommand(AddMessagesButtonClick);
            ViewMessagesButtonCommand = new RelayCommand(ViewMessagesButtonClick);

            ContentControlBinding = new DefaultView();
        }

        private void AddMessagesButtonClick()
        {
            ContentControlBinding = new AddMessagesView();
            OnChanged(nameof(ContentControlBinding));
        }

        private void ViewMessagesButtonClick()
        {

        }
    }

}
