using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahorcado
{
    class ItemViewModel: INotifyPropertyChanged
    {
        private string _imageUrl;
        private string _word;
        private string _message;
        private bool _buttonsEnabled;

        public List<char> Letters { get; set; }
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                OnPropertyChanged("ImageUrl");
            }
        }

        public string Word { 
            get { return _word; }
            set
            {
                _word = value;
                OnPropertyChanged("Word");
            }
        }

        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged("Message");
            }
        }

        public bool ButtonsEnabled
        {
            get { return _buttonsEnabled; }
            set
            {
                _buttonsEnabled = value;
                OnPropertyChanged("ButtonsEnabled");
            }
        }

        public ItemViewModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
