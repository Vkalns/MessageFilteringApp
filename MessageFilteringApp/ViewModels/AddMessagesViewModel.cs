using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MessageFilteringApp.Commands;
using MessageFilteringApp.Models;
using MessageFilteringApp.Views;
using MessageFilteringApp.Database;

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
            if (string.IsNullOrWhiteSpace(MessageHeaderTextBox) || 
                string.IsNullOrWhiteSpace(MessageBodyTextBox))
            {
                MessageBox.Show("Please enter all values");
                return;
            }

            Message message = new Message()
            {
                Header = MessageHeaderTextBox,
                Body = MessageBodyTextBox
            };

            SaveToFile save = new SaveToFile();
            if (!save.ToJson(message))
            {
                MessageBox.Show("Error while saving");
            }
            else
            {
                MessageBox.Show("Message saved in file");
                save = null;
            }
            LoadAbbreviations loadAbb = new LoadAbbreviations();
            loadAbb.FromCsv();
        }
        #endregion

    }
}
