using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamContacs.Data;
using XamContacs.Services;
using XamContacs.View;

namespace XamContacs
{
    public partial class App : Application
    {
        private static ContacsDatabase database; 

        public  static ContacsDatabase Database
        {
            get
            {
                if(database == null)
                {
                    try
                    {
                        database = new ContacsDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("contacsdb.db3"));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
                return database;
            }
          
            
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactPage());
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
