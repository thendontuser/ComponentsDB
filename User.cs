using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentsDB
{
    /// <summary>
    /// Класс для работы с таблицей Users
    /// </summary>
    internal class User
    {
        private SqlConnection SqlConnection;

        /// <summary>
        /// Подключается к базе данных
        /// </summary>
        /// <param name="sqlConnection"></param>
        public User(SqlConnection sqlConnection)
        {
            SqlConnection = sqlConnection;
        }

        /// <summary>
        /// Ищет пользователя по username и password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns>true, если пользователь найден. false, если нет</returns>
        public bool GetUser(string username, string password)
        {
            string command = "SELECT * FROM [CUSR]";
            SqlDataAdapter adapter = new SqlDataAdapter(command, SqlConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                if (string.Equals(row.ItemArray[0].ToString(), username) && string.Equals(row.ItemArray[1].ToString(), password))
                {
                    return true;
                }
            }
            return false;
        }
    }
}