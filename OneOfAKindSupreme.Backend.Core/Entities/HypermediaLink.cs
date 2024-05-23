
namespace OneOfAKindSupreme.Backend.Core.Entities
{
    public class HypermediaLink(string href, string relation, string method)
    {
        public string Href => href;
        public string Rel => relation;
        public string Method => method;
    }
}
