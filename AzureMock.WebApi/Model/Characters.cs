using System.Text.Json.Serialization;

namespace AzureMock.WebApi.Model
{
    public struct Characters
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public Cartoon Cartoon { get; private set; }

        public Characters(Guid id, string name, Cartoon cartoon)
        {
            Id = id;
            Name = name;
            Cartoon = cartoon;
        }

    }
}
