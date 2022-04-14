using Schema_therapy.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Schema_therapy.Views
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