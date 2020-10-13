using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GettingStarted
{
    public class ViewModel
    {
        private bool isChecked = true;

        public Command TransactionCommmand { get; set; }
        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; }
        }

        public ViewModel()
        {
            TransactionCommmand = new Command(DoTransaction);
        }
        
        private void DoTransaction()
        {
            App.Current.MainPage.DisplayAlert("Hello","Transaction is Initiated ","Ok");
        }
    }
}
