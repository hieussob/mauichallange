
using MediaManager;
using surfingmauiapp.Features.Main.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace surfingmauiapp.Features.Main.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Story> Stories { get; set; }

        public ICommand HeartCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand PlayMusicCommand { get; set; }

        public MainViewModel()
        {
            Stories = new ObservableCollection<Story>
            {
                new Story {
                    Image = "user1.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber = GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys",
                },

                new Story {
                    Image = "user2.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user3.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user4.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user5.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user1.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user2.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user3.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },
                new Story {
                    Image = "user5.png",
                    BorderColor = GetRandomColor(),
                    HeartNumber =  GetRandomNumber(),
                    LastOnline="4 hours ago",
                    MainDetail="Probably considered the forefather of pro surfing",
                    Place="London, United Kingdom",
                    NickName= "Evan Tonys" },

            };
            HeartCommand = new Command<Story>(HeartCommandExecute);
            SaveCommand = new Command<Story>(SaveCommandExecute);
            PlayMusicCommand = new Command(PlayMusicCommandExecute);
        }

        private async void PlayMusicCommandExecute(object obj)
        {
            var fileName = "TiengCuoiTreCon-ThanhKhiet_3knbn.mp3";
            var filePath = Path.Combine("Resources", "Raw", fileName);
            var mediaManager = CrossMediaManager.Current;
            await mediaManager.Play("D:\\Documents\\Maui\\surfingmauiapp\\surfingmauiapp\\Resources\\Raw\\TiengCuoiTreCon-ThanhKhiet_3knbn.mp3");
        }

        private void SaveCommandExecute(Story story)
        {
            if(story == null) return;
            story.IsSaved = !story.IsSaved;
        }

        private void HeartCommandExecute(Story story)
        {
            if (story == null) return;
            story.IsHearted = !story.IsHearted;
            story.HeartNumber += story.IsHearted ? 1 : -1;
        }

        private int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next(100);
        }

        private Color GetRandomColor()
        {
            Random random = new Random();
            return Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
