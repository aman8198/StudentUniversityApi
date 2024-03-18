using Bogus;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;

namespace TestProject1
{
    public class Tests2
    {
        /*
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var client = new RestClient("http://localhost:5143/api/");
            var request = new RestRequest("Student", Method.Get);
            var response = client.ExecuteGet(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            //Console.WriteLine(response);
            //Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            var client = new RestClient("http://localhost:5143/api/");
            var request = new RestRequest("Student", Method.Post);
            Student student = new Student();
            student.StudentName = "New Value";
            request.AddJsonBody(student);
            var response = client.ExecutePost(request);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [Test]
        public void Test3()
        {
            var client = new RestClient("http://localhost:5143/api/");
            var request = new RestRequest("Student", Method.Post);
            // Create a Faker instance for generating fake data
            var faker = new Faker<Student>()
                .RuleFor(s => s.StudentName, f => f.Name.FullName()); // Define a rule to generate fake names

            // Generate a fake student
            var student = faker.Generate();
            request.AddJsonBody(student);
            var response = client.ExecutePost(request);
            Console.WriteLine(response.Content);
            Assert.AreEqual(200, (int)response.StatusCode);
        }

        [Test]
        public void Test4()
        {
           // var dictionary = new Dictionary<string, string>();

            var client = new RestClient("http://localhost:5143/api/");
            var request = new RestRequest("Student", Method.Post);
            // Create a Faker instance for generating fake data
            var faker = new Faker<Student>()
                .RuleFor(s => s.StudentName, f => f.Name.FullName()); // Define a rule to generate fake names

            // Generate a fake student
            var student = faker.Generate();
            request.AddJsonBody(student);
            var response = client.ExecutePost(request);
            //dictionary["content"] = response.Content;

            JObject responseObject = JObject.Parse(response.Content);

            var updateRequest = new RestRequest("Student/{id}", Method.Put);

            // Create a Faker instance for generating fake data
            var faker1 = new Faker<Student>()
                .RuleFor(s => s.StudentName, f => f.Name.FullName()); // Define a rule to generate fake names
            var updateStudent = faker1.Generate();

            updateRequest.AddUrlSegment("id", (int)responseObject["studentID"]);
            updateRequest.AddJsonBody(updateStudent);
            var updateResponse = client.ExecutePut(updateRequest);
            Assert.AreEqual(200, (int)updateResponse.StatusCode);

        }

        [Test]
        public void Test5()
        {
            var client = new RestClient("http://localhost:5143/api/");
            var request = new RestRequest("Student", Method.Post);
            // Create a Faker instance for generating fake data
            var faker = new Faker<Student>()
                .RuleFor(s => s.StudentName, f => f.Name.FullName()); // Define a rule to generate fake names

            // Generate a fake student
            var student = faker.Generate();
            request.AddJsonBody(student);
            var response = client.ExecutePost(request);
            //dictionary["content"] = response.Content;

            JObject responseObject = JObject.Parse(response.Content);

            var deleteRequest = new RestRequest("Student/{id}", Method.Delete);

            deleteRequest.AddUrlSegment("id", (int)responseObject["studentID"]);
            var deleteResponse = client.ExecuteDelete(deleteRequest);
            Assert.AreEqual(200, (int)deleteResponse.StatusCode);

        }*/
    }
}