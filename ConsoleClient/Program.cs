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

            //{ "UserName":"Stas","MessageText":"P65Z"} Stas < 03.05.2021 12:04:42 >: Privet
        }
    }
}
