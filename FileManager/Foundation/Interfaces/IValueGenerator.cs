namespace FileManager.Foundation.Interfaces
{
    public interface IValueGenerator
    {
        public DateTime RandomDate(DateTime startOfRange, DateTime endOfRange);
        public int RandomPositiveEvenIntegerNumber(int startOfRange, int endOfRange);
        public decimal RandomPositiveFloatNumber(int startOfRange, int endOfRange, int numberOfDecimalPlaces);
        public string RandomRusString(int length);
        public string RandomLatinString(int length);
    }
}
