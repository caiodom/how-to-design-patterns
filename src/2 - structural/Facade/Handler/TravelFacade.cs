using Facade.Enum;
using Facade.Handler.Subsystems;


namespace Facade.Facade
{
    public class TravelFacade
    {
        private readonly CarRental _carRental;
        private readonly FlightBooking _flightBooking;
        private readonly HotelBooking _hotelBooking;
        private readonly PaymentProcessor _paymentProcessor;
        public TravelFacade()
        {
            _carRental = new CarRental();
            _flightBooking = new FlightBooking();
            _hotelBooking = new HotelBooking();
            _paymentProcessor = new PaymentProcessor();
        }


        public void BookTrip(TypeOfService[] travelPackage)
        {
            bool operationSuccessful = true;

            for (int i = 0; i < travelPackage.Length; i++)
            {
                if (!operationSuccessful)
                {
                    Console.WriteLine("Canceling operation...");
                    return;
                }

                switch (travelPackage[i])
                {
                    case TypeOfService.Flight:
                        operationSuccessful = ReserveServiceIfAvailable(TypeOfService.Flight, _flightBooking);
                        break;
                    case TypeOfService.Hotel:
                        operationSuccessful = ReserveServiceIfAvailable(TypeOfService.Hotel, _hotelBooking);
                        break;
                    case TypeOfService.Car:
                        operationSuccessful = ReserveServiceIfAvailable(TypeOfService.Car, _carRental);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(travelPackage), travelPackage[i],
                         $"The travel package contains an invalid or unsupported service: '{travelPackage[i]}'. Supported services are: 'Flight', 'Hotel' and 'Car'.");
                }
            }

            _paymentProcessor.ProcessPayment();
            Console.WriteLine("Trip booked successfully!!\n");
        }

        private bool ReserveServiceIfAvailable(TypeOfService travelService, IBaseService baseProcess)
        {
            var serviceName = travelService.ToString();
            Console.WriteLine($"Checking if the {serviceName} service is available...");

            if (!baseProcess.IsAvaible())
            {
                Console.WriteLine($"The {serviceName} service is not available.");
                return false;
            }

            Console.WriteLine($"The {serviceName} service is available!");
            baseProcess.RequestService();
            return true;

        }
    }
}
