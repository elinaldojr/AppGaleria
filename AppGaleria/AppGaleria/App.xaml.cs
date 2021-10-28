using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGaleria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var pg = new NavigationPage(
                new XamarinForms.Paginas.PgNavegacao.Conteudo1()
            );

            //MainPage = new MainPage();
            MainPage = pg;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
