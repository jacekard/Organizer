using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Organizer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int WindowMargin { get; set; } = 100;
        public bool WindowSlideState { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            this.WindowSlideState = false;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Width = 150;
            this.Height = SystemParameters.WorkArea.Height - this.WindowMargin;
            this.Left = SystemParameters.WorkArea.Width - this.Width;
            this.Top = this.WindowMargin / 2;
        }

        private void DraggableWindow(object sender, MouseButtonEventArgs e)

        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenMenu(object sender, RoutedEventArgs e)
        {

        }
    }
}