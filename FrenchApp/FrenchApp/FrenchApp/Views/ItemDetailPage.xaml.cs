using FrenchApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FrenchApp.Views
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