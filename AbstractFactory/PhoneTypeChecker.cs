namespace AbstractFactory
{
    class PhoneTypeChecker
    {

        public enum Manufacturers
        {
            Samsung,
            HTC,
            Nokia
        }
        Manufacturers manu;
        IPhoneFactory factory;

        PhoneTypeChecker(Manufacturers m)
        {

        }
        public  void CheckProducts()
        {

        }
    }
}
