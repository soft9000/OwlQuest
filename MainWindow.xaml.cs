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

using QuestKeep;

namespace QuestKeep
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

        private void OnNew(object sender, RoutedEventArgs e)
        {
            QuestKeep.QuestDB.MainTest(null);
            MessageBox.Show("Testing Success.", "OnNew");
        }

        private void OnOpen(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnOpen");
        }

        private void OnSaveAs(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnSaveAs");
        }

        private void OnAbout(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnAbout");
        }

        private void OnTestRandom(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnTestRandom");
        }

        private void OnTestOrdered(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnTestOrdered");
        }

        private void OnDump(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnDump");
        }

        private void OnDumpMerge(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnDumpMerge");
        }

        private void OnDumpRestore(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnDumpRestore");
        }

        private void OnFileReport(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnFileReport");
        }

        private void OnCopy(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnCopy");
        }

        private void OnPaste(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnPaste");
        }

        private void OnTestMetrics(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("TODO.", "OnTestMetrics");
        }
    }
}
