using Microsoft.Extensions.DependencyInjection;

namespace Naidis_TARpv24
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var StartPage = new StartPage();
            var navPage = new NavigationPage(StartPage)
            {
                BarBackgroundColor = Colors.Blue,
                BarTextColor = Colors.White
            };
            return new Window(navPage);

        }
    }
}