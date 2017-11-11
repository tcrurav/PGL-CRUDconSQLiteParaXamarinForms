using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLiteEjemplo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCiclo : ContentPage
    {
        public AddCiclo()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var ciclo = new Ciclo()
            {
                Nombre = txtNombre.Text,
                Abreviatura = txtAbreviatura.Text
            };
            App.DAUtil.SaveCiclo(ciclo);
            Navigation.PopAsync();
        }
    }
}