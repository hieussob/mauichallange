using ClothingFashion.Features.Home.Models;
using ClothingFashion.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingFashion.Controls
{
    public class ItemTemplateSelectors : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var id = ((Item)item).Id;
            if (id % 2 == 0)
            {
                return Templates.EvenGalleryItemTemplate;
            }
            else
            {
                return Templates.OddGalleryItemTemplate;
            }
        }
    }
}
