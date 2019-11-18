using System.Windows;
using Fletnix.View.Pages;
using Fletnix.ViewModel;

namespace Fletnix.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }
    }
}
