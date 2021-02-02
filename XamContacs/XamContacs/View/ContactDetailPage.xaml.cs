using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamContacs.Model;
using XamContacs.ViewModel;

namespace XamContacs.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        public ContactDetailPageViewModel ViewModel { get; set; }
        public ContactDetailPage( Contact contact = null)
        {
            InitializeComponent();
            if (contact == null)
            {
                ViewModel = new ContactDetailPageViewModel(Navigation);
                this.BindingContext = ViewModel;
            }
            else
            {
                ViewModel = new ContactDetailPageViewModel(Navigation, contact);
            }
        }
    }
}