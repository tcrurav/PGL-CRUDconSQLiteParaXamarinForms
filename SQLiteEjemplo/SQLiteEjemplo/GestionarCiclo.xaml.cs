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
    public partial class GestionarCiclo : ContentPage
    {
        public GestionarCiclo()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var ciclos = App.DAUtil.GetAllCiclos();
            lstData.ItemsSource = ciclos;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
                //ItemSelected is called on deselection, 
                //which results in SelectedItem being set to null
            }
            var vSelUser = (Ciclo)e.SelectedItem;
            Navigation.PushAsync(new ShowCiclo(vSelUser));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AddCiclo());
        }
    }
}