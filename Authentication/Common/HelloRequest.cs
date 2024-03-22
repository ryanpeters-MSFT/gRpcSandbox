using System.Runtime.Serialization;

namespace Common
{
    [DataContract]
    public class HelloRequest
    {
        [DataMember(Order = 1)]
        public string Name { get; set; }

        [DataMember(Order = 2)]
        public int Age { get; set; }
    }
}
