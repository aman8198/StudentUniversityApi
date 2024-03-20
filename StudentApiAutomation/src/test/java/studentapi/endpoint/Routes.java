package studentapi.endpoint;

public class Routes {
	public static String base_url = "http://localhost:5143/api/";
	
	//Student Model
	public static String get_all_student_url = base_url + "Student";
	public static String post_student_url = base_url + "Student";
	public static String get_student_url = base_url + "Student/{Id}";
	public static String update_student_url = base_url + "Student/{Id}";
	public static String delete_student_url = base_url + "Student/{Id}";
	
	
	//Course Model
	public static String get_all_course_url = base_url + "Course";
	public static String post_course_url = base_url + "Course";
	public static String get_course_url = base_url + "Course/{Id}";
	public static String update_course_url = base_url + "Course/{Id}";
	public static String delete_course_url = base_url + "Course/{Id}";
	
	//Instructor Model
	public static String get_all_instructor_url = base_url + "Instructor";
	public static String post_instructor_url = base_url + "Instructor";
	public static String get_instructor_url = base_url + "Instructor/{Id}";
	public static String update_instructor_url = base_url + "Instructor/{Id}";
	public static String delete_instructor_url = base_url + "Instructor/{Id}";
	

}
