using System.ComponentModel;

namespace surfingmauiapp.Features.Main.Models
{
    public class Story :INotifyPropertyChanged
    {
        public string Image { get; set; }
        public Color BorderColor { get; set; }
        private bool _isHearted;
        public bool IsHearted
        {
            get => _isHearted;
            set
            {
                if (_isHearted != value)
                {
                    _isHearted = value;
                    OnPropertyChanged(nameof(IsHearted));
                }
            }
        }

        public string NickName { get; set; }
        public string LastOnline { get; set; }
        private int _heartNumber;
        public int HeartNumber
        {
            get => _heartNumber;
            set
            {
                _heartNumber = value;
                OnPropertyChanged(nameof(HeartNumber));
            }
        }
        public string MainDetail { get; set; }
        public string Place { get; set; }

        private bool _isSaved;
        public bool IsSaved
        {
            get => _isSaved;
            set
            {
                if (_isSaved != value)
                {
                    _isSaved = value;
                    OnPropertyChanged(nameof(IsSaved));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
