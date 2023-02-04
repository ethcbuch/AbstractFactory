//Ethan Buchanan
//2-3-23
//CSCI352
//IPhoneFactory interfacer with the phones of each company being created

namespace AbstractFactory
{
    public interface IPhoneFactory
    {
        ISmart getSmart();
        IDumb GetDumb();
    }

    class SamsungFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            GalaxyS2 aGalaxyS2 = new GalaxyS2();
            return aGalaxyS2;
        }
        public IDumb GetDumb()
        {
            Genio aGenio = new Genio();
            return aGenio;
        }
    }
    class HTCFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            Titan aTitan = new Titan();
            return aTitan;
        }
        public IDumb GetDumb()
        {
            Primo aPrimo = new Primo();
            return aPrimo;
        }
    }

    class NokiaFactory : IPhoneFactory
    {
        public ISmart getSmart()
        {
            Lumia aLumia = new Lumia();
            return aLumia;
        }
        public IDumb GetDumb()
        {
            Asha aAsha = new Asha();
            return aAsha;
        }
    }
}

