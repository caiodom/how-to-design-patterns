

namespace Facade.Handler.Subsystems
{
    public class HotelBooking : IBaseService
    {

        public void CancelService()
        {
            Console.WriteLine("Canceling hotel booking...");
        }

        public void RequestService()
        {
            Console.WriteLine("Booking hotel...");
        }
        public bool IsAvaible()
        {
            return true;
        }
    }
}
