using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Clases;
using System.Runtime.InteropServices.ComTypes;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        List<Contactos> contactos;
        public MainPage()
        {
            InitializeComponent();
            contactos = new List<Contactos>();
            LvwContactos.ItemSelected += LvwContactos_ItemSelected;
        }

        private void LvwContactos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           var contacto = e.SelectedItem as Contactos;
           Navigation.PushAsync(new DetallesContactoPage(contacto));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            using (var conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            {
                conn.CreateTable<Contactos>();
                contactos = conn.Table<Contactos>().ToList();
                LvwContactos.ItemsSource = contactos;
                
            }
        }

        private void ToolBarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }
    }
}
