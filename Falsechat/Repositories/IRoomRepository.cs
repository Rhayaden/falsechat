using Falsechat.Model;
using System;

namespace Falsechat.Repositories
{
    public interface IRoomRepository
    {
        void CreateRoom(string username, string contactName);
        bool CheckRoomExist(string username, string contactName);
        int GetIdByMembers(string username, string contactName);
        RoomModel GetRoomByMembers(string username, string contactName);
        string GetLastMessageSenderById(int id);
        string GetLastMessageById(int id);
        DateTime GetLastMessageSentDateById(int id);
        void UpdateLastMessageById(int id, string sender, string message, DateTime date);
    }
}
