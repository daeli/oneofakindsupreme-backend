using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.Core.Interfaces.Api
{
    public interface IResponse<T>
    {
        public bool Succeeded { get; }
        public IList<string>? Errors { get; }
        public T? Data { get; }
        public IList<HypermediaLink>? Links { get; }
    }
}
