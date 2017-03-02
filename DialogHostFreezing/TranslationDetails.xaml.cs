namespace DialogHostFreezing
{
    using System.Windows.Controls;
    using MaterialDesignThemes.Wpf;

    public partial class TranslationDetails : UserControl
    {
        public TranslationDetails()
        {
            InitializeComponent();
        }

        private void DiscardButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DialogHost.CloseDialogCommand.Execute(null, null);
        }
    }
}
