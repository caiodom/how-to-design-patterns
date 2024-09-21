using Facade.Enum;
using Facade.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
