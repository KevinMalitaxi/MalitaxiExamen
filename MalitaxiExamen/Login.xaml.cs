using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MalitaxiExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //almacenando en varibales lo que usuario ingresa
                string usuario = txtUsuario.Text;
                string clave = txtClave.Text;

                //Permite abrir la ventana(ViewDos)
                await Navigation.PushAsync(new Registro(usuario, clave));
                if (usuario == "estudiante2021" && clave == "uisrael2021")
                {
                    await Navigation.PushAsync(new Registro(usuario, clave));
                }
                else
                {
                    await DisplayAlert("Error", "Usuario/clave incorrectos", "oK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }

        }
    }
}