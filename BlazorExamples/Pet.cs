using System.ComponentModel.DataAnnotations;

namespace BlazorExamples.Pages
{
    public class Pet
    {
        [Required]
        [StringLength(50)]
        public string Animal { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
