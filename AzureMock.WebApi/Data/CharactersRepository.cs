using AzureMock.WebApi.Model;

namespace AzureMock.WebApi.Data
{
    public class CharactersRepository
    {
        public static List<Characters> GetAll()
        {
            var list = new List<Characters>();

            var jhonnyquest = new Cartoon(Guid.NewGuid(), "Jhonny Quest");
            var spaceghost = new Cartoon(Guid.NewGuid(), "Space Ghost");
            var flintstones = new Cartoon(Guid.NewGuid(), "The Flintstones");
            var jetson = new Cartoon(Guid.NewGuid(), "The Jetsons");

            list.Add(new Characters(Guid.NewGuid(), "Johnny Quest", jhonnyquest));
            list.Add(new Characters(Guid.NewGuid(), "Hadji", jhonnyquest));
            list.Add(new Characters(Guid.NewGuid(), "Roger Bannon", jhonnyquest));
            list.Add(new Characters(Guid.NewGuid(), "Bandit", jhonnyquest));
            list.Add(new Characters(Guid.NewGuid(), "Doctor Quest", jhonnyquest));

            list.Add(new Characters(Guid.NewGuid(), "Space Ghost", spaceghost));
            list.Add(new Characters(Guid.NewGuid(), "Jan", spaceghost));
            list.Add(new Characters(Guid.NewGuid(), "Jace", spaceghost));
            list.Add(new Characters(Guid.NewGuid(), "Blip", spaceghost));


            list.Add(new Characters(Guid.NewGuid(), "Fred Flintstone", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Wilma Flintstone", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Pebbles Flintstone", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Dino", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Barney Rubble", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Betty Rubble", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Bamm-Bamm Rubble", flintstones));


            list.Add(new Characters(Guid.NewGuid(), "George Jetson", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Jane Jetson", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Elroy Jetson", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Judy Jetson", flintstones));
            list.Add(new Characters(Guid.NewGuid(), "Rosey", flintstones));
            return list;

        }
    }
}
