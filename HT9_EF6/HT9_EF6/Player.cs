using System;
using System.ComponentModel.DataAnnotations;

namespace HT9_EF6
{
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(180, ErrorMessage = "To long"), MinLength(2), Required]
        public string FirstName { get; set; }
        [MaxLength(180), MinLength(2), Required]
        public string LastName { get; set; }
        [ Required]
        public int PlayerNumber { get; set; }
        [ Required]
        public int Age { get; set; }
        // public string Position { get; set; }
        
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

    }
}