using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HT9_EF6
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(180, ErrorMessage = "To long"), MinLength(3), Required]
        public string Name { get; set; } // название команды
        [MaxLength(180, ErrorMessage = "To long"), MinLength(3), Required]
        public string Coach { get; set; } // тренер

        /*
        public virtual ICollection<Player> Players { get; set; }

        public Team()
        {
            Players = new List<Player>();
        }*/
        

        public override string ToString()
        {
            return Name;
        }
    }
}