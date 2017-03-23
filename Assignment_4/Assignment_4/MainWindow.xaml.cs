using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace Assignment_4
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void uxZipCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (IsUSorCanadianZipCode(uxZipCode.Text))
                uxSubmit.IsEnabled = true;
            else uxSubmit.IsEnabled = false;
        }

        private bool IsUSorCanadianZipCode(string zipCode)
        {
            bool isValidUsOrCanadianZip = false;
            string pattern = @"(^\d{5}(-\d{4})?$)|(^[ABCEGHJKLMNPRSTVXYabceghjklmnprstvxy]{1}\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstv‌​xy]{1} *\d{1}[ABCEGHJKLMNPRSTVWXYZabceghjklmnprstvxy]{1}\d{1}$)";
            Regex regex = new Regex(pattern);
            return isValidUsOrCanadianZip = regex.IsMatch(zipCode);
        }

    }

}
