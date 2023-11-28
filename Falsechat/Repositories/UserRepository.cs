using Falsechat.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;

namespace Falsechat.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public bool Login(string email, string hashedPassword)
        {
            string query = "SELECT user_password FROM users WHERE user_email= @user_email";
            using(SqlConnection connection = GetConnection())
            using(SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
            {
                new SqlParameter
                {
                    ParameterName = "@user_email",
                    SqlDbType = SqlDbType.NVarChar,
                    Value = email,
                }
            };
                command.Parameters.AddRange(paramList.ToArray());
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (BCrypt.Net.BCrypt.EnhancedVerify(hashedPassword, reader["user_password"].ToString()))
                {
                    return true;
                }
                return false;
            }
        }
        public void Register(string username, string email, string hashedPassword, string preferredLanguage, string hashedSecurityKey)
        {
            string query = "INSERT INTO users (username, user_email, user_password, user_preferred_language, user_security_key) VALUES (@username, @user_email, @user_password, @user_preferred_language, @user_security_key)";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@user_email", email);
                command.Parameters.AddWithValue("@user_password", hashedPassword);
                command.Parameters.AddWithValue("@user_preferred_language", preferredLanguage);
                command.Parameters.AddWithValue("@user_security_key", hashedSecurityKey);
                command.ExecuteNonQuery();
            }
        }
        public void ResetPassword(string email, string hashedNewPassword)
        {
            string query = "UPDATE users SET user_password = @user_password WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@user_password",
                        SqlDbType = SqlDbType.Char,
                        Value = hashedNewPassword,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
            }
        }
        public bool CheckUsernameExist(string username)
        {
            string query = "SELECT username FROM users WHERE username = @username";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@username",
                        SqlDbType = SqlDbType.Char,
                        Value = username,
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
        public bool CheckUserEmailExist(string email)
        {
            string query = "SELECT user_email FROM users WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public UserModel GetUserByEmail(string email)
        {
            string query = "SELECT id, username, user_email, user_preferred_language, user_contacts FROM users WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                ObservableCollection<ContactModel> user_contacts = GetUserContactsByEmail(email);

                return new UserModel()
                {
                    Id = int.Parse(reader["id"].ToString()),
                    Username = reader["username"].ToString(),
                    Email = reader["user_email"].ToString(),
                    PreferredLanguage = reader["user_preferred_language"].ToString(),
                };
            }
        }
        public int GetIdByUsername(string username)
        {
            string query = "SELECT id FROM users WHERE username = @username";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@username",
                        SqlDbType = SqlDbType.Char,
                        Value = username,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return int.Parse(reader["id"].ToString());
            }
        }
        public string GetUsernameById(int id)
        {
            string query = "SELECT username FROM users WHERE id = @id";
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
                return reader["username"].ToString().Trim();
            }
        }
        public string GetUsernameByEmail(string email)
        {
            string query = "SELECT username FROM users WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader["username"].ToString().Trim();
            }
        }
        public ObservableCollection<ContactModel> GetUserContactsByEmail(string email)
        {
            string query = "SELECT username, user_contacts FROM users WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    },
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                ObservableCollection<ContactModel> user_contacts = new ObservableCollection<ContactModel>();
                if(reader["user_contacts"] != null)
                {
                    var contactsAsString = reader["user_contacts"].ToString().Split(',');
                    foreach (var contactId in contactsAsString)
                    {
                        if (contactId == "")
                        {
                            return null;
                        }
                        int parsedId = int.Parse(contactId);
                        user_contacts.Add(new ContactModel
                        {
                            Id = parsedId,
                            ContactName = GetUsernameById(parsedId),
                            PreferredLanguage = GetUserPrefLangByUsername(reader["username"].ToString().Trim()),
                        });
                    }
                }
                return user_contacts;
            }
        }
        public string GetUserPrefLangByUsername(string username)
        {
            string query = "SELECT user_preferred_language FROM users WHERE username = @username";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@username",
                        SqlDbType = SqlDbType.Char,
                        Value = username,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader["user_preferred_language"].ToString().Trim();
            }
        }
        public string GetUserSecurityKeyByEmail(string email)
        {
            string query = "SELECT user_security_key FROM users WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                return reader["user_security_key"].ToString().Trim();
            }
        }
        public void UpdateUserContactsByEmail(string email, List<string> contactId)
        {
            string query = "UPDATE users SET user_contacts = @user_contacts WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@user_contacts",
                        SqlDbType = SqlDbType.VarChar,
                        Value = string.Join(",", contactId),
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
            }
        }
        public void ChangeUserPrefLangByEmail(string email, string newPrefLang)
        {
            string query = "UPDATE users SET user_preferred_language = @user_preferred_language WHERE user_email = @user_email";
            using (SqlConnection connection = GetConnection())
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                List<SqlParameter> paramList = new List<SqlParameter>
                {
                    new SqlParameter
                    {
                        ParameterName = "@user_email",
                        SqlDbType = SqlDbType.NVarChar,
                        Value = email,
                    },
                    new SqlParameter
                    {
                        ParameterName = "@user_preferred_language",
                        SqlDbType = SqlDbType.Char,
                        Value = newPrefLang,
                    }
                };
                command.Parameters.AddRange(paramList.ToArray());
                command.ExecuteNonQuery();
            }
        }
    }
}