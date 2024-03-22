using System.Runtime.Serialization;

namespace Common
{
    [DataContract]
    public class HelloReply
    {
        [DataMember(Order = 1)]
        public string Message { get; set; }

        [DataMember(Order = 2)]
        public ICollection<string> Names { get; set; }
    }
}
