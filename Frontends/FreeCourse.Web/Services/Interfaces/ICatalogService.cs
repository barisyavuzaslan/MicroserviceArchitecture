﻿using FreeCourse.Web.Models.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface ICatalogService
    {
        Task<List<CourseViewModel>> GetAllCourseAsync();
        Task<List<CategoryViewModel>> GetAllCategoryAsync();
        Task<List<CourseViewModel>> GetAllCourseByUserIdAsync(string userId);
        Task<CourseViewModel> GetByCourseIdAsync(string courseId);
        Task<bool> AddCourseAsync(CourseCreateInputModel courseCreateInputModel);
        Task<bool> UpdateCourseAsync(CourseUpdateInputModel courseUpdateInputModel);
        Task<bool> DeleteCourseAsync(string courseId);


    }
}
