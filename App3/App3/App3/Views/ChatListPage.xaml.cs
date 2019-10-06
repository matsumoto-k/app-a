using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.ObjectModel;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatListPage : ContentPage
    {
        public ChatListPage()
        {
            InitializeComponent();

            List<ChatListInfo> chatListInfos = new List<ChatListInfo>();

            chatListInfos.Add(new ChatListInfo() { Name = "name1", Text = "text1" });

            this.ChatList.ItemsSource = chatListInfos;

        }
    }
}