using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MessageFilteringApp.Commands;
using MessageFilteringApp.Views;

namespace MessageFilteringApp.ViewModels
{
    public class AddMessagesViewModel : BaseViewModel
    {
        #region TextBlock Content
        public string MessageHeaderTextBlock { get; private set; }
        public string MessageBodyTextBlock { get; private set; }
        #endregion

        #region textBox Content
        public string MessageHeaderTextBox { get; set; }
        public string MessageBodyTextBox { get; set; }
        #endregion

        #region Add Button Content/Command
        public string AddButtonText { get; private set; }

        public ICommand AddButtonCommand { get; private set; }
        #endregion

        #region Constructor
        public AddMessagesViewModel()
        {
            MessageHeaderTextBlock = "Message header:";
            MessageBodyTextBlock = "Message body";

            MessageHeaderTextBox = string.Empty;
            MessageBodyTextBox = string.Empty;

            AddButtonText = "Add message";
            AddButtonCommand = new RelayCommand(AddButtonClick);
        }
        #endregion

        #region Private Click Helpers
        private void AddButtonClick()
        {

        }
        #endregion

    }
}
