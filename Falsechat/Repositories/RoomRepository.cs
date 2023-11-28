using Falsechat.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Falsechat.Repositories
{
    public class RoomRepository : RepositoryBase, IRoomRepository
    {
        public void CreateRoom(string username, string contactName)
        {
            if(CheckRoomExist(username, contactName))
            {
                return;
            }
            string query = "INSERT INTO rooms (room_members) VALUES (@room_members)";
            List<string> roomMembers = new List<string>
            {
                username.Trim(),
                contactName.Trim()
            };
            var sortedList = roomMembers.OrderBy(x => x);
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@room_members", string.Join(",", sortedList));
                command.ExecuteNonQuery();
            }
        }
        public bool CheckRoomExist(string username, string contactName)
        {
            string query = "SELECT * FROM rooms WHERE room_members = @room_members";
            List<string> roomMembers = new List<string> {
                username.Trim(),
                contactName.Trim()
            };
            var sortedList = roomMembers.OrderBy(x => x);
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@room_members",
                        SqlDbType = SqlDbType.VarChar,
                        Value = string.Join(",", sortedList),
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                return false;
            }
        }
        public int GetIdByMembers(string username, string contactName)
        {
            string query = "SELECT id FROM rooms WHERE room_members = @room_members";
            List<string> roomMembers = new List<string>
            {
                username.Trim(),
                contactName.Trim()
            };
            var sortedList = roomMembers.OrderBy(x => x);
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@room_members",
                        SqlDbType = SqlDbType.VarChar,
                        Value = string.Join(",", sortedList),
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return int.Parse(reader["id"].ToString());
            }
        }
        public RoomModel GetRoomByMembers(string username, string contactName)
        {
            string query = "SELECT * FROM rooms WHERE room_members = @room_members";
            List<string> roomMembers = new List<string>
            {
                username.Trim(),
                contactName.Trim()
            };
            var sortedList = roomMembers.OrderBy(x => x);
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@room_members",
                        SqlDbType = SqlDbType.VarChar,
                        Value = string.Join(",", sortedList),
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if(reader.IsDBNull(3))
                {
                    return new RoomModel
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Members = sortedList,
                    };
                }
                else
                {
                    return new RoomModel
                    {
                        Id = int.Parse(reader["id"].ToString()),
                        Members = sortedList,
                        LastMessageSender = reader["last_message_sender"].ToString().Trim(),
                        LastMessage = reader["last_message"].ToString(),
                        LastMessageSentDate = reader.GetDateTime(4)
                    };
                }
            }
        }
        public string GetLastMessageSenderById(int id)
        {
            string query = "SELECT last_message_sender FROM rooms WHERE id = @id";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = id,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader["last_message_sender"].ToString();
            }
        }
        public string GetLastMessageById(int id)
        {
            string query = "SELECT last_message FROM rooms WHERE id = @id";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = id,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader["last_message"].ToString();
            }
        }
        public DateTime GetLastMessageSentDateById(int id)
        {
            string query = "SELECT last_message_date FROM rooms WHERE id = @id";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = id,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (!reader.Read())
                {
                    return default;
                }
                return reader.GetDateTime(4);
            }
        }
        public void UpdateLastMessageById(int id, string sender, string message, DateTime date)
        {
            string query = "UPDATE rooms SET last_message_sender = @last_message_sender, last_message = @last_message, last_message_date = @last_message_date WHERE id = @id";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@id",
                        SqlDbType = SqlDbType.Int,
                        Value = id,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@last_message_sender",
                        SqlDbType = SqlDbType.Char,
                        Value = sender,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@last_message",
                        SqlDbType = SqlDbType.VarChar,
                        Value = message,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@last_message_date",
                        SqlDbType = SqlDbType.DateTime,
                        Value = date,
                    },
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
            }
        }
    }
}
