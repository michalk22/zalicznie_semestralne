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
    /// Logika interakcji dla klasy wpf1.xaml
    /// </summary>
    public partial class wpf1 : Window
    {
        public wpf1()
        {
            InitializeComponent();
            sklep_internetowyEntities db = new sklep_internetowyEntities();
            var usrs= from z in db.users
                       select z;

            

            this.gridusers.ItemsSource = usrs.ToList();
        }

        private void skle_Click(object sender, RoutedEventArgs e)
        {
            sklep_internetowyEntities db = new sklep_internetowyEntities();
            var sklep1 = from z in db.shop

                       select z;



            this.gridusers.ItemsSource = sklep1.ToList();
        }

        private void zam_Click(object sender, RoutedEventArgs e) 
        {
            sklep_internetowyEntities db = new sklep_internetowyEntities();
            var zam1 = from c in db.zamowienie
                       select c;



            this.gridusers.ItemsSource = zam1.ToList();
        }

        private void dost_Click(object sender, RoutedEventArgs e) 
            sklep_internetowyEntities db = new sklep_internetowyEntities();
            var sk1 = from v in db.dostawa
                       select v;
            


            this.gridusers.ItemsSource = sk1.ToList();
        }
    /// <summary>
    ///  dodaje  zawartości do tabli shop
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void dodac_Click(object sender, RoutedEventArgs e)
        {
            sklep_internetowyEntities db = new sklep_internetowyEntities();

            shop shopObject = new shop()
            {
               nazwa_sklpu="test",
                miejscowasc = "test",
                ulica = "test"


            };

            db.shop.Add(shopObject);
            db.SaveChanges();
        }

        private void prod_Click(object sender, RoutedEventArgs e) // zwraca liste produktów
        {
            sklep_internetowyEntities db = new sklep_internetowyEntities();
            var pod1 = from b in db.produkty
                      select b;



            this.gridusers.ItemsSource = pod1.ToList();
        }

    }

}
