using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Concrete
{
    public class KaynakForUpdateDto : IDto
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public string? Link { get; set; }
    }
}