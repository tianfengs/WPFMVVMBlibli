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

namespace SimpleMvvmDemo.Client1
{
    using Microsoft.Win32;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            slider3.Value = slider1.Value + slider2.Value;
        }

        private void saveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.ShowDialog();
        }

        //private void addButton_Click(object sender, RoutedEventArgs e)
        //{
        //    double d1 = double.Parse(this.tb1.Text);    // 会抛出异常
        //    double d2 = double.Parse(this.tb2.Text);

        //    this.tb3.Text = (d1 + d2).ToString();
        //}

        //private void saveButton_Click(object sender, RoutedEventArgs e)
        //{
        //    SaveFileDialog dlg = new SaveFileDialog();
        //    dlg.ShowDialog();
        //}
    }
}
