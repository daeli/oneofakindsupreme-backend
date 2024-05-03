namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class CreateProjectResponse(int id, string name, string status)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Status { get; set; } = status;
    }
}
