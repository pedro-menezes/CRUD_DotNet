using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Entities
{
    public class Carro
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public string marca { get; set; }
        public int numPortas { get; set; }
        public int ano { get; set; }
    }
}