using System;

namespace FWTL.Events.Telegram.Messages
{
    public class Chat
    {
        public DateTime? CreateDate { get; set; }

        public int Id { get; set; }

        public int? MigratetToChannelId { get; set; }

        public string Title { get; set; }

        public string Type { get; set; }
    }
}
