using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int BrandId { get; set; } //Bir model bir markaya aiddir
        public Brand Brand { get; set; }
        public ICollection<Advertisement> Advertisements { get; set; } //Bir modelin cox elanlar ola biler
    }
}
