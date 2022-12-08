namespace AzureMock.WebApi.Model
{
    public struct Cartoon
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Cartoon(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
