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
    /// Interaction logic for MotherActivities.xaml
    /// </summary>
    public partial class MotherActivities : Window
    {
       
        public MotherActivities()
        {
            InitializeComponent();
        }

        private void Button_Click_AddMother(object sender, RoutedEventArgs e)
        {
            AddMotherWindow addmotherwindow = new AddMotherWindow();
            addmotherwindow.ShowDialog();
        }


        private void Button_Click_UpdateMother(object sender, RoutedEventArgs e)
        {
            UpdateMother updateMother = new UpdateMother();
            updateMother.ShowDialog();
        }

        private void Button_Click_RemoveMother(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_AddChild(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_UpdateChild(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_RemoveChild(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_AddContract(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_UpdateContract(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_RemoveContact(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
