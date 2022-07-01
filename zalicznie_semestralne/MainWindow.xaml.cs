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

namespace zalicznie_semestralne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

      
        

        private void Zaloguj_click(object sender, RoutedEventArgs e)
        {

            sklep_internetowyEntities db = new sklep_internetowyEntities();

            var query = from u in db.users
                        where u.login == logintxt.Text && u.password == passwordtxt.Password
                        select u;

            if (query.Count() >= 1)
            {
                MessageBox.Show("Zalogowano");
                wpf1 objokno = new wpf1();
                this.Visibility = Visibility.Hidden;
                objokno.Show();
            }
            else
            {
                MessageBox.Show("Nie prawidłowy login lub hasło");
            }


        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            MainWindow1 ad = new MainWindow1();
            ad.Show();
        }
    }
}
