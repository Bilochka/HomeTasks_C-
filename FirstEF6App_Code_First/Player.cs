using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstEF6App_Code_First
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(180, ErrorMessage = "To long"), MinLength(2), Required]
        public string FirstName { get; set; }
        [MaxLength(180), MinLength(2), Required]
        public string LastName { get; set; }
        [MaxLength(2, ErrorMessage = "Too long"), MinLength(1), Required]
        public int PlayerNumber { get; set; }
        [MaxLength(2, ErrorMessage = "Too old"), MinLength(1), Required]
        public int Age { get; set; }
        // public string Position { get; set; }

        public int? TeamId { get; set; }
        public virtual Team SomeTeam { get; set; }

    }
}

