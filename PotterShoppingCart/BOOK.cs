namespace PotterShoppingCart
{
    public struct BOOK
    {
        public int Cost { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }


    }
}