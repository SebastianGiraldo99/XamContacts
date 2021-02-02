using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamContacs.Helpers;
using XamContacs.Model;
using XamContacs.View;

namespace XamContacs.ViewModel
{
    public class ContactPageViewModel
    {
        public ObservableCollection<Grouping<string, Contact>> ContacsList { get; set; }

        public Contact CurrentContact { get; set; }

        public Command AddContactCommand { get; set; }
        public Command ItemTappedCommnad { get; }
        public INavigation Navigation { get; set; }

        public ContactPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            Task.Run(async () =>
            ContacsList = await App.Database.GetItemsGroupAsync()).Wait();
            AddContactCommand = new Command(async () => await GoToContactDetailPage());
            ItemTappedCommnad = new Command(async () => GoToContactDetailPage(CurrentContact));
        }
        public async Task GoToContactDetailPage(Contact contact = null)
        {
            if(contact == null)
            {
                await Navigation.PushAsync(new ContactDetailPage());
            }
            else
            {
                await Navigation.PushAsync(new ContactDetailPage(CurrentContact));
            }
            
        }
    }
}
