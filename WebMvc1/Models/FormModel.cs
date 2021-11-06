using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebMvc1.Models
{
    public class FormModel
    {
        private const string polishname = "Imię";
        
        [Display(Name = polishname)]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }

        [Required]

        private const string polishDaysCount = "Liczba dni od urodzenia";

        [Display(Name = polishDaysCount)]
        public int NumberOfDaysFromBirthday
        {
            get
            {
                return Convert.ToInt32((DateTime.Now - Date).TotalDays);
            }
        }
    }
}
