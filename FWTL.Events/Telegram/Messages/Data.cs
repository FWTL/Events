using System.Collections.Generic;
using static FWTL.Events.Telegram.Enums;

namespace FWTL.Events.Telegram.Messages
{
    public class Data
    {
        public PeerType PeerType { get; set; }

        public int SourceId { get; set; }

        public List<Message> Messages { get; set; } = new List<Message>();
    }
}