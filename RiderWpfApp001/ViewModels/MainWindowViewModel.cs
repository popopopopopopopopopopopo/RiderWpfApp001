using Prism.Mvvm;

namespace RiderWpfApp001.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _Title = "ほげもげ";

        public string Title
        {
            get => _Title;
            set => SetProperty(ref _Title, value);
        }
        
        private string _Message = "ほげもげ";

        public string Message
        {
            get => _Message;
            set => SetProperty(ref _Message, value);
        }
    }
}