using Microsoft.EntityFrameworkCore;

namespace FileManager.Domain
{
    /// <summary>
    /// Модель для хранения результата выполнения хранимой функции
    /// </summary>
    [Keyless]
    public class IntNumSumAndFloatNumMedianaResult
    {
        public string? Result { get; set; }
    }
}
