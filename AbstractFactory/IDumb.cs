//Ethan Buchanan
//2-3-23
//CSCI352
//Implements the IDumb interface with the dumb phones for each company

namespace AbstractFactory
{
    public interface IDumb
    {
        string getName();
    }

    class Asha : IDumb
    {
        public string getName()
        {
            return "Asha";
        }
    }

    //I think this is supposed to be Genio a Samsung Genie doesnt exsist, not that it really matters
    class Genio : IDumb
    {
        public string getName()
        {
            return "Genio";
        }
    }
    class Primo : IDumb
    {
        public string getName()
        {
            return "Primo";
        }
    }

}
