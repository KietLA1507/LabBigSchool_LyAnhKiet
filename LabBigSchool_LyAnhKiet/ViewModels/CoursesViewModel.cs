﻿using LabBigSchool_LyAnhKiet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabBigSchool_LyAnhKiet.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}