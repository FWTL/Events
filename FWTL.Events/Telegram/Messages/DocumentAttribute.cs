namespace FWTL.Events.Telegram.Messages
{
    public class DocumentAttribute
    {
        public DocumentAttribute(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
