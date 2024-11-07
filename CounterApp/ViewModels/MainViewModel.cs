// ViewModels/MainViewModel.cs
using System.Collections.ObjectModel;
using System.Windows.Input;
using CounterApp.Models;

namespace CounterApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Counter> Counters { get; set; }

        private string _newCounterName;
        public string NewCounterName
        {
            get => _newCounterName;
            set
            {
                if (_newCounterName != value)
                {
                    _newCounterName = value;
                    OnPropertyChanged(nameof(NewCounterName));
                }
            }
        }

        public ICommand AddCounterCommand { get; }
        public ICommand IncrementCommand { get; }
        public ICommand DecrementCommand { get; }

        public MainViewModel()
        {
            Counters = new ObservableCollection<Counter>();
            AddCounterCommand = new Command(AddCounter);
            IncrementCommand = new Command<Counter>(IncrementCounter);
            DecrementCommand = new Command<Counter>(DecrementCounter);
        }

        private void AddCounter()
        {
         
            string counterName = string.IsNullOrWhiteSpace(NewCounterName) ? $"Counter {Counters.Count + 1}" : NewCounterName;

            Counters.Add(new Counter(counterName));

          
            NewCounterName = string.Empty;
        }

        private void IncrementCounter(Counter counter)
        {
            counter.Increment();
        }

        private void DecrementCounter(Counter counter)
        {
            counter.Decrement();
        }
    }
}
