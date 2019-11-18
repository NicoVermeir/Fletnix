using System.Windows;

namespace Fletnix.View
{
    /// <summary>
    /// Interaction logic for CreateCatalogItemWindow.xaml
    /// </summary>
    public partial class CreateCatalogItemWindow : Window
    {
        public CreateCatalogItemWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
