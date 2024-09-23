using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Receiver
{
    //Receiver
    public class VolumeReceiver
    {
        private int _volume=50;

        public void Increase(int volume)
        {
            Console.WriteLine($"Actual Volume: {_volume}");

            _volume=_volume += volume;
            bool isValidVolume = VolumeValidator();

            if (isValidVolume)
                Console.WriteLine($"Volume increased to {_volume}");
        }


        public void Decrease(int volume)
        {
            Console.WriteLine($"Actual Volume: {_volume}");

            _volume=_volume -= volume;

            bool isValidVolume=VolumeValidator();

            if(isValidVolume)
                Console.WriteLine($"Volume decreased to {_volume}");
        }

        private bool VolumeValidator()
        {

            if (_volume > 100)
            {
                _volume = 100;
                Console.WriteLine("Volume is already at maximum (100)");
                return false;
            }
                

            if (_volume < 0)
            {
                _volume = 0;
                Console.WriteLine("Volume is already at minimum (0)");
                return false;
            }

            return true;
                
        }

    }
}
