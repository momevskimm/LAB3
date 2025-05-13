﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_LAB3.Models
{
	public class Doctor
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
        public List<Patient> Patients{ get; set; }

        public Doctor()
        {
            Patients = new List<Patient>();
        }
    }
}