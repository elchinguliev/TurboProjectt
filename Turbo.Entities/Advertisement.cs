using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turbo.Entities
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public DateTime DatePosted { get; set; }
        public int BrandId { get; set; } //Bir elanin bir markasi ola biler
        public Brand  Brand { get; set; }
        public int ModelId { get; set; } //Bir elanin biir modeli ola biler
        public Model Model { get; set; }
        public int UserId { get; set; } //Bir elanin bir istifadecisi var
        public User User { get; set; }
    }
}
