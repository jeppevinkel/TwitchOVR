using System.Windows;
using TwitchOVR.Commands;
using TwitchOVR.ViewModels.Base;

namespace TwitchOVR.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand CloseProgramCommand { get; set; }
        public RelayCommand MinimizeProgramCommand { get; set; }
        
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand TwitchViewCommand { get; set; }
        public RelayCommand VrPipeViewCommand { get; set; }
        
        public HomeViewModel HomeVm { get; set; }
        public TwitchViewModel TwitchVm { get; set; }
        public VrPipeViewModel VrPipeVm { get; set; }
        
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView;}
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            TwitchVm = new TwitchViewModel();
            VrPipeVm = new VrPipeViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVm;
            });
            
            TwitchViewCommand = new RelayCommand(o =>
            {
                CurrentView = TwitchVm;
            });
            
            VrPipeViewCommand = new RelayCommand(o =>
            {
                CurrentView = VrPipeVm;
            });


            CloseProgramCommand = new RelayCommand(o =>
            {
                if (o is Window window) window.Close();
                Application.Current.Shutdown();
            });

            MinimizeProgramCommand = new RelayCommand(o =>
            {
                if (o is Window window) window.WindowState = WindowState.Minimized;
            });
        }
    }
}