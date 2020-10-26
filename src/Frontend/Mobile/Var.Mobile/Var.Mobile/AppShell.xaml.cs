using System;
using System.Collections.Generic;
using Var.Mobile.ViewModels;
using Var.Mobile.Views;
using Xamarin.Forms;

namespace Var.Mobile
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
