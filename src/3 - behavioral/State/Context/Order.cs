
using State.States;
using State.Utils;

namespace State.Context
{
    //Context
    public class Order
    {
        private IOrderState _currentState;

        public IOrderState _newOrderState { get; }
        public IOrderState _beingPreparedState { get; }
        public IOrderState _canceledState { get; }
        public IOrderState _readyForDeliveryState { get; }
        public IOrderState _deliveredState { get;}

        public Order()

        {
            _newOrderState = new NewOrderState(this);
            _beingPreparedState = new BeingPreparedState(this);
            _canceledState = new CanceledState(this);
            _readyForDeliveryState = new ReadyForDeliveryState(this);
            _deliveredState = new DeliveredState(this);

            _currentState = _newOrderState; 

        }

        public void SetState(IOrderState state)
        {
            _currentState=state;
        }

        public void Proceed()
        {
            _currentState.Proceed(this);
        }

        public void Cancel()
        {
            if (_currentState is CanceledState)
            {
                Console.WriteLine("Ordem já cancelada!");
                return;
            }
                _currentState.Cancel(this);
            
            
        }

        public OrderStatus GetStatus()
        {
            return _currentState.GetStatus();
        }




    }
}
