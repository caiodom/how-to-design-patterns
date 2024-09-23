
using Command.Command;
using Command.ConcreteCommands;
using Command.Invoker;
using Command.Receiver;


//receiver
var volumeReceiver = new VolumeReceiver();

//commands
ICommand volumeIncrease= new IncreaseVolumeCommand(volumeReceiver);
ICommand volumeDecrease = new DecreaseVolumeCommand(volumeReceiver);

//invoker
var remoteControl = new RemoteControl();

//increase
remoteControl.SetCommand(volumeIncrease);
remoteControl.PressButton(25);

//decrease
remoteControl.SetCommand(volumeDecrease);
remoteControl.PressButton(45);


//increase
remoteControl.SetCommand(volumeIncrease);
remoteControl.PressButton(300); //max 100 Expected

//increase
remoteControl.SetCommand(volumeDecrease);
remoteControl.PressButton(600); //min 0 Expected