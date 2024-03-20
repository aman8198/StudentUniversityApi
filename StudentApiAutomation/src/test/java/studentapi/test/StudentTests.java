package studentapi.test;

import java.util.Map;

import org.testng.Assert;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import com.github.javafaker.Faker;

import io.restassured.response.Response;
import studentapi.endpoint.StudentEndPoints;
import studentapi.payload.Student;

public class StudentTests {
	Faker faker;
	Student studentPayload;
	
	@BeforeClass
	public void setup() {
		faker = new Faker();
		studentPayload = new Student();
		
		//System.setProperty("javax.net.ssl.trustStore", "null");
		
		studentPayload.setStudentName(faker.name().firstName());
		
	}
	
	@Test(priority=1)
	public void testPostStudent() {
		Response response = StudentEndPoints.createStudent(studentPayload);
		response.then().log().all();
		
		 // Map<String, Object> jsonAsMap = response.getBody().as(Map.class);
		Assert.assertEquals(response.getStatusCode(),200);
	}
	
	@Test(priority = 2)
	public void testGetStudent() {
		Response response = StudentEndPoints.readAllStudent();
		response.then().log().all();
		Assert.assertEquals(response.getStatusCode(), 200);	
		
	}
	
	@Test(priority = 3)
	public void testGetStudentById() {
		Response response =
				StudentEndPoints.createStudent(studentPayload);
		response.then().log().all();
		
		  Map<String, Object> jsonAsMap = 
				  response.getBody().as(Map.class);
		  System.out.println("In println " + jsonAsMap);
		Response response1 =
				StudentEndPoints
				.readStudentById((Integer)jsonAsMap.get("studentID"));
		response1.then().log().all();
		Assert.assertEquals(response1.getStatusCode(), 200);	
	}
	
	@Test(priority = 4)
	public void testUpdateStudent() 
	{
		Response createStudentResponse = 
				StudentEndPoints.createStudent(studentPayload);
		createStudentResponse.then().log().all();
		Map<String, Object> jsonAsMap = 
				createStudentResponse.getBody().as(Map.class);
		studentPayload.setStudentName(faker.name().firstName());
		Response response = 
        StudentEndPoints.updateStudent((Integer)jsonAsMap.get("studentID"),
        studentPayload);
		response.then().log().body();
		Assert.assertEquals(response.getStatusCode(), 200);		
	}

	@Test(priority = 5)
	public void testDeleteStudent() {
		Response createStudentResponse = 
				StudentEndPoints.createStudent(studentPayload);
		createStudentResponse.then().log().all();
		Map<String, Object> jsonAsMap = 
				createStudentResponse.getBody().as(Map.class);
		Response response =
				StudentEndPoints.deleteStudent((Integer)jsonAsMap.get("studentID"));
		response.then().log().body();
		Assert.assertEquals(response.getStatusCode(), 200);	
		
	}
	

}
