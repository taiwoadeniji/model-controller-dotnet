using System;
using System.ComponentModel.DataAnnotations;

namespace model_controller_assignment.Models
{
    public class ChocolateModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Shape { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public string Year { get; set; }

    }
}