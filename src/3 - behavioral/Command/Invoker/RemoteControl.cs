using Command.Command;

namespace Command.Invoker
{
    //invoker
    public class RemoteControl
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton(int volume)
        {

            _command.Execute(volume);
        }


    }
}
