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

namespace zalicznie_semestralne
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  dodaje nowego uzytkownika do tabeli users
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dod_Click(object sender, RoutedEventArgs e) 
        {
            sklep_internetowyEntities db = new sklep_internetowyEntities ();

            users dodObject = new users()
            {
                login = im.Text,
                password= naz.Text
            };

            db.users.Add(dodObject);
            db.SaveChanges();
        }
    }
}
