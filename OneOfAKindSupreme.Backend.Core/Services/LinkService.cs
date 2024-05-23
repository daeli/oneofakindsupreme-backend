using Microsoft.AspNetCore.Http;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneOfAKindSupreme.Backend.Core.Services
{
    public class LinkService : ILinkService
    { 
        public List<HypermediaLink> GenerateLinks(HttpContext context)
        {
            throw new NotImplementedException();
        }
    }
}
