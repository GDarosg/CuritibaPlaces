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
using CuritibaPlaces.Model;

namespace CuritibaPlaces.View
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Window
    {
        private User user;

        public home()
        {
            InitializeComponent();
        }

        public home()
        {
            
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var Enderecos = new Endereco();
            Enderecos.Show();
            this.Close();
        }

        private void Pesquisar(object sender, RoutedEventArgs e)
        {
            var Places = new Place ();
            Places.Show();
            this.Close();
        }

        private void enderecoCadastrado(object sender, RoutedEventArgs e)
        {
            var  = new ();
            Places.Show();
            this.Close();
        }
    }
}
