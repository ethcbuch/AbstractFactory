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
            return null;
        }
        public IDumb GetDumb()
        {
            return null;
        }

        class HTCFactory : IPhoneFactory
        {
            public ISmart getSmart()
            {
                return null;
            }
            public IDumb GetDumb()
            {
                return null;
            }
        }

        class NokiaFactory : IPhoneFactory
        {
            public ISmart getSmart()
            {
                return null;
            }
            public IDumb GetDumb()
            {
                return null;
            }
        }
    }

}
