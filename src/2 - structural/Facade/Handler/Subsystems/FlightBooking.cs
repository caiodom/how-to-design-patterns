
namespace Facade.Handler.Subsystems
{
    public class FlightBooking : IBaseService
    {

        public void CancelService()
        {
            Console.WriteLine("Canceling flight reservation....");
        }

        public bool IsAvaible()
        {
            return true;
        }

        public void RequestService()
        {
            Console.WriteLine("Reserve flight....");
        }

    }
}
