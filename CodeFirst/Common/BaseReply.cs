using ProtoBuf;

namespace Common
{
    [ProtoContract]
    [ProtoInclude(2, typeof(HelloReply))]
    public class BaseReply
    {
        // Note: the tag/order is relevant to the current type, not the sub-types used by it
        [ProtoMember(1)]
        public int Id { get; set; }
    }
}
