using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_LAB3.Models
{
	public class Patient
	{
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }

        [Required]
        [Range(10000, 99999, ErrorMessage = "Mora da e 5 cifren")]
        [Display(Name="Kod na pacientot")]
        public int PatientCode { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}