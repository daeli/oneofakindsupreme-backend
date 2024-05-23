using Microsoft.AspNetCore.Http;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.Core.Interfaces.Api
{
    public interface ILinkService
    {
        List<HypermediaLink> GenerateLinks(HttpContext context);
    }
}
