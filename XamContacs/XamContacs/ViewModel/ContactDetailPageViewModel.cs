using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamContacs.Model;

namespace XamContacs.ViewModel
{
    public class ContactDetailPageViewModel
    {
        public Command SaveContantCommand { get; set; }
        public Contact CurrentContact { get; set; }
        public INavigation Navigation { get; set; }

        public ContactDetailPageViewModel(INavigation navigation, Contact contact = null)
        {
            Navigation = navigation;
            if (contact == null)
            {
                CurrentContact = new Contact();
            }
            else
            {
                CurrentContact = contact;
            }
            SaveContantCommand = new Command(async () => await SaveContact());
        }

        public async Task SaveContact()
        {
            await App.Database.SaveItemAsync(CurrentContact);
            await Navigation.PopToRootAsync();
        }
    }
}
