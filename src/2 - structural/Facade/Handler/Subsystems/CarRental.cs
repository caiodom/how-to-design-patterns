
namespace Facade.Handler.Subsystems
{
    public class CarRental : IBaseService
    {
        public void CancelService()
        {
            Console.WriteLine("Canceling Car Rental...");
        }

        public void RequestService()
        {
            Console.WriteLine("Reserving car...");
        }

        public bool IsAvaible()
        {
            return true;
        }



    }
}
