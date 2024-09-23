using Microsoft.Maui.Controls.Shapes;

namespace ClothingFashion.UI
{
    public class Styles
    {
        public static Style SwipeActionStyle = new Style(typeof(Controls.SwipeAction))
        {
            Setters =
            {
                new Setter
                {
                    Property = VisualElement.WidthProperty,
                    Value = 60
                },
                new Setter
                {
                    Property = View.VerticalOptionsProperty,
                    Value = LayoutOptions.End
                },
                new Setter
                {
                    Property = View.MarginProperty,
                    Value = new Thickness(Dimens.Spacing12)
                },

            }
        };

        public static Style SwipeActionTrackStyle = new Style(typeof(Border))
        {
            Setters =
            {
                new Setter
                {
                    Property = Border.StrokeShapeProperty,
                    Value =  new RoundRectangle
                {
                    CornerRadius = new CornerRadius(12) 
                }
                },
                new Setter
                {
                    Property = Border.StrokeThicknessProperty,
                    Value = Dimens.StrokeThickenss0
                },
                new Setter
                {
                    Property = Border.BackgroundColorProperty,
                    Value = AppColors.SoftBlack
                },
            }
        };

        public static Style SwipeActionThumbStyle = new Style(typeof(Border))
        {
            Setters =
            {
                new Setter
                {
                    Property = Border.StrokeShapeProperty,
                    Value =  new RoundRectangle
                {
                    CornerRadius = new CornerRadius(Dimens.Radius24) 
                }
                },
                new Setter
                {
                    Property = Border.StrokeThicknessProperty,
                    Value = Dimens.StrokeThickenss0
                },
                new Setter
                {
                    Property = Border.BackgroundColorProperty,
                    Value = AppColors.White
                },
                new Setter
                {
                    Property = Border.MarginProperty,
                    Value = Dimens.Spacing6
                }, new Setter
                {
                    Property = Border.WidthProperty,
                    Value = 150
                },
            }
        };

        public static Style SwipeActionTextStyle = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter
                {
                    Property = Label.FontSizeProperty, Value= Dimens.FontSize10
                },
                new Setter
                {
                    Property = Label.LineBreakModeProperty, Value = LineBreakMode.TailTruncation
                },
                new Setter
                {
                    Property = Label.CharacterSpacingProperty, Value = Dimens.Spacing1
                },
                new Setter
                {
                    Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center
                },
                new Setter
                {
                    Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center
                },
                new Setter
                {
                    Property = Label.MarginProperty, Value = new Thickness(Dimens.Spacing12, Dimens.Spacing1)
                },
                new Setter
                {
                    Property = Label.TextColorProperty, Value = AppColors.Black
                },
               


            }
        };

        public static Style SwipeActionDirectionTextStyle = new Style(typeof(Label))
        {
            Setters =
            {
                new Setter
                {
                    Property = Label.FontSizeProperty, Value= Dimens.FontSize15
                },
                new Setter
                {
                    Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center
                },
                new Setter
                {
                    Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center
                },
                new Setter
                {
                    Property = Label.MarginProperty, Value = new Thickness(Dimens.Spacing6, Dimens.Spacing1)
                },

            }
        };
    }
}
