using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fletnix.View
{
    /// <summary>
    /// Interaction logic for CreateGenreWindow.xaml
    /// </summary>
    public partial class CreateGenreWindow : Window
    {
        public CreateGenreWindow()
        {
            InitializeComponent();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
