using Schema_therapy.ViewModels;
using Schema_therapy.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Schema_therapy
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
