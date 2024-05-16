using AbstractFactory.Interfaces;


namespace AbstractFactory.Factories
{
    public class Factory : IFactory
    {
        public ICarFactory CreateCarFactory()
            => new CarFactory();


        public IMotocycleFactory CreateMotocycleFactory()
            => new MotocycleFactory();

    }
}
