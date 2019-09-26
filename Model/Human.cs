namespace Task.Model
{
    public class Human
    {
        public Human(string type, int countProduct)
        {
            Type = type;
            CountProduct = countProduct;
        }

        public string Type { get; }
        public int CountProduct { get; set; }

        public override string ToString()
        {
            return Type + "(" + CountProduct + ")";
        }
    }
}