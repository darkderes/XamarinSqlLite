using App1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }
        private void Btn_Clicked(object sender, EventArgs args)
        {
            Contactos nuevo = new Contactos();
            nuevo.Nombre = TxtNombre.Text;
            nuevo.Apellido = TxtApellido.Text;
            nuevo.Mail = TxtEmail.Text;
            nuevo.Telefono = TxtTelefono.Text;

            using (var Conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            { 
                Conn.CreateTable<Contactos>();
                Conn.Insert(nuevo);
            }
        }
    }
}