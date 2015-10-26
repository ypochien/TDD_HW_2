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

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            BOOK b = (BOOK)obj;
            if ((object)b == null) return false;
            return b.Name == this.Name;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}