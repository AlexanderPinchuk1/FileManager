using FileManager.Foundation.Interfaces;
using System.Text.RegularExpressions;

namespace FileManager.Foundation
{
    /// <summary>
    /// Сервис для генерации строк
    /// </summary>
    public partial class LineService(IValueGenerator valueGenerator) : ILineService
    {
        private const int PREVIOUS_YEAR_COUNT = 5;
        private const int LATIN_STRING_LENGTH = 10;
        private const int RUS_STRING_LENGTH = 10;
        private const int INTEGER_NUMBER_START_OF_RANGE = 1;
        private const int INTEGER_NUMBER_END_OF_RANGE = 100000000;
        private const int FLOAT_NUMBER_START_OF_RANGE = 1;
        private const int FLOAT_NUMBER_END_OF_RANGE = 20;
        private const int DECIMAL_PLACES_COUNT = 8;

        private readonly Regex _lineRegex = LineRegex();
        private readonly IValueGenerator _valueGenerator = valueGenerator;



        public string Generate()
        {
            return string.Join("||", new List<string>()
            {
                _valueGenerator
                    .RandomDate(DateTime.Now.AddYears(-PREVIOUS_YEAR_COUNT), DateTime.Now)
                    .ToShortDateString(),
                _valueGenerator.RandomLatinString(LATIN_STRING_LENGTH),
                _valueGenerator.RandomRusString(RUS_STRING_LENGTH),
                Convert.ToString(_valueGenerator.RandomPositiveEvenIntegerNumber(
                    INTEGER_NUMBER_START_OF_RANGE,
                    INTEGER_NUMBER_END_OF_RANGE)),
                Convert.ToString(_valueGenerator.RandomPositiveFloatNumber(
                    FLOAT_NUMBER_START_OF_RANGE,
                    FLOAT_NUMBER_END_OF_RANGE,
                    DECIMAL_PLACES_COUNT))
            }) + "||";
        }

        public bool IsMatchLinePattern(string line)
        {
            return _lineRegex.IsMatch(line);
        }



        [GeneratedRegex(@"^(0[1-9]|[12][0-9]|3[01])\\.(0[1-9]|1[0-2])\\.\\d{4}\\|\\|[a-zA-Z]{10}\\|\\|[а-яА-ЯёЁ]{10}\\|\\|\\d{1,9}\\|\\|\\d{1,2}\\,\\d{8}\\|\\|$")]
        private static partial Regex LineRegex();
    }
}
