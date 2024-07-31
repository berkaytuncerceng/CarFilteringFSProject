using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Kaynak : IEntity
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Link { get; set; }
    }
}
