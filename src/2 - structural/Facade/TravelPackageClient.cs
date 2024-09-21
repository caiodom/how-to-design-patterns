using Facade.Enum;
using Facade.Facade;

namespace Facade
{
    //Client
    public class TravelPackageClient
    {
        private readonly TravelFacade _travelFacade;
        public TravelPackageClient()
        {
            _travelFacade = new TravelFacade();
        }

        public void RequestFacade(TypeOfService[] travelServices)
        {
            _travelFacade.BookTrip(travelServices);
        }

        public TypeOfService[] GetTotalTravelPackage()
        {
            return [TypeOfService.Flight, TypeOfService.Hotel, TypeOfService.Car];
        }

        public TypeOfService[] GetBasicTravelPackage()
        {
            return [TypeOfService.Flight, TypeOfService.Hotel];
        }
    }
}
