using Bogus;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using TestProject1.Endpoints;
using TestProject1.Payload;

namespace TestProject1.Tests
{
    public class StudentTests
    {
        Faker faker;
        Student student;
        StudentEndPoints studentEndPoint = new StudentEndPoints(Routes.base_url);
 
        [SetUp]
        public void SetUp()
        {
            faker = new Faker();
            student = new Student();
            student.StudentName = faker.Name.FirstName();
            
        }

        [Test, Order(1)]
        public void GetStudents()
        {
           var getStudentResponse = studentEndPoint.ReadStudent();
            Assert.AreEqual(200, (int)getStudentResponse.StatusCode);
        }

        [Test, Order(2)]
        public void GetStudentById()
        {
            var getStudentByIdResponse = studentEndPoint.ReadStudentById(2);
            Assert.AreEqual(200, (int)getStudentByIdResponse.StatusCode);   
        }

        [Test, Order(3)]
        public void CreateStudent() 
        {
            var createStudentResponse = studentEndPoint.CreateStudent(student);
            Assert.AreEqual(200, (int)createStudentResponse.StatusCode);
        }

        [Test, Order(4)]
        public void UpdateStudent()
        {
            var createStudentResponse = studentEndPoint.CreateStudent(student);
            JObject responseObject = JObject.Parse(createStudentResponse.Content);
            student.StudentName = faker.Name.FirstName();
            var updateStudentResponse = studentEndPoint.UpdateStudent((int)responseObject["studentID"], student);
            Assert.AreEqual(200, (int)updateStudentResponse.StatusCode);
        }

        [Test, Order(5)]
        public void DeleteStudent()
        {
            var createStudentResponse = studentEndPoint.CreateStudent(student);
            JObject responseObject = JObject.Parse(createStudentResponse.Content);
            var deleteStudentResponse = studentEndPoint.DeleteStudent((int)responseObject["studentID"]);
            Assert.AreEqual(200, (int)deleteStudentResponse.StatusCode);
        }

    }
}
