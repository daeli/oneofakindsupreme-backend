
namespace OneOfAKindSupreme.Backend.Core.Domain.Models
{
    public record Result<T>(bool IsSuccessful, Error? Error, T? Data)
    {
        public bool IsSuccessful { get; } = IsSuccessful;

        public Error? Error { get; } = Error;

        public T? Data { get; } = Data;
    }
}
