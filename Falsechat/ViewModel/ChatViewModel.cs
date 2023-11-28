using Falsechat.Core;
using Falsechat.Model;
using Falsechat.Repositories;
using Falsechat.Translation;
using System;
using System.Collections.ObjectModel;

namespace Falsechat.ViewModel
{
    public class ChatViewModel : ViewModelBase
    {
        private int _currentRoomId;
        private string _username;
        private string _currentContact;
        private string _message;
        private string _sentMessage;
        private ObservableCollection<ChatModel> _chat = new ObservableCollection<ChatModel>();
        private readonly IUserRepository _userRepository;
        private readonly IRoomRepository _roomRepository;
        private readonly MyMemoryAPI _translator;
        private RoomModel _room;
        public RelayCommand SendMessageCommand { get; set; }
        public ChatViewModel(IUserRepository userRepository, IRoomRepository roomRepository, MyMemoryAPI translator)
        {
            _userRepository = userRepository;
            _roomRepository = roomRepository;
            _translator = translator;
            Username = Mediator.Username.Trim();
            CurrentContact = Mediator.CurrentContact.Trim();
            Chat.Clear();
            SendMessageCommand = new RelayCommand(async(execute) =>
            {
                string translatedMessage = await _translator.TranslateAsync(Message, Mediator.PrefLangOfSelectedContact);
                Chat.Add(new ChatModel
                {
                    Sender = _userRepository.GetUsernameByEmail(Mediator.Email),
                    SentMessage = translatedMessage,
                });
                _roomRepository.UpdateLastMessageById(Room.Id, Username, translatedMessage, DateTime.Now);
                Message = string.Empty;
            }, canExecute => Message != null && Room.Id == _roomRepository.GetIdByMembers(Username, CurrentContact));
            CheckAll(Username, CurrentContact);
        }
        private void CheckAll(string username, string currentContact)
        {
            Chat.Clear();
            if (!_roomRepository.CheckRoomExist(username, currentContact))
            {
                _roomRepository.CreateRoom(username, currentContact);
                Room = _roomRepository.GetRoomByMembers(username, currentContact);
                return;
            }
            Room = _roomRepository.GetRoomByMembers(username, currentContact);
            if (string.IsNullOrEmpty(Room.LastMessage))
            {
                Chat.Clear();
                return;
            }
            else
            {
                Chat.Add(new ChatModel
                {
                    Sender = Room.LastMessageSender,
                    SentMessage = Room.LastMessage,
                    SentDate = Room.LastMessageSentDate,
                });
            }
        }
        public string Message
        {
            get
            { return _message; }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<ChatModel> Chat
        {
            get { return _chat; }
            set
            {
                _chat = value;
                OnPropertyChanged();
            }
        }

        public string SentMessage
        {
            get { return _sentMessage; }
            set
            {
                _sentMessage = value;
                OnPropertyChanged();
            }
        }

        public int CurrentRoomId
        {
            get { return _currentRoomId; }
            set
            {
                _currentRoomId = value;
                OnPropertyChanged();
            }
        }


        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }


        public string CurrentContact
        {
            get { return _currentContact; }
            set
            {
                _currentContact = value;
                OnPropertyChanged();
            }
        }

        public RoomModel Room
        {
            get { return _room; }
            set
            {
                _room = value;
                OnPropertyChanged();
            }
        }

    }
}
