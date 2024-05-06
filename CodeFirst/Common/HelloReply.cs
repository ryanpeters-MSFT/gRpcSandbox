using ProtoBuf;

namespace Common
{
    [ProtoContract]
    public class HelloReply : BaseReply
    {
        [ProtoMember(1)]
        public string Message { get; set; }

        [ProtoMember(2)]
        public ICollection<string> Names { get; set; }
    }
}
