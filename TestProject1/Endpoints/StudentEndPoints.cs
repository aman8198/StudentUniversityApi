using RestSharp;
using TestProject1.Payload;

namespace TestProject1.Endpoints
{
    public class StudentEndPoints
    { 
        private readonly RestClient _client;
        private readonly string _baseurl;
        public StudentEndPoints(string baseurl)
        {
            _baseurl = baseurl;
            _client = new RestClient(_baseurl); 
        }
        
        public RestResponse CreateStudent(Student student)
        {
            var request = new RestRequest(Routes.common_student_endpoint, Method.Post);
            request.AddJsonBody(student);
            var response = _client.ExecutePost(request);
            return response;

        }

        public RestResponse ReadStudent()
        {
            var request = new RestRequest(Routes.common_student_endpoint, Method.Get);
            var response = _client.ExecuteGet(request);
            return response;
        }

        public RestResponse ReadStudentById(int id)
        {
            var request = new RestRequest($"{Routes.common_student_endpoint}/{id}", Method.Get);
            var response = _client.ExecuteGet(request);
            return response;
        }

        public RestResponse UpdateStudent(int id, Student student)
        {
            var request = new RestRequest($"{Routes.common_student_endpoint}/{id}", Method.Put);
            request.AddJsonBody(student);
            var response = _client.ExecutePut(request);
            return response;
        }

        public RestResponse DeleteStudent(int id)
        {
            var request = new RestRequest($"{Routes.common_student_endpoint}/{id}", Method.Delete);
            var response = _client.ExecuteDelete(request);
            return response;
        }
    }
}
