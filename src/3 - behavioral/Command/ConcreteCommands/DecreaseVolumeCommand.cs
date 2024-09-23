using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommands
{
    //Concrete Command
    public class DecreaseVolumeCommand : ICommand
    {
        private readonly VolumeReceiver _receiver;
        public DecreaseVolumeCommand(VolumeReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute(int volume)
        {
            Console.WriteLine($"Decreasing volume by {volume} units.");

            _receiver.Decrease(volume);
        }

    }
}
