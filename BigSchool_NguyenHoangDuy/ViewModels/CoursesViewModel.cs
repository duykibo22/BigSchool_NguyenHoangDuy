using BigSchool_NguyenHoangDuy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_NguyenHoangDuy.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public IEnumerable<Following> FollowingList { get; set; }
        public IEnumerable<Attendance> AttendanceList { get; set; }
    }
}