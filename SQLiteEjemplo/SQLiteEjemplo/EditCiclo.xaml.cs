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
    public partial class EditCiclo : ContentPage
    {
        Ciclo mSelCiclo;
        ContentPage anteriorPage;
        public EditCiclo(Ciclo ciclo, ContentPage anteriorPage)
        {
            InitializeComponent();
            mSelCiclo = ciclo;
            this.anteriorPage = anteriorPage;
            BindingContext = mSelCiclo;
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            mSelCiclo.Nombre = txtNombre.Text;
            mSelCiclo.Abreviatura = txtAbreviatura.Text;

            App.DAUtil.EditCiclo(mSelCiclo);
            Navigation.RemovePage(anteriorPage);
            Navigation.PopAsync();
        }
    }
}