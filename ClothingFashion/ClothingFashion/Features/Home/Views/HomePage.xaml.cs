using ClothingFashion.Features.Home.ViewModels;

namespace ClothingFashion.Features.Home.Views;

public partial class HomePage : ContentPage
{
    double scrollX = 0;

    public HomePage(HomeViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    private void PanGestureRecognizer_PanUpdated(object sender, PanUpdatedEventArgs e)
    {
        switch (e.StatusType)
        {
            case GestureStatus.Running:
                scrollX -= e.TotalX;
                scrollView.ScrollToAsync(scrollX, 0, false);
                break;

            case GestureStatus.Completed:
                break;
        }
    }
}