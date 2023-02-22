using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        //build foreign key relationship
        [Required(ErrorMessage ="Enter the Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage ="Enter Movie Title")]
        
        public string Title { get; set; }

        [Required(ErrorMessage ="Enter the Year")]
        
        public short Year { get; set; }

        [Required(ErrorMessage ="Enter the Director")]
        public string Director { get; set; }

        [Required(ErrorMessage ="Enter the Movie Rating")]
        public string Rating { get; set; }

        public bool? Edited { get; set; }

        public string LentTo { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

    }
}
