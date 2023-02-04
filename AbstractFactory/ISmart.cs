namespace AbstractFactory
{
    public interface ISmart
    {
        string getName();
    }

    class Lumia : ISmart
    {
        public string getName()
        {
            return null;
        }    
    }
    class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return null;
        }
    }
    class Titan : ISmart
    {
        public string getName()
        {
            return null;
        }
    }
}
