using Microsoft.Maui.Controls.Shapes;

namespace ClothingFashion.UI
{
    public static class Templates
    {
        public static DataTemplate OddGalleryItemTemplate = new DataTemplate(() =>
        {
            var border = new Border
            {
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(Dimens.Radius10),
                },
                StrokeThickness = Dimens.StrokeThickenss0,
                HeightRequest = 230,
                WidthRequest = 110,
                Margin = new Thickness(0, -45, 0, 0),
            };
            var image = new Image
            {
                Aspect = Aspect.AspectFill,
            };
            image.SetBinding(Image.SourceProperty, "Image");


            StartToTopAnimation(image, CancellationToken.None);

            border.Content = image;
            return border;
        });

        private static async void StartToTopAnimation(Image image, CancellationToken cancellationToken)
        {
            while (true)
            {
                await image.TranslateTo(0, 150, 4000, Easing.CubicInOut);
                await image.TranslateTo(0, 0, 4000, Easing.CubicInOut);
            }
        }
        private static async void StartToBottomAnimation(Image image, CancellationToken cancellationToken)
        {
            while (true)
            {
                await image.TranslateTo(0, -150, 4000, Easing.CubicInOut);
                await image.TranslateTo(0, 0, 4000, Easing.CubicInOut);
            }
        }

        public static DataTemplate EvenGalleryItemTemplate = new DataTemplate(() =>
        {
            var border = new Border
            {
                StrokeShape = new RoundRectangle
                {
                    CornerRadius = new CornerRadius(Dimens.Radius10),
                },
                StrokeThickness = Dimens.StrokeThickenss0,
                HeightRequest = 230,
                WidthRequest = 110,
                Margin = new Thickness(Dimens.Spacing6),
            };
            var image = new Image
            {
                Aspect = Aspect.AspectFill,
            };
            image.SetBinding(Image.SourceProperty, "Image");
            StartToBottomAnimation(image, CancellationToken.None);
            border.Content = image;

            return border;
        });
    }
}
