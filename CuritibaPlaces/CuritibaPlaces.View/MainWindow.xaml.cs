using CuritibaPlaces.Controllers;
using CuritibaPlaces.Model;
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

namespace CuritibaPlaces.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersController usersController = new UsersController();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            var register = new Register();
            register.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            String login = textBoxLogin.Text;
            String password = passwordBox.Password;
            if(login !=null && password!= null)
            {
                User user = usersController.SearchByLogin(login);
                if (user != null && user.Password == password)
                {
                    var home = new home(user);
                    home.Show();
                    this.Close();
                }
                else{
                    MessageBox.Show("Login ou Senha Incorretos");
                }
                
            }
            else
            {
                MessageBox.Show("preencha os campos!");
            }
        }
    }
}
