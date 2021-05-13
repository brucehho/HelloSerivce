using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloSerivce
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            //create some answer based on the value string
            return "If your voice travels" + value + " feet, the influence of your voice will cover " + Int32.Parse(value) * 3.14 + " sq feet";
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject helloObject = new HelloObject();
            if (Int32.Parse(id) > 0)
            {
                helloObject.happyHello = true;
                helloObject.helloMessage = "great day. couldn't be better eh>";
            }
            else
            {
                helloObject.happyHello = false;
                helloObject.helloMessage = "Feeling very glum. come out tomorrow";
            }
            return helloObject;
        }

        public Service1()
        {
            Console.WriteLine("THe 8-ball awaits your question...");
        }

        public string ObtainAnswerToQuestion(string userQuestion)
        {
            string[] answers = { "Future Uncertain", "Yes", "No", "Hazy", "Ask again later", "Definitely" };
            //return a random response.
            Random r = new Random();
            return answers[r.Next(answers.Length)];
        }

        public string SayHello()
        {
            return "你好吗？我是何鸿斌，很高兴认识你.";
        }
    }
}