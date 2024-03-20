package studentapi.endpoint;

import static io.restassured.RestAssured.given;

import io.restassured.http.ContentType;
import io.restassured.response.Response;
import studentapi.payload.Student;

public class StudentEndPoints {
	
	public static Response createStudent(Student payload) {
		Response response = 
				given()
					.contentType(ContentType.JSON)
					.accept(ContentType.JSON)
					.body(payload)
				.when()
					.post(Routes.post_student_url);
		return response;
		
	}
	
	public static Response readStudentById(int Id) {
		Response response =
				given()
				.pathParam("Id",Id)
				.when()
				.get(Routes.get_student_url);
		return response;
	}
	
	public static Response readAllStudent() {
		Response response = 
				given()
				.get(Routes.get_all_student_url);
		return response;
	}
	
	public static Response updateStudent(int Id, Student payload) {
		Response response = 
				given()
					.contentType(ContentType.JSON)
					.accept(ContentType.JSON)
					.pathParam("Id",Id)
					.body(payload)
				.when()
					.put(Routes.update_student_url);
		return response;
	}
	
	public static Response deleteStudent(int Id)
	{
		Response response = 
				given()
				 .pathParam("Id", Id)
		        .when()
		         .delete(Routes.delete_student_url);
		 return response;
	}

}
