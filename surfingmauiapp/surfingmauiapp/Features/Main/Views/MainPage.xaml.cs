using surfingmauiapp.Features.Main.ViewModels;

namespace surfingmauiapp.Features.Main.Views
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }


    }

}
