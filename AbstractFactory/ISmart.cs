//Ethan Buchanan
//2-3-23
//CSCI352
//Implements the ISmart interface with the smart phones for each company
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
            return "Lumia";
        }    
    }
    class GalaxyS2 : ISmart
    {
        public string getName()
        {
            return "GalaxyS2";
        }
    }
    class Titan : ISmart
    {
        public string getName()
        {
            return "Titan";
        }
    }
}
