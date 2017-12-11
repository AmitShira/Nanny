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
using System.Windows.Shapes;

namespace PLWPF
{ 
    /// <summary>
    /// Interaction logic for AddChildWindow.xaml
    /// </summary>
    public partial class AddChildWindow : Window
    {
        BE.Child mychild;
        public AddChildWindow()
        {
            InitializeComponent();
            mychild = new BE.Child();
            DataContext = mychild;
        }

        
        private void addChildButton_Click(object sender, RoutedEventArgs e)
        {
            BL.FactoryBl.getBL().AddChild(mychild);
            mychild = new BE.Child();
            DataContext = mychild;
            DialogResult = true;
        }

      }
}
