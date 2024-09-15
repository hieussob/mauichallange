using surfingmauiapp.Features.Main.ViewModels;

namespace surfingmauiapp.Features.Main.Views
{
    public partial class MainPage : ContentPage
    {
        private double _startY;
        private double _startX;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
        {
            if (e.StatusType == GestureStatus.Started)
            {
                _startY = e.TotalY;
            }
            else if (e.StatusType == GestureStatus.Running)
            {
                double deltaY = e.TotalY - _startY;

                scrollView.ScrollToAsync(
                    scrollView.ScrollX,
                    scrollView.ScrollY - deltaY,
                    false);

                _startY = e.TotalY;
            }
        }
    }

}
