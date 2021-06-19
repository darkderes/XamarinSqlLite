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
    public partial class DetallesContactoPage : ContentPage
    {
        public Contactos Contacto { get; set; }
        public DetallesContactoPage(Contactos contacto)
        {
            InitializeComponent();
            Contacto = contacto;

            LblNombre.Text = Contacto.Nombre + " " + Contacto.Apellido;
            LblTelefono.Text = Contacto.Telefono;
            LblCorreo.Text = Contacto.Mail;

        }
    }
}