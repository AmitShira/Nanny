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
    /// Interaction logic for AddMotherWindow.xaml
    /// </summary>
    public partial class AddMotherWindow : Window
    {
        BE.Mother mymother;
        public AddMotherWindow()
        {
            InitializeComponent();
            mymother = new BE.Mother();
            DataContext = mymother;
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                mymother.Address = new BE.Address() { City = this.cityTextBox.Text, Country = this.countryTextBox.Text, Number = Int32.Parse(this.numberTextBox.Text), Street = this.streetTextBox.Text, ZipCode = this.zipCodeTextBox.Text };
                mymother.BankDetails.BankAdress = new BE.Address() { City = this.cityTextBox.Text, Country = this.countryTextBox.Text, Number = Int32.Parse(this.numberTextBox.Text), Street = this.streetTextBox.Text, ZipCode = this.zipCodeTextBox.Text };
                BL.FactoryBl.getBL().AddMother(mymother);
                MessageBox.Show(mymother.ToString());
                mymother = new BE.Mother();
                DataContext = mymother;
                DialogResult = true;
            }

      
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //this.DialogResult = false;
            }
      
        }
    }
}
