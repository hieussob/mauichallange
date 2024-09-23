using ClothingFashion.Features.Home.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingFashion.Features.Home.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Item> items = new();
        
        public HomeViewModel()
        {
            Items = InitialItems();
        }

        public ObservableCollection<Item> InitialItems()
        {
            var result = new ObservableCollection<Item>();

            for (int i = 0; i < 5; i++)
            {
                result.Add(new Item { Id = 1, Image = "pantspio.jpg" });
                result.Add(new Item { Id = 2, Image = "coatgeremia.jpg" });
                result.Add(new Item { Id = 3, Image = "blazergloria.jpg" });
                result.Add(new Item { Id = 4, Image = "trouserskous.jpg" });
                result.Add(new Item { Id = 5, Image = "woolstriped.jpg" });
                result.Add(new Item { Id = 6, Image = "shirtfurio.jpg" });
                result.Add(new Item { Id = 7, Image = "sweatermarcello.jpg" });
                result.Add(new Item { Id = 8, Image = "shirtcroccante.jpg" });
            }
            return result;
        }

        [RelayCommand]
        async Task GoHome()
        {
            await Shell.Current.GoToAsync("///MainPage");

        }
    }

}
