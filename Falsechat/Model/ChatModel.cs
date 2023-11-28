using System;

namespace Falsechat.Model
{
    public class ChatModel
    {
        public string Sender { get; set; }
        public string SentMessage { get; set; }
        private DateTime? _sentDate = DateTime.Now;
        public DateTime? SentDate
        {
            get { return _sentDate; }
            set { _sentDate = value; }
        }
    }
}
