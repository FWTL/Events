using System.Collections.Generic;
using static FWTL.Events.Telegram.Enums;

namespace FWTL.Events.Telegram.Messages
{
    public class MessageMedia
    {
        public List<DocumentAttribute> Attibutes { get; set; } = new List<DocumentAttribute>();

        public List<File> Files { get; set; }

        public TelegramMediaType Type { get; set; }
    }
}