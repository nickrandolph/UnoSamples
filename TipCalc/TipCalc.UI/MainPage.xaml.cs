using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;
using Windows.UI.Xaml.Controls;

namespace TipCalc.UI
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

           DataContext = new MainViewModel(new CalculationService());
        }
    }
}
