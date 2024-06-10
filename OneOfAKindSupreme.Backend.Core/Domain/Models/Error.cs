
namespace OneOfAKindSupreme.Backend.Core.Domain.Models
{
    public class Error(string Message)
    {
        public string Message { get; } = Message;
    }
}
