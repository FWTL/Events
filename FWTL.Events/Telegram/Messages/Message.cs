using System;
using System.Collections.Generic;
using static FWTL.Events.Telegram.Enums;

namespace FWTL.Events.Telegram.Messages
{
    public class Message
    {
        public TelegramMessageAction Action { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? EditDate { get; set; }

        public List<MessageEntity> Entities { get; set; } = new List<MessageEntity>();

        public int FromId { get; set; }

        public int Id { get; set; }

        public MessageMedia Media { get; set; }

        public string Text { get; set; }
    }
}