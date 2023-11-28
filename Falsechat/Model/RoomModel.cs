using System;
using System.Collections.Generic;

namespace Falsechat.Model
{
    public class RoomModel
    {
        public int Id { get; set; }
        private IEnumerable<string> _members = new List<string>();
        private string _lastMessageSender = null;
        private string _lastMessage = null;
        private DateTime? _lastMessageSentDate = null;
        public IEnumerable<string> Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public string LastMessageSender
        {
            get { return _lastMessageSender; }
            set { _lastMessageSender = value; }
        }

        public string LastMessage
        {
            get { return _lastMessage; }
            set { _lastMessage = value; }
        }

        public DateTime? LastMessageSentDate
        {
            get { return _lastMessageSentDate; }
            set { _lastMessageSentDate = value; }
        }

    }
}
