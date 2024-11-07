// Models/Counter.cs
using System.ComponentModel;

namespace CounterApp.Models
{
    public class Counter : INotifyPropertyChanged
    {
        private int _value;
        public string Name { get; set; }

        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        public Counter(string name)
        {
            Name = name;
            Value = 0;
        }

        public void Increment() => Value++;
        public void Decrement() => Value--;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
