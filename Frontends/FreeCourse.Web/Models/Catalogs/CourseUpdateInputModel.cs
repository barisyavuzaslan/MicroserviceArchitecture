﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Models.Catalogs
{
    public class CourseUpdateInputModel
    {
        public string Id { get; set; }
        [Display(Name = "Kurs Adı")]
        public string Name { get; set; }
        [Display(Name = "Kurs Açıklması")]
        public string Description { get; set; }
        [Display(Name = "Kurs Fiyatı")]
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public DateTime CreateDate { get; set; }
        public FeatureViewModel Feature { get; set; }
        [Display(Name = "Kurs Kategorisi")]
        public string CategoryId { get; set; }
        [Display(Name = "Kurs Resmi")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
