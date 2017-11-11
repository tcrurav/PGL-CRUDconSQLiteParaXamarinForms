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
    public partial class ShowCiclo : ContentPage
    {
        Ciclo mSelCiclo;
        public ShowCiclo(Ciclo ciclo)
        {
            InitializeComponent();
            mSelCiclo = ciclo;
            BindingContext = mSelCiclo;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditCiclo(mSelCiclo, this));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            bool accepted = await DisplayAlert("Confirmar", "¿Estás seguro?", "Sí", "No");
            if (accepted)
            {
                App.DAUtil.DeleteCiclo(mSelCiclo);
            }
            await Navigation.PopAsync();
        }
    }
}