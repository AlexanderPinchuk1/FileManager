using FileManager.Foundation.Interfaces;

namespace FileManager.Foundation
{
    /// <summary>
    /// Генератор случайных последовательностей чисел, строк, дат
    /// </summary>
    public class ValueGenerator : IValueGenerator
    {
        private const string RUSSIAN_SYMBOLS = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const string LATIN_SYMBOLS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private readonly Random _random;



        public ValueGenerator()
        {
            _random = new Random();
        }



        public DateTime RandomDate(DateTime startOfRange, DateTime endOfRange)
        {
            return startOfRange + new TimeSpan(0, _random.Next(0, (int)(endOfRange - startOfRange).TotalMinutes), 0);
        }

        public int RandomPositiveEvenIntegerNumber(int startOfRange, int endOfRange)
        {
            return _random.Next(startOfRange, endOfRange) & int.MaxValue - 1;
        }

        public decimal RandomPositiveFloatNumber(int startOfRange, int endOfRange, int DecimalPlaceCount)
        {
            var intPart = _random.Next(startOfRange, endOfRange - 1);
            var fractionPart = (double)_random.Next();
            fractionPart = fractionPart % 10 == 0 ? fractionPart + _random.Next(1, 9) : fractionPart;
            fractionPart /= Math.Pow(10, DecimalPlaceCount);
            fractionPart -= Math.Truncate(fractionPart);

            return (decimal)(intPart + fractionPart);
        }

        public string RandomRusString(int length)
        {
            return RandomString(length, RUSSIAN_SYMBOLS);
        }

        public string RandomLatinString(int length)
        {
            return RandomString(length, LATIN_SYMBOLS);
        }

        private string RandomString(int length, string possibleChars)
        {
            return new string(Enumerable
                .Repeat(possibleChars, length)
                .Select(str => str[_random.Next(str.Length)])
                .ToArray());
        }
    }
}
