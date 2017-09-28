using System.Threading.Tasks;
using BeerDrinking.Extensions;
using Prism.AppModel;
using Prism.Navigation;
using Prism.Services;
using Realms;
using Realms.Sync;

namespace BeerDrinking.ViewModels
{

    public class SplashScreenPageViewModel : ViewModelBase
    {
        public SplashScreenPageViewModel(INavigationService navigationService, IApplicationStore applicationStore,
                                         IDeviceService deviceService)
            : base(navigationService, applicationStore, deviceService)
        {
        }

        public override async void OnNavigatedTo(NavigationParameters parameters)
        {
            await User.LoginAsync(Credentials.UsernamePassword("foo@beer.com", "tastybeer", false), new System.Uri(Helpers.Secrets.AuthUrl));
            var realm = Realm.GetInstance(Helpers.AppConstants.RealmConfiguration);
            realm.Seed();

            // TODO: Make a call to the Navigation Service.
            // NOTE: You will need to Specify the NavigationPage as the before the landing page...
            await _navigationService.NavigateAsync("/MainPage/NavigationPage/BreweriesPage");
        }
    }
}