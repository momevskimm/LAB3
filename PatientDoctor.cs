﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_LAB3.Models
{
    public class PatientDoctors
    {
        public PatientDoctors()
        {
            patients = new List<Patient>();
        }
        public int DoctorId { get; set; }

        public Doctor doctor { get; set; }
        public int PatientId { get; set; }
        public List<Patient> patients { get; set; }
    }
}