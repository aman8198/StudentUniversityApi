using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Endpoints
{
    public class Routes
    {
        public static string base_url = "http://localhost:5143/api/";

        //Student Endpoint
        public static string common_student_endpoint = "Student";

        //Course Endpoint
        public static string get_courses = "Course";
        public static string get_course_by_id = "Course/{Id}";
        public static string post_course = "Course";
        public static string update_course = "Course/{Id}";
        public static string delete_course = "Course/{Id}";

        //Instructor Endpoint
        public static string get_instructor = "Instructor";
        public static string get_instructor_by_id = "Instructor/{Id}";
        public static string post_instructor = "Instructor";
        public static string update_instructor = "Instructor/{Id}";
        public static string delete_instructor = "Instructor/{Id}";

    }
}
