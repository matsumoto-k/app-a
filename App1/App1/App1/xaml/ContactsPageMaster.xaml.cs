using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.xaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPageMaster : ContentPage
    {
        public ListView ListView;

        public ContactsPageMaster()
        {
            InitializeComponent();

            BindingContext = new ContactsPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class ContactsPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<ContactsPageMasterMenuItem> MenuItems { get; set; }

            public ContactsPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<ContactsPageMasterMenuItem>(new[]
                {
                    new ContactsPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new ContactsPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new ContactsPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new ContactsPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new ContactsPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}