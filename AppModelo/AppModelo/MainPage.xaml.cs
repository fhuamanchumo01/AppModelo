using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace AppModelo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BotonAccion_Clicked(object sender, EventArgs e)
        {
            var modelo = DeviceInfo.Model;
            var marca = DeviceInfo.Manufacturer;
            var nombre = DeviceInfo.Name;
            var version = DeviceInfo.VersionString;
            var plataforma = DeviceInfo.Platform;
            var idioma = DeviceInfo.Idiom;
            var tipo = DeviceInfo.DeviceType;

            lblInfo.Text = String.Format("Modelo: {0}" +
                                        "\n Marca: {1}" +
                                        "\n Nombre: {2}" +
                                        "\n Version del software: {3}" +
                                         "\n Plataforma: {4}" +
                                          "\n Tipo: {5}" +
                                           "\n Físico/virtual: {6}", modelo, marca, nombre, version, plataforma, idioma, tipo );

            
        }
    }
}
