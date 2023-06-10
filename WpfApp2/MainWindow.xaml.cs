using WpfApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Controls.Primitives;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> mas = new List<int>();
        private List<double> masReal = new List<double>();
        private Queue<Triangle> queueReal = new Queue<Triangle>();
        public MainWindow()
        {
            InitializeComponent();
            // lbLab8.ItemsSource = intList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Triangle triangle = new Triangle(double.Parse(triangleleg1.Text), double.Parse(triangleleg2.Text));
            queueReal.Enqueue(triangle);
            TreeViewItem item = new TreeViewItem();
            item.Tag = "Запись " + queueReal.Count;
            item.Header = "Запись " + queueReal.Count;
            item.Items.Add(triangle.leg1);
            item.Items.Add(triangle.leg2);
            treeList.Items.Add(item);
            triangleleg1.Clear();
            triangleleg2.Clear();
        }

    }
}