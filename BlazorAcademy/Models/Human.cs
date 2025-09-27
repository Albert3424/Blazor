using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademy.Models
{
    public class Human
    {
        [Required]
        [Display(Name = "Фамилия", Order = -9, Prompt = "Введите фамилию")]
        public string last_name { get; set; }
        [Required]
        public string first_name { get; set; }
        public string? middle_name { get; set; }
        [Required]
        public DateOnly birth_date { get; set; }
        [EmailAddress]
        [Display(Name = "Мыло")]
        public string? email { get; set; }
        [Phone]
        public string? phone { get; set; }
        public byte[]? photo { get; set; }
    }
}