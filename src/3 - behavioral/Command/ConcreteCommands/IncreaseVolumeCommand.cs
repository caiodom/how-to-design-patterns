using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommands
{
    //Concrete Command
    public class IncreaseVolumeCommand : ICommand
    {
        private readonly VolumeReceiver _receiver;
        public IncreaseVolumeCommand(VolumeReceiver receiver)
        {
            _receiver = receiver;
        }
        public void Execute(int volume)
        {
            Console.WriteLine($"Increasing volume by {volume} units.");

            _receiver.Increase(volume);
        }
    }
}
