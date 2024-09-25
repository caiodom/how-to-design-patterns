using System.Text;
namespace Memento.Originator
{
    //originator
    public class Circle : ICircleShape
    {
        public string _circle;

        public void Draw(int radius)
        {
            double thickness = 0.4;
            char symbol = '*';
            StringBuilder sb = new StringBuilder();


            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double value = x * x + y * y;
                    if (value >= (radius - thickness) * (radius - thickness) &&
                        value <= (radius + thickness) * (radius + thickness))
                    {
                        sb.Append(symbol);
                    }
                    else
                    {
                        sb.Append(" ");
                    }
                }
                sb.AppendLine();
            }

            _circle = sb.ToString();
        }

        public string Get()
        {
            return _circle;
        }

        public string RestoreToMemento(Memento memento)
        {
            var restoredCircle = memento.GetState();
            Console.WriteLine($"State restored");
            return restoredCircle;


        }

        public Memento SaveToMemento()
        {
            Console.WriteLine("Saving current state to Memento.");
            return new Memento(_circle);
        }
    }
}
