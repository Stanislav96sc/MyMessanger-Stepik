using System;
using Newtonsoft.Json;

namespace MyMessanger_Stepik
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Stas", "Privet", DateTime.UtcNow);
            
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);

            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);

            //{ "UserName":"Stas","MessageText":"Privet","TimeStamp":"2021-05-05T18:45:14.3515625Z"}
        }
    }
}
