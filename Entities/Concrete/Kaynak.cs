using Core.Entities.Abstract;
using Dapper.Contrib.Extensions;

namespace Entities.Concrete
{
	[Table("kaynaklar")]
	public class Kaynak : IEntity
    {
		[Key]
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Link { get; set; }
    }
}
