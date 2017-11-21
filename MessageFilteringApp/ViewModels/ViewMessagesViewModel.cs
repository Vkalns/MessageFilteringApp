using MessageFilteringApp.Commands;
using MessageFilteringApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MessageFilteringApp.ViewModels
{
    class ViewMessagesViewModel : BaseViewModel
    {
        #region TextBlocks Content
        public string MessageHeaderTextBlock { get; private set; }
        //public string MessageTypeTextBlock { get; private set; }
        public string MessageSenderTextBlock { get; private set; }
        public string MessageSubjectTextBlock { get; private set; }
        public string MessageTextBlock { get; private set; }
        public string MessageHashtagsTextBlock { get; private set; }
        #endregion

        #region textBoxes Content
        public string MessageHeaderTextBox { get; set; }
        public string MessageSenderTextBox { get; set; }
        public string MessageSubjectTextBox { get; set; }
        public string MessageTextTextBox { get; set; }
        public string MessageHashtagsTextBox { get; set; }
        #endregion

        #region Next Button Content/Command
        public string NextButtonText { get; private set; }

        public ICommand NextButtonCommand { get; private set; }
        #endregion

        #region Constructor
        public ViewMessagesViewModel()
        {
            MessageHeaderTextBlock = "Header:";
            //MessageTypeTextBlock = "Message body";
            MessageSenderTextBlock = "Sender:";
            MessageSubjectTextBlock = "Subject:";
            MessageTextBlock = "Message:";
            MessageHashtagsTextBlock = "Hashtags in the message:";

            MessageHeaderTextBox = string.Empty;
            MessageSenderTextBox = string.Empty;
            MessageSubjectTextBox = string.Empty;
            MessageTextTextBox = string.Empty;
            MessageHashtagsTextBox = string.Empty;



            NextButtonText = "Next message";
            NextButtonCommand = new RelayCommand(NextButtonClick);
        }
        #endregion

        #region Private Click Helpers
        private void NextButtonClick()
        {
            if (false)
            {
                MessageBox.Show("Please enter all values");
                return;
            }
        }

            
        #endregion

    }
}

