using System.ComponentModel;
using Xamarin.Forms;
using Var.Mobile.ViewModels;

namespace Var.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}