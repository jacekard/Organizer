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
        private readonly int WindowMargin = 100;

        public MainWindow()
        {
            InitializeComponent();

            SizeToContent = System.Windows.SizeToContent.Manual;
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
            this.DragMove();
        }

   
    }
}