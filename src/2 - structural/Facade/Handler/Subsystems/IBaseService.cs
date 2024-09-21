
namespace Facade.Handler.Subsystems
{
    public interface IBaseService
    {
        void RequestService();
        void CancelService();

        bool IsAvaible();
    }
}
