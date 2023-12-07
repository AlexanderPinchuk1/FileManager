namespace FileManager.Foundation.Interfaces
{
    public interface ILineService
    {
        public string Generate();

        public bool IsMatchLinePattern(string line);
    }
}
