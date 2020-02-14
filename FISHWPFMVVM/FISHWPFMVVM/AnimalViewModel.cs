using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FISHWPFMVVM
{
    class AnimalViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<Animal> animals = new ObservableCollection<Animal>();
        public ObservableCollection<Animal> Animals
        {
            get
            {
                return animals;
            }

            set
            {
                animals = value;
            }
        }


        private Animal currentAnimal;
        public Animal CurrentAnimal
        {
            get
            {
                return currentAnimal;
            }

            set
            {
                currentAnimal = value;
                imageSource = "Images/" + currentAnimal.Name + ".png";
                OnPropertyChanged();
                OnPropertyChanged("ImageSource");
            }
        }

        private string imageSource;
        public string ImageSource
        {
            get
            {
                return imageSource;
            }

            set
            {
                imageSource = value;
                OnPropertyChanged();
            }
        }


        public AnimalViewModel()
        {
            animals.Add(new Animal("Butterflyfish", "20 cm", 0));
            animals.Add(new Animal("Tiger Shark", "3.25 to 4.25 m", 635));
            animals.Add(new Animal("Great White Shark", "4.6 m to 6 m", 2268));

        }

    }
}
