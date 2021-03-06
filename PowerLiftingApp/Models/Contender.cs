﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PowerLiftingApp.Models
{
    public class Contender
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Contender Name")]
        [StringLength(30, MinimumLength = 4)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bench press weight is required")]
        [DisplayName("Bench Press")]
        [Range(0, 500)]
        public Decimal BenchPress { get; set; }

        [Required(ErrorMessage = "Squat weight is required")]
        [DisplayName("Squat")]
        [Range(0, 500)]
        public Decimal Squat { get; set; }

        [Required(ErrorMessage = "Deadlift weight is required")]
        [DisplayName("Deadlift")]
        [Range(0, 500)]
        public Decimal Deadlift { get; set; }

        [DisplayName("Total Score")]
        public Decimal TotalResult { get; set; }
    }
}