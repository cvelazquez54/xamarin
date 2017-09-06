using Domain.Teacher;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherHiring.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeacherHiring.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClassListPage : ContentPage
    {
        

        public ClassesPageViewModel viewModel;
        public ClassListPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ClassesPageViewModel();
            
        }

        async void Handle_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            DtoClassAvailable item = (DtoClassAvailable)e.SelectedItem;

            await DisplayAlert("Item Tapped " + item.ClassName, "An item was tapped.", "OK");

            ((ListView)sender).SelectedItem = null;
        }


    }
}